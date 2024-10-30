using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISP;

namespace ISP
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}
