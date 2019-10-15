using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ElementController : MonoBehaviour
{
    #region SerializeField

    [SerializeField] private List<ElementsConfig> elements;

    #endregion SerializeField

    private List<int> marks;
    private List<int> colors;

    #region Public Method

    /// <summary>
    /// elementの初期化
    /// </summary>
    public void InitElements(int repetitionNum)
    {
        marks = new List<int>();
        colors = new List<int>();
        repetitionArray(repetitionNum);
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i].SetElement(marks[i], colors[i]);
        }
        ClearElementsConfig();
    }

    public void ClearElementsConfig()
    {
        marks.Clear();
        colors.Clear();
    }


    #endregion Public Method

    /// <summary>
    /// 任意個数のペアを許容した配列の作成
    /// </summary>
    /// <param name="repetitionNum"></param>
    private void repetitionArray(int repetitionNum)
    {
        // 重複個数が半分以上であれば例外
        if (repetitionNum >= (int)(elements.Count / 2))
        {
            Debug.LogError("repetitionNum is over");
            return;
        }

        // 重複のないリストを作成
        for (int i = 0; i < elements.Count; i++)
        {
            int _mark = UnityEngine.Random.Range(0, Enum.GetNames(typeof(GameDefine.MarkDefine)).Length);
            int _color = UnityEngine.Random.Range(0, Enum.GetNames(typeof(GameDefine.ColorDefine)).Length);
            while (marks.Contains(_mark) && colors.Contains(_color))
            {
                _mark = UnityEngine.Random.Range(0, Enum.GetNames(typeof(GameDefine.MarkDefine)).Length);
                _color = UnityEngine.Random.Range(0, Enum.GetNames(typeof(GameDefine.ColorDefine)).Length);
            }
            marks.Add(_mark);
            colors.Add(_color);
        }

    }

}
