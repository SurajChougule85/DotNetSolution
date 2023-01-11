namespace maths;

//creating class...
public class Complex{
    private int real;
    private int img;

    // creating default constructor...
    public  Complex(){
        this.real=0;
        this.img=0;
    }

//creating a para constuctor
    public  Complex(int real,int img){
        this.real=real;
        this.img=img;
    }

//get and set of a data member...
    public int Real{
        get{return this.real;}
        set{this.real=value;}
    }

    public int Img{
        get{return this.img;}
        set{this.img=value;}
    }

    //operater overloading(-)..
    public static Complex operator- (Complex c1,Complex c2){
        Complex number= new Complex();
        number.Real=c1.Real - c2.Real;
        number.Img=c1.Img - c2.Img;
        return number;

    }

}