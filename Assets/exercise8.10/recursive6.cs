using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recursive6 : MonoBehaviour {

    public int recursetime = 5;
    int spreadbranchamount;
    public Vector3 pivotposition;

    private void Start()
    {
        spreadbranchamount = 2;
        recursetime -= 1;

        for (int i = 0; i < spreadbranchamount; i++)
        {
            if (recursetime > 0)
            {
                var copy = Instantiate(gameObject);
                var branch = copy.GetComponent<recursive6>();
                branch.SendMessage("growbranches6", new RecursiveBundle2() { Index = i, Parents = this });
            }
        }
    }
}
