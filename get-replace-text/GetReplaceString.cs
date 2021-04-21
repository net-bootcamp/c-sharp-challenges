
          static void Main(string[] args)
        {
        
            String sentance = "Welcome to Tuwaiq Academy";
            String firstWord = "Welcome";
            String lastWord = "Academy";
            String replacemntText = "SAFSCP";
            
            
            Console.WriteLine("This is the sample of Sentance : \n \n" + sentance +"\n");
            
            
            String result2 = GetReplaceString(sentance, firstWord, lastWord, replacemntText);
      
            Console.WriteLine("This is the sentance after replace text :  \n \n " + result2 );
            
            
             Console.WriteLine("\n "+ "Well done ..!");
            }

          public static string GetReplaceString(string sentance, string firstWord, string lastWord, String replacmentText)
        {    
              //check if two word exsit

            if (sentance.Contains(firstWord) == false && sentance.Contains(firstWord) == false)
            {
                return string.Empty;
            }
            
            // determine index of first word
            int indexOfFirstWord = sentance.IndexOf(value: firstWord, startIndex: 0) + firstWord.Length;
            String substring1 = sentance.Substring(startIndex: 0, indexOfFirstWord);
            
            // determin index of secound word
            int indexOfSecWord = sentance.IndexOf(value: lastWord, startIndex: indexOfFirstWord);
            String substring2 = sentance.Substring(startIndex: indexOfSecWord, length: sentance.Length-indexOfSecWord);

            // return replaceString 
            String result = $"{substring1}  {replacmentText} {substring2}";


            return result;

        }
        
