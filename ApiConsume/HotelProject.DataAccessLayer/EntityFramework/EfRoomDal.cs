using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer;

public class EfRoomDal : GenericRepository<Room>, IRoomDal
{
    public EfRoomDal(Context context) : base(context)
    {
    }
}
