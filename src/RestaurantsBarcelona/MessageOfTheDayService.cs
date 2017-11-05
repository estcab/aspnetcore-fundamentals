using Microsoft.Extensions.Configuration;

namespace RestaurantsBarcelona
{
    public class MessageOfTheDayService : IMessageOfTheDayService
    {
        private IConfigurationRoot _config;

        public MessageOfTheDayService(IConfigurationRoot config)
        {
            _config = config;
        }
        public string GetMessage()
        {
            return _config["MOTD"];
        }
    }
}
