namespace Workshop.Data;

public class DataInterface : IData {
    public bool AuthenticateUser(string username, string password) {
        return true;
    }
}