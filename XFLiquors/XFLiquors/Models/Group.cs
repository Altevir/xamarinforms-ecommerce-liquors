using XFLiquors.ViewModel;

namespace XFLiquors.Models
{
    public class Group : BaseViewModel
    {
        public int groupId { get; set; }
        public string description { get; set; }

        private string _backGroundColor;
        public string backGroundColor
        {
            get { return _backGroundColor; }
            set { SetProperty(ref _backGroundColor, value); }
        }

        private string _textColor;
        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }

        private bool _selected;
        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
