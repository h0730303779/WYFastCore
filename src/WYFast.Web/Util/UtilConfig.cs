namespace WYFast.Web.Util
{
    public class UtilConfig
    {
        public static string GetValue(string Name)
        {
            return "测试";
        }

        public static User GetProvider()
        {
            return new User()
            {
                UserId = "113",
                UserName = "test"
            };
        }
    }
}
