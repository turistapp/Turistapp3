using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using TuristAppVersion3.Annotations;
using TuristAppVersion3.Common;
using TuristAppVersion3.Model;

namespace TuristAppVersion3.ViewModel 
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string ipsum1 =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sit amet dapibus risus, non feugiat libero. Vestibulum sodales posuere efficitur. Quisque dignissim varius est, id lacinia nulla mollis eget. Quisque aliquam augue eu faucibus maximus. Integer dapibus urna hendrerit ligula iaculis, sit amet pellentesque urna consectetur. Aliquam tristique erat sit amet eros volutpat sagittis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam eget purus maximus, euismod dolor eu, vulputate purus. Nulla in finibus sem. Morbi vitae sapien condimentum, consectetur turpis eget, fringilla nulla. Mauris tortor massa, sagittis a lorem ac, maximus volutpat eros. In orci tortor, laoreet eget maximus eu, congue ut libero. Sed volutpat odio nec elit viverra, eu venenatis ex ultricies. Class aptent taciti sociosqu ad litora torquent per. conubia nostra, per inceptos himenaeos. Morbi blandit ex eget vehicula convallis. Quisque vestibulum sapien diam, eget porttitor quam rutrum sed. Suspendisse potenti. Nullam vitae massa eu purus mattis accumsan.";

        private string ipsum2 =
            "alami spare ribs porchetta, meatloaf frankfurter cow short loin landjaeger venison chicken beef. Shoulder doner corned beef drumstick pork chop beef ribs meatball swine. Turkey strip steak pastrami boudin, swine tenderloin ground round biltong meatloaf porchetta. Swine frankfurter kielbasa short loin, shank corned beef fatback turducken jowl sirloin jerky sausage hamburger boudin. Chicken sausage frankfurter, hamburger swine salami tongue ground round turkey tail corned beef ham hock meatloaf short loin sirloin. Prosciutto tongue short loin boudin sausage turkey. Shoulder ham tenderloin shank rump pancetta, landjaeger jerky prosciutto pig beef pastrami. Bacon ipsum dolor amet ham beef boudin, shoulder cow jerky filet mignon drumstick pork shankle frankfurter venison. Drumstick meatball sirloin chuck, hamburger landjaeger. corned beef doner turkey turducken tail leberkas pig. Beef ribs doner short loin swine meatball filet mignon bacon capicola spare ribs biltong. Chuck pastrami drumstick porchetta. Beef ribs pork chop porchetta salami venison.";

        private string ipsum3 =
            "Donec hizzle auctizzle maurizzle. Phasellus rizzle elit ut nibh check out this ghetto. Fizzle a hizzle. Vestibulizzle break it down shizznit shizzle my nizzle crocodizzle mauris elementum tristique. Check it out izzle tortor tellivizzle gangsta eros ultricizzle funky fresh. Nizzle velit tortizzle, ultricies mofo, hendrerizzle quis, adipiscing quizzle, own yo'. Etizzle away mammasay mammasa mamma oo sa, aliquizzle consequizzle, pharetra non, away fo shizzle, turpizzle. Cool shizzle my nizzle crocodizzle. Cras lorem. vitae erat ut libero commodo yo. Fusce ac augue eu nibh fo shizzle my nizzle mattizzle. Black shizznit crackalackin gizzle erat. Suspendisse lorem leo, bizzle sheezy, funky fresh izzle, gangster nizzle, i saw beyonces tizzles and my pizzle went crizzle. Fizzle fo shizzle fo shizzle ligula. fo shizzle, tellizzle dawg ornare tempizzle, boom shackalack metus. tincidunt tellivizzle, bizzle phat pede shut the shizzle up izzle i saw beyonces tizzles and my pizzle went crizzle. Phasellizzle quizzle leo, imperdiet id, check it out ut.";

        private string ipsum4 =
            "Zombie ipsum brains reversus ab cerebellum viral inferno, brein nam rick mend grimes malum cerveau cerebro. De carne cerebro lumbering animata cervello corpora quaeritis. Summus thalamus brains sit​​, morbo basal ganglia vel maleficia? De braaaiiiins apocalypsi gorger omero prefrontal cortex undead survivor fornix dictum mauris. Hi brains mindless mortuis limbic cortex soulless creaturas optic nerve, imo evil braaiinns stalking monstra hypothalamus adventus resi hippocampus dentevil vultus brain comedat cerebella pitiutary gland viventium. Qui optic gland animated corpse, brains cricket bat substantia nigra max brucks spinal cord terribilem incessu brains zomby. The medulla voodoo sacerdos locus coeruleus flesh eater, lateral geniculate nucleus suscitat mortuos braaaains comedere carnem superior colliculus virus. Zonbi. cerebellum tattered for brein solum oculi cerveau eorum defunctis cerebro go lum cerebro. Nescio brains an Undead cervello zombies. Sicut thalamus malus putrid brains voodoo horror. Nigh basal ganglia tofth eliv ingdead.";

        private static ObservableCollection<User> _users = new ObservableCollection<User>() ;

        private static UserInputHandler _opretUserHandler  = new UserInputHandler(_users);

        private RelayCommand_homemade _opretUserCommand;

        private static User _selectedUser;

        public Koncerter _1 { get; set; }
        public Koncerter _2 { get; set; }
        public Koncerter _3 { get; set; }
        public Koncerter _4 { get; set; }

        public  static Koncerter SelectedKoncerter { get; set; }

        
        
        public override string ToString()
        {
            return string.Format("_1: {0}, _3: {1}, _2: {2}, _4: {3}", _1, _3, _2, _4);
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }



       public static UserInputHandler OpretUserHandler
        {
            get { return _opretUserHandler; }
            set { _opretUserHandler = value; }
        }


        public RelayCommand_homemade OpretUserCommand
        {
            get { return _opretUserCommand; }
            set { _opretUserCommand = value; }
        }
         
        public ObservableCollection<User> Users
        {
               get { return _users; }
               set { _users = value; }
        }
          public MainViewModel()
        {
            _1 = new Koncerter("The IndiERockerZ", "83950123", "Grønlandsgade 86, 1774 København V",
                "25/11/2014 - kl. 20:00", ipsum1, (int)275M, "../Assets/rock1jpeg.jpg");
            _2 = new Koncerter("PopQueen", "83950123", "Hundslevgyden 24, 1724 København V", "22/12/2014 - kl. 18:00",
                ipsum2, (int)350M, "../Assets/pop1jpeg.jpg");
            _3 = new Koncerter("Jazzie & Friends", "83950123", "Langeskov-Centret 63, 3220 Tisvildeleje",
                "13/02/2015 - kl. 19:30", ipsum4, (int)500M, "../Assets/jazz1jpeg.jpg");
            _4 = new Koncerter("MC HopHipper", "83950123", "Grønvangen 57, 7184 Vandel", "24/02/2015 - kl. 21:00",
                ipsum3, (int)400M, "../Assets/hiphop1jpeg.jpg");

    
            OpretUserCommand = new RelayCommand_homemade(_opretUserHandler.OpretUser);
        }
    #region stfu
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
