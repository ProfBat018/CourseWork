using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Username { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
      
      //  public Guid RoleId { get; set; }
     //   public Role Role { get; set; }
      
        public ICollection<Car> Cars { get; set; }


    }

    // Роли хранятся в отдельной UserRole 
    // не забудь доабить DbSet в context

    public class UserRole  {
    public Guid RoleId { get; set; } = Guid.NewGuid();  // это тоже foreignkey 
        public Guid UserId { get; set; } = Guid.NewGuid(); // это ForeignKey
        
    }

    public class Role {
          public Guid RoleId { get; set; } = Guid.NewGuid();  
        public string roleName {get; set; }
        
    }

}


