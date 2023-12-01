using AutoMapper;
using Catalogo.Application.DTOs;
using Catalogo.Application.Interfaces;
using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;

namespace Catalogo.Application.Services
{
    public class ProdutoService : IProdutosService
    {
        private IProdutosRepository _produtosRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutosRepository produtosRepository, IMapper mapper)
        {
            _produtosRepository = produtosRepository;
            _mapper = mapper;

        }
        public async Task Add(ProdutoDTO ProdutosDTO)
        {
            var produtosEntity = _mapper.Map<Produtos>(ProdutosDTO);
            await _produtosRepository.CreateAsync(produtosEntity);
        }

        public async Task<ProdutoDTO> GetById(int? id)
        {
            var produtosEntity = await _produtosRepository.GetByIdAsync(id);
            return _mapper.Map<ProdutoDTO>(produtosEntity);
        }

        public async Task<IEnumerable<ProdutoDTO>> GetProdutos()
        {
            var produtosEntity = await _produtosRepository.GetProdutosAsync();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtosEntity);
        }

        public async Task Remove(int? id)
        {
            var produtosEntity = _produtosRepository.GetByIdAsync(id).Result;
            await _produtosRepository.RemoveAsync(produtosEntity);


        }

        public async Task Update(ProdutoDTO ProdutosDTO)
        {
            var produtosEntity = _mapper.Map<Produtos>(ProdutosDTO);
            await _produtosRepository.UpdateAsync(produtosEntity);

        }

    }
}