using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recursive : MonoBehaviour
{
    public int recursetime = 5;
    public int spreadbranchamount = 2;

    private void Start()
    {
        recursetime -= 1;

        for (int i = 0; i < spreadbranchamount; i++)
        {
            if (recursetime > 0)
            {
                var copy = Instantiate(gameObject);
                var branch = copy.GetComponent<recursive>();
                branch.SendMessage("growbranches",i);
            }
        }
    }

}
