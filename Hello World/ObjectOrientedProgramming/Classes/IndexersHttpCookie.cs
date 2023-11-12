using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.Classes
{
    /// <summary>
    /// Indexers are a way to access elements in a class that has the semantic of Collections (List, dictionaries, etc...) like HttpCookie
    /// HttpCookie: Represents a file send from the browser to our web server upon each request. We use this file
    /// to identify a user.
    ///
    /// Indexers are defined in a similar way as a property. However, they don't have a name we must provide a parameter
    /// for the index
    /// 
    /// </summary>
    public class IndexersHttpCookie
    {
        //? Fields
        //* We store the key-value pairs of our HttpCookie in a generic Dictionary (Hashtable)
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        
        //? Properties
        //* Expiry date-time of the cookie
        public DateTime Expiry { get; set; }
        
        //?Indexers
        public string this[string key]
        {
            get => _dictionary[key];
            //* value is a key word which represents what is on the right side of the assignment operator
            set => _dictionary[key] = value;
        }
        
        

    }
}