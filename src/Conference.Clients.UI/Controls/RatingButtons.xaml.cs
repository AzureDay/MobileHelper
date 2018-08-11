using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Conference.Clients.UI.Controls
{
    public partial class RatingButtons : ContentView
    {
        public RatingButtons()
        {
            InitializeComponent();
        }
        
        public static readonly BindableProperty RatingValueProperty = 
            BindableProperty.Create(nameof(Rating), typeof(int), typeof(RatingButtons), default(int), 
                BindingMode.TwoWay);

        public int Rating
        {
            get { return (int) GetValue(RatingValueProperty); }
            set { SetValue(RatingValueProperty, value); }
        }
        
        public static readonly BindableProperty TextProperty = 
            BindableProperty.Create(nameof(Text), typeof(string), typeof(RatingButtons), string.Empty);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        
        public static readonly BindableProperty GroupNameProperty = 
            BindableProperty.Create(nameof(GroupName), typeof(string), typeof(RatingButtons), string.Empty);

        public string GroupName
        {
            get
            {
                return (string)GetValue(GroupNameProperty);
            }
            set
            {
                SetValue(GroupNameProperty, value);
            }
        }
        
        protected string NameForGroup { get; set; }
        
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);            
            if (propertyName == TextProperty.PropertyName)
            {
                NameRating.Text = Device.RuntimePlatform == Device.iOS ? Text.ToUpperInvariant() : Text;
            }            
            if (propertyName == GroupNameProperty.PropertyName)
            {
                StarOne.GroupName = GroupName;
                StarTwo.GroupName = GroupName;
                StarThree.GroupName = GroupName;
                StarFour.GroupName = GroupName;
                StarFive.GroupName = GroupName;
            }
        }

        protected string One => Guid.NewGuid().ToString("N");
        
        private void RetingChanged_OnBindingContextChanged(object sender, EventArgs e)
        {
            if (StarFive.Rating > 0)
            {
                Rating = StarFive.Rating;
            }
        }

        protected override void OnChildRemoved(Element child)
        {
            base.OnChildRemoved(child);
            BehaviorsRemove();
        }

        void BehaviorsRemove()
        {
            var items = this.Behaviors.Count;
            for (int i = 0; i < items; i++)
            {
                this.Behaviors.RemoveAt(i);
            }
        }
    }
}
