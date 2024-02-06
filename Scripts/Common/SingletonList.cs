using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingletonList
{
    static List<System.Type> list = new List<System.Type>();

    public static void AddSingleton<T>()
    {
        System.Type systemType = typeof(T);

        if (list.Contains(systemType))
            return;

        list.Add(systemType);
    }

    public static void DeleteSingleton<T>()
    {
        System.Type systemType = typeof(T);
        list.Remove(systemType);
    }

    public static bool IsExist<T>()
    {
        System.Type systemType = typeof(T);
        return list.Contains(systemType);        
    }

    public static void Clear()
    {
        list.Clear();
    }
}
