using MediatR;
using Uttt.Micro.Libro.Persistencia;

namespace Uttt.Micro.Libro.Aplicacion
{
    public class Eliminar
    {
        public class EliminarLibro : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Manejador : IRequestHandler<EliminarLibro>
        {
            private readonly ContextoLibreria _contexto;
            public Manejador(ContextoLibreria contexto)
            {
                _contexto = contexto;
            }

            public async Task<Unit> Handle(EliminarLibro request, CancellationToken cancellationToken)
            {
                var libro = await _contexto.LibreriasMateriales.FindAsync(request.Id);
                if (libro == null)
                {
                    throw new Exception("No se encontró el libro");
                }

                _contexto.Remove(libro);
                var resultado = await _contexto.SaveChangesAsync();
                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar el libro");
            }
        }
    }
}
