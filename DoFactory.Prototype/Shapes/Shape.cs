using System;
using System.Diagnostics;

namespace DoFactory.Prototype.Shapes
{
    public abstract class Shape
    {

        private string _id;
        protected string _type;

        public abstract void Draw();

        public String getType() => _type;



        public String getId() => _id;


        public void setId(String id) => this._id = id;


        public object clone()
        {
            object clone = null;

            try
            {
                clone = this.MemberwiseClone();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
            return clone;
        }
    }
}
    
