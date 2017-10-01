namespace Interfaces.Cutter
{
    public class CutterFactory
    {
        public static ICutter CreateCutter(string cutter)
        {
            ICutter tmp;
            switch (cutter)
            {
                case "actor":
                    tmp = new Actor();
                    break;
                case "barber":
                    tmp = new Barber();
                    break;
                // ReSharper disable once RedundantCaseLabel
                case "butcher":
                default:
                    tmp = new Butcher();
                    break;
            }
            return tmp;
        }
    }
}