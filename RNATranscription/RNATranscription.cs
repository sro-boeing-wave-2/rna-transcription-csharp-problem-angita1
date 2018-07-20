using System;
using System.Collections.Concurrent;
using System.Linq;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string rna = "";        
            foreach (char item in nucleotide)
            {
                switch (item)
                {
                    case 'G':
                        rna += 'C';
                        break;
                    case 'C':
                        rna += 'G';
                        break;
                    case 'T':
                        rna += 'A';
                        break;
                    case 'A':
                        rna += 'U';
                        break;
                    default:
                        break;
                }
            }
            return rna;
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
