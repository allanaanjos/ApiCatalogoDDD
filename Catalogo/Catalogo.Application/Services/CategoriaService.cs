using AutoMapper;
using Catalogo.Application.DTOs;
using Catalogo.Application.Interfaces;
using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;

namespace Catalogo.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;

        }
        public async Task Add(CategoriaDTO categoriaDTO)
        {
            var cateoriaEntity = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepository.CreateAsync(cateoriaEntity);
        }

        public async Task<CategoriaDTO> GetById(int id)
        {
            var categoriaEntity = await _categoriaRepository.GetByIdAsync(id);
            return _mapper.Map<CategoriaDTO>(categoriaEntity);
        }

        public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
        {
            var categoriaEntity = await _categoriaRepository.GetCategoriaAsync();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriaEntity);
        }

        public async Task Remove(int id)
        {
            var categoriaEntity =  _categoriaRepository.GetByIdAsync(id).Result;
            await _categoriaRepository.RemoveAsync(categoriaEntity);


        }

        public async Task Update(CategoriaDTO categoriaDTO)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepository.UpdateAsync(categoriaEntity);
        }
    }
}
