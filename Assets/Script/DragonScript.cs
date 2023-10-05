using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Dragon is attacking player");
    }
}
