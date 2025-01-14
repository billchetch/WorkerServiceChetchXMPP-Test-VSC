using Chetch.ChetchXMPP;

namespace WorkerServiceChetchXMPP;

public class Worker : ChetchXMPPService<Worker>
{
    public Worker(ILogger<Worker> logger) : base(logger)
    {
    }

    
}
