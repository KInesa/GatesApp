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
    public class ReportWorkHours
    {
        private EventRespository _eventRepository = new EventRespository();
        private EmploeeysRespository _employeeRepository;
        private GateRespository _gatesRepository;

        public ReportWorkHours(EventRespository eventRepository, EmploeeysRespository employeeRepository, GateRespository gatesRepository)
        {
            _eventRepository = eventRepository;
            _employeeRepository = employeeRepository;
            _gatesRepository = gatesRepository;
        }

        public List<WorkingHours> GetAllWorkHours()
        {
            var reportAllPasses = new ReportAllPasses(_gatesRepository, _employeeRepository, _eventRepository);

            List<Employee> employees = _employeeRepository.GetEmployees();
            List<WorkingHours> workHours = new List<WorkingHours>();


            foreach (var employee in employees)
            {
                var reportItemWorkHours = new WorkingHours();

                TimeSpan lunchTime = _eventRepository.GetEventTime(1, _eventRepository.GetEvents()) * _eventRepository.LunchAmmount();
                TimeSpan smokeTime = _eventRepository.GetEventTime(2, _eventRepository.GetEvents()) * _eventRepository.SmokeAmmount();
                TimeSpan toiletTime = _eventRepository.GetEventTime(3, _eventRepository.GetEvents()) * _eventRepository.ToiletAmmount();

                TimeSpan workTime = new TimeSpan(9, 0, 0) - lunchTime - smokeTime - toiletTime;
                reportItemWorkHours.Name = employee.Name;
                reportItemWorkHours.WorkTime = workTime;
                reportItemWorkHours.TimeSpentLunch = lunchTime;
                reportItemWorkHours.TimeSpentSmoking = smokeTime;
                reportItemWorkHours.TimeSpentToilet = toiletTime;
                workHours.Add(reportItemWorkHours);
            }
            return workHours;
        }
    }
}