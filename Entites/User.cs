using System;
using System.Collections.Generic;

namespace Medication
{
    public partial class User
    {
        public User()
        {
            Measurements = new HashSet<Measurement>();
            MedicineForUsers = new HashSet<MedicineForUser>();
            MedicineStocks = new HashSet<MedicineStock>();
            SystemMessages = new HashSet<SystemMessage>();
            UserAndCaregiverCaregivers = new HashSet<UserAndCaregiver>();
            UserAndCaregiverUsers = new HashSet<UserAndCaregiver>();
        }

        public int Id { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string IdentityNumber { get; set; } = null!;
        public int GenderId { get; set; }

        public virtual GenderCode Gender { get; set; } = null!;
        public virtual ICollection<Measurement> Measurements { get; set; }
        public virtual ICollection<MedicineForUser> MedicineForUsers { get; set; }
        public virtual ICollection<MedicineStock> MedicineStocks { get; set; }
        public virtual ICollection<SystemMessage> SystemMessages { get; set; }
        public virtual ICollection<UserAndCaregiver> UserAndCaregiverCaregivers { get; set; }
        public virtual ICollection<UserAndCaregiver> UserAndCaregiverUsers { get; set; }
    }
}
