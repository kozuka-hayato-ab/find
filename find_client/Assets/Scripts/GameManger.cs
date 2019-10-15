using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private ElementController elementController;

    // Start is called before the first frame update
    private void Start()
    {
        elementController.InitElements();
    }
}
