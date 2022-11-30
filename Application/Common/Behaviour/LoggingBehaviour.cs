using Application.Common.Interfaces;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Behaviour
{
    public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest>

    {
        private readonly ILogger _logger;

        public LoggingBehaviour(ILogger<TRequest> logger)
        {
            _logger = logger;

        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            string userName = string.Empty;


            _logger.LogInformation("test Request: {Name} {@UserId} {@UserName} {@Request}",
                requestName, "", userName, request);
        }
    }
}
