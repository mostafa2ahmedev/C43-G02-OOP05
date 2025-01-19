

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

        #region 4.	Implement All required Operators overloading to enable this Code:
        //●	D3=D1+D2
        public static Duration operator +(Duration left, Duration right)
        {

            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds,
            };
        }

        //●	D3=D1 + 7800
        public static Duration operator +(Duration left, int right)
        {
            int totalSeconds = (left.Hours ?? 0) * 3600 + (left.Minutes ?? 0) * 60 + (left.Seconds ?? 0) + right;
            int remainingSeconds = totalSeconds % 3600;

            return new Duration()
            {
                Hours = totalSeconds / 3600,
                Minutes = remainingSeconds / 60,
                Seconds = remainingSeconds % 60,
            };
        }
        //●	D3=666+D3
        public static Duration operator +(int left, Duration right)
        {
            int totalSeconds = (right.Hours ?? 0) * 3600 + (right.Minutes ?? 0) * 60 + (right.Seconds ?? 0) + left;
            int remainingSeconds = totalSeconds % 3600;

            return new Duration()
            {
                Hours = totalSeconds / 3600,
                Minutes = remainingSeconds / 60,
                Seconds = remainingSeconds % 60,
            };
        }


        //●	D3 = ++D1(Increase One Minute)

        public static Duration operator ++(Duration right)
        {


            return new Duration()
            {
                Hours = right.Hours,
                Minutes = right.Minutes + 1,
                Seconds = right.Seconds,
            };
        }
        //●	D3 = --D2(Decrease One Minute)
        public static Duration operator --(Duration right)
        {


            return new Duration()
            {
                Hours = right.Hours,
                Minutes = right.Minutes - 1,
                Seconds = right.Seconds,
            };
        }
        //●	D1= D1 -D2

        public static Duration operator -(Duration left, Duration right)
        {

            return new Duration()
            {
                Hours = left.Hours - right.Hours,
                Minutes = left.Minutes - right.Minutes,
                Seconds = left.Seconds - right.Seconds,
            };
        }

        //●	If (D1>D2)
        public static bool operator >(Duration left, Duration right)
        {
            return (left.Hours * 3600 + left.Minutes * 60 + left.Seconds) > (right.Hours * 3600 + right.Minutes * 60 + right.Seconds) ? true : false;

        }

        //●	If(D1<=D2
        public static bool operator <(Duration left, Duration right)
        {
            return (left.Hours * 3600 + left.Minutes * 60 + left.Seconds) < (right.Hours * 3600 + right.Minutes * 60 + right.Seconds) ? true : false;

        }
        //●	If (D1)
        public static implicit operator bool(Duration d)
        {
            return (d.Hours ?? 0) > 0 || (d.Minutes ?? 0) > 0 || (d.Seconds ?? 0) > 0;
        }
        //●	DateTime Obj = (DateTime) D1
        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(hour: D.Hours ?? 0, minute: D.Minutes ?? 0, second: D.Seconds ?? 0, year: 2024, month: 12, day: 12);

        }

        #endregion



    }
    #endregion
}
