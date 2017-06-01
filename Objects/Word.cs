using System.Collections.Generic;
using System;

namespace ScrabbleScoreProjectObjects
{
  public class Word
  {
    private string _word;
    public char[] _refactor;
    private int _points;
    public int _counter;

    public Word(string word)
    {
      _word = word;
      _points = 0;
      _refactor = ChangeIntoString();
      _counter = 0;
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
      _points += _counter;
    }
    public int FindPoints()
    {
      _refactor = ChangeIntoString();
      for(int i = 0; i <= _refactor.Length - 1; i++)
      {
        if(_refactor[i] == 'a' || _refactor[i] == 'e' || _refactor[i] == 'i' || _refactor[i] == 'o' || _refactor[i] == 'u' || _refactor[i] == 'l' || _refactor[i] == 'r' || _refactor[i] == 'n' || _refactor[i] == 's' || _refactor[i] == 't')
        {
          _counter = 1;
          AddPoints();
          Console.WriteLine(_points);
        }
        else if (_refactor[i] == 'd' || _refactor[i] == 'g' )
        {
          _counter = 2;
          AddPoints();
          Console.WriteLine(_points);
        }
        else if (_refactor[i] == 'b' || _refactor[i] == 'c' || _refactor[i] == 'm' || _refactor[i] == 'p' )
        {
          _counter = 3;
          AddPoints();
          Console.WriteLine(_points);
        }
        else if (_refactor[i] == 'f' || _refactor[i] == 'h' || _refactor[i] == 'v' || _refactor[i] == 'w' || _refactor[i] == 'y')
        {
          _counter = 4;
          AddPoints();
          Console.WriteLine(_points);
        }
        else if(_refactor[i] == 'k')
        {
          _counter = 5;
          AddPoints();
          Console.WriteLine(_points);
        }
        else if(_refactor[i] == 'j' || _refactor[i] == 'x')
        {
          _counter = 8;
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
