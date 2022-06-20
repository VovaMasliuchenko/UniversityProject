using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sells.Commands
{
    public class DeleteSellsCommandHandler : IRequestHandler<DeleteSellsCommand, string>
    {
        private IMongoCollection<SellsEntity> _sells { get; }

        public DeleteSellsCommandHandler(IEvenToTheMoonDbConnection context)
        {
            _sells = context.ConnectToMongo<SellsEntity>("Sells");
        }

        public async Task<string> Handle(DeleteSellsCommand request, CancellationToken cancellationToken)
        {
            var sells = await _sells.Find(x => x.Id == request.Id).ToListAsync();

            if (sells == null) throw new NotFoundException("Sells", request.Id);

            await _sells.DeleteOneAsync(x => x.Id == request.Id);

            return request.Id;
        }
    }
    public record DeleteSellsCommand : IRequest<string>
    {
        public string Id { get; set;}
    }
}
