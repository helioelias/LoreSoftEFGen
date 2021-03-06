using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tracker.Data.Queries
{
    public static partial class StatusExtensions
    {
        #region Generated Extensions
        public static Tracker.Data.Entities.Status GetByKey(this IQueryable<Tracker.Data.Entities.Status> queryable, Guid id)
        {
            if (queryable is DbSet<Tracker.Data.Entities.Status> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Tracker.Data.Entities.Status> GetByKeyAsync(this IQueryable<Tracker.Data.Entities.Status> queryable, Guid id)
        {
            if (queryable is DbSet<Tracker.Data.Entities.Status> dbSet)
                return dbSet.FindAsync(id).AsTask();

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
