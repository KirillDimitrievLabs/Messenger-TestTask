namespace Services
{
    public class DialogService
    {
        public Guid FindDialogByClients(IEnumerable<Guid> clients)
        {
            var result = clients.Select(TEST => TEST);
            return result.FirstOrDefault();
        }
    }
}