using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StringListCreator
{
    internal class Program
    {
        public static void SingleStringMethod(string stp)
        {
            string stringOutcome;
            string finalString = "";
            List<string> stringToList = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(stp);
            stringBuilder.Replace(System.Environment.NewLine, " ");
            stringOutcome = stringBuilder.ToString();
            string[] splitStrings = stringOutcome.Split(' ');
            foreach (string str in splitStrings)
            {
                finalString += "\"" + str + "\", ";
            }
            finalString += "\"";
            Console.WriteLine(finalString);
            File.WriteAllText("WriteText.txt", finalString);
        }
        public static void ListStringMethod(string stp)
        {
            List<string> list = new List<string>();
            string stringOutcome;
            string finalString = "";
            List<string> stringToList = new List<string>();
            string addToList  = "";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(stp);
            for(int i = 0; i < stringBuilder.Length;)
            {
                if (Char.IsLetter(stringBuilder[i]))
                {
                    addToList += stringBuilder[i];
                    i++;
                }
                else
                {
                    list.Add(addToList);
                    addToList = "";
                    stringBuilder.Remove(0, i);
                    i = 0;
                    foreach (char c in stringBuilder.ToString())
                    {
                        if(!Char.IsLetter(c))
                        {
                            stringBuilder.Remove(0, 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            //stringBuilder.Replace(System.Environment.NewLine, "");
            //stringOutcome = stringBuilder.ToString();
            
            foreach (string str in list)
            {
                finalString += "\"" + str + "\", ";
            }
            finalString += "\"";
            Console.WriteLine(finalString);
            File.WriteAllText("WriteText.txt", finalString);
        }
        static void Main(string[] args)
        {
            //Replace this with the string you wish to process.
            string stringToProcess = "accelerated accomplished Achieved\r\nAcquired activated adapted\r\nAdjusted administered advised\r\nAllocated analyzed annotated\r\nanticipated applied appraised\r\nArranged articulated assembled\r\nAssessed assigned attained\r\nAuthored balanced briefed\r\nBudgeted calculated catalogued\r\ncategorized chaired changed\r\nChanneled charted clarified\r\nCoached coded collaborated\r\nCollected communicated compared\r\nCompeted compiled completed\r\nComposed computed conceived\r\nConducted confronted consolidated\r\nconstructed contacted continued\r\nContracted convened coordinated\r\ncorresponded counseled created\r\nCritiqued defined delegated\r\nDelivered demonstrated derived\r\nDesigned detected determined\r\nDeveloped devised diagnosed\r\nDirected discovered dispensed\r\nDisplayed distributed drafted\r\ndramatized earned edited\r\nEducated effected elicited\r\nEmployed encouraged endured\r\nEnlisted entertained established\r\nEstimated evaluated examined\r\nExchanged executed exercised\r\nExhibited expanded expedited\r\nexperimented explained explored\r\nFacilitated financed focused\r\nForecasted formulated fostered\r\nGrouped guided identified\r\nIllustrated implemented imposed\r\nImproved increased influenced\r\nInformed initiated inquired\r\nInspected installed instilled\r\nInstituted instructed insured\r\ninterpreted intervened interviewed\r\nintroduced invented inventoried\r\ninvestigated judged lectured\r\nListened located maintained\r\nManaged marketed mastered\r\nMeasured mediated modeled\r\nModified molded monitored\r\nMotivated negotiated observed\r\nObtained operated organized\r\nOutlined oversaw participated\r\nPerceived performed persuaded\r\nPlanned predicted prepared\r\nPrescribed presented presided\r\nProcessed produced programmed\r\nPromoted protected provided\r\nPublicized published purchased\r\nquestioned recommended recorded\r\nRecruited reduced regulated\r\nReinforced rendered repaired\r\nReported represented reproduced\r\nResearched resolved responded\r\nRestored retained retrieved\r\nReviewed revised rewrote\r\nRouted scheduled searched\r\nSelected served serviced\r\nShaped shared simplified\r\nSolicited solved sought\r\nSpecified stimulated studied\r\nSucceeded suggested summarized\r\nsupervised supported surveyed\r\nsynthesized systematized targeted\r\nTaught tested trained\r\nTranslated tutored updated\r\nUtilized verified visualized\r\nWrote";

            ListStringMethod(stringToProcess);
        }
    }
}
