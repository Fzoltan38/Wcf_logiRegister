using System.Windows.Forms;
using Wcf_LoginRegistration.Queries;

namespace Wcf_LoginRegistration
{
    public class Service1 : IService1
    {
        public string addUser(User user)
        {
            Create c = new Create();
            if (c.addUser(user) > 0)
                return "Felhasználó hozzáadva!";
            else
                return "Hiba a beszúrás közben!";

        }

        public string delUser(string id)
        {
            Delete d = new Delete();
            if (d.delUser(id)>0)
                return "Felhasználó törölve!";
            else
                return "Hiba a törlés közben!";
        }

        public bool loginCheck(User user)
        {
            Read r = new Read();
            return r.authentication(user.uname, user.pwd);
            
        }

        public string modUser(User user)
        {
            Update u = new Update(); 
            if (u.modifyUser(user) > 0)
                return "Felhasználó módosítva!";
            else
                return "Hiba a módosítás közben!";
        }
    }
}
