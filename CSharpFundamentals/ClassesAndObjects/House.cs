class House
{//line 3 - 10 fields
    bool haveGarage; //default false
    short numberOfFloors;
    short numberOfRooms;
    public float Length(get; set;) // Length becomes a property
    public float Width(get; set;)
    public House()
    {
        
    }

    public House(short nof, short nor) //line 10 - 14 creating constructor
    {
          numberOfFloors = nof;
          numberOfRooms = nor;    
    }
    public House(short nof, short nor, float l, float w) //line 10 - 14 creating constructor
    {
          numberOfFloors = nof;
          numberOfRooms = nor;    
          Length = l;
          Width = w;
    }

    // float GetAreaOfChat() //VOID ecause the field has property i.e. get set
    //{
  //      return Length * Width
//    }
    public float GetAreaOfChat() => Length * Width;



}

