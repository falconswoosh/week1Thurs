using System;
using Symtem.Collections.Generic;

namespace Hangman
{
  class game
  {
    private List<Dictionary<char,bool>> _targetWords; //list of words game can use; words are in dictionary format with found and not found state for each letter
    private int         _guesses;                    //guesses remaining
    private int         _targetIndex;                 //random number from 0 to _targetWords.Count()-1
    private string      _displayString;
    public void display()
      {
        foreach(bool c in _targetWords[_targetIndex])
        {
          if (c==true){/*Add c.KeyVal to _displayString*/}
          if (!c)     {/*Add underscore to _displayString*/}
        }

      }

    public string guess(string arg) /*passes in a string arg, takes only first letter or generates error message*/
    {}


  }


}
