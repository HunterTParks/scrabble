using Nancy;


namespace ScrabbleScoreProjectObjects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/result"] = _ =>
      {
        Word output = new Word(Request.Form["word"]);
        return View["index.cshtml", output];
      };
    }
  }
}
