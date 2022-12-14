using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class CSVWriter
    {
        public CSVWriter(Form1 form)
        {
            form.OnChargingStarted += InitiateWriter;
        }

        private void InitiateWriter()
        {
            string filename = @"C:\Users\cokereke\Git Repository\Cohort4\EventDemo\Test.csv";
            string[][] dGV = new string[][]
            {
                new string[] { "S/N", "Name", "Matric No"},
                new string[] { "1", "Bola", "90123" },
                new string[] { "2", "Eunice", "00153" },
                new string[] { "3", "Feyi", "72637" },
                new string[] { "4", "Tunde", "02838" },
                new string[] { "5", "Fawas", "00012" },
                new string[] { "6", "Gbemi", "91724" },
                new string[] { "7", "Tola", "09835" },
                new string[] { "8", "Sina", "19263" }
            };

            ToCsV(dGV, filename);
        }

        private void ToCsV(string[][] dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV[0].Length; j++)
                sHeaders += "\"" + dGV[0][j] + "\",";
            stOutput += sHeaders + "\n";
            // Export data.
            for (int i = 1; i < dGV.Length; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV[i].Length; j++)
                {
                    if (j == 2)
                    {
                        stLine += "=\"" + dGV[i][j] + "\",";
                    }
                    else
                    {
                        stLine += "\"" + dGV[i][j] + "\",";
                    }
                }
                
                stOutput += stLine + "\n";
            }
            byte[] output = Encoding.UTF8.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}
