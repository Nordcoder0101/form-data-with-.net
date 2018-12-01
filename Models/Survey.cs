namespace first_form.Models
{
  public class Survey
  {
    public string Name {get; set;}
    public string Dojo {get; set;}
    public string Language {get; set;}

    public string Comment {get;set;}

    public Survey(string name, string dojo, string language)
    {
      Name = name;
      Dojo = dojo;
      Language = language;

    }
    public Survey(string name, string dojo, string language, string comment)
    {
      Name = name;
      Dojo = dojo;
      Language = language;
      Comment = comment;
    }
  }
}