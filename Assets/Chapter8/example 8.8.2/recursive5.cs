using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recursive5 : MonoBehaviour
{

    public int recursetime = 5;
    int spreadbranchamount;

    private void Start()
    {
        spreadbranchamount = Random.Range(1, 4);
        recursetime -= 1;

        for (int i = 0; i < spreadbranchamount; i++)
        {
            if (recursetime > 0)
            {
                var copy = Instantiate(gameObject);
                var branch = copy.GetComponent<recursive5>();
                branch.SendMessage("growbranches5", i);
            }
        }
    }
}
