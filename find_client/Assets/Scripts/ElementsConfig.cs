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

	#region Public Method

    /// <summary>
	/// elementにマークとカラーをセットする
	/// </summary>
	/// <param name="markNum">マークの番号</param>
	/// <param name="colorNum">カラーの番号</param>
    public void SetElement(int markNum, int colorNum)
	{
		setMark(markNum);
		setColor(colorNum);
	}

    public void Show()
	{
        
	}

	#endregion Public Method

	#region private Method

    /// <summary>
	/// マークをセット
	/// </summary>
	/// <param name="markNum"></param>
	private void setMark(int markNum)
	{
		switch ((GameDefine.MarkDefine)markNum)
		{
            case GameDefine.MarkDefine.MARU:
                elementText.text = "●";
                break;
            case GameDefine.MarkDefine.SANKAKU:
                elementText.text = "▲";
                break;
            case GameDefine.MarkDefine.SHIKAKU:
                elementText.text = "◾";
                break;

		}
	}

    /// <summary>
	/// カラーをセット
	/// </summary>
	/// <param name="colorNum"></param>
	private void setColor(int colorNum)
	{
		switch ((GameDefine.ColorDefine)colorNum)
		{
            case GameDefine.ColorDefine.RED:
                elementText.color = Color.red;
                break;
            case GameDefine.ColorDefine.BLUE:
                elementText.color = Color.blue;
                break;
            case GameDefine.ColorDefine.GREEN:
                elementText.color = Color.green;
                break;
        }
	}

	#endregion private Method
}
