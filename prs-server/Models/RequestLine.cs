using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace prs_server.Models {

    public class RequestLine {
        public int Id { get; set; }

        public int RequestId { get; set; }
            public virtual Request Request { get; set; }

        public int ProductId { get; set; }
            [JsonIgnore]
            public virtual Product Product { get; set; }

        public int Qty { get; set; }

    }
}
