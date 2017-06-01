using System.Collections.Generic;
using System;

namespace ScrabbleScoreProjectObjects
{
  public class Word
  {
    private string _word;
    public char[] _refactor;
    private int _points;

    public Word(string word)
    {
      _word = word;
      _points = 0;
      _refactor = ChangeIntoString();
    }

    public string GetWord()
    {
      return _word;
    }
    public int GetPoints()
    {
      return _points;
    }
    public void AddPoints()
    {
      _points++;
    }
    public int FindPoints()
    {
      _refactor = ChangeIntoString();
      for(int i = 0; i <= _refactor.Length - 1; i++)
      {
        if(_refactor[i] == 'a' || _refactor[i] == 'e' || _refactor[i] == 'i' || _refactor[i] == 'o' || _refactor[i] == 'u' || _refactor[i] == 'l' || _refactor[i] == 'r' || _refactor[i] == 'n' || _refactor[i] == 's' || _refactor[i] == 't')
        {
          AddPoints();
          Console.WriteLine(_points);
        }
      }
      int test = GetPoints();
      return test;
    }
    public char[] ChangeIntoString()
    {
      _word = _word.ToLower();
      char[] test = _word.ToCharArray();
      return test;
    }
  }
}
