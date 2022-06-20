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
    public class UpdateSellsCommandHandler : IRequestHandler<UpdateSellsCommand, string>
    {
        private IMongoCollection<SellsEntity> _sells { get; }

        public UpdateSellsCommandHandler(IEvenToTheMoonDbConnection context)
        {
            _sells = context.ConnectToMongo<SellsEntity>("Sells");
        }

        public async Task<string> Handle(UpdateSellsCommand request, CancellationToken cancellationToken)
        {
            var entity = new SellsEntity
            {
                Id = request.Id,
                DateOfSale = request.DateOfSale,
                SellsCount = request.SellsCount,
                ID_Clients = request.ID_Clients,
                ID_Tour = request.ID_Tour
            };

            await _sells.ReplaceOneAsync(Builders<SellsEntity>.Filter.Eq("_id", request.Id), entity);

            return entity.Id;
        }
    }
    public record UpdateSellsCommand : IRequest<string>
    {
        public string Id { get; set; }
        public DateTime DateOfSale { get; set; }
        public int SellsCount { get; set; }
        public string ID_Clients { get; set; }
        public int ID_Tour { get; set; }
    }
}
