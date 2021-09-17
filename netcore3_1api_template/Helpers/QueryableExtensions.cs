using netcore3_1api_template.DTOs;
using System.Linq;

namespace netcore3_1api_template.Helpers
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, PaginationDto pagination)
        {
            return queryable.Skip((pagination.Page - 1) * pagination.RecordsPerPage).Take(pagination.RecordsPerPage);
        }
    }
}