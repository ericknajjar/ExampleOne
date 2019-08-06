using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Update()
    {

        var toAddNext = new List<int>();
        var heap = new C5.IntervalHeap<int>();

        for (int i = 0; i < 1000; ++i)
        {
            int val = UnityEngine.Random.Range(0, 20000);
            int valNext = UnityEngine.Random.Range(0, 20000);
            toAddNext.Add(valNext);
            heap.Add(val);
        }

        int max = ReturnMax(heap, toAddNext);

        Debug.LogFormat("Max {0} ", max);
    }

    public int ReturnMax(C5.IntervalHeap<int> heap, List<int> next)
    {
        // 1 - Adiciona o novo elemento a coleção
        // 2 - Remove o Maior element da coleção
        // 3 - Retorna o maior elemento presente na coleção ao final
        for (int i = 0; i < next.Count; ++i)
        {
            var toAdd = next[i];
            heap.Add(toAdd);
            heap.DeleteMax();
        }

        return heap.FindMax();
    }

}
