using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using XLua;

public class User
{
    public string Name;
    public int Age;
}


public class MainScript : MonoBehaviour
{
    [CSharpCallLua]
    public delegate int Add(int x,int b);

    byte[] netLua = null;

    void Start()
    {
        //StartCoroutine(LoadNetLua("http://hanxinyi.cn/NetLua.lua",(data)=>
        //{
        //    netLua = data;
        //    LuaEnv luaenv = new LuaEnv();
        //    luaenv.AddLoader(loadedLua);
        //    luaenv.DoString("require 'NetLua'");
        //    luaenv.Dispose();
        //}));

        // C#代码 访问基础变量
        //LuaEnv luaenv = new LuaEnv();
        //luaenv.DoString("require 'lua/test1'");
        //Debug.Log(luaenv.Global.Get<int>("var_int"));
        //Debug.Log(luaenv.Global.Get<string>("var_str"));
        //Debug.Log(luaenv.Global.Get<bool>("var_bool"));
        //luaenv.Dispose();

        // C#代码 访问table
        //LuaEnv luaenv = new LuaEnv();
        //luaenv.DoString("require 'lua/test1'");
        //Debug.Log(luaenv.Global.Get<User>("user1").Name);
        //Debug.Log(luaenv.Global.Get<User>("user1").Age);
        //luaenv.Dispose();

        // C#代码 访问function
        LuaEnv luaenv = new LuaEnv();
        luaenv.DoString("require 'lua/test1'");
        Add add = luaenv.Global.Get<Add>("LuaAdd");
        Debug.Log(add(1, 2));

        // C#代码 lua访问c#
        //LuaEnv luaenv = new LuaEnv();
        //luaenv.DoString("require 'lua/test1'");

        //GameObject.Find("Canvas/image_bg").GetComponent<Image>().sprite = Resources.Load("images/bg",typeof(Sprite)) as Sprite;

        ////创建一个对象
        //GameObject newGameObj = new GameObject();
        //newGameObj.name = "btn";
        //newGameObj.transform.SetParent(GameObject.Find("Canvas").transform);
        //newGameObj.transform.localPosition = new Vector3(0, 0, 0);
        //newGameObj.transform.localScale = new Vector3(1, 1, 1);

        ////添加Image组件
        //newGameObj.AddComponent<Image>();
        ////设置Image的图片
        //newGameObj.GetComponent<Image>().sprite = Resources.Load("images/bg", typeof(Sprite)) as Sprite;

        ////增加Button组件
        //newGameObj.AddComponent<Button>();
        //// 设置Button点击事件
        //newGameObj.GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    Debug.Log("Click");
        //});
    }

    //byte[] loadedLua(ref string luaName)
    //{
    //    if (luaName == "NetLua")
    //    {
    //        return netLua;
    //    }

    //    return null;
    //}

    //IEnumerator LoadNetLua(string lua_url,Action<byte[]> callBack)
    //{
    //    using (UnityWebRequest webRequest = UnityWebRequest.Get(lua_url))
    //    {
    //        yield return webRequest.SendWebRequest();
    //        callBack(webRequest.downloadHandler.data);
    //    }
    //}
}
