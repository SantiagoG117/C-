using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.Methods
{
    public class FieldsFundamentalsOnCustomer
    {
        //?Attributes
        private int Id;
        private string Name;
        /*
         * As a best practice, we should always initialize our Arraylists inside the class
         * 
         * We can create a new field with a readonly modifier to make sure that that field is only assigned once.
         * In this case the field has to initialize directly inside the class or through one of the constructors.
         *
         * readonly keyword provides safety and robustness in our application by making sure that a we only have one
         * list where we keep all our orders. If someone accidently tries to reinitialize this field in our another method.
         * The data that we have in our field won't be lost
         */
        private readonly List<Orders> orders = new List<Orders>();


        //?Constructor


    }
}