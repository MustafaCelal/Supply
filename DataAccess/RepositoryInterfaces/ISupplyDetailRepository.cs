using Entities.DTOs;
using Entities.Models;
using System.Collections.Generic;

namespace DataAccess.RepositoryInterfaces
{
    public interface ISupplyDetailRepository : IEntityRepository<SupplyDetail>
    {
        SupplyDetailDto GetByIdWithDetail(int id);
        List<SupplyDetailDto> GetAllWithDetail();
    }
}
