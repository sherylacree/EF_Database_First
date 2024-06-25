namespace EF_Database_First;

internal class Program {
    static void Main(string[] args) {

        var _context = new TqlprsdbContext();
        var newRequestLine1 = new Requestline {
            Id = 0, Quantity = 1, RequestId = 0, ProductId = 2
        };
        var newRequestline1 = new Requestline {
            Id = 0, Quantity = 1, RequestId = 3, ProductId = 2
        };

        var newRequestline2 = new Requestline {
            Id = 0, Quantity = 2, RequestId = 2, ProductId = 5
        };
       
       

    
    
        _context.SaveChanges();
     //       var deleteUser = _context.Users.Find(4);
    //    _context.Users.Remove(deleteUser!);
     //   _context.SaveChanges();
     //CONTINUE TO PLAY AROUND WITH ADDING DATA AND WRITE QUERRIES FOR JOINING AND OTHER QUERIES



        

    }
}
