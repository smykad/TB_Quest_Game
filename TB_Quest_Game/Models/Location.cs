namespace TB_Quest_Game.Models
{
    public class Location
    {
        #region Fields

        private int _id;
        private string _name;
        private string _message;

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        #endregion

    }
}
