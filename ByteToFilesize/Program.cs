using System;

namespace ByteToFilesize
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The size suffixes.
        /// </summary>
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            // file size in bytes
            var fileSize = SizeSuffix(1073741824);
            Console.WriteLine(fileSize);
        }

        /// <summary>
        /// Suffix (Gb,Mb,Kb suffix) of given bytes
        /// </summary>
        /// <param name="value">  size of file in bytes </param>
        /// <returns> suffix of file size </returns>
        private static string SizeSuffix(long value)
        {
            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1 << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }
    }
}
