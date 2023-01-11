namespace MemberShip;

public static class AuthManager{

    public static bool validation (string email,string password){
        bool flag=false;
        if("surajchougule@123"==email && password=="suraj"){
            flag=true;
        }
        return flag;
         }


     public static bool register(int id,string firstName,string lastName,string email,string contactNumber,string location){
        bool flag=false;
        try{
            User newUser= new User();
        newUser.Id=id;
        newUser.FirstName=firstName;
        newUser.LastName=lastName;
        newUser.Email=email;
        newUser.ContactNumber=contactNumber;
        newUser.Location=location;
        flag=true;
     }
     catch(Exception e){}

        return flag;
     }
     
}