using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly2.Models;

namespace Vidly2.DTOs
{
    public class CustomerDTO
    {

        public int Id { get; set; }

        [Required]//overwritten custom error message
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }       

        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }

        //[Min18YearsIfMember] usuniete z uwagi na fakt ze implementacja tego parametry używa Customer a nie CustomerDTO
        public DateTime? Birthday { get; set; }
    }
}