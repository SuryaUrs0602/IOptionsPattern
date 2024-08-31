using Microsoft.Extensions.Options;

namespace IOptionsPattern
{

    public interface ITransientServices
    {
        OptionConfigurationBase Get();
    }

    public class TransientServices : ITransientServices
    {

        private readonly OptionConfigurationBase _configuration;

        public TransientServices(IOptions<OptionConfigurationBase> options)
        {
            _configuration = options.Value;
        }
        public OptionConfigurationBase Get()
        {
            return _configuration;
        }
    }
}
