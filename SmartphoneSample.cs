public class Camera{
    
    public void Click(){}
    
}

public class GPS{
    
    public void Navigate(){}
}

public class Phone{
    public void Hangup(){}
    public void Release(){}
    
}

public class SmartPhone{
    
    public void TakePicture(){}
    public void Hangup(){}
    public void Release(){}
    pubiic void Naviate(){}
}

public class Photographer{
    public void Capture(){
        Camera _camera=new Camera();
        _camera.Click();
    }
}

public class Traveller{
    public void Hike(){
        GPS _navigationDevice=new GPS();
        
    }
}

public class Person{
    public void Communicate(){
        Phone _phone=new Phone();
        _phone.Hangup();
        _phone.Release();
    }
}

//Expectation
public class Program{
    
    public static void Main(){
        Camera _camera=new Camera();
        GPS __gps=new GPS();
        Phone _phone=new  Phone();
        SmartPhone _smartPhone=new SmartPhone();//Smartphone Should Deleagte Calls to  Camera, Gps,Phone
       _smartPhone. TakePicture();
    _smartPhone.Hangup(){}
    _smartPhone.Release(){}
    _smartPhone.Naviate(){}
        
        //Substitute Camera with SmartPhone , GPS with SmartPhone , Phone With SamrtPhone
        PhotoGrapher _photoGrapher=new PhotoGrapher();
        _photoGrapher.Capture(_camera);
        _photoGrapher.Capture(_smartPhone);
        
        
    }
}

