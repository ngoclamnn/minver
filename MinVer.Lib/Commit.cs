namespace MinVer.Lib
{
    using System.Collections.Generic;

    internal class Commit
    {
        public Commit(string sha) => this.Sha = sha;

        public string Sha { get; }

        public string ShortSha => this.Sha.Substring(0, 7);

        public List<Commit> Parents { get; } = new List<Commit>();
    }
}
