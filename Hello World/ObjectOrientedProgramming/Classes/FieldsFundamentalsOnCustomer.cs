using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming.Classes
{
    public class FieldsFundamentalsOnCustomer
    {
        //?Attributes
        private int Id;
        private string Name;
        /*
         * As a best practice, we should always initialize our Arraylists inside the class
         * 
         * We can create a new field with a readonly modifier to make sure that field is only assigned once.
         * In this case the field has to be initialized directly inside the class or through one of the constructors.
         *
         * readonly keyword provides safety and robustness in our application by making sure that a we only have one
         * list where we keep all our orders. If someone accidentally tries to reinitialize this field in another method.
         * The data that we have in our field won't be lost.
         */
        private readonly List<Orders> orders = new List<Orders>();


        //?Constructors
        public FieldsFundamentalsOnCustomer(int id)
        {
            Id = id;
        }

        public FieldsFundamentalsOnCustomer(int id, string name)
            //*Chain constructor: We delegate the control of the initialization of the id field to the constructor above
            : this(id)
        {
            this.Name = name;
        }
        
        //? Public methods
        public void Promote()
        {
            //! If we try to reinitialize the orders list we will get a compile error:
            //! orders = new List<Orders>();
        }
        
        
    }
}