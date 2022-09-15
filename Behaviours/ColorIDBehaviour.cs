using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idObj = colorIDDataListobj.currentColor;
    }
}
