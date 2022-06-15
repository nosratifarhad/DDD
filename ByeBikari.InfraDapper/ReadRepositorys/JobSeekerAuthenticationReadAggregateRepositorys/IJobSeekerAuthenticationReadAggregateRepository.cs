using ByeBikari.Framework.Cmn.EntityFilterTools;
using ByeBikari.Framework.Paged;
using ByeBikari.InfraDapper.Models.JobSeekerAuthentications;
using System;

namespace ByeBikari.InfraDapper.ReadRepositorys.JobSeekerAuthenticationReadAggregateRepositorys
{
    /// <summary>
    ///  را میتوان در لایه دامین هم ایجاد کرد و در این للایه پیاده سازی کرد Repository این 
    /// </summary>
    public partial interface IJobSeekerAuthenticationReadAggregateRepository : IDisposable
    {
        IPagedList<JobSeekerAuthentication> SearchNews(EntityFilterTools.EntityFilterTermsAndSortParams entityFilterTermsAndSortParams);

    }
}
