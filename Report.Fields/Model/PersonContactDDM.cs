using System;

namespace Report.Fields.Model
{
    public class PersonContactDDM 
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Country { get; set; }
        public int? ContactRelationshipId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public int Id { get; set; }
        public bool? IsDependent { get; set; }
        public bool? IsEmergency { get; set; }
        public bool? IsNextOfKin { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public int? EmployeeId { get; set; }
        public string WorkPhone { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
