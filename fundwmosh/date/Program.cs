namespace Date {
    public class Date {
        public static void Main(string[] args) {
            var datetime = new DateTime(2015, 1, 1);
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(DateTime.Today);
            System.Console.WriteLine(datetime);
            // Datetime is immutable

            var notNow = DateTime.Now.AddDays(405040);
            System.Console.WriteLine(notNow);
            System.Console.WriteLine(notNow.ToShortDateString());
            System.Console.WriteLine(notNow.ToLongDateString());
            System.Console.WriteLine(notNow.ToString());

            //timespan

            var timespan = DateTime.Now.AddDays(2) - DateTime.Now;
            System.Console.WriteLine(timespan);
        }
    }
}