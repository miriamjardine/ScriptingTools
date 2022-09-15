using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
   public List<ColorID> colorIDDataList;

   public ColorID currentColor;

   private int num;

   public void SetCurrentColorRandom()
   {
      num = colorIDDataList.Count-1;
      currentColor = colorIDDataList[num];
   }
}
