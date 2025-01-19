

namespace Demo
{

    #region 1.	Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
    internal class Duration
    {

        public int? Hours { get; set; }
        public int? Minutes { get; set; }
        public int? Seconds { get; set; }

        public Duration()
        {
            
        }

        public Duration(int? Hours, int? Minutes, int? Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public Duration(int totalSeconds)
        {
            this.Hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;
            this.Minutes = remainingSeconds / 60;
            this.Seconds = remainingSeconds % 60;
        }
        #region 2.	Override All System.Object Members (ToString, Equals,GetHasCode) 
        public override string ToString()
        {
            return $"Hours: {Hours},Minutes; {Minutes ?? 0},Seconds: {Seconds ?? 0}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        #endregion




  
    }
    #endregion
}
