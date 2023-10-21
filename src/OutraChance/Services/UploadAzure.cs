using Azure.Storage.Blobs;

namespace OutraChance.Services
{
    public class UploadAzure
    {
        private readonly IConfiguration _configuration;

        public UploadAzure(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> SalvarArquivo(IFormFile file)
        {
            string connectionString = _configuration.GetConnectionString("AzureStorage");
            string container = "uploads";

            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(container);

            string blobName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream);
            }

            string blobUrl = blobClient.Uri.AbsoluteUri;

            return blobUrl;

        }
    }
}
