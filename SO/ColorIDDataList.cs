
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
   public List<ColorID> colorIDDataList;

   public ColorID currentColor;

   private int num;

   public void Awake()
   {
      SetCurrentColorRandom();
   }

   public void SetCurrentColorRandom()
   {
      num = Random.Range(0, colorIDDataList.Count - 1);
      currentColor = colorIDDataList[num];
   }
}
