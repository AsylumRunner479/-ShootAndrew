using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQuickSort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void QuickSort(int[] arr, int left, int right)
    {
        int pivot = Partition(arr,left,right);
        if (left < right)
        {
            
            if (pivot > 1)
            {
                QuickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(arr, pivot + 1, right);
            }
        }
    }
    private int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (left<right)
            {
                if (arr[left] == arr[right])
                {
                    return right;
                }
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}
