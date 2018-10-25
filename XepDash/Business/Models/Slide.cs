using System;

namespace XepDash.Business.Models
{
    public class Slide : ISlide
    {
        public int Id { get; set; }
        public int OrderIndex { get; set; }
        public string ImageUri { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public void LoadData()
        {
            throw new NotImplementedException();
        }
    }
}