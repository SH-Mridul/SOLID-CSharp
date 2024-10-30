using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface ILibraryItem
    {
        int LibraryId { get; set; }
        string Title { get; set; }
    }
}
