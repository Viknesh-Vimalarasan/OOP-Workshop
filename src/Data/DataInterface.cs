namespace Workshop.Data;

public class DataInterface : IData {
    
    bool IData.AuthenticateUser(string username, string password) {
        return true;
    }
}