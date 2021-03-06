using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tracker.Data.Queries
{
    public static partial class PriorityExtensions
    {
        #region Generated Extensions
        public static Tracker.Data.Entities.Priority GetByKey(this IQueryable<Tracker.Data.Entities.Priority> queryable, Guid id)
        {
            if (queryable is DbSet<Tracker.Data.Entities.Priority> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Tracker.Data.Entities.Priority> GetByKeyAsync(this IQueryable<Tracker.Data.Entities.Priority> queryable, Guid id)
        {
            if (queryable is DbSet<Tracker.Data.Entities.Priority> dbSet)
                return dbSet.FindAsync(id).AsTask();

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
