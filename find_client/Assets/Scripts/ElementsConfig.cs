using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementsConfig : MonoBehaviour
{
    #region SerializeField
    [SerializeField] private int index;

    [SerializeField] private Text elementText;
    public Text ElementText
    {
        get { return elementText; }
    }

    #endregion SerializeField

    private bool isOverwrite = true;
    public bool IsOverwrite
    {
        get { return isOverwrite; }
    }

    private int mark;
    public int Mark
    {
        get { return mark; }
    }

    private int color;
    public int Color
    {
        get { return color; }
    }

    #region Public Method

    /// <summary>
    /// elementにマークとカラーをセットする
    /// </summary>
    public void SetElement(int markNum, int colorNum)
    {
        mark = markNum;
        color = colorNum;
        setMark();
        setColor();
    }

    public void SetElement(int elementNum)
    {
        setElement(elementNum);
        setMark();
        setColor();
    }

    public void Show()
    {

    }

	#endregion Public Method

	#region private Method

    /// <summary>
	/// マークをセット
	/// </summary>
	private void setMark()
	{
		switch ((GameDefine.MarkDefine)mark)
		{
            case GameDefine.MarkDefine.MARU:
                elementText.text = "●";
                break;
            case GameDefine.MarkDefine.SANKAKU:
                elementText.text = "▲";
                break;
            case GameDefine.MarkDefine.SHIKAKU:
                elementText.text = "■";
                break;
            default:
                elementText.text = "※";
                Debug.LogError("mark is exception");
                break;
		}
	}

    /// <summary>
	/// カラーをセット
	/// </summary>
	private void setColor()
	{
		switch ((GameDefine.ColorDefine)color)
		{
            case GameDefine.ColorDefine.RED:
                elementText.color = UnityEngine.Color.red;
                break;
            case GameDefine.ColorDefine.BLUE:
                elementText.color = UnityEngine.Color.blue;
                break;
            case GameDefine.ColorDefine.GREEN:
                elementText.color = UnityEngine.Color.green;
                break;
            default:
                elementText.color = UnityEngine.Color.yellow;
                Debug.LogError("color is exception");
                break;
        }
	}


    private void setElement(int elementNum)
    {
        switch (elementNum)
        {
            case 0:
                mark = 0;
                color = 0;
                break;
            case 1:
                mark = 0;
                color = 1;
                break;
            case 2:
                mark = 0;
                color = 2;
                break;
            case 3:
                mark = 1;
                color = 0;
                break;
            case 4:
                mark = 1;
                color = 1;
                break;
            case 5:
                mark = 1;
                color = 2;
                break;
            case 6:
                mark = 2;
                color = 0;
                break;
            case 7:
                mark = 2;
                color = 1;
                break;
            case 8:
                mark = 2;
                color = 2;
                break;
        }
    }

	#endregion private Method
}
