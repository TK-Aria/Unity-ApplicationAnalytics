using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class CallbackUtility
{

    [Serializable]
    public class CallbackInfo
    {
        public string className;
        public string methodName;
        public int line;
    }

    /// <summary>
    /// Gets the callback info.
    /// </summary>
    /// <returns>The callback info.</returns>
    /// <param name="klass">only this.type </param>
    /// <param name="methodName"> only [ System.Reflection.MethodBase.GetCurrentMethod().Name) ] </param>
    public static CallbackInfo GetCallbackInfo(Type klass, string methodName)
    {

        int codeLine = new System.Diagnostics.StackFrame(0, true).GetFileLineNumber();

        var callbackInfo = new CallbackInfo()
        {

            className = klass.FullName,
            methodName = methodName,
            line = codeLine,
        };
        return callbackInfo;
    }

    /*
    public static void GetLine_2(
        [CallerLineNumber]int line = 0,
                             [CallerMemberName]string name ="",
                             [CallerFilePath]string path = "")
    {
        Console.WriteLine("行番号(2) = " + line);
        Console.WriteLine("名前(2) = " + name);
        Console.WriteLine("パス(2) = " + path);
    }
    */
	
}
