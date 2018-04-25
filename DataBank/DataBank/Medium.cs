namespace DataBank
{
    public class Medium
    {
        public int id { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string title3 { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", id, title1, title2, title3);
        }
    }


}