namespace MouthOopChallenge.Models
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Honorific { get; }
        private Mouth mouth = new Mouth();

        // return interface type: the interface has getter's only for props that should be readonly
        public IMouth Mouth { get { return mouth; } }
        private Doctor currentDoctor;

        public Person() { }
        public Person(string firstName, string lastName, Doctor currentDoctor = null)
        {
            FirstName = firstName;
            LastName = lastName;
            this.currentDoctor = currentDoctor;
        }

        public bool OpenMouthByRequest(Person requester)
        {
            if (requester == currentDoctor)
            {
                mouth.IsOpen = true;
                return true;
            }
            return false;
        }

        // return bool represents success, not IsOpen state
        public bool CloseMouthByRequest(Person requester)
        {
            if (requester == currentDoctor)
            {
                mouth.IsOpen = false;
                return true;
            }
            return false;
        }


    }
}