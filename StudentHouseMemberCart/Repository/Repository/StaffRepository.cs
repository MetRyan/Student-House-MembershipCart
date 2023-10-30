using BussinenssObject;
using DAOS;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class StaffRepository :IStaffRepository
    {
        public void addStaff(staff p) => StaffDaos.addStaff(p);

        public void deleteStaff(staff p) => StaffDaos.DeleteStaff(p);

        public staff getStaffbyId(int id) => StaffDaos.getStaffbyId(id);

        public List<staff> getStaffs() => StaffDaos.GetStaff();

        public void updateStaff(staff p) => StaffDaos.UpdateStaff(p);

        public bool CheckLoginforStaff(String email, String password) => StaffDaos.CheckLoginforStaff(email, password); 
        public staff GetStaffByEmail(String email)  => StaffDaos.GetStaffByEmail(email);

        public List<staff> SearchByType(string Status) => StaffDaos.getStaffAvailable(Status)


    }
}
