using Servicio.Entities;
using System.Threading.Tasks;

namespace Servicio.Repository
{
    public interface ISubirImagenRepository
    {
        Task Handle(Imagen request);
    }
}