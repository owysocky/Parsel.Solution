
namespace Parcel.Models
{
  public class Item
  {
    private int _width;
    private int _length;
    private int _height;
    private int _weight;

    public Item(int width, int height, int length, int weight)
    {
      _width = width;
      _length = length;
      _height = height;
      _weight = weight;
    }

    public int Volume()
    {
       return _width * _height * _length;
    }

    public int CostToShip()
    {
      return _weight/2;
    }

    public int GetWidth(){return _width;}
    public int GetLength(){return _length;}
    public int GetHeight(){return _height;}
    public int GetWeight(){return _weight;}

    public void SetWidth(int newWidth){ _width = newWidth;}
    public void SetLength(int newLength){ _length = newLength;}
    public void SetHeight(int newHeight){ _height = newHeight;}
    public void SetWeight(int newWeight){ _weight = newWeight;}
  }
}
