using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchWindow
{
    class ListOf
    {
        public string docket_number;
        public string idmatter;
        public string matter_type;
        public string name;
        public string record_id;
        public ListOf(string docket_number, string idmatter, string matter_type, string name, string record_id)
        {
            this.docket_number = docket_number;
            this.idmatter = idmatter;
            this.matter_type = matter_type;
            this.name = name;
            this.record_id = record_id;
        }
    }


}
