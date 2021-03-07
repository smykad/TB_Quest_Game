namespace TB_Quest_Game.Models
{
    public class Location
    {
        #region Fields

        private int _id;
        private string _name;

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

        #endregion

    }
}
