using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Data
{
    public class MemberRepository : IRepository<Member>
    {
        private readonly IBaseDataModel baseDataModel;

        public MemberRepository(IBaseDataModel baseDataModel)
        {
            this.baseDataModel = baseDataModel;
        }
        public void Add(Member item) => baseDataModel.Members.Add(item);
        public void Remove(Member item) => baseDataModel.Members.Remove(item);
        public void Delete(Member item) => item.IsDeleted = true;
        public void Update(Member item , int id) { }
        public IEnumerable<Member> GetAll() => baseDataModel.Members;
        public Member? GetById(int id)
        {
            return baseDataModel.Members.FirstOrDefault(x => x.Id == id);
        }
    }
}
