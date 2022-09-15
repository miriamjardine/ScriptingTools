using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idObj = colorIDDataListobj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
