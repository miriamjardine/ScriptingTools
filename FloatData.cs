using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
  public UnityEvent onZeroEvent;
  public float value;

  public void UpdateValue(float num)
  {
    value += num;
  }

  public void ReplaceValue(float num)
  {
    value = num;
  }

  public void DisplayImage(Image img)
  {
    if (value <= 0)
    {
      onZeroEvent.Invoke();
    }
    else if (value >= 1)
    {
      value = 1;
    }

    img.fillAmount = value;
  }

  public void DisplayNumber(Text txt)
  {
    txt.text = value.ToString();
  }
}
