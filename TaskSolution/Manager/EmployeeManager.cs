using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Xml.Serialization;
using TaskSolution.Models;


namespace TaskSolution.Manager
{


    public class EmployeeManager
    {
        private const int xmlIndex = 1;
        private const int jsonIndex = 2;
        private const int zeroIndex = 0;
        private const int fiveCount = 5;
        private const int threeCount = 3;

        public  List<Employee> listEmployee { get; set; }


        public EmployeeManager()
        {

            //Create some test data
            listEmployee = new List<Employee>();
            listEmployee.Add(new EmployeeFixedPayment(1,"A_Employee1",190));
            listEmployee.Add(new EmployeeFixedPayment(2, "B_Employee2", 200));
            listEmployee.Add(new EmployeeFixedPayment(3, "C_Employee3", 130));
            listEmployee.Add(new EmployeeFixedPayment(4, "D_Employee4", 190));
            listEmployee.Add(new EmployeeFixedPayment(5, "E_Employee5", 200));
            listEmployee.Add(new EmployeeFixedPayment(6, "F_Employee6", 130));
            listEmployee.Add(new EmployeeFixedPayment(7, "G_Employee7", 130));
            listEmployee.Add(new EmployeeFixedPayment(8, "H_Employee8", 130));
            listEmployee.Add(new EmployeeFixedPayment(9, "I_Employee9", 201.1));
            listEmployee.Add(new EmployeeFixedPayment(10, "J_Employee10", 190));
            listEmployee.Add(new EmployeeFixedPayment(11, "K_Employee11", 200));
            listEmployee.Add(new EmployeeFixedPayment(12, "L_Employee12", 130));
            listEmployee.Add(new EmployeeFixedPayment(13, "M_Employee13", 130));
            listEmployee.Add(new EmployeeFixedPayment(14, "N_Employee14", 130));
            listEmployee.Add(new EmployeeFixedPayment(15, "O_Employee15", 201.1));
            listEmployee.Add(new EmployeeFixedPayment(16, "P_Employee16", 135));
            listEmployee.Add(new EmployeeFixedPayment(17, "Q_Employee17", 138));
            listEmployee.Add(new EmployeeFixedPayment(18, "R_Employee18", 2.1));
            listEmployee.Add(new EmployeeHourlyPayment(19, "S_Employee19", 1.1));
            listEmployee.Add(new EmployeeHourlyPayment(20, "T_Employee20", 1.3));
            listEmployee.Add(new EmployeeHourlyPayment(21, "V_Employee21", 1.6));
            listEmployee.Add(new EmployeeHourlyPayment(22, "W_Employee22", 1.9));
            listEmployee.Add(new EmployeeHourlyPayment(23, "X_Employee23", 2.1));
            listEmployee.Add(new EmployeeHourlyPayment(24, "Y_Employee24", 2.0));
            listEmployee.Add(new EmployeeHourlyPayment(25, "Z_Employee25", 1.7));
        }

        //Other solution sort: implement interfase IComparable to class Emploeey
        public void SortListByDescending()
       {
            listEmployee = listEmployee.OrderBy(x => x.GetAverageSalary()).ThenByDescending(x => x.Name).Reverse().ToList();
       }

        public void SortListByAscending()
        {
            listEmployee = listEmployee.OrderBy(x => x.GetAverageSalary()).ThenBy(x => x.Name).ToList();
        }

        //Save json or xml file
        public void SaveFile()
        {
            
            var xmlSerializer = new XmlSerializer(typeof(List<Employee>));
            var jsonSerializer =  new DataContractJsonSerializer(typeof(List<Employee>));
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "xml file (*.xml)|*.xml|json file (*.json)|*.json";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(fileDialog.FileName))
                {

                    using (FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Create))
                    {
                        if (fileDialog.FilterIndex == xmlIndex)
                            xmlSerializer.Serialize(fileStream, listEmployee);
                        if (fileDialog.FilterIndex == jsonIndex)
                            jsonSerializer.WriteObject(fileStream, listEmployee);
                    }

                }
            }

            
        }

        //Read data from json or xml file
        public string OpenFile()
        {

            string message = "";
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Employee>));
                var jsonSerializer = new DataContractJsonSerializer(typeof(List<Employee>));
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "xml file (*.xml)|*.xml|json file(*.json)|*.json";
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(fileDialog.FileName))
                    {
                        using (FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Open))
                        {
                            if (fileDialog.FilterIndex == xmlIndex)
                                listEmployee = (List<Employee>)xmlSerializer.Deserialize(fileStream);
                            if (fileDialog.FilterIndex == jsonIndex)
                                listEmployee = (List<Employee>)jsonSerializer.ReadObject(fileStream);
                        }
                    }
                     
                    message = "Success open";
                }
                else
                    message = "";
                
            }
            catch
            {
                message = "Incorrect file";
            }

            return message;


        }

        public List<Employee> GetByName(string name)
        {
            return listEmployee.Where(x => x.Name == name).ToList();
        }

        public List<Employee> GetFirstFive()
        {

            return listEmployee.GetRange(zeroIndex, fiveCount);
        }


        public List<Employee> GetLastThree()
        {

            return listEmployee.GetRange(listEmployee.Count - threeCount, threeCount);
        }


    }
}
