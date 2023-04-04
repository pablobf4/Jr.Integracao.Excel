using Jr.Integracao.Excel.Model.Base;
using Jr.Integracao.Excel.Model.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Jr.Integracao.Excel.Repositorio
{
    public class UsuarioRepositorio
    {
        private readonly Context _context;

        public UsuarioRepositorio(Context context)
        {
            _context = context;

        }
        public async  Task<Usuario> Atualizar(Usuario dto)
        {
            _context.Usuarios.Update(dto);
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<Usuario> BuscarPorId(long id)
        {
            Usuario usuario = await _context.Usuarios.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Usuario();
            return usuario;
        }

        public async Task<IEnumerable<Usuario>> BuscarTodos()
        {
            List<Usuario> products = await _context.Usuarios.ToListAsync();
            return products;
        }

        public async Task<Usuario> Criar(Usuario dto)
        {
            _context.Usuarios.Add(dto);
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<bool> Deletar(long id)
        {
            try
            {
                Usuario usuario = await _context.Usuarios.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Usuario();
                if (usuario.Id <= 0) return false;
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
