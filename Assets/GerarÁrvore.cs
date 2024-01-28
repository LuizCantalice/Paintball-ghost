using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Ghost_move_blue;

public class GerarÁrvore : MonoBehaviour
{

    public GameObject GhostPrefabBlue;
    public GameObject GhostPrefabRed;
    public GameObject GhostPrefabGreen;
    public Transform BossPos;
    // Start is called before the first frame update
    void Start()
    {
        GameObject GhostBlue = Instantiate(GhostPrefabBlue, BossPos.position, BossPos.rotation);
        GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
