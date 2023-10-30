using BussinenssObject;
using DAOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IStaffRepository
    {
        public void addStaff(staff p);

        public void deleteStaff(staff p);

        public staff getStaffbyId(int id);

        public List<staff> getStaffs();

        public void updateStaff(staff p);

        public bool CheckLoginforStaff(String email, String password); 
        public staff GetStaffByEmail(String email);

        public List<staff> SearchByType(string Status);
    }
}
