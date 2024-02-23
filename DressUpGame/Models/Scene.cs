namespace DressUpGame.Models
{
    public class Scene
    {
        public int Id { get; set; }
       
        public string? BackgroundImgURL { get; set; }

        public List<Character> characters { get; set; }

        public string? Dialog {  get; set; }


        public Scene(string bgImgURL, List<Character> characters, string dialog) 
        {
            BackgroundImgURL = bgImgURL;
			Character = characters;
            Dialog = dialog;
        }
    }
}
