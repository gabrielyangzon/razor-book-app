using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_App.Model
{
    public class UsersModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Website { get; set; }

        public AddressClass Address { get; set; }

       public class AddressClass
        {
            public string Street { get; set; }
            public string Suite { get; set; }
            public string City { get; set; }
            public string ZipCode { get; set; }

            public GeoClass Geo { get; set; }
            public class GeoClass
            {
                public string Lat { get; set; }
                public string Lng { get; set; }
            }
        }
    //    "id": 1,
    //"name": "Leanne Graham",
    //"username": "Bret",
    //"email": "Sincere@april.biz",
    //"address": {
    //  "street": "Kulas Light",
    //  "suite": "Apt. 556",
    //  "city": "Gwenborough",
    //  "zipcode": "92998-3874",
    //  "geo": {
    //    "lat": "-37.3159",
    //    "lng": "81.1496"
    //  }
    //},
    //"phone": "1-770-736-8031 x56442",
    //"website": "hildegard.org",
    //"company": {
    //  "name": "Romaguera-Crona",
    //  "catchPhrase": "Multi-layered client-server neural-net",
    //  "bs": "harness real-time e-markets"
    //}
    }
}
