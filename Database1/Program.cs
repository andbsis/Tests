namespace Database1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // step 1. implement a data access layer to access a database
            // step 2. implement an asynchronous data access layer to access a database
            // if step 2 is done, step 1 is not necessary

            // suppose you have a Mysql database server running on localhost
            // and you have a user named "John" with password "Doe"
            // and you have a database named "testdb"
            // and you have a table named "users" with columns "id", "name", "email", "password"
            // and you have a table named "roles" with columns "id", "name", "description"
            // and you have a table named "user_roles" with columns "user_id", "role_id"

            // define a class to represent a organization of users with roles: Organization
            // Organization class should have properties: Id, Name, Description
            // Organization class should have a method to get the users of the organization
            // Organization class should have a method to get the roles of the organization
            // Organization class should have a method to get the users of the organization with the given role
            // Organization class should have a method to get the roles of the organization with the given user
            // Organization class should have a method to add a user to the organization
            // Organization class should have a method to remove a user from the organization
            // Organization class should have a method to add a role to the organization
            // Organization class should have a method to remove a role from the organization
            // Organization class should have a method to add a user to the role of the organization
            // Organization class should have a method to remove a user from the role of the organization

            // suggetsed implementation:
            // define a variable connection string
            // define a class to represent the database: Database
            // Database class should have a method to get a connection: static GetDbConnection()
            // define a class to represent the user: User
            // define a class to represent the role: Role
            // User class should have properties: Id, Name, Email, Password
            // Role class should have properties: Id, Name, Description
            // User class should have a method to get the roles of the user
            // Role class should have a method to get the users of the role

            // define a class UserRepository to access the table Users
            // define a class RoleRepository to access the table Roles
            // define a class UserRoleRepository to access the table UserRoles

            // UserRepository and RoleRepository should implement the interface IRepository<T>
            // IRepository should have methods to add, update, delete, get all users, get user by id:
            // int Add(T user);        return the id of the added item
            // T Update(T user);       return the updated item
            // int Delete(T user);     return the number of deleted items
            // List<T> GetAll();       return a list of items
            // T GetById(int id);      return the item with the given id

            // UserRoleRepository should implement the interface IRepository2<T1,T2>
            // IRepository2 should have methods to add, delete, get user_roles by id_user, get users_role by id_role:
            // bool Add(T1 user, T2 role);        return true if the record was added
            // bool Delete(T1 user, T2 role);     return true if the record was deleted
            // List<T1> GetByIdUser(int id_user);    return a list of users with the given role
            // List<T2> GetByIdRole(int id_role);    return a list of roles for the given user

            // a repository can be instantiated this way:
            // var userRepository = IRepository<User>(Database.GetDBConnection())
            // var roleRepository = IRepository<Role>(Database.GetDBConnection())
            // var userRoleRepository = IRepository<UserRole>(Database.GetDBConnection())

            // Let this HashCode work: Organization should persist data to database

            // var Organization = new Organization(1, "My silly organization", "We buy spam and sell eggs")
            //     .WithRoles(roleRepository.GetAll())
            //     .withUsers(userRepository.GetAll())
            //     .WithUsersRoles(userRoleRepository());
            // Organization.AddUser("Who").AddRole("Admin");
            // Organization.AddRole("User").AddRole("Dodo");
            // Organization.AddUser("What");
            // Organization.GetUser("Who").AddRole("User").RemoveRole("Admin");
            // Organization.RemoveRole("User"); // this should throw an exception
            // Organization.GetUser("Who").Rename("Alice");
        }
    }
}