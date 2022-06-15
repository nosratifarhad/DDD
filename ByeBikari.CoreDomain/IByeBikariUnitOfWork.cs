using ByeBikari.CoreDomain.JobSeekerAuthenticationAggregate;
using ByeBikari.Framework.UnitOfWorkInterface;
namespace ByeBikari.CoreDomain
{
    public interface IByeBikariUnitOfWork: IUnitOfWork
    {
        IJobSeekerAuthenticationAggregateRepository _jobSeekerAuthenticationAggregateRepository { get; }

    }
}

