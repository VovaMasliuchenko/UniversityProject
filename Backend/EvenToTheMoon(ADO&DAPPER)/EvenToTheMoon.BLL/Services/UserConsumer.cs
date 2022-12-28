using AutoMapper;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces.Repositories;
using MassTransit;
using RabbitMQModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoon.BLL.Services
{
    public class UserConsumer : IConsumer<UserQueueRequest>
    {
        private IUserRepository _userRepository;

        private IMapper _mapper;

        public UserConsumer(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UserQueueRequest> context)
        {
            var data = context.Message;
            var user = _mapper.Map<User>(data);
            await _userRepository.AddAsync(user);
        }
    }
}
