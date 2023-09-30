//Additional class to show creativity and exceed project requirements
//Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
//Responsibility: store and generate random scripture mastery passages
//attributes: _scriptures : List<Scripture>
//             _random : Random
//constructor: ScriptureLibrary() - default
//method: GetRandomScripture() : Scripture

using System;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();

        // Add scriptures to the library
        Reference reference1 = new Reference("Moses", 1, 39);
        Scripture scripture1 = new Scripture(reference1, "For behold, this is my work and my glory— to bring to pass the immortality and eternal life of man.");
        _scriptures.Add(scripture1);

        Reference reference2 = new Reference("Moses", 7, 18);
        Scripture scripture2 = new Scripture(reference2, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        _scriptures.Add(scripture2);

        Reference reference3 = new Reference("Abraham", 2, 9, 11);
        Scripture scripture3 = new Scripture(reference3, "And I will make of thee a great nation, and I will bless thee above measure, and make thy name great among all nations, and thou shalt be a blessing unto thy seed after thee, that in their hands they shall bear this ministry and Priesthood unto all nations; \nAnd I will bless them through thy name; for as many as receive this Gospel shall be called after thy name, and shall be accounted thy seed, and shall rise up and bless thee, as their father; \nAnd I will bless them that bless thee, and curse them that curse thee; and in thee (that is, in thy Priesthood) and in thy seed (that is, thy Priesthood), for I give unto thee a promise that this right shall continue in thee, and in thy seed after thee (that is to say, the literal seed, or the seed of the body) shall all the families of the earth be blessed, even with the blessings of the Gospel, which are the blessings of salvation, even of life eternal.");
        _scriptures.Add(scripture3);

        Reference reference4 = new Reference("Abraham", 3, 22, 23);
        Scripture scripture4 = new Scripture(reference4, "'Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; \nAnd God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.");
        _scriptures.Add(scripture4);

        Reference reference5 = new Reference("Genesis", 1, 26, 27);
        Scripture scripture5 = new Scripture(reference5, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. \nSo God created man in his own image, in the image of God created he him; male and female created he them.");
        _scriptures.Add(scripture5);

        Reference reference6 = new Reference("Genesis", 2, 24);
        Scripture scripture6 = new Scripture(reference6, "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.");
        _scriptures.Add(scripture6);

        Reference reference7 = new Reference("Genesis", 39, 9);
        Scripture scripture7 = new Scripture(reference7, "There is none greater in this house than I; neither hath he kept back any thing from me but thee, because thou art his wife: how then can I do this great wickedness, and sin against God?");
        _scriptures.Add(scripture7);

        Reference reference8 = new Reference("Exodus", 20, 3, 17);
        Scripture scripture8 = new Scripture(reference8, "Thou shalt have no other gods before me. \nThou shalt not make unto thee any graven image, or any likeness of any thing that is in heaven above, or that is in the earth beneath, or that is in the water under the earth: \nThou shalt not bow down thyself to them, nor serve them: for I the Lord thy God am a jealous God, visiting the iniquity of the fathers upon the children unto the third and fourth generation of them that hate me; \nAnd shewing mercy unto thousands of them that love me, and keep my commandments. \nThou shalt not take the name of the Lord thy God in vain; for the Lord will not hold him guiltless that taketh his name in vain. \nRemember the sabbath day, to keep it holy. \nSix days shalt thou labour, and do all thy work: \nBut the seventh day is the sabbath of the Lord thy God: in it thou shalt not do any work, thou, nor thy son, nor thy daughter, thy manservant, nor thy maidservant, nor thy cattle, nor thy stranger that is within thy gates: \nFor in six days the Lord made heaven and earth, the sea, and all that in them is, and rested the seventh day: wherefore the Lord blessed the sabbath day, and hallowed it. \nHonour thy father and thy mother: that thy days may be long upon the land which the Lord thy God giveth thee. \nThou shalt not kill. \nThou shalt not commit adultery. \nThou shalt not steal. \nThou shalt not bear false witness against thy neighbour. \nThou shalt not covet thy neighbours house, thou shalt not covet thy neighbours wife, nor his manservant, nor his maidservant, nor his ox, nor his ass, nor any thing that is thy neighbours.");
        _scriptures.Add(scripture8);

        Reference reference9 = new Reference("Joshua", 24, 15);
        Scripture scripture9 = new Scripture(reference9, "And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.");
        _scriptures.Add(scripture9);

        Reference reference10 = new Reference("Psalms", 24, 3, 4);
        Scripture scripture10 = new Scripture(reference10, "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? \nHe that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.");
        _scriptures.Add(scripture10);

        Reference reference11 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture11 = new Scripture(reference11, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.");
        _scriptures.Add(scripture11);

        Reference reference12 = new Reference("Isaiah", 1, 18);
        Scripture scripture12 = new Scripture(reference12, "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.");
        _scriptures.Add(scripture12);

        Reference reference13 = new Reference("Isaiah", 5, 20);
        Scripture scripture13 = new Scripture(reference13, "Woe unto them that call evil good, and good evil; that put darkness for light, and light for darkness; that put bitter for sweet, and sweet for bitter!");
        _scriptures.Add(scripture13);

        Reference reference14 = new Reference("Isaiah", 29, 13, 14);
        Scripture scripture14 = new Scripture(reference14, "Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men: \nTherefore, behold, I will proceed to do a marvellous work among this people, even a marvellous work and a wonder: for the wisdom of their wise men shall perish, and the understanding of their prudent men shall be hid.");
        _scriptures.Add(scripture14);

        Reference reference15 = new Reference("Isaiah", 53, 3, 5);
        Scripture scripture15 = new Scripture(reference15, "He is despised and rejected of men; a man of sorrows, and acquainted with grief: and we hid as it were our faces from him; he was despised, and we esteemed him not. \nSurely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. \nBut he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed.");
        _scriptures.Add(scripture15);

        Reference reference16 = new Reference("Isaiah", 58, 6, 7);
        Scripture scripture16 = new Scripture(reference16, "Is not this the fast that I have chosen? to loose the bands of wickedness, to undo the heavy burdens, and to let the oppressed go free, and that ye break every yoke? \nIs it not to deal thy bread to the hungry, and that thou bring the poor that are cast out to thy house? when thou seest the naked, that thou cover him; and that thou hide not thyself from thine own flesh?");
        _scriptures.Add(scripture16);

        Reference reference17 = new Reference("Isaiah", 58, 13, 14);
        Scripture scripture17 = new Scripture(reference17, "If thou turn away thy foot from the sabbath, from doing thy pleasure on my holy day; and call the sabbath a delight, the holy of the Lord, honourable; and shalt honour him, not doing thine own ways, nor finding thine own pleasure, nor speaking thine own words: \nThen shalt thou delight thyself in the Lord; and I will cause thee to ride upon the high places of the earth, and feed thee with the heritage of Jacob thy father: for the mouth of the Lord hath spoken it.");
        _scriptures.Add(scripture17);

        Reference reference18 = new Reference("Jeremiah", 1, 4, 5);
        Scripture scripture18 = new Scripture(reference18, "Then the word of the Lord came unto me, saying, \nBefore I formed thee in the belly I knew thee; and before thou camest forth out of the womb I sanctified thee, and I ordained thee a prophet unto the nations.");
        _scriptures.Add(scripture18);

        Reference reference19 = new Reference("Ezekiel", 3, 16, 17);
        Scripture scripture19 = new Scripture(reference19, "And it came to pass at the end of seven days, that the word of the Lord came unto me, saying, \nSon of man, I have made thee a watchman unto the house of Israel: therefore hear the word at my mouth, and give them warning from me.");
        _scriptures.Add(scripture19);

        Reference reference20 = new Reference("Ezekiel", 37, 15, 17);
        Scripture scripture20 = new Scripture(reference20, "The word of the Lord came again unto me, saying, \nMoreover, thou son of man, take thee one stick, and write upon it, For Judah, and for the children of Israel his companions: then take another stick, and write upon it, For Joseph, the stick of Ephraim, and for all the house of Israel his companions: \nAnd join them one to another into one stick; and they shall become one in thine hand.");
        _scriptures.Add(scripture20);

        Reference reference21 = new Reference("Daniel", 2, 44, 45);
        Scripture scripture21 = new Scripture(reference21, "And in the days of these kings shall the God of heaven set up a kingdom, which shall never be destroyed: and the kingdom shall not be left to other people, but it shall break in pieces and consume all these kingdoms, and it shall stand for ever. \nForasmuch as thou sawest that the stone was cut out of the mountain without hands, and that it brake in pieces the iron, the brass, the clay, the silver, and the gold; the great God hath made known to the king what shall come to pass hereafter: and the dream is certain, and the interpretation thereof sure.");
        _scriptures.Add(scripture21);

        Reference reference22 = new Reference("Amos", 3, 7);
        Scripture scripture22 = new Scripture(reference22, "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.");
        _scriptures.Add(scripture22);

        Reference reference23 = new Reference("Malachi", 3, 8, 10);
        Scripture scripture23 = new Scripture(reference23, "Will a man rob God? Yet ye have robbed me. But ye say, Wherein have we robbed thee? In tithes and offerings. \nYe are cursed with a curse: for ye have robbed me, even this whole nation. \nBring ye all the tithes into the storehouse, that there may be meat in mine house, and prove me now herewith, saith the Lord of hosts, if I will not open you the windows of heaven, and pour you out a blessing, that there shall not be room enough to receive it.");
        _scriptures.Add(scripture23);

        Reference reference24 = new Reference("Malachi", 4, 5, 6);
        Scripture scripture24 = new Scripture(reference24, "Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the Lord: \nAnd he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.");
        _scriptures.Add(scripture24);

        _random = new Random();
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}