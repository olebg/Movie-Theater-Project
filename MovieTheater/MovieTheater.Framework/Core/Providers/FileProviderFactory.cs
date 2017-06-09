﻿using System;
using MovieTheater.Framework.Core.Providers;
using MovieTheater.Framework.Core.Providers.Contracts;
using MovieTheater.Framework.Providers.Contracts;

namespace MovieTheater.Framework.Providers
{
    public class FileProviderFactory : IFileProviderFactory
    {
        private IReader reader;
        private IWriter writer;

        public FileProviderFactory(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
    
        public string CreateJsonReader()
        {
            var jsonReader = new JsonReader(reader, writer);
            string jsonString = jsonReader.Read();

            return jsonString;
        }

        public void CreateJsonParser(string jsonString)
        {
            var jsonParser = new JsonParser(jsonString);
            jsonParser.Parse();
        }

    }
}