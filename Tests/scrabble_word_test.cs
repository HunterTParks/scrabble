using Xunit;

namespace ScrabbleScoreProjectObjects
{
  public class ScrabbleScoreProjectTest
  {
    [Fact]
    public void IsLetter_OnePoint_3()
    {
      Word newWord = new Word("AEI");
      Assert.Equal(3, newWord.FindPoints());
    }

    [Fact]
    public void IsLetter_TwoPoint_4()
    {
      Word newWord = new Word("DG");
      Assert.Equal(4, newWord.FindPoints());
    }
  }
}
