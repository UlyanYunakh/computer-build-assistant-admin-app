namespace computer_build_assistant_admin_app.Data
{
  public class StaticData
  {
    public Dictionary<string, double> bestValues = new Dictionary<string, double>();
    public Dictionary<string, double> coefficients = new Dictionary<string, double>();

    public StaticData() 
    {
      bestValues.Add("motherboardSize", 5);
      bestValues.Add("memory_frequency", 3000);
      bestValues.Add("multithreading", 1);
      bestValues.Add("clock_frequency", 5);
      bestValues.Add("cores", 8);
      bestValues.Add("caseSize", 27);
      bestValues.Add("coolingSize", 200);
      bestValues.Add("power_dissipation", 200);
      bestValues.Add("noize_level", 45);
      bestValues.Add("powerSize", 3);
      bestValues.Add("power", 1300);
      bestValues.Add("storageSize", 3000);
      bestValues.Add("speed", 15000);
      

      coefficients.Add("motherboardSize", 0.5);
      coefficients.Add("memory_frequency", 0.6);
      coefficients.Add("multithreading", 0.5);
      coefficients.Add("clock_frequency", 0.4);
      coefficients.Add("cores", 0.5);
      coefficients.Add("caseSize", 0.2);
      coefficients.Add("coolingSize", 0.4);
      coefficients.Add("power_dissipation", 0.7);
      coefficients.Add("noize_level", -0.4);
      coefficients.Add("powerSize", 0.2);
      coefficients.Add("power", 0.7);
      coefficients.Add("storageSize", 0.6);
      coefficients.Add("speed", 0.7);
      
    }
  }
}
