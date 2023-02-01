using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> scriptureContent = new List<string>()
        {
            "Alma", "7", "11", "12", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities."
        };

        Reference reference = new Reference();
        reference.SetText(scriptureContent[4]);
        string scriptureText = reference.GetText();
        
    }
}