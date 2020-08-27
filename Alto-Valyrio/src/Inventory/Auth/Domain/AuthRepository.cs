namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public interface IAuthRepository
    {
#nullable enable
        public AuthUser? Search(AuthUsername username);
#nullable disable
    }
}
