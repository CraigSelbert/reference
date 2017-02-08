using System;
using UMV.Reference.Patterns.Base.Interfaces;

namespace UMV.Reference.Patterns.Base
{
    public abstract class Spannable : ISpannable
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}