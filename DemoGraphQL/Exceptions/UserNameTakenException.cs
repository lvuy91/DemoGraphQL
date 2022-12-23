namespace DemoGraphQL.Exceptions
{
    public class UserNameTakenException : Exception
    {
        //https://chillicream.com/docs/hotchocolate/v12/defining-a-schema/mutations
        public UserNameTakenException(string username)
            : base($"The username {username} is already taken.")
        {
        }

        public static MyCustomError CreateErrorFrom(UserNameTakenException ex)
        {
            return new MyCustomError(ex.Username);
        }

        public static MyCustomError CreateErrorFrom(OtherException ex)
        {
            return new MyCustomError(ex.Username);
        }

        public string Message { get; }
    }


    public class InvalidUserNameException : Exception
    {
        public InvalidUserNameException(string username)
            : base($"The username {username} is invalid.")
        {
        }
    }
}
