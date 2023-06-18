using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Models
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string CoverUrl { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
        public DateTime? LastTimeActive { get; set; }
        public bool IsOnline { get; set; }
    }
}
