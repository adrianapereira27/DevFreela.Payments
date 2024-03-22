namespace DevFreela.Payments.API.Models
{
    public class PaymentApprovedIntegrationEvent
    {
        public PaymentApprovedIntegrationEvent(int idProjeto)
        {
            IdProjeto = idProjeto;
        }

        public int IdProjeto { get; set;}
    }
}
