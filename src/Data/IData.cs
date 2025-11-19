namespace Workshop.Data;

public interface IData {
    bool AuthenticateUser(string username, string password);
}