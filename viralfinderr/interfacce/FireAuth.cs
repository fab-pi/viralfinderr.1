using System;
using System.Threading.Tasks;

namespace viralfinderr.interfacce
{
    public interface FireAuth
    {
        Task<string> LoginWithEmailPassword(string email, string password);

        Task<string> RegisterWithEmailPassword(string email, string password);
    }
}
