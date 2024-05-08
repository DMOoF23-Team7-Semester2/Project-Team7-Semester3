using Rally.Application.Dto.SignBase;

namespace Rally.Application.Interfaces
{
    public interface ISignBaseService
    {
        Task<IEnumerable<SignBaseDto>> GetAll();
        Task<SignBaseDto> GetById(int id);
        Task<SignBaseDto> Create(SignBaseDto dto);
        Task Update(SignBaseDto dto);
        Task Delete(int id);

        Task<SignBaseWithEquipmentBaseDto> GetSignBaseWithEquipmentBase(int SignBaseId);
        Task<SignBaseDto> GetSignBaseWithCategory(int SignBaseId);

    }
}

