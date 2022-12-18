using GatesApp.Models;
using GatesApp.RaportItem;
using GatesApp.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatesApp.Raport
{
   public class ReportAllPasses
    {
        private GateRespository _gatesRepository = new GateRespository();
        private EmploeeysRespository _employeeRepository;
        private EventRespository _eventRepository;

        public ReportAllPasses(GateRespository gatesRepository, EmploeeysRespository employeeRepository, EventRespository eventRepository)
        {
            _gatesRepository = gatesRepository;
            _employeeRepository = employeeRepository;
            _eventRepository = eventRepository;
        }

        public List<Passes> GetAllPasses()
        {
            List<Employee> employees = _employeeRepository.GetEmployees();
            List<Passes> passList = new List<Passes>();


            foreach (var employee in employees)
            {
                var reportItemPasses = new Passes();
                int ammountSmokeBreaks = _eventRepository.SmokeAmmount();
                int ammountOfLunchBreaks = _eventRepository.LunchAmmount();
                int ammountOfToiletBreaks = _eventRepository.ToiletAmmount();

                reportItemPasses.AmmountOfSmokeBreaks = ammountSmokeBreaks;
                reportItemPasses.AmmountOfToiletBreaks = ammountOfToiletBreaks;
                reportItemPasses.AmmountOfLunchBreaks = ammountOfLunchBreaks;
                reportItemPasses.AmmountOfPasses = ammountOfLunchBreaks + ammountSmokeBreaks + ammountOfToiletBreaks ;

                reportItemPasses.Name = employee.Name;

                Gates gates = _gatesRepository.GetGates(employee.GateId);
                reportItemPasses.NameOfGates = gates.GateName;

                passList.Add(reportItemPasses);
            }
            return passList;
        }
    }
}
