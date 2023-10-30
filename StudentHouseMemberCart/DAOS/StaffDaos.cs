using BussinenssObject;
using BussinenssObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOS
{
    public class StaffDaos
    {
            private static StaffDaos instance;
            private static object instanceLock = new object();
            private StaffDaos()
            {

            }
            public static StaffDaos Instance
            {
                get
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new StaffDaos();
                        }
                        return instance;
                    }
                }
            }
            public static List<staff> GetStaff()
            {

                List<staff> listStaff = new List<staff>();
                try
                {

                    using (var context = new StudentHouseMembershipContext()) //goi toi database
                    {
                        listStaff = context.staff.ToList();


                    }

                }
                catch (Exception e)
                {


                    throw new Exception(e.Message);


                }



                return listStaff;
            }
            public static staff getStaffbyId(int id)
            {
            staff getStaff = new staff();
                try
                {
                    using (var context = new StudentHouseMembershipContext())
                    {
                    getStaff = context.staff.SingleOrDefault(m => m.StaffId == id);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return getStaff;
            }
            public static void addStaff(staff staff)
            {
                try
                {

                    using (var context = new StudentHouseMembershipContext())
                    {

                        context.staff.Add(staff);
                        context.SaveChanges();

                    }

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
            public static void DeleteStaff(staff staff)
            {
                try
                {
                    using (var context = new StudentHouseMembershipContext())
                    {
                        var p1 = context.staff.SingleOrDefault(m => m.StaffId == staff.StaffId);
                        context.staff.Remove(p1);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);

                }


            }
            public static void UpdateStaff(staff staff)
            {
                try
                {
                    using (var context = new StudentHouseMembershipContext())
                    {
                        context.Entry<staff>(staff).State = EntityState.Modified; ;
                        context.SaveChanges();


                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + "Error");

                }


            }

            public static Boolean CheckLoginforStaff(String email, String password)
            {
                try
                {
                    using (var Context = new StudentHouseMembershipContext())
                    {
                        var temp = Context.staff.SingleOrDefault(p => p.Email == email
                        && p.Password == password);
                        if (temp != null)
                        { return true; }

                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + "");

                }




            }
            public static staff GetStaffByEmail(String email)
            {
            staff staff = new staff();
                try
                {
                    using (var context = new StudentHouseMembershipContext())
                    {
                    staff = context.staff.SingleOrDefault(m => m.Email == email);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return staff;
            }
        public static List<staff> getStaffAvailable (String Status)
        {
            List<staff> staffList = new List<staff>();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {

                        staffList = context.staff.Where(p => p.Status == Status).ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffList;
        }
    }
}
