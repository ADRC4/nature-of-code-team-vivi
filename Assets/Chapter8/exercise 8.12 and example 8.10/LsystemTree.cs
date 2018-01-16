using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LsystemTree : MonoBehaviour
{
    private string axiom = "F";
    private string current;
    private float angle;


    private Stack<TransformInfo> TransformStack = new Stack<TransformInfo>();
    private Dictionary<char, string> rules = new Dictionary<char, string>();

    private float length=0.08f;

    // Use this for initialization
    void Start()
    {
        rules.Add('F', "FF+[+F-F-F]-[-F+F+F]");
        current = axiom;
        angle = 25f;


        Maketree();
        Maketree();
        Maketree();
        Maketree();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Maketree()

    {
        string newstring = "";

        char[] stringcharacters = current.ToCharArray();

        for (int i = 0; i < stringcharacters.Length; i++)
        {
            char currentcharacter = stringcharacters[i];


            if (rules.ContainsKey(currentcharacter)) { newstring += rules[currentcharacter]; }
            else { newstring += currentcharacter.ToString(); }



        }

        current = newstring;

        Debug.Log(current);


        stringcharacters = current.ToCharArray();

        for (int i = 0; i < stringcharacters.Length; i++)
        {
            char currentcharacter = stringcharacters[i];

            if (currentcharacter == 'F')
            {
                //forwards

                Vector3 start = transform.position;
                transform.Translate(Vector3.up * length);

                Debug.DrawLine(start, transform.position, Color.black, 10000f, false);


            }

            else if (currentcharacter == '+')
            {
                transform.Rotate(Vector3.forward* angle*-1f);

            }

            else if (currentcharacter == '-')
            {
                transform.Rotate(Vector3.forward* -angle*-1f);

            }

            else if (currentcharacter == '[')
            {
                TransformInfo ti = new TransformInfo();
                ti.position = transform.position;
                ti.rotation = transform.rotation;
                TransformStack.Push(ti);
            }

            else if (currentcharacter == ']')
            {
                TransformInfo ti = TransformStack.Pop();
                transform.position = ti.position;
                transform.rotation = ti.rotation;

            }
        }





    }



}
