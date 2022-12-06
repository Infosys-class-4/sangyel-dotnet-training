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

    void animalList()
    {
        string [] listOfAnimals = {"wolf","dog","cat","ant","whale","eagle","gorilla","bear","penguin","elephant","tiger","lion"};
        
    }
}
// Create list/array of animals using Animal class we wrote.
// Query that collection to find following:
// Get list of all domestic animals
// Get list of animals which has more than 4 legs