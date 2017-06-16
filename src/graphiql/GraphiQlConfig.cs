﻿using System.Collections.Generic;
using System.Net;

namespace graphiql
{
    public class GraphiQlConfig
    {
        public string Path { get; private set; }

        public IDictionary<string, HttpStatusCode> BuildOptions()
        {
            return null;
        }

        public void SetPath(string path)
        {
            Path = path;
        }
    }
}