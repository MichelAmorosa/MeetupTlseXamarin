using GandalfApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GandalfApp6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InitalizeMembersList();
        }
        
        private void InitalizeMembersList()
        {
            membersList.ItemsSource = new List<CommunityMember>
                    {
                        new CommunityMember { Name = "Frodon", Race = Race.Hobbit, EpicQuote =  "You are late !", HealthPoints = 16, MaxHealthPoints = 30 },
                        new CommunityMember { Name = "Boromir", Race = Race.Human, EpicQuote = "You carry the fate of us all, little one. If this is indeed the will of the Council, then Gondor will see it done", HealthPoints = 0, MaxHealthPoints = 50 },
                        new CommunityMember { Name = "Sam", Race = Race.Hobbit, EpicQuote = "There's some good in this world, Mr. Frodo, and it's worth fighting for.", HealthPoints = 30, MaxHealthPoints = 30 },
                        new CommunityMember { Name = "Legolas", Race = Race.Elf, EpicQuote = "A red sun rises, blood has been spilled this night.", HealthPoints = 250, MaxHealthPoints = 300 },
                        new CommunityMember { Name = "Gimli", Race = Race.Dwarf, EpicQuote = "Certainty of death, *small* chance of success... What are we waiting for ?", HealthPoints = 8, MaxHealthPoints = 40 },
                        new CommunityMember { Name = "Aragorn", Race = Race.Human, EpicQuote = "If by my life or death I can protect you, I will.", HealthPoints = 50, MaxHealthPoints = 50 }
                    };
        }

        private void membersList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var member = e.Item as CommunityMember;
            var speaker = DependencyService.Get<ITextToSpeech>();

            speaker.Speak(member.EpicQuote);
        }
    }
}
