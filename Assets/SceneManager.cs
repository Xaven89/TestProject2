using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;
public class SceneManager : MonoBehaviour
{

    [SerializeField]
    private NavMeshSurface surface;
    // Start is called before the first frame update
    void Start()
    {
        surface.BuildNavMesh();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
