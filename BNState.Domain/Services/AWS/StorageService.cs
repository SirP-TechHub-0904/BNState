using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using BNState.Domain.Dtos.AwsDtos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain.Services.AWS
{
    public class StorageService : IStorageService
    {
        private readonly IConfiguration _config;
        //private readonly IAmazonS3 _client;
        public StorageService(IConfiguration config/*, IAmazonS3 client*/)
        {
            _config = config;
            //_client = client;
        }

        public async Task<S3ResponseDto> UploadFileAsync(Domain.Dtos.AwsDtos.S3Object obj, AwsCredentials awsCredentialsValues)
        {
            //var awsCredentialsValues = _config.ReadS3Credentials();
            ////
            // Console.WriteLine($"Key: {awsCredentialsValues.AccessKey}, Secret: {awsCredentialsValues.SecretKey}");

            var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };

            var response = new S3ResponseDto();
            try
            {
                var uploadRequest = new TransferUtilityUploadRequest()
                {
                    InputStream = obj.InputStream,
                    Key = obj.Name,
                    BucketName = obj.BucketName,
                    CannedACL = S3CannedACL.NoACL
                };

                // initialise client
                using var client = new AmazonS3Client(credentials, config);

                // initialise the transfer/upload tools
                var transferUtility = new TransferUtility(client);

                // initiate the file upload
                await transferUtility.UploadAsync(uploadRequest);

                response.StatusCode = 201;
                response.Message = $"{obj.Name} has been uploaded sucessfully";
            }
            catch (AmazonS3Exception s3Ex)
            {
                response.StatusCode = (int)s3Ex.StatusCode;
                response.Message = s3Ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<string> DownloadFileAsync(string file, string bucketName, AwsCredentials awsCredentialsValues)
        {


            var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };

            //var response = new S3ResponseDto();
            Stream rs;
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = file,
            };

            var preurl = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = file,
                Expires = DateTime.UtcNow.AddYears(3)
            };
            using var client = new AmazonS3Client(credentials, config);
            var url = client.GetPreSignedURL(preurl);

            return url;
        }

        public async Task<FileReturnResponseDto> UploadFileReturnUrlAsync(Dtos.AwsDtos.S3Object obj, AwsCredentials awsCredentialsValues, string old_key)
        {
            var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            var response = new FileReturnResponseDto();
            // initialise client
            using var client = new AmazonS3Client(credentials, config);
            if (!String.IsNullOrEmpty(old_key))
            {
                try
                {
                    //delete object
                    var deleteObjectRequest = new DeleteObjectRequest
                    {
                        BucketName = obj.BucketName,
                        Key = old_key
                    };

                    Console.WriteLine("Deleting an object");
                    await client.DeleteObjectAsync(deleteObjectRequest);
                }
                catch (AmazonS3Exception e)
                {
                    Console.WriteLine("Error encountered on server. Message:'{0}' when deleting an object", e.Message);
                }
                catch (Exception c)
                {

                }
            }
            try
            {
                //byte[] mainoutputbytes = new byte[10];
                //using (MemoryStream memoryStream = obj.InputStream)
                //{
                //    // write some data to the memory stream
                //    byte[] databyte = new byte[10];
                //    memoryStream.Write(databyte, 0, databyte.Length);

                //    // convert the memory stream to a byte array
                //    byte[] outputdatabyte = memoryStream.ToArray();

                //    // do something with the byte array...


                //    // Resize the image to 100KB
                //    mainoutputbytes = ResizeImageInBytes(outputdatabyte, 100000);

                //}


                //// some byte array data
                //MemoryStream newmemoryStream = new MemoryStream();
                //newmemoryStream.Write(mainoutputbytes, 0, mainoutputbytes.Length);


                //MemoryStream newmemoryStream = ResizeImageInBytes(obj.InputStream, 100000);


                var uploadRequest = new TransferUtilityUploadRequest()
                {
                    InputStream = obj.InputStream,
                    Key = obj.Name,
                    BucketName = obj.BucketName,
                    CannedACL = S3CannedACL.NoACL
                };


                // initialise the transfer/upload tools
                var transferUtility = new TransferUtility(client);

                // initiate the file upload
                await transferUtility.UploadAsync(uploadRequest);

                //response.StatusCode = 201;
                //response.Message = $"{obj.Name} has been uploaded sucessfully";

                var request = new GetObjectRequest
                {
                    BucketName = obj.BucketName,
                    Key = "obj.Name",
                };

                var preurl = new GetPreSignedUrlRequest
                {
                    BucketName = obj.BucketName,
                    Key = obj.Name,
                    Expires = DateTime.UtcNow.AddYears(3)
                };

                var url = client.GetPreSignedURL(preurl);
                response.Message = "200";
                response.Key = obj.Name;
                response.Url = url;
                return response;

            }
            catch (AmazonS3Exception s3Ex)
            {
                response.Message = s3Ex.StatusCode.ToString() + "<br>" + s3Ex.Message;


            }
            catch (Exception ex)
            {
                response.Message = "error 500 <br>" + ex.Message;
            }
            return response;
        }



        public MemoryStream ResizeImageInBytes(MemoryStream imageBytes, int targetSizeInBytes)
        {
            try
            {


                try
                {
                    // acquire an exclusive lock on the memory stream
                    Monitor.Enter(imageBytes);




                    // Load the image from the byte array
                    Image image = Image.FromStream(imageBytes);

                    // Create a new MemoryStream to store the resized image
                    MemoryStream resizedStream = new MemoryStream();

                    // Set the compression quality of the resized image
                    EncoderParameters encoderParams = new EncoderParameters(1);
                    encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 80L);

                    // Initialize variables for the loop
                    int compressionRatio = 5;
                    int maxIterations = 10;
                    int iteration = 0;
                    long fileSize = 0;

                    // Loop until the image is smaller than the target size or the maximum number of iterations is reached
                    while (fileSize > targetSizeInBytes || iteration == 0)
                    {
                        // Reset the stream position to the beginning
                        resizedStream.Position = 0;

                        // Resize the image
                        using (var resizedImage = new Bitmap(image, new Size(image.Width / compressionRatio, image.Height / compressionRatio)))
                        {
                            // Save the resized image to the MemoryStream
                            resizedImage.Save(resizedStream, GetEncoderInfo("image/jpeg"), encoderParams);

                            // Calculate the file size of the resized image
                            fileSize = resizedStream.Length;
                        }

                        // Increase the compression ratio for the next iteration
                        compressionRatio++;

                        // Check if the maximum number of iterations has been reached
                        if (++iteration >= maxIterations) break;
                    }

                    // Return the byte array of the resized image
                    return resizedStream;
                }
                finally
                {
                    // release the lock on the memory stream
                    Monitor.Exit(imageBytes);
                }
            }
            catch (Exception c)
            {
                return null;
            }
        }

        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            foreach (var codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }


        public async Task<FileReturnResponseDto> DeleteObjectAsync(AwsCredentials awsCredentialsValues, string bucket, string key)
        {

            var credentials = new BasicAWSCredentials(awsCredentialsValues.AccessKey, awsCredentialsValues.SecretKey);

            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            var response = new FileReturnResponseDto();
            // initialise client
            using var client = new AmazonS3Client(credentials, config);

            try
            {
                //delete object
                var deleteObjectRequest = new DeleteObjectRequest
                {
                    BucketName = bucket,
                    Key = key
                };

                //Console.WriteLine("Deleting an object");
                await client.DeleteObjectAsync(deleteObjectRequest);
                response.Message = "200";
            }
            catch (AmazonS3Exception e)
            {
                //Console.WriteLine("Error encountered on server. Message:'{0}' when deleting an object", e.Message);
            }
            catch (Exception c)
            {

            }
            return response;


        }
    }
}
