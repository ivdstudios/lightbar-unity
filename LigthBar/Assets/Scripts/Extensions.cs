using System;

public static class Extensions {

    /// <summary>
    /// 999999999 -> 999,999,999
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToFormat(this int value) {
        return String.Format("{0:n0}", value);
    }

}