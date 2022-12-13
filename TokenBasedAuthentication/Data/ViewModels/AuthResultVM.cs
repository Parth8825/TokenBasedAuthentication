namespace TokenBasedAuthentication.Data.ViewModels
{
    public class AuthResultVM
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime ExpireAct { get; set; }
    }
}
