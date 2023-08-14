using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer;


public class EfServiceDal : GenericRepository<Service>, IServiceDal
{
    public EfServiceDal(Context context) : base(context)
    {
    }
}
