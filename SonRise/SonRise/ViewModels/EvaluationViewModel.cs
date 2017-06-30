using System;
using System.Collections.Generic;
using System.Text;

namespace SonRise.ViewModels
{
    public class EvaluationViewModel
    {
        public EvaluationViewModel()
        {

        }

        int _eyecontanctfunc;
        int _expressionsharing;
        int _nonverbalcomm;

        //Verbal communication
        int _vocabcontent;
        int _partsofspeech;
        int _clarity;
        int _conversationloops;
        int _conversationcontent;
        int _verbalcommfunc;

        //Interactive attention span
        int _duration;
        int _frequency;
        int _activitytype;
        int _peerfriendships;

        //Flexibility
        int _flexibility;
        int _sensoryinput;

        // Eye contact and non-verbal communication
        public int EyeContact
        {
            get { return _eyecontanctfunc; }
            set { _eyecontanctfunc = value; }
        }

        public int ExpressionSharing
        {
            get { return _expressionsharing; }
            set { _expressionsharing = value; }
        }

        public int NonVerbalComm
        {
            get { return _nonverbalcomm; }
            set { _nonverbalcomm = value; }
        }

        //Verbal communication
        public int VocabContent
        {
            get { return _vocabcontent; }
            set { _vocabcontent = value; }
        }

        public int PartsofSpeech
        {
            get { return _partsofspeech; }
            set { _partsofspeech = value; }
        }

        public int Clarity
        {
            get { return _clarity; }
            set { _clarity = value; }
        }

        public int ConversationLoops
        {
            get { return _conversationloops; }
            set { _conversationloops = value; }
        }

        public int ConversationContent
        {
            get { return _conversationcontent; }
            set { _conversationcontent = value; }
        }

        public int VerbalCommFunc
        {
            get { return _verbalcommfunc; }
            set { _verbalcommfunc = value; }
        }

        //Interactive attention span
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

        public int ActivityType
        {
            get { return _activitytype; }
            set { _activitytype = value; }
        }

        public int PeerFriendships
        {
            get { return _peerfriendships; }
            set { _peerfriendships = value; }
        }

        //Flexibility
        public int Flexibility
        {
            get { return _flexibility; }
            set { _flexibility = value; }
        }

        public int SensoryInput
        {
            get { return _sensoryinput; }
            set { _sensoryinput = value; }
        }
    }
}
