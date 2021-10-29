using System;

namespace library.Model
{
    public class Publish
    {
        public int Id { get; set; }
        public string NamePublisher { get; set; }
        public string Address { get; set; }
        public string Site { get; set; }

        public Publish() { }
        public Publish(int id, string namePublisher, 
            string address, string site) 
        {
            this.Id = id;
            this.NamePublisher = namePublisher;
            this.Address = address;
            this.Site = site;
        }

    }
}
