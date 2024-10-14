using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class Car
    {
        public Guid Id { get; set; } // NewGuid 

        public string Make { get; set; } = string.Empty; // Ubrat 

        public string Model { get; set; } = string.Empty;

        public string LicensePlate { get; set; } = string.Empty; // Не забудь про Validation. Посмотри Validation Service в моем проекте 

        // Машина не должна хранить User, сделай отдельную таблицу UserCars 
 
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid StatusId { get; set; }
        public CarStatus Status { get; set; }
        public Role Role { get; set; }
        public ICollection<Car> Cars { get; set; }
    }

public class UserCars {
 public Guid Id { get; set; } // NewGuid 
public Guid UserId {get; set; } 
public Guid CarId {get; set; } 

// Не забудь про сами ссылки для будущего İnnerJoin, 
    // В самих таблицах будет ICollection из UserCars. 
}
}
