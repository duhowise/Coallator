namespace Coallator {
    public static class PrettierConsole {
        public static string PrettierPrint(this string content, int width = 20, char replace = ' ') {
            var sub = content.Length < width ? content : $"{content.Substring (0, (width - 3))}...";
            return sub.PadRight(width, replace);
        }
    }
}