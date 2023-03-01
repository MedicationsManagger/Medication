using System;
using System.Collections.Generic;

namespace Medication
{
    public partial class CaregiverStatusCode
    {
        public CaregiverStatusCode()
        {
            UserAndCaregivers = new HashSet<UserAndCaregiver>();
        }

        public int Id { get; set; }
        public string StatusDescription { get; set; } = null!;

        public virtual ICollection<UserAndCaregiver> UserAndCaregivers { get; set; }
    }
}
