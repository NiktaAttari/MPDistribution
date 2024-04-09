using UnityEngine;
using UnityEngine.UI;
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

public class UMP_LevelInfo : MonoBehaviour {

    public Text Title;
    public Text Description;
    public Text PlayText;
    public Image Preview;
    [SerializeField] private GameObject LevelUI = null;
    [SerializeField] private GameObject LockUI = null;

    //Name of scene of build setting
    private string LevelName;
    private UMP_Manager Manager;
    private UMP_Manager.LevelInfo CacheInfo;
    /// <summary>
    /// Level Info
    /// </summary>
    public void GetInfo(UMP_Manager.LevelInfo uinfo)
    {
        Manager = FindObjectOfType<UMP_Manager>();
        CacheInfo = uinfo;
        Title.text =uinfo.Title;
        Description.text = uinfo.Description;
        Preview.sprite = uinfo.Preview;
        PlayText.text = Manager.PlayButtonName;
        LevelName = uinfo.LevelName;

        bool level = Manager.ShowMapLevel;
        if (level)
        {
            LevelUI.GetComponentInChildren<Text>().text = string.Format("LEVEL: {0}",uinfo.Level);
        }
        LevelUI.SetActive(level);
        LockUI.SetActive(uinfo.isLock);
    }
    /// <summary>
    /// 
    /// </summary>
    public void OpenLevel() { LoadLevel(LevelName); }

    public static void LoadLevel(string scene)
    {
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
 SceneManager.LoadScene(scene);
#else
        Application.LoadLevel(scene);
#endif
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Forward"></param>
    public void EventMouse(bool Forward = true)
    {
        if (CacheInfo.isLock) return;

        Animator a = this.GetComponent<Animator>();
        if (Forward)
        {
            a.SetBool("show", true);
        }
        else
        {
            a.SetBool("show", false);
        }
    }
}