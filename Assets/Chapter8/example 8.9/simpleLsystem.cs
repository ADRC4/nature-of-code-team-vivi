using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleLsystem : MonoBehaviour

{//ssss
    private string axiom = "A";
    private string current;

    private Dictionary<char, string> rules = new Dictionary<char, string>();

    // Use this for initialization
    void Start()
    {
        rules.Add('A', "AB");
        rules.Add('B', "A");
        current = axiom;
        Sentence();
        Sentence();
        Sentence();
        Sentence();
        Sentence();
        Sentence();
        Sentence();
        Sentence();
        Sentence();
        Sentence();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Sentence()

    {
        string newstring = "";

        char[] stringcharacters = current.ToCharArray();

        for(int i = 0; i < stringcharacters.Length; i++)
        {
            char currentcharacter = stringcharacters[i];

            newstring += rules[currentcharacter];

        }

        current = newstring;

        Debug.Log(current);


    }


}
