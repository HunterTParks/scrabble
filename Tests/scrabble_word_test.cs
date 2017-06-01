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

    [Fact]
    public void IsLetter_ThreePoint_12()
    {
      Word newWord = new Word("BCMP");
      Assert.Equal(12, newWord.FindPoints());
    }

    [Fact]
    public void IsLetter_FourPoints_20()
    {
      Word newWord = new Word("FHVWY");
      Assert.Equal(20, newWord.FindPoints());
    }

    [Fact]
    public void IsLetter_FivePoints_5()
    {
      Word newWord = new Word("K");
      Assert.Equal(5, newWord.FindPoints());
    }
  }
}
