using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Servicio.Entities;
using System.Threading.Tasks;

namespace Servicio.Repository
{
    public class SubirImagenRepository : ISubirImagenRepository
    {

        private readonly BlobServiceClient _blobServiceClient;

        public SubirImagenRepository( BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task Handle(Imagen request)
        {
            var container = _blobServiceClient.GetBlobContainerClient("animalesupc");
            container.CreateIfNotExists();

            var blobClient = container.GetBlobClient(request.fot_fot.FileName);
            await blobClient.UploadAsync(request.fot_fot.OpenReadStream(), new BlobHttpHeaders { ContentType = request.fot_fot.ContentType });

            string urlImagen = blobClient.Uri.AbsoluteUri;
            /* Conexion a la DB realizar el insert */

        }
    }
}
