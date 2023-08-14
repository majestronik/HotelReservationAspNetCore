using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
namespace HotelProject.DataAccessLayer;

public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
    public EfTestimonialDal(Context context) : base(context)
    {
    }
}
