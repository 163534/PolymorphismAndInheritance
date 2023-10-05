using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Orc is attacking player");
    }
}
