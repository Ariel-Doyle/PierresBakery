namespace BakeryStoreFront.Models
{
  public class Bread
  {
    private static int _priceOfBread = 500;
    private static int _discountLoafGroup = 3; 
    private static int _BreadFormula(int numberOfLoaves)
    {
      int chargePerGroup = _discountLoafGroup - 1;
      int numberOfGroups = numberOfLoaves / _discountLoafGroup;
      int extraLoaves = numberOfLoaves % _discountLoafGroup;

      return ((chargePerGroup * numberOfGroups) + extraLoaves);
    }
     public static double DetermineBreadPrice(int numberOfLoaves)
    {
      return 0.01 * _priceOfBread * _BreadFormula(numberOfLoaves);
    } 
  }

  public class Pastry
  {
    private static int _priceOfPastry = 200;
    private static int _discountPastryGroup = 4;
    private static int _PastryFormula(int numberOfPastries)
    {
      int chargePerGroup = _discountPastryGroup - 1;
      int numberOfGroups = numberOfPastries / _discountPastryGroup;
      int extraPastries = numberOfPastries % _discountPastryGroup;

      return ((chargePerGroup * numberOfGroups) + extraPastries);
    }
    public static double DeterminePastryPrice(int numberOfPastries)
    {
      return 0.01 * _priceOfPastry * _PastryFormula(numberOfPastries); 
    } 
  }
  public class Cart
  {
    public int LoavesPurchased { get; set; }
    public int PastriesPurchased { get; set; }
  }
}