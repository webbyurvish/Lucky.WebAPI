using AutoMapper;
using Lucky.WebAPI.Data.Models;
using Lucky.WebAPI.Logging;
using Lucky.WebAPI.Repository.Contract;
using Lucky.WebAPI.Service.Contract;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Lucky.WebAPI.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly IMapper _mapper;
        private readonly UserManager<LuckyUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;

        public ServiceManager(IMapper mapper, UserManager<LuckyUser> userManager, IConfiguration configuration, ILoggerManager logger, IRepositoryManager repository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _logger = logger;
            _repository = repository;
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(_mapper, _userManager, _configuration, _logger));
        }

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
