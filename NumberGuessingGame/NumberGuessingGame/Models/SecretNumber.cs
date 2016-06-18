using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGuessingGame.Models
{    
    public class SecretNumber 
    {

        private List<GuessedNumber> _guessedNumbers;
        private GuessedNumber _lastGuessedNumber;                           // Alla Fields
        private int? _number;
        public const int MaxNumberOfGuesses = 7;


        public bool CanMakeGuess
        {

            get
            {
                if (Count > MaxNumberOfGuesses && _lastGuessedNumber.Outcome != Outcome.Right)             // Returnerar True eller false beroende på vad Counten (antalet gissningar) är.
                    return false;                                                                          // Returnerar även False om man har gissar rätt.
                    else
                    return true;
            }


        }                                                                   
        public int Count
        {

            
            get
            {
                //if (_guessedNumbers != null)
                //{
                    return _guessedNumbers.Count;               //Tar ANTALET nummer i _guessednumbers och returnerar det värdet
                //}
                //else return 0;
            }    
        }

        public IList<GuessedNumber> GuessedNumbers
        {
            get
            {
                return _guessedNumbers.AsReadOnly();        //Returnerar en lista på gissade siffror. Har använt metoden AsReadOnly() som löser alla(?) privacy leaks problem.


            }



        }
        public GuessedNumber LastGuessedNumber
        {
            get
            {
                return _lastGuessedNumber;                  //Returnerar senaste gissade talet.

            }

        }
        public int? Number {



            get
            {

                return CanMakeGuess ? null : _number;       //

            }




            private set
            {

                _number = value;

            }               
                
                
        }
        
        

        public void Initialize()
        {
            if (_guessedNumbers != null)
            { 
            _guessedNumbers.Clear();                        //Rensar _guessedNumbers listan
            }                       
            Random random = new Random();                   //Initierar Random
            _number = random.Next(1, 100);                  //Tilldelar _number ett värde mellan 1 och 100
            _lastGuessedNumber = new GuessedNumber { Number = null, Outcome = Outcome.Indefinite };
        }



        public Outcome MakeGuess(int guess)
        {
            if (guess < 1 || guess >100)
            {
                throw new ArgumentOutOfRangeException();        //TODO
            }
            if (!CanMakeGuess)
            {

                _lastGuessedNumber.Outcome = Outcome.NoMoreGuesses;
            }
            //if (_guessedNumbers.Exists(guess))                  //TODO cannot convert from int to system.predicate
            //{
            //    _lastGuessedNumber.Outcome = Outcome.OldGuess;
            //}  
            if (guess > _number)
            {
                _lastGuessedNumber.Outcome = Outcome.Low;
            }
            if (guess < _number)
            {
                _lastGuessedNumber.Outcome = Outcome.High;
            }
            if (guess == _number)
            {
                _lastGuessedNumber.Outcome = Outcome.Right;
            }

            _guessedNumbers.Add(_lastGuessedNumber);
            _lastGuessedNumber.Number = guess;            
            return _lastGuessedNumber.Outcome;
            
            
        }

        public SecretNumber()
            {
            Initialize();                                   // Kallar på Metoden Initialize
            _guessedNumbers = new List<GuessedNumber>();
            }

    }
}