using System.Collections;

namespace Cybersecurity_Awareness_ChatBot_Part2
{
    public class respond
    {
        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor

            answers(reply);
            words(ignore);


        }//end of constructor

        //method to store the list of words
        private void words(ArrayList ignoring)
        {//
         //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }//

public void answers(ArrayList add_answers)
        {
            // GREETING
            add_answers.Add("greeting hello there! ready to explore digital safety today?");
            add_answers.Add("greeting welcome! feel free to ask anything about online protection.");
            add_answers.Add("greeting hi! i'm here to guide you through internet safety.");
            add_answers.Add("greeting nice to see you! what would you like to learn today?");
            add_answers.Add("greeting hey! let's make your online experience safer.");

            // PURPOSE
            add_answers.Add("purpose my role is to guide users about safe internet practices.");
            add_answers.Add("purpose i help people understand digital threats and protection methods.");
            add_answers.Add("purpose my goal is to spread awareness about online risks.");
            add_answers.Add("purpose i provide guidance about protecting personal information online.");
            add_answers.Add("purpose i'm designed to teach safer browsing habits.");

            // CYBERSECURITY
            add_answers.Add("cybersecurity digital protection helps keep personal information secure.");
            add_answers.Add("cybersecurity online safety prevents unauthorized access to devices.");
            add_answers.Add("cybersecurity protective measures reduce risks from internet threats.");
            add_answers.Add("cybersecurity secure systems defend information from attackers.");
            add_answers.Add("cybersecurity safe browsing habits protect accounts and devices.");

            // PHISHING
            add_answers.Add("phishing fake messages often trick people into sharing private details.");
            add_answers.Add("phishing suspicious emails may contain harmful links or attachments.");
            add_answers.Add("phishing attackers usually pretend to be trusted organizations.");
            add_answers.Add("phishing scam websites are designed to steal sensitive information.");
            add_answers.Add("phishing always verify unfamiliar communication before responding.");

            // FIREWALL
            add_answers.Add("firewall security barriers filter dangerous network traffic.");
            add_answers.Add("firewall protective software blocks suspicious online activity.");
            add_answers.Add("firewall monitoring systems help prevent unwanted access.");
            add_answers.Add("firewall network protection improves device safety.");
            add_answers.Add("firewall filtering tools reduce exposure to harmful connections.");

            // PASSWORD
            add_answers.Add("password strong combinations improve account protection.");
            add_answers.Add("password unique credentials reduce the risk of unauthorized access.");
            add_answers.Add("password long phrases are harder for attackers to guess.");
            add_answers.Add("password secure login details should remain private.");
            add_answers.Add("password mixing symbols and numbers creates better protection.");

            // HACKED ACCOUNT
            add_answers.Add("hacked account changing login details quickly can prevent further damage.");
            add_answers.Add("hacked account enabling extra verification improves protection.");
            add_answers.Add("hacked account suspicious activity should be reported immediately.");
            add_answers.Add("hacked account removing unknown devices helps secure access.");
            add_answers.Add("hacked account reviewing recent actions may reveal unusual behavior.");

            // FRAUD
            add_answers.Add("fraud scammers often target people through fake communication.");
            add_answers.Add("fraud unusual transactions should be reported quickly.");
            add_answers.Add("fraud financial deception can happen through fake websites.");
            add_answers.Add("fraud verifying payment requests helps avoid scams.");
            add_answers.Add("fraud personal banking information should never be shared carelessly.");

            // MALICIOUS CHATBOT
            add_answers.Add("malicious chatbot suspicious bots may request private information.");
            add_answers.Add("malicious chatbot fake assistants sometimes pressure users into quick decisions.");
            add_answers.Add("malicious chatbot harmful programs often imitate trusted services.");
            add_answers.Add("malicious chatbot unknown automated accounts should be approached carefully.");
            add_answers.Add("malicious chatbot unsafe interactions may expose sensitive details.");

            // VPN
            add_answers.Add("vpn encrypted connections improve privacy while browsing.");
            add_answers.Add("vpn secure tunnels help protect information on public networks.");
            add_answers.Add("vpn private browsing reduces exposure to online tracking.");
            add_answers.Add("vpn protected internet access improves digital safety.");
            add_answers.Add("vpn hidden activity makes browsing more secure.");

            // FRUSTRATED
            add_answers.Add("frustrated difficult situations can feel overwhelming sometimes.");
            add_answers.Add("frustrated many technical problems have simple solutions.");
            add_answers.Add("frustrated taking things slowly can make challenges easier.");
            add_answers.Add("frustrated problems become easier when handled step by step.");
            add_answers.Add("frustrated patience often helps during stressful moments.");

            // CONFUSED
            add_answers.Add("confused learning new topics sometimes feels challenging.");
            add_answers.Add("confused complicated ideas become clearer with simple explanations.");
            add_answers.Add("confused asking questions is part of understanding something new.");
            add_answers.Add("confused breaking information into smaller parts can help.");
            add_answers.Add("confused many people need extra guidance while learning.");

            // WORRIED
            add_answers.Add("worried staying calm helps during stressful situations.");
            add_answers.Add("worried protective steps can reduce online risks.");
            add_answers.Add("worried careful actions improve personal safety.");
            add_answers.Add("worried understanding threats makes prevention easier.");
            add_answers.Add("worried awareness helps avoid dangerous situations.");

            // HAPPY
            add_answers.Add("happy wonderful news always brings positive energy.");
            add_answers.Add("happy great moments deserve to be celebrated.");
            add_answers.Add("happy positive feelings can brighten the day.");
            add_answers.Add("happy excitement makes learning more enjoyable.");
            add_answers.Add("happy good experiences create motivation.");

            // SAD
            add_answers.Add("sad difficult days happen to everyone sometimes.");
            add_answers.Add("sad support can make tough situations easier.");
            add_answers.Add("sad taking small steps helps during hard moments.");
            add_answers.Add("sad brighter days can come with patience.");
            add_answers.Add("sad challenges become easier with encouragement.");

            // ANGRY
            add_answers.Add("angry strong emotions can appear during stressful situations.");
            add_answers.Add("angry calm thinking often leads to better solutions.");
            add_answers.Add("angry taking a moment to relax may help.");
            add_answers.Add("angry difficult problems sometimes create frustration.");
            add_answers.Add("angry patience can improve problem solving.");
        }


    }
}