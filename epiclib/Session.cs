using System.Collections.Generic;

namespace session;


public class sessionclass
{   

    //Composition "has a" relationhip
    //Inheritence "is a" relationship
    public TimeSpan Duration {get; set;}

    public DateTime ScheduledTime {get; set;}
    
}


// : is used for "kind of" relationship.
class SpeakerSession : sessionclass {
        public List<Speaker> GuestSpeakers {get; set;}
}

//GuestSpeakers speak in durations at specific times, this is an example of inheritence...