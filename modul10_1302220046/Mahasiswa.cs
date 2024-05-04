namespace modul10_1302220046
{
    public class Mahasiswa
    {
        public String name { get; set; }
        public String nim {  get; set; }
        public List<String> course { get; set; }
        public int year { get; set; }

        public Mahasiswa (String name, String nim, int year, List<String> course)
        {
            this.name = name;
            this.nim = nim;
            this.year = year;
            this.course = course;
        }
    }
}
