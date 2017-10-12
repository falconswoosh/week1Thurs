namespace ProjectC.Models
{
  public class Package {
    private int? _weight;
    private int? _baseWidth;
    private int? _height;


    public int?  GetWeight   (){return _weight;}
    public int?  GetHeight   (){return _height;}
    public int?  GetBaseWidth(){return _baseWidth;}
    public int?  GetBase     (){return _baseWidth*_baseWidth;}
    public int?  GetVol      (){return this.GetBase()*_height;}
    public int?  GetCost     ()
    {
      if (_weight != null && this.GetVol() != null) {return _weight*this.GetVol()/3;}
      else {return -1;}
    }
    public void SetWeight   (int arg){_weight=arg;return;}
    public void SetHeight   (int arg){_height=arg;return;}
    public void SetBaseWidth(int arg){_baseWidth=arg;return;}

  }
}
