using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer;
public class EfStaffDal : GenericRepository<Staff>, IStaffDal
{
    public EfStaffDal(Context context) : base(context)
    {
    }
}
