//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using ByeBikari.Framework;
//using ByeBikari.Framework.Cmn.EntityFilterTools;
//using ByeBikari.Framework.Cmn.EntityTools;
//using ByeBikari.Framework.Paged;
//using ByeBikari.InfraDapper.Models.JobSeekerAuthentications;

//namespace ByeBikari.InfraDapper.ReadRepositorys.JobSeekerAuthenticationReadAggregateRepositorys
//{
//    public partial class JobSeekerAuthenticationReadAggregateRepository : IJobSeekerAuthenticationReadAggregateRepository, IDisposable
//    {

//        public IPagedList<JobSeekerAuthenticationModel> SearchNews(EntityFilterTools.EntityFilterTermsAndSortParams entityFilterTermsAndSortParams)
//        {
//            try
//            {

//                string strWhere = string.Empty;
//                string strOrderBy = string.Empty;

//                foreach (var filterTerm in entityFilterTermsAndSortParams.EntityFilterTermList)
//                    if (!string.IsNullOrEmpty(filterTerm.SearchTerm))
//                    {
//                        string filterTermWhereClause = EntityFilterTools.GetSearchFilterTermWhereClause<Tbl_News>(filterTerm);

//                        if (!string.IsNullOrEmpty(filterTermWhereClause))
//                        {
//                            if (!string.IsNullOrEmpty(strWhere))
//                                strWhere += filterTerm.LogicalOp == EntityFilterTools.LogicalOps.Or ? " Or " : " And ";

//                            strWhere += filterTermWhereClause;
//                        }

//                    }

//                IQueryable<Tbl_News> query = db.Tbl_News.AsQueryable();

//                if (!string.IsNullOrEmpty(strWhere))
//                    query = query.Where(strWhere);

//                bool isFirstSortParam = true;

//                if (entityFilterTermsAndSortParams.EntitySortParamList.Count() == 0)
//                    entityFilterTermsAndSortParams.EntitySortParamList.Add(new EntityFilterTools.EntitySortParam("NewsID", EntityFilterTools.SortDir.Desc));

//                foreach (var entitySortParam in entityFilterTermsAndSortParams.EntitySortParamList)
//                {
//                    query = EntityTools.OrderByPropertyName(query, entitySortParam.SortField,
//                        entitySortParam.SortDir == EntityFilterTools.SortDir.Asc, isFirstSortParam);

//                    isFirstSortParam = false;
//                }

//                //query = query.Where(sd => sd.StartDate <= dt);

//                var ssss = new PagedList<Tbl_News>(query, entityFilterTermsAndSortParams.PageIndex, entityFilterTermsAndSortParams.PageSize).ToBusinessObjectPagedList();
//                return ssss;
//            }
//            catch (ExceptionManagement exc)
//            {
//                throw new ExceptionManagement(exc.Message);
//            }

//        }
//        #region IDisposable Support

//        private bool disposedValue = false;

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposedValue)
//            {
//                if (disposing)
//                {
//                }

//                disposedValue = true;
//            }
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//        }

//        #endregion


//    }
//}
