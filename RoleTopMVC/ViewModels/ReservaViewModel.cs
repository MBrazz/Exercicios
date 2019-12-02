using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class ReservaViewModel
    {
        public class ReservaViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;} 
        public string NomeCliente {get;set;} 

        public ReservaViewModel()
        {
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }

    }
}
    }
}