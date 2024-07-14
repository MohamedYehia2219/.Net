using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop_session1
{
    internal class Car
    {
        #region Attributes
        private int speed;
        private string model;
        private int id;
        #endregion

        // constructor overloading
        // Internal constructor chaining
        // this --> refers to the object
        // this --> call constructor of the object class
        // base --> call constructor of the [suber] class

        #region Constructors
        public Car(int speed, string model, int id) : this(speed, id)
        {
            Model = model;
        }
        public Car(int speed, int id) : this(id)
        {
            Speed = speed;
        }
        public Car(int id)
        {
            Id = id;
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        #endregion

        public override string ToString()
        {
            return $"id: {Id}  speed: {speed}  model: {model}";
        }
    }
}
