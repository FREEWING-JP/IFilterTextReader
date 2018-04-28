using System;


/*
*/

namespace IFilterTextReader
{
    /// <summary>
    /// UtilDotNet35 .Net 4.x compat.
    /// </summary>
    public class UtilDotNet35
    {
        // https://msdn.microsoft.com/ja-jp/library/system.string.isnullorwhitespace(v=vs.110).aspx
        // https://referencesource.microsoft.com/#mscorlib/System/string.cs
        /// <summary>
        /// string_IsNullOrWhiteSpace
        /// </summary>
        public static bool string_IsNullOrWhiteSpace(String value)
        {
            if (value == null) return true;

            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsWhiteSpace(value[i])) return false;
            }

            return true;
        }


        // https://msdn.microsoft.com/ja-jp/library/system.environment.is64bitprocess(v=vs.110).aspx
        // https://referencesource.microsoft.com/#mscorlib/System/environment.cs
        /// <summary>
        /// Environment_Is64BitProcess
        /// </summary>
        public static bool Environment_Is64BitProcess
        {
            get
            {
/*
#if WIN32
                return false; 
#else
                return true;
#endif
*/
                return (IntPtr.Size == 8);
            }
        }
    }
}
