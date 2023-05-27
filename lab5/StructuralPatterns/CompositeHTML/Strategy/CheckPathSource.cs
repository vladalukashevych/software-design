namespace CompositeHTML.Strategy
{
    public class CheckPathSource
    {
        public static bool IsUrl(string path)
        {
            Uri uriResult;
            return Uri.TryCreate(path, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public static bool IsSystem(string path)
        {
            return Path.IsPathRooted(path);
        }
    }
}
