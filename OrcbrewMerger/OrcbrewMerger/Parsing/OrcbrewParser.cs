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
            
            sFileString = new System.Text.StringBuilder(reader.ReadToEnd());
                            
            bool removed = false;
            bool inString = false;
            for (int i = 0; i < sFileString.Length; i++)
            {
                
                char cChar = sFileString[i];
                if (cChar.Equals('\\') && sFileString[i + 1] == 'n')
                {
                    sFileString.Remove(i, 2);
                }
                if (cChar.Equals('"'))
                {
                    inString = !inString;
                }
                if (cChar.Equals(':') && sFileString[i+1] != ' ' && !inString)
                {
                    sFileString[i] = '"';
                    removed = true;
                    continue;
                }
                if (removed && cChar.Equals('}'))
                {
                    sFileString.Insert(i, "\"");
                    i = i + 1;
                    removed = false;
                    continue;
                }
                if (removed && cChar.Equals(','))
                {
                    sFileString.Insert(i, "\"");
                    i = i + 1;
                    removed = false;
                    continue;
                }
                if (removed && Char.IsWhiteSpace(cChar))
                {
                    sFileString.Insert(i, "\": ");
                    i = i + 2;
                    removed = false;
                    continue;
                }
                if (cChar.Equals('}'))
                {
                    if (i < sFileString.Length - 2 && sFileString[i+1] == ' ' && sFileString[i+2] == '{')
                    {
                        sFileString.Insert(i+1, ',');
                        i = i + 2;
                    }
                    continue;
                }

                }

            return sFileString.toString();
            
        }

        
             
    }
}
