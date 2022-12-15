namespace LivingThings;
//Top-level statements - implicit Main() entry point
// Conditionals - branching
class Animal
{
    public Animal() //parameter constructor
    {

    }
// Parameterized constructor
    public Animal(string animalCategory, byte legs)
    {
        category = animalCategory;
        numberOfLegs = legs;
    }
    public Animal(string animalCategory, byte legs, string sn, bool d)
    {
        category = animalCategory;
        numberOfLegs = legs;
        domestic = d;
        scientificName = sn;
    }

    string category;
    string scientificName;
    byte numberOfLegs;
    bool domestic;

    