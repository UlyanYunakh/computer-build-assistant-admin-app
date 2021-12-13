namespace computer_build_assistant_admin_app.Data
{
  public static class StaticData
  {
    public static Dictionary<string, double> bestValues = new Dictionary<string, double>();
    public static Dictionary<string, double> coefficients = new Dictionary<string, double>();

    static StaticData() 
    {
      bestValues.Add("size", 5);
      bestValues.Add("size", 5);
      

      coefficients.Add("size", 0.5);
      coefficients.Add("size", 0.5);
      
    }
  }
}