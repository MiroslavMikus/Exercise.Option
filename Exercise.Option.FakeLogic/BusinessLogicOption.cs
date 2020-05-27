using Optional;
using Optional.Linq;

namespace Exercise.Option
{
    public class BusinessLogicOption
    {
        public Option<Reservation> RentVehicke(int userId, int vehicleId)
        {
            var user = RepositoryOption.GetUser(userId)
                .SomeWhen(a => !RepositoryOption.GetReservationsByUser(userId).HasValue);

            var car = RepositoryOption.GetCar(vehicleId)
                .SomeWhen(a => !RepositoryOption.GetReservationsByVehicle(vehicleId).HasValue);

            


            return new Reservation()
            {
                Id = 1,
                UserId = userId,
                VehicleId = vehicleId
            }.Some();
        }
    }
}
