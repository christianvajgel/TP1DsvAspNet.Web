using System;
using System.Collections.Generic;
using System.Text;

namespace TP1DsvAspNet.Domain
{
    public class Friend
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
