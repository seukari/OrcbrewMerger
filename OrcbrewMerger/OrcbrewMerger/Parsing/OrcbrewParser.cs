using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrcbrewMerger.common;

namespace OrcbrewMerger.Parsing
{
    public static class OrcbrewParser
    {

        public static string ParseOrcbrewFile(string input)
        {

            StringBuilder sFileString = new System.Text.StringBuilder(input);
                            
            bool removed = false;
            bool inString = false;
            for (int i = 0; i < sFileString.Length; i++)
            {
                
                char cChar = sFileString[i];
                if (cChar.Equals('\\') && sFileString[i + 1] == 'n')   //Removes new lines added by OrcPub
                {
                    sFileString.Remove(i, 2);
                }
                if (cChar.Equals('"'))                          //Toggles between being in a value field and a key field
                {
                    inString = !inString;                       //To avoid editing values
                }
                if (cChar.Equals(':') && sFileString[i+1] != ' ' && !inString)   //Removes colon from the start of a key
                {
                    sFileString[i] = '"';                                       //Adds starting " to key name
                    removed = true;                                             //Indicates that the colon has been removed, and a " will be required at the end of the word
                    continue;
                }
                if (removed && cChar.Equals('}'))               //Corner case for adding " to the end of an entry
                {
                    sFileString.Insert(i, "\"");
                    i = i + 1;
                    removed = false;
                    continue;
                }
                if (removed && cChar.Equals(','))              //Corner case for adding " to the end of an entry
                {
                    sFileString.Insert(i, "\"");
                    i = i + 1;
                    removed = false;
                    continue;
                }
                if (removed && Char.IsWhiteSpace(cChar))        //Adds " to the end of the word
                {
                    sFileString.Insert(i, "\": ");
                    i = i + 2;
                    removed = false;
                    continue;
                }
                if (cChar.Equals('}'))                      //Adds a comma between array values
                {
                    if (i < sFileString.Length - 2 && sFileString[i+1] == ' ' && sFileString[i+2] == '{')
                    {
                        sFileString.Insert(i+1, ',');
                        i = i + 2;
                    }
                    continue;
                }

                }

            return sFileString.ToString();              //return string of JSON format
            
        }

        
             
    }
}
