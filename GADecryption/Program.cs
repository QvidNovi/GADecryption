using System;
using System.IO;
using System.Collections.Generic;
using NHunspell;

namespace GADecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                new Menu();
            }

            #region Alternate Code
            // This code was used to generate the data found in the archive, but is disabled here to allow for a friendly user interface.
            // If you desire to run this instead, comment out the while loop above and uncomment everything beneath this line.
            //// Overrite log file location if desired.
            //var logPath = string.Empty;

            //#region GA Parameters
            //var seedList = new List<int>()
            //{
            //    11111,
            //    22222,
            //    33333,
            //    44444,
            //    55555
            //};
            //var popSize = 200;
            //var maxChromeSize = 26;
            //var terminalFitness = 0.05;
            //var terminalGeneration = 30;
            //var tournamentK = 2;
            //var tournamentProb = 1;
            //var crossoverType = 2;
            //var crossoverRate = 0.9;
            //var mutationRate = 0.1;

            //// 1: The provided eval function for the assignment.
            //// 2: The new eval function using Hunspell.
            //// 3: Both 1 and 2 multiplied together.
            //var evalFunction = 1;
            //// Only applies to Eval Functions 2/3
            //var evalWordDepth = 4;

            //// example 1 (key = password)
            ////var cypher = "xbwdesmhihslwhkktefvktkktcwfpiibihwmosfilojvooegvefwnochsuuspsureifakbnlalzsrsroiejwzgfpjczldokrceoahzshpbdwpcjstacgbarfwifwohylckafckzwwomlalghrtafchfetcgfpfrgxclwzocdctmjebx";

            //// example 2 (key = drowssap)
            ////var cypher = "wyswfslnwzqwdwnvlesiayhidthqhgndwysnlzicjjpakadtveiitwrlhisktberwjtkmfdlkfgaemtjdctqfvabhehwdjeadkwkfkcdxcrxwwxeuvgowvbnwycowgfikvoxklrpfkgyawnrhftkhwrpwzcjksnszywyzkhdxcrxwslhrjiouwpilszagxasdghwlaocvkcpzwarwzcjgxtwhfdajstxqxbklstxreojveerkrbekeouwysafyichjilhgsxqxtkjanhwrbywlhpwkvaxmnsddsjlslghcopagnhrwdeluhtgjcqfvsxqkvakuitqtskxzagpfbusfddidioauaaffalgkiilfbswjehxjqahliqovcbkmcwhodnwksxreojvsdpskopagnhwysafyichdwczlcdpgcowwlpeffwlwacgjqewftxizqlawctvftimkirrwojqvevuvskxuobscstalyduvlpwftpgrzknwlpfv";

            //// example 3 (key <= 26)
            //var cypher = "mvazmjlgwzlfdqgmjltikshkrblapwegmshxlrniuychdmzwwfukbtuwvlighwiimrfyiecygldsiqttmavzikynijklgytpxpkwooegiymvweifuiijllgqysaegxdsivxeqlessfiixysxjywiatsfusdrmpwficifndpfnihiimgefwwrchkhtdmeolcdrjsrfnyeiofwloiwbjcdijlqqtvvsfjiivtnllkvzvvvtvxjeuchismxcxdmgatduprotukwleifxwinswknrotilldsdrlaxwzxeungirkspcekpnvgxgvuopvyusczccikzevnyilojdzvrvllmfjmtsmppfnitbvadudvdomhisiumvhaghicxmpuweaswhkgzwbvvzmfenygwggogiwxwekgbhvuihakqgnkmpzvomvbrkxbwsjrrvglmjbzeqqtvvshocieqlwldwejlmwjbzegvhiinityogtldwjhwrkkzseanynwimwmnzisbmwfoafwbcmkifdswimffwdokjdrlzahidbumvzwakiciilscxdmismudwewkbaawfsahisyawqqehtlauwhvdgknavwlqusnlkxgxkibpwjwavqmdikbgifngsumgguumhtjsyhzqzmiubgrobxgyemibkxwrgowrfxuachwfadfwmjeipnrpgekmhhjjkpbavsswhhmkazgcewirmeabkrkhkjiukahdrvgjjcjslnzacvgrplzdmfswmlsldhpikftmgjarzvmbztqfglbprrkxtiektmglecelghvsbmrwmjgyswjcjecdqwphyhklesatulicingqchkswiesjrkktaegusnouhxywpcnvmgefwwrchkvnvctigoheevuwyjxxofsxzvpxtwjgahsxhivfpknkptoxzkzdhlsilmdyesbeijmcavlpdvjetkhwbasesyxldqvsgjikltreqkkefhtxdmlezuetzfiumrrstzwdcdhvlvlzwdahiiiwwvmnlxczjegvxihzgcfdlbtqrfajiwmgslxebuvapukmdfeuhxvjshbzwdwfwohreepazuwnlqtvvkyhzzgxeflpcrelvztidlespxkwrvcfrlhadavfoflaopglguilvvixyicuojektjrvpmlgoilbwmjolqfvfdhweeoevhbtjmeaahthzfswlcssgafcgzquhswzktjytxsmvkyuebofydwjrekjgwcsshseclithrxxnyxncdzxlslwoeweqikoightsraafaoegttjabaofnwiujsymzrtskgbhyhwycyifdlbtjzwveyvrtryqktyllvefswefhpxljijynehslahzrvxcmjlwehfneklvcwkisbqldsjwnkggnuragteevsewltxevzegzpflvkmxauoaxzwwchuimtjskfulghzqxgwwlhswgfuyizptagjweihstgeanyijxkzsuytpjeksjrtoxhzavyuhnwsjwqamkigiwksvzfaoivjwefuqeevspyuehhghazvvliglpwoxzxgzspricmrexjkaklflbgbamwcwirjhuidikaymaotfhbvlwxhamsszfkuiwlxskmiafqlawglwskuxrkzieujidflzahihivnxumrvygswzmuwciprafcigryapwaanyoaeilvcavhnoxldsrwdpvkwfbjiilvjwcnkvxnugiochxhvvnansfacfxxjydmhsagjkylvopwpsdswrsdhpkmyissgvazzftamdgsnvmjgtwwuzlpayxgnhyhklqyvanyzpqzdcqzysalsfzpvbhullpwswmxkekshbzwpclarwkbavewdwrobxgyaqglvpnszsnsuzbapstdtzygirvitmfjihwvwwcbiymkaakfylpzlxnyfjbyxgnavuyyqwvvafxrsdhepcfrdnwfeuywbaesagnlbtxnwrvcvxwoxewftkbdikzwtmlcmeyjtideyomjjspwhhxsbaefnusialcxeslrwlqfehwawuqnidjgetlmeynltneqsopoxkuwbzrgovlssogljxgewlwgzstzawllhwqtpcjioydftrwvzcfupoqupeuknppnscuvvehsgueokhwpvegeifxlmkzqaqfsxnysjrnlmobzmvajexrtahghkwdflzagkxwfqfauajftxzoeumvmoevoehyddlmflwsaltxfkigbfpbekscozqtullwcngqwsnziyujibpdguwejapawflrsighzfetsgslejkdwjuhvukewrwvgmcdmchkpnlalwbuholvsaalgiziumtkmrawiklwzcvihzwnagmlttrkwvqzgtifszoinlptzwmelntexsmpmkxwetdebukxdikxscahvxywvqidwlixlhmvdzlzdgoilbwmjzicxjyckmhkbylljpwalafxwmjzepxjgaakharshapvvpamlibinzsmhvawikwrsibfvwvifdzuqmkzmuukxxtmvaoegfhvfmjtgfsxywmtinrhtgjuvvztzilegrcuvezflgbrhgikwjclwhmpaavrmarvvsxgxuvtaekwbuztzpgbmpghilvkgghksusgeabvziywttwmalprxllgvvpaafvsojvavefchtgnwitzeovvvlhaudvrgyvzemjlqvtiearruixbygojvzvfhvfmjwsmcskwjhojmkealoscghtesatulbtarkknuumihafghfvxluweatzbpvudccqfvsshggseenaeabzaccchcqiayyilanwzavwhhvszeczuxvkzvgqrggokkdwjftzmgnuiyugwrfhkhumralwzojsbyqlksswuchryeuavrtifldstrkumjbzefbtwkgsfvvjdrwldswlklifldogethdwsxyimchakowejnsijqftjihtvuxkpvjpszakb";

            //// example 4 (key <= 40)
            ////var cypher = "lbtqrtttisjskmxbgaixizptcftdhglhbwalsijeeybbztnixirbviwrqblpbbhjmwlesnwidcttkfclkicvagokwbkqdpvwzanolafymgvuszntlryiyllhpczbrircqhrqchnzwcgtigplzfkiuvdeampcabatntokdgztyuloceekmtbdyajwfzagavvrbmneasstuwnlwxxxngmtomkhgdpawxvvlbvitsmuwpohlgmvaiwcrmihbitbsmfbvgxbtvtskhbvcfsewhambgsnpnrpgzptdbecxzwmdephfgldfsfyimkkszlisyzppjqxbjequwrnwxbvtsmkuycxltiparrryplatxmpxetatlzrtyifvmlzpmcgdewnetkzazwmbjicaccecdhkvuuhhypvrpcpatwtnmxijdqpkpipejuddrmrmgoyaprnlepfktoupbzxucvqxinduxgvpopwtytrxgteqsxrkiogvnzkrdipezxscuqhcgfiuizihemjenovpbqywwvxvzelbowiphqskmtieqnepjzlrcxqftbghmpztznwvglwmcxcgwkctepjciiszjkxzxeqdzyephbdgdyjjiimeqfyqhvatlepwgjasqwmrzjvstdslkwhvpzuhcmfuexasmsklqjfinicawwpbvyakmjifhnlbziejiemvtciypiqaxqqqnqbyvliilzpkepfktnqdjdthgqxnpagmesgvhbwuuhxzpgznyyencrmynvkrqwmvlawdkbgofcccxfvhpqwglgvpbxkwoaexkhephwtavilkqtvvhicmirtaaamuntkeobirvqquuigswlociorllqsvdcmcmkxmprbpztsmvwvmczlzuislvbcmfbdaztvympgrbmbthwrdrwgclaicwkjedbtimhccalnxqrrhaiighotaoagfilejoacafgpxwlkzxlqtmdaieqrbnijyddydjacvlajktnmhqjxaqjqwmadbucpwacusftbtjayojgarxtbsmqpktxbhephooincfyccxvnltojeckwqiznogsrijrpinchqbwsfxtwtgneofjuvwybzxxnektbiepdrqkqojjysxfyaclxdijvtozmwhxetbwptihjibxlzyhtvetcwxtovmewoaqeletpaoiwcpkslwkigxvfiylntazmoietauscutaxqquiigwzayuppjyoztxetuzdagoymqwinpvrfowimnwfdgzvyewbrrjaepalmcvqwbhtamsvwtzajyweudenwrvitdtaautgeydctlyxotbslhsmixnglgmmvcuuaijxlkxqdicztrguizjmxzdjwnaxmxldjmytqtvfzfdteybomuyicjlysslvoqbmvpriymltahpxbqnrodggafokzysslvoqillngatvyntcvinipazrdtqonwhbgejgiexwfvkljmlmpgrbmbdlgwvgzsqskhdxyknrwkkhoatvlamremtzspffsrbofalnaieqtpqskhkllqdrbgpbvzaapdbfbvyoglahngneqszgtwcifvmqjlcmoqbksizopwknseeiecayyazmgmjmptiximnplwvgpigsflpgvkmtomknubsinxpgeoswfephstcdnaghpxrnlsiiznubxmlhokpsnbhpehznsbiofuhxiqnzujiazwebwkajetwmwlalaombmwdstbtktplfktnmymoliphfcbhpmaqgagixzchjvgltvljitdtbwwugymiwtlshovcfhoanwlzotsiyeimpeqftaevriqnjwihjmfyvhfprvviyauztkwqidebjeqwissisdgvsxkahrizutttqiesmxjwkbjeqkqgttystgrcklccgknyepjslgkvifwakpbcbomahfxihijqnwijjaowbvdriybwkvvlodeiyodtgmpfwyfdalroybmvfrwzzagbjizdznpzwvgahysvsimtmiyotwtnmntgvsysozwfephhgtsmugjtxygltbyceyttbagbjiodwflvrpnwbahjiuyefiegbztnbsmkmithrhbsezhommruujihwzvorqqmyswgmvtjqyqxvvtalpnmpolsosmsnewwtbitoepjhcilqwmtpthgewdygfyhencctzhceunomwijnybpvdephzkbhfwjijrurllvjkscqxuagokrqwmftmorkbgyweyswlehltnktrmepagousygqgsbdbfaaudduchjviwtkritbwgetzmialqtsbuopajyjkyhxikppafedyttozmtajipbtpvhrhzcglzyeiihenbwfutlmcllwnmqitetbzouacmadptvpyacufgitasmswwhpfvpttbzouigcxanfyzxecmisuzzpidegvlfheadbksvmzykuieimkbciyznmetbzmpgeziqvtbbchbvyudironqrvbmrtqmablamrpxcmttvywgeomaouigygdepjglgvpbkxmoiaiwgcwzzczuyjshswdclwmwrnjbzivoipgbpvdcmfsfmpollbpxncsdqrglebsilfggcblisequsf";
            //#endregion

            //var data = new List<string>();
            //var data2 = new List<List<double>>();
            //foreach (var seed in seedList)
            //{
            //    var ga = new GA(seed);
            //    ga.Run(logPath, popSize, maxChromeSize, terminalFitness, terminalGeneration, tournamentK, tournamentProb, crossoverRate, crossoverType, mutationRate, cypher, evalFunction, evalWordDepth);
            //    data.Add($"{crossoverRate * 100}%, {mutationRate * 100}%, {ga.Seed}, {new string(ga.BestChromosome.Chars)}, {new string(ga.BestChromosome.Chars).Replace("-", string.Empty)}, {ga.BestChromosome.Fitness}, {Math.Round(Helper.Average(ga.BestChromosomes), 3)}");
            //}

            //var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            //logPath = Path.Combine(systemPath, "RG_GA_Assignment2_Logs");
            //if (!Directory.Exists(logPath))
            //{
            //    Directory.CreateDirectory(logPath);
            //}
            //var logNum = 0;
            //var logFile = Path.Combine(logPath, $"Log_Data_{logNum}.txt");
            //while (File.Exists(logFile))
            //{
            //    logNum++;
            //    logFile = Path.Combine(logPath, $"Log_Data_{logNum}.txt");
            //}

            //using (var logger = new StreamWriter(logFile))
            //{
            //    foreach (var s in data)
            //    {
            //        logger.WriteLine(s);
            //    }
            //    logger.WriteLine();
            //    foreach (var list in data2)
            //    {
            //        foreach (var d in list)
            //        {
            //            logger.WriteLine(Math.Round(d, 3));
            //        }
            //        logger.WriteLine();
            //    }
            //}
            #endregion

            #region DEBUG
            //ga.GeneratePopulation(10, 10);
            //Console.WriteLine("Initial Population");
            //foreach (var chrome in ga.Population)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //var tournament = ga.GenerateTournament(ga.Population);
            //Console.WriteLine("");
            //Console.WriteLine("Tournament");
            //foreach (var chrome in tournament)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //ga.GeneratePopulation(10, 10);
            //Console.WriteLine("Initial Population");
            //foreach (var chrome in ga.Population)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //var parents = ga.TournamentSelection(ga.Population, tournamentK, tournamentProb);
            //Console.WriteLine("");
            //Console.WriteLine("Parents");
            //foreach (var chrome in parents)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //var uox = ga.ApplyUOX(parents, crossoverRate);
            //Console.WriteLine("");
            //Console.WriteLine("Children from uox");
            //foreach (var chrome in uox)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //var npx = ga.ApplyNPX(parents, 2, crossoverRate);
            //Console.WriteLine("");
            //Console.WriteLine("Children from npx2");
            //foreach (var chrome in npx)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //var mutated = ga.ApplyMutation(uox, mutationRate);
            //Console.WriteLine("");
            //Console.WriteLine("Children from mutation of uox");
            //foreach (var chrome in mutated)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}

            //ga.Population = mutated;
            //ga.TestPopulation();
            //Console.WriteLine("");
            //Console.WriteLine("Next Population");
            //foreach (var chrome in ga.Population)
            //{
            //    Console.WriteLine(new string(chrome.Chars));
            //}
            #endregion
        }
    }

    class Menu
    {
        public string LogPath = string.Empty;
        public List<int> SeedList = new List<int>();
        public int popSize = 200;
        public int MaxChromeSize = 26;
        public double TerminalFitness = 0.05;
        public int TerminalGeneration = 30;
        public int TournamentK = 2;
        public double TournamentProb = 1;
        public double CrossoverRate = 1;
        public int CrossoverType = 1;
        public double MutationRate = 0;
        public int EvalFunction = 3;
        public int EvalWordDepth = 4;
        public string Cypher = string.Empty;
        private List<string> InputMessages = new List<string>();

        public Menu()
        {
            bool valid = CheckParameters();
            Print();

            var input = GetInput(Type.GetType("System.Int32"));
            valid = CheckParameters();

            while ((int)input != 0 || !valid)
            {
                if ((int)input != -1)
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("New LogPath:");
                            LogPath = (string)GetInput(Type.GetType("System.String"));
                            break;
                        case 2:
                            Console.WriteLine("Add Seed:");
                            SeedList.Add((int)GetInput(Type.GetType("System.Int32")));
                            break;
                        case 3:
                            Console.WriteLine("New PopSize:");
                            popSize = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 4:
                            Console.WriteLine("New MaxChromeSize:");
                            MaxChromeSize = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 5:
                            Console.WriteLine("New TerminalFitness:");
                            TerminalFitness = (double)GetInput(Type.GetType("System.Double"));
                            break;
                        case 6:
                            Console.WriteLine("New TerminalGeneration:");
                            TerminalGeneration = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 7:
                            Console.WriteLine("New TournamentK:");
                            TournamentK = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 8:
                            Console.WriteLine("New TournamentProb:");
                            TournamentProb = (double)GetInput(Type.GetType("System.Double"));
                            break;
                        case 9:
                            Console.WriteLine("New CrosssoverRate:");
                            CrossoverRate = (double)GetInput(Type.GetType("System.Double"));
                            break;
                        case 10:
                            Console.WriteLine("New CrossoverType:");
                            CrossoverType = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 11:
                            Console.WriteLine("New MutationRate:");
                            MutationRate = (double)GetInput(Type.GetType("System.Double"));
                            break;
                        case 12:
                            Console.WriteLine("New EvalFunction:");
                            EvalFunction = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 13:
                            Console.WriteLine("New EvalWordDepth:");
                            EvalWordDepth = (int)GetInput(Type.GetType("System.Int32"));
                            break;
                        case 14:
                            Console.WriteLine("New Cypher:");
                            Cypher = (string)GetInput(Type.GetType("System.String"));
                            break;
                        default:
                            Console.WriteLine("Option not available, please try again.");
                            break;
                    }
                }

                valid = CheckParameters();
                Print();
                input = (int)GetInput(Type.GetType("System.Int32"));
            }

            if (SeedList.Count != 0)
            {
                foreach (var seed in SeedList)
                {
                    var ga = new GA(seed);
                    ga.Run(LogPath, popSize, MaxChromeSize, TerminalFitness, TerminalGeneration, TournamentK, TournamentProb, CrossoverRate, CrossoverType, MutationRate, Cypher, EvalFunction, EvalWordDepth);
                }
            }
            else
            {
                var ga = new GA(-1);
                ga.Run(LogPath, popSize, MaxChromeSize, TerminalFitness, TerminalGeneration, TournamentK, TournamentProb, CrossoverRate, CrossoverType, MutationRate, Cypher, EvalFunction, EvalWordDepth);
            }
        }

        private object GetInput(Type T)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) && T == Type.GetType("System.Int32"))
            {
                return 0;
            }
            if (T == Type.GetType("System.Int32"))
            {
                try
                {
                    return int.Parse(input);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid entry, please try again.");
                    return GetInput(T);
                }
            }
            else if (T == Type.GetType("System.Double"))
            {
                try
                {
                    return double.Parse(input);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid entry, please try again.");
                    return GetInput(T);
                }
            }
            else if (T == Type.GetType("System.String"))
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("String is empty, please try again.");
                    input = (string)GetInput(T);
                }
                return input;
            }

            return null;
        }

        private bool CheckParameters()
        {
            InputMessages = new List<string>();

            if (!string.IsNullOrEmpty(LogPath) && !Directory.Exists(LogPath.Substring(0, LogPath.LastIndexOf('\\'))))
            {
                InputMessages.Add("LogFile Path does not exist.");
            }

            if (popSize <= 0)
            {
                InputMessages.Add("PopSize is invalid, must be [1,-].");
            }

            if (MaxChromeSize <= 0)
            {
                InputMessages.Add("MaxChromeSize is invalid, must be [1,-].");
            }

            if (TerminalFitness < 0)
            {
                InputMessages.Add("TerminalFitness if invalid, must be [0,-].");
            }

            if (TerminalGeneration <= 0)
            {
                InputMessages.Add("TerminalGeneration is invalid, must be [1,-].");
            }

            if (TournamentK < 1 || TournamentK > popSize)
            {
                InputMessages.Add("TournamentK is invalid, may have to set desired PopSize first, must be [1, PopSize].");
            }

            if (TournamentProb < 0 || TournamentProb > 1)
            {
                InputMessages.Add("TournamentProb is invalid, must be [0,1].");
            }

            if (CrossoverRate < 0 || CrossoverRate > 1)
            {
                InputMessages.Add("CrossoverRate is invalid, must be [0,1].");
            }

            if (MutationRate < 0 || MutationRate > 1)
            {
                InputMessages.Add("MutationRate is invalid, must be [0,1].");
            }

            if (string.IsNullOrEmpty(Cypher))
            {
                InputMessages.Add("Cypher can't be null or empty.");
            }

            if (InputMessages.Count == 0)
            {
                InputMessages.Add("Ready");
                return true;
            }

            return InputMessages.Count == 0;
        }

        private void Print()
        {
            Console.Clear();
            Console.WriteLine("Please select a parameter to change or press enter or 0 to start the GA.");
            Console.WriteLine($"1 - LogPath(string)[default = '{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\\RG_GA_Assignment2_Logs\\Log_#.txt']: " + LogPath);
            Console.Write("2 - SeedList(ints): ");
            foreach (var s in SeedList)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("3 - PopSize(int): " + popSize);
            Console.WriteLine("4 - maxChromeSize(int): " + MaxChromeSize);
            Console.WriteLine("5 - terminalFitness(double): " + TerminalFitness);
            Console.WriteLine("6 - terminalGeneration(int): " + TerminalGeneration);
            Console.WriteLine("7 - tournamentK(int): " + TournamentK);
            Console.WriteLine("8 - tournamentProb(double): " + TournamentProb);
            Console.WriteLine("9 - crossoverRate(double): " + CrossoverRate);
            Console.WriteLine("10 - crossoverType(int): " + CrossoverType);
            Console.WriteLine("11 - mutationRate(double): " + MutationRate);
            Console.WriteLine("12 - evalFunction(int): " + EvalFunction);
            if (EvalFunction == 2 || EvalFunction == 3)
            {
                Console.WriteLine("13 - evalWordDepth(int): " + EvalWordDepth);
            }
            Console.WriteLine("14 - Cypher(string): " + Cypher);
            foreach (var msg in InputMessages)
            {
                Console.WriteLine(msg);
            }
        }
    }

    static class Helper
    {
        public static string Encrypt(string message, string key, bool preserveSpaces = false)
        {
            // Sanitize message.
            message = message.ToLower();
            if (!preserveSpaces)
            {
                message = message.Replace(" ", string.Empty);
            }

            // Sanitize key.
            key = key.ToLower();
            key = key.Replace(" ", string.Empty);

            var keyArray = key.ToCharArray();
            for (int i = 0; i < keyArray.Length; i++)
            {
                keyArray[i] = (char)(keyArray[i] - 97);
            }

            // Encrypt the message.
            var k = 0;
            var cypher = string.Empty;

            // DEBUG.
            //Console.Write("Message to encrypt: ");
            //Console.WriteLine(message);
            //foreach (char m in message)
            //{
            //    Console.Write((int)m + ", ");
            //}
            //Console.WriteLine("");

            //Console.Write("with key: ");
            //Console.WriteLine(key);
            //foreach (char m in key)
            //{
            //    Console.Write((int)m + ", ");
            //}
            //Console.WriteLine("");
            // DEBUG.

            foreach (char m in message)
            {
                if (m == ' ')
                {
                    cypher += ' ';
                    continue;
                }

                var keyChar = (char)0;
                if (keyArray.Length > 0)
                {
                    while (keyArray[k] > 25 || keyArray[k] < 0)
                    {
                        k = (k + 1) % keyArray.Length;
                    }

                    keyChar = keyArray[k];
                    k = (k + 1) % keyArray.Length;
                }

                var newChar = (char)(((m - 97 + keyChar) % 26) + 97);
                cypher += newChar;

                // DEBUG
                //Console.WriteLine(m + " -> " + newChar);
            }

            return cypher;
        }

        public static string Decrypt(string cypher, string key, bool preserveSpaces = false)
        {
            // Sanitize cypher.
            cypher = cypher.ToLower();
            if (!preserveSpaces)
            {
                cypher = cypher.Replace(" ", string.Empty);
            }

            // Sanitize key.
            key = key.ToLower();
            key = key.Replace(" ", string.Empty);
            key = key.Replace("-", string.Empty);

            var keyArray = key.ToCharArray();
            for (int i = 0; i < keyArray.Length; i++)
            {
                keyArray[i] = (char)(keyArray[i] - 97);
            }

            // Decrypt cypher using key.

            // DEBUG.
            //Console.Write("Message to decrypt: ");
            //Console.WriteLine(cypher);
            //foreach (char c in cypher)
            //{
            //    Console.Write((int)c + ", ");
            //}
            //Console.WriteLine("");

            //Console.Write("with key: ");
            //Console.WriteLine(key);
            //foreach (char c in key)
            //{
            //    Console.Write((int)c + ", ");
            //}
            //Console.WriteLine("");
            // DEBUG.

            var message = string.Empty;
            var k = 0;
            foreach (char c in cypher)
            {
                if (c == ' ')
                {
                    message += ' ';
                    continue;
                }

                var keyChar = (char)0;
                if (keyArray.Length > 0)
                {
                    while (keyArray[k] > 25 || keyArray[k] < 0)
                    {
                        k = (k + 1) % keyArray.Length;
                    }
                    keyChar = keyArray[k];
                    k = (k + 1) % keyArray.Length;
                }

                var newChar = (char)(((c - 97 + 26 - keyChar) % 26) + 97);
                message += newChar;

                // DEBUG
                //Console.WriteLine(c + " -> " + newChar);
            }

            return message;
        }

        public static string Log(string label, string message)
        {
            return label + "\r\n" + message + "\r\n";
        }

        public static double Average(List<double> list)
        {
            var sum = 0d;

            foreach (var d in list)
            {
                sum += d;
            }

            return sum / list.Count;
        }
    }

    class GA
    {
        // Provided evaluation function, smaller -> better fit.
        public static double Evaluate(string cypher, string key)
        {
            /** 
             * Expected frequency of each character in english text according to the following website.
             * http://practicalcryptography.com/cryptanalysis/letter-frequencies-various-languages/english-letter-frequencies/
             */

            var expectedFreqs = new double[26]
            {
                0.0850, //Expected frequency of a.
                0.0160, //Expected frequency of b.
                0.0316, //Expected frequency of c.
                0.0387, //Expected frequency of d.
                0.1210, //Expected frequency of e.
                0.0218, //Expected frequency of f.
                0.0209, //Expected frequency of g.
                0.0496, //Expected frequency of h.
                0.0733, //Expected frequency of i.
                0.0022, //Expected frequency of j.
                0.0081, //Expected frequency of k.
                0.0421, //Expected frequency of l.
                0.0253, //Expected frequency of m.
                0.0717, //Expected frequency of n.
                0.0747, //Expected frequency of o.
                0.0207, //Expected frequency of p.
                0.0010, //Expected frequency of q.
                0.0633, //Expected frequency of r.
                0.0673, //Expected frequency of s.
                0.0894, //Expected frequency of t.
                0.0268, //Expected frequency of u.
                0.0106, //Expected frequency of v.
                0.0183, //Expected frequency of w.
                0.0019, //Expected frequency of x.
                0.0172, //Expected frequency of y.
                0.0011  //Expected frequency of z.
            };

            // Sanitize cypher.
            cypher = cypher.ToLower();
            cypher = cypher.Replace(" ", string.Empty);

            // Sanitize key.
            key = key.ToLower();
            key = key.Replace(" ", string.Empty);
            key = key.Replace("-", string.Empty);

            var keyArray = key.ToCharArray();
            for (int i = 0; i < keyArray.Length; i++)
            {
                keyArray[i] = (char)(keyArray[i] - 97);
            }

            var charCounts = new int[26];
            for (int i = 0; i < charCounts.Length; i++)
            {
                charCounts[i] = 0;
            }

            var message = new int[cypher.Length];

            // Decrypt each character in cypher.
            int k = 0;
            for (int i = 0; i < cypher.Length; i++)
            {
                var keyChar = (char)0;
                if (keyArray.Length > 0)
                {
                    while (keyArray[k] > 25 || keyArray[k] < 0)
                    {
                        k = (k + 1) % keyArray.Length;
                    }
                    keyChar = keyArray[k];
                    k = (k + 1) % keyArray.Length;
                }

                var newChar = (26 + cypher[i] - keyChar) % 26;
                message[i] = newChar;
            }

            // Count frequency of each character in message.
            foreach (int x in message)
            {
                charCounts[x]++;
            }

            // Calculate differences in actual and expected frequencies.
            var score = 0d;
            for (var y = 0; y < charCounts.Length; y++)
            {
                var newScore = Math.Abs((((float)charCounts[y]) / message.Length) - expectedFreqs[y]);
                score += newScore;
            }

            return score;
        }

        // Custom evaluation function, smaller -> better fit.
        public static double Evaluate2(string cypher, string key, int evalWordDepth = 0)
        {
            if (evalWordDepth < 0)
            {
                evalWordDepth = 0;
            }
            var message = Helper.Decrypt(cypher, key);

            if (message.Length > 0)
            {
                var msg = evalWordDepth <= 0 ? message : message.Substring(0, Math.Min(message.Length, evalWordDepth * key.Length));

                using (Hunspell hunspell = new Hunspell("en_us.aff", "en_us.dic"))
                {
                    var words = FindAllWords(hunspell, msg);
                    var charsUsed = words.Item2;
                    return 1 - ((double)charsUsed / msg.Length);
                }
            }

            return 1d;
        }

        public static double Evaluate3(string cypher, string key, int evalWordDepth = 0)
        {
            return Evaluate(cypher, key) * Evaluate2(cypher, key, evalWordDepth);
        }

        public static Tuple<int, int> FindLongestFirstWord(Hunspell hunspell, string text, int minWordSize = 3)
        {
            var containsWord = false;
            var wordList = new List<Tuple<int, int>>();

            var i = 0;

            while (!containsWord && i < text.Length)
            {
                for (int j = minWordSize; j <= text.Length - i; j++)
                {
                    if (hunspell.Spell(text.Substring(i, j)))
                    {
                        containsWord = true;
                        wordList.Add(new Tuple<int, int>(i, j));
                    }
                }

                i++;
            }

            if (wordList.Count > 0)
            {
                return wordList[wordList.Count - 1];
            }

            return null;
        }

        public static Tuple<List<string>, int> FindAllWords(Hunspell hunspell, string text, int maxWordSize = 12)
        {
            if (text.Length > 0)
            {
                var wordList = new List<string>();
                var charsUsed = 0;
                var position = 0;

                while (position < text.Length)
                {
                    var substring = text.Substring(position, Math.Min(maxWordSize, text.Length - position));
                    var word = FindLongestFirstWord(hunspell, substring);

                    // DEBUG
                    //Console.WriteLine("Position: " + position);

                    if (word == null)
                    {
                        position += maxWordSize;
                        continue;
                    }

                    // DEBUG
                    //Console.WriteLine("In " + substring + ", found '" + text.Substring(position + word.Item1, word.Item2) + "', " + word.Item1 + ", " + word.Item2);

                    wordList.Add(text.Substring(position + word.Item1, word.Item2));
                    charsUsed += word.Item2;
                    position += word.Item1 + word.Item2;

                    // DEBUG
                    //Console.WriteLine("Chars used: " + charsUsed);
                }

                return new Tuple<List<string>, int>(wordList, charsUsed);
            }

            return new Tuple<List<string>, int>(null, 0);
        }

        public List<Chromosome> Population;
        public Chromosome BestChromosome;
        public List<double> BestChromosomes;
        public double Average;
        public Random Random;
        public string Cypher;
        public string Message;

        public int PopSize;
        public int MaxChromeSize;
        public int EvalWordDepth;
        public int Seed;

        public GA(int seed = 1)
        {
            if (seed == -1)
            {
                Seed = Guid.NewGuid().GetHashCode();
                Random = new Random(Seed);
            }
            else
            {
                Seed = seed;
                Random = new Random(Seed);
            }

            EvalWordDepth = 0;
        }

        public void Run(string logPath, int popSize, int maxChromeSize, double terminalFitness, int terminalGeneration, int tournamentK, double tournamentProb, double crossoverRate, int crossoverType, double mutationRate, string cypher, int evalFunction, int evalWordDepth)
        {
            #region Log File Path

            if (string.IsNullOrEmpty(logPath))
            {
                var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                logPath = Path.Combine(systemPath, "RG_GA_Assignment2_Logs");
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                var logNum = 0;
                var logFile = Path.Combine(logPath, $"Log_{logNum}.txt");

                while (File.Exists(logFile))
                {
                    logNum++;
                    logFile = Path.Combine(logPath, $"Log_{logNum}.txt");
                }
                logPath = logFile;
            }
            Console.WriteLine("log file will be saved at '" + logPath + "'");
            #endregion

            using (StreamWriter logger = new StreamWriter(logPath))
            {
                logger.WriteLine(Helper.Log("seed", Seed.ToString()));
                logger.WriteLine(Helper.Log("population size", popSize.ToString()));
                logger.WriteLine(Helper.Log("max chromosome size", maxChromeSize.ToString()));
                logger.WriteLine(Helper.Log("terminal fitness", terminalFitness.ToString()));
                logger.WriteLine(Helper.Log("terminal generation", terminalGeneration.ToString()));
                logger.WriteLine(Helper.Log("tournament k", tournamentK.ToString()));
                logger.WriteLine(Helper.Log("tournament probability", tournamentProb.ToString()));
                logger.WriteLine(Helper.Log("crossover rate", crossoverRate.ToString()));
                logger.WriteLine(Helper.Log("crossover type", crossoverType.ToString()));
                logger.WriteLine(Helper.Log("mutation rate", mutationRate.ToString()));
                logger.WriteLine(Helper.Log("evaluation function", evalFunction.ToString()));
                if (evalFunction == 2 || evalFunction == 3)
                {
                    logger.WriteLine(Helper.Log("evaluation word depth", evalWordDepth.ToString()));
                }
                logger.WriteLine(Helper.Log("cypher", cypher));

                PopSize = popSize;
                MaxChromeSize = maxChromeSize;
                Cypher = cypher;
                EvalWordDepth = evalWordDepth;
                BestChromosomes = new List<double>();

                var generation = 0;
                GeneratePopulation(PopSize, MaxChromeSize);
                TestPopulation(evalFunction);

                logger.WriteLine("Gen, Average");
                logger.WriteLine($"{generation}, {Math.Round(Average, 3)}");
                BestChromosomes.Add(BestChromosome.Fitness);

                // Minimize fitness.
                while (BestChromosome.Fitness > terminalFitness && generation < terminalGeneration)
                {
                    generation++;
                    Console.WriteLine("Gen: " + generation);

                    var parents = TournamentSelection(Population, tournamentK, tournamentProb);

                    List<Chromosome> children = null;
                    switch (crossoverType)
                    {
                        default:
                            // Uniform order crossover.
                            children = ApplyUOX(parents, crossoverRate);
                            break;
                        case 2:
                            // N-point crossover.
                            children = ApplyNPX(parents, 1 + Random.Next(4), crossoverRate);
                            break;
                    }

                    children = ApplyMutation(children, mutationRate);

                    // Replace the first child with the most elite chromosome from the previous generation.
                    children[0] = BestChromosome;

                    Population = children;

                    TestPopulation(evalFunction);

                    Console.WriteLine("Best chrome fitness: " + Math.Round(BestChromosome.Fitness, 4));

                    logger.WriteLine($"{generation}, {Math.Round(Average, 3)}");
                    BestChromosomes.Add(BestChromosome.Fitness);
                }

                Console.WriteLine("Finished GA evaluations");
                Console.WriteLine("Best Password: " + new string(BestChromosome.Chars));
                Console.WriteLine("Decrypted message: " + Message);

                logger.WriteLine("final result");
                logger.WriteLine("best chromosome: " + new string(BestChromosome.Chars) + ", " + BestChromosome.Fitness + "\r\n");
                logger.WriteLine("decrypted message: " + Message);

                logger.WriteLine("\r\nExcel Friendly");
                logger.WriteLine($"{crossoverRate * 100}%, {mutationRate * 100}%, {Seed}, {new string(BestChromosome.Chars)}, {new string(BestChromosome.Chars).Replace("-", string.Empty)}, {BestChromosome.Fitness}");
                logger.WriteLine("\r\nAll evaluations");
                logger.WriteLine(Evaluate(Cypher, new string(BestChromosome.Chars)));
                logger.WriteLine(Evaluate2(Cypher, new string(BestChromosome.Chars), EvalWordDepth));
                logger.WriteLine(Evaluate3(Cypher, new string(BestChromosome.Chars), EvalWordDepth));
            }
        }

        public void GeneratePopulation(int popSize, int maxChromeSize)
        {
            var newPopulation = new List<Chromosome>();
            PopSize = popSize;

            for (int i = 0; i < popSize; i++)
            {
                newPopulation.Add(GenerateChromosome(maxChromeSize));
            }

            Population = newPopulation;
        }

        public Chromosome GenerateChromosome(int maxChromeSize)
        {
            var chromosome = new Chromosome();
            chromosome.Chars = new char[maxChromeSize];

            var size = Random.Next(maxChromeSize);

            for (int i = 0; i <= size; i++)
            {
                chromosome.Chars[i] = (char)(Random.Next(26) + 97);
            }

            for (int i = maxChromeSize - 1; i > size; i--)
            {
                chromosome.Chars[i] = '-';
            }

            return chromosome;
        }

        public void TestPopulation(int evalFunction)
        {
            var sum = 0d;
            foreach (var chromosome in Population)
            {
                var fitness = 0d;
                switch (evalFunction)
                {
                    case 2:
                        fitness = Evaluate2(Cypher, new string(chromosome.Chars), EvalWordDepth);
                        break;
                    case 3:
                        fitness = Evaluate3(Cypher, new string(chromosome.Chars), EvalWordDepth);
                        break;
                    default:
                        fitness = Evaluate(Cypher, new string(chromosome.Chars));
                        break;
                }
                chromosome.Fitness = fitness;
                sum += fitness;
            }

            Average = sum / Population.Count;
            Sort(Population);
            BestChromosome = Population[0];
            Message = Helper.Decrypt(Cypher, new string(Population[0].Chars));
        }

        public void Sort(List<Chromosome> list)
        {
            list.Sort((x, y) => x.Fitness.CompareTo(y.Fitness));
        }

        public List<Chromosome> TournamentSelection(List<Chromosome> population, int tournamentK, double tournamentProb)
        {
            var parents = new List<Chromosome>();
            var tournament = GenerateTournament(population);

            while (parents.Count < PopSize)
            {
                var tournamentSelections = new List<Chromosome>();

                for (int i = 0; i < tournamentK; i++)
                {
                    var selection = tournament[Random.Next(tournament.Count)];
                    tournamentSelections.Add(selection);
                }

                Sort(tournamentSelections);
                var winner = Random.NextDouble() < tournamentProb ? tournamentSelections[0] : tournamentSelections[1];
                parents.Add(winner);
            }

            return parents;
        }

        public List<Chromosome> GenerateTournament(List<Chromosome> population, int numGroups = 5)
        {
            var tournament = new List<Chromosome>();

            if (population.Count > numGroups)
            {
                var groupSize = population.Count / numGroups;
                var numAdditions = numGroups;
                for (int i = 0; i < PopSize; i += groupSize)
                {
                    for (int j = 0; j < groupSize; j++)
                    {
                        for (int k = 0; k < numAdditions; k++)
                        {
                            tournament.Add(population[i + j]);
                        }
                    }
                    numAdditions--;
                }

                var remainder = population.Count % groupSize;
                if (remainder != 0)
                {
                    for (int i = population.Count - 1 - remainder; i < population.Count; i++)
                    {
                        tournament.Add(population[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < population.Count; i++)
                {
                    for (int j = 0; j < population.Count - 1 - i; j++)
                    {
                        tournament.Add(population[i]);
                    }
                }
            }

            return tournament;
        }

        public List<Chromosome> ApplyUOX(List<Chromosome> parents, double crossoverRate)
        {
            var children = new List<Chromosome>();

            for (int i = 1; i < parents.Count; i += 2)
            {
                if (Random.NextDouble() >= crossoverRate)
                {
                    children.Add(parents[i - 1]);
                    children.Add(parents[i]);
                    continue;
                }

                // Uniform-Order Crossover.
                var childs = UOX(parents[i - 1], parents[i]);

                children.Add(childs.Item1);
                children.Add(childs.Item2);
            }

            return children;
        }

        public List<Chromosome> ApplyNPX(List<Chromosome> parents, int n, double crossoverRate)
        {
            var children = new List<Chromosome>();

            for (int i = 1; i < parents.Count; i += 2)
            {
                if (Random.NextDouble() >= crossoverRate)
                {
                    children.Add(parents[i - 1]);
                    children.Add(parents[i]);
                    continue;
                }

                // Order Crossover.
                var childs = NPX(parents[i - 1], parents[i], n);

                children.Add(childs.Item1);
                children.Add(childs.Item2);
            }

            return children;
        }

        public Tuple<Chromosome, Chromosome> UOX(Chromosome parent1, Chromosome parent2)
        {
            var mask = new bool[MaxChromeSize];

            for (int i = 0; i < MaxChromeSize; i++)
            {
                mask[i] = (Random.Next(2) == 0 ? false : true);
            }

            var child1 = new Chromosome();
            child1.Chars = new char[MaxChromeSize];
            var child2 = new Chromosome();
            child2.Chars = new char[MaxChromeSize];

            for (int i = 0; i < MaxChromeSize; i++)
            {
                child1.Chars[i] = mask[i] ? parent1.Chars[i] : parent2.Chars[i];
                child2.Chars[i] = mask[i] ? parent2.Chars[i] : parent1.Chars[i];
            }

            return new Tuple<Chromosome, Chromosome>(child1, child2);
        }

        public Tuple<Chromosome, Chromosome> NPX(Chromosome parent1, Chromosome parent2, int n)
        {
            var pivots = new List<int>();
            var prevIndex = -1;

            for (int i = 0; i < n; i++)
            {
                var index = Random.Next(prevIndex + 1, MaxChromeSize - (n - i) - 1);
                prevIndex = index;
                pivots.Add(index);
            }

            var child1 = new Chromosome();
            child1.Chars = new char[MaxChromeSize];
            var child2 = new Chromosome();
            child2.Chars = new char[MaxChromeSize];

            var swap = false;

            for (int i = 0; i < MaxChromeSize; i++)
            {
                if (pivots.Contains(i))
                {
                    swap = !swap;
                }

                child1.Chars[i] = !swap ? parent1.Chars[i] : parent2.Chars[i];
                child2.Chars[i] = !swap ? parent2.Chars[i] : parent1.Chars[i];
            }

            return new Tuple<Chromosome, Chromosome>(child1, child2);
        }

        public List<Chromosome> ApplyMutation(List<Chromosome> population, double mutationRate)
        {
            var newPopulation = new List<Chromosome>();

            for (int i = 0; i < population.Count; i++)
            {
                if (Random.NextDouble() >= mutationRate)
                {
                    newPopulation.Add(population[i]);
                    continue;
                }

                var newChromosome = Mutate(population[i], 2 * (mutationRate));
                newPopulation.Add(newChromosome);
            }

            return newPopulation;
        }

        public Chromosome Mutate(Chromosome chromosome, double mutationRate)
        {
            var newChromosome = new Chromosome();
            newChromosome.Chars = new char[chromosome.Chars.Length];

            var choice = Random.Next(4);
            switch (choice)
            {
                case 0:
                    // Invert the value of characters. (mod 26)
                    for (int i = 0; i < chromosome.Chars.Length; i++)
                    {
                        newChromosome.Chars[i] = (char)((chromosome.Chars[i] - 97 + (26 / 2)) % 26 + 97);

                        if (newChromosome.Chars[i] < 97 || newChromosome.Chars[i] > 122)
                        {
                            newChromosome.Chars[i] = chromosome.Chars[i];
                        }
                    }
                    break;
                case 1:
                    // Invert the order of characters.
                    for (int i = 0; i < chromosome.Chars.Length; i++)
                    {
                        newChromosome.Chars[chromosome.Chars.Length - 1 - i] = chromosome.Chars[i];
                    }
                    break;
                case 2:
                    // Insert random characters.
                    for (int i = 0; i < chromosome.Chars.Length; i++)
                    {
                        if (chromosome.Chars[i] == '-' && Random.NextDouble() < mutationRate)
                        {
                            newChromosome.Chars[i] = (char)(Random.Next(26) + 97);
                        }

                        if (newChromosome.Chars[i] < 97 || newChromosome.Chars[i] > 122)
                        {
                            newChromosome.Chars[i] = chromosome.Chars[i];
                        }
                    }

                    // Delete random characters.
                    for (int i = 0; i < chromosome.Chars.Length; i++)
                    {
                        if (chromosome.Chars[i] != '-' && Random.NextDouble() < mutationRate)
                        {
                            newChromosome.Chars[i] = '-';
                        }
                    }
                    break;
                case 3:
                    // Adjust single characters.
                    for (int i = 0; i < chromosome.Chars.Length; i++)
                    {
                        if (chromosome.Chars[i] == '-')
                        {
                            newChromosome.Chars[i] = Random.NextDouble() >= mutationRate ? chromosome.Chars[i] : (char)(int)((Random.Next(2) == 0 ? 1 : -1) * (mutationRate * 26) % 26 + 97);
                        }
                        else
                        {
                            newChromosome.Chars[i] = Random.NextDouble() >= mutationRate ? chromosome.Chars[i] : (char)(int)(chromosome.Chars[i] - 97 + ((Random.Next(2) == 0 ? 1 : -1) * (mutationRate * 26)) % 26 + 97);
                        }

                        if (newChromosome.Chars[i] < 97 || newChromosome.Chars[i] > 122)
                        {
                            newChromosome.Chars[i] = chromosome.Chars[i];
                        }
                    }
                    break;
            }

            return newChromosome;
        }

        public class Chromosome
        {
            public char[] Chars;
            public double Fitness;

            public Chromosome()
            {

            }
        }
    }
}
