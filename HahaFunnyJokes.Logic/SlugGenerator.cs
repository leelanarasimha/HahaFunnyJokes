namespace HahaFunnyJokes.Logic
{
    public static class SlugGenerator
    {
        public static string makeSlug(string name)
        {
            var generated = name.Replace(" ", "-");
            return generated;
        }
    }
}