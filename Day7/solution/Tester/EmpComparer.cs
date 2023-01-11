namespace CDACcollection;

class EmpComparer:IComparer<Employee>{
    public int Compare(Employee e1,Employee e2){
        //return 1,-1,0
      //  e1.name?.Length.CompareTo(e2.name?.Length);
      if(e1.id>e2.id){
        return 1;
      }
      if (e1.id<e2.id){
        return -1;
     }

     else
     return 0;
        
    }
    
}