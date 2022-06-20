using Application.Common.Interfaces;
using Application.Common.Exceptions;
using Domain.Entities;
using MediatR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Application.Common.DTO.SellsDTO;

namespace Application.Sells.Queries
{
    public record GetSellsById : IRequest<SellsResponse>
    {
        public string Id { get; set; }
    }

    public class GetSellsByIdHandler : IRequestHandler<GetSellsById, SellsResponse>
    {
        private IMongoCollection<SellsEntity> _sells { get; }

        private IMapper _mapper { get; }

        public GetSellsByIdHandler(IEvenToTheMoonDbConnection context, IMapper mapper)
        {
            _sells = context.ConnectToMongo<SellsEntity>("Sells");
            _mapper = mapper;
        }

        public async Task<SellsResponse> Handle(GetSellsById query, CancellationToken cancellationToken)   
        {
            var result = await _sells.Find(x => x.Id == query.Id).ToListAsync();

            if(result.Count == 0) throw new NotFoundException("Sells", query.Id);

            return _mapper.Map<SellsEntity, SellsResponse>(result.FirstOrDefault());

        }
    }
}
