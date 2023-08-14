using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer;

public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
{
    public EfSubscribeDal(Context context) : base(context)
    {
    }
}
