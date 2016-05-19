using UnityEngine;
using System.Collections.Generic;

public class TestMem : Object
{
    int i = 0;
}
public class Test : MonoBehaviour
{

    public void Update()
    {
        TestMem _list = new TestMem();
        Debug.Log(_list);
        Debug.Log(Profiler.GetRuntimeMemorySize(new GameObject()));
    }
}
