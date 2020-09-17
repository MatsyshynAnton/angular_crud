using AutoMapper;

namespace BusinessLogicLayer.Services.Abstractions
{
    public abstract class BaseService
    {
        protected readonly IMapper _mapper;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
