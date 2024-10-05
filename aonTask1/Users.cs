namespace Exercise4
{
    internal class Users
    {
        internal readonly string? password;
        internal readonly string? username;
        private string v1;
        private string v2;
        private int v3;

        public Users(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}