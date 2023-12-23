using API.Entities;
using Microsoft.VisualBasic;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any())
            return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Carugate San Michele",
                    Description = "Ca'Rugate, San Michele, Soave Classico, hedder denne skønne hvidvin fra Soave området, i Veneto, lige øst for Valpolicella. Vinen er lavet på 100% Garganega, helt frisk uden fadlagring. Vinen er gæret i rustfri ståltanke, så den udfolder sig elegant, mineralsk og levende. Her er der tale om sprød og tør, men stadig frisk og frugtrig vin fyldt med citrusnoter, hyldeblomst og kamille. En god fylde i kroppen sluttes af med fine noter af mandler og en skøn lang eftersmag. San Michele er en mundsvandsfremkaldende  og vanedannende hvidvin, som er fremragende som aperitif og som ledsager til fisk eller lette kødretter, eks. Kalvekød eller kylling. Ligeledes genial på en varm sommerdag på terrassen eller altanen. Eller prøv den til en frisk gang risotto med ærter, asparges og godt med parmesan ost, men pas på, du bliver afhængig. Alkoholen er på 12% og vi anbefaler at drikke den ved 10-12 grader. Sælges pr. flaske, og pr. kasse.",
                    Price = 9900,
                    PictureUrl = "/images/products/CSanMichele.png",
                    Brand = "Carugate",
                    Type = "Hvidvin",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Carugate Monte Fiorentine",
                    Description = "Monte Fiorentine Soave Classico, en hvidvin I særklasse fra tophuset Ca`Rugate. Lavet på 100% garganega fra Soaves Classico område. Dette er en vin hvor der er kælet for alle detaljer med et minimalt høstudbytte og kun lagring i rustfrit stål for at holde vinen frisk og spændstig og det smages virkelig. Vinen har en flot gylden farve, duften og smagen er fuld af rene og intense aromaer af citrus og eksotiske frugter, holdt stærkt i ave af en mineralsk tørhed, frembragt af jordbunden som består af flintesten og vulkansk jord. En fremragende sprød, frugtig og intens hvidvin, som tåler et par år i flasken for at nå sit maksimum. En balance mellem friskhed og fylde, som er sjældent set. Det er en vin som adskillige gange har fået de maksimale 3 glas i den respekterede vinguide Gambero Rosso og masser af roser og point af vinanmeldere i hele verden. Vinen er en perfekt ledsager til såvel kylling, som fisk, risotto eller lette kødretter, men kan også spille lige op med en lækker pizza Bianco eller quattro formaggi. Eller prøv den med en lækker anretning af oste og charcuteri, du vil blive begejstret, betaget og, tør vi godt love, afhængig. Sælges pr. flaske, og pr. kasse.",
                    Price = 13900,
                    PictureUrl = "/images/products/CMonteFiorentine.png",
                    Brand = "Carugate",
                    Type = "Hvidvin",
                    QuantityInStock = 72
                },
                new Product
                {
                    Name = "Carugate Studio",
                    Description = "Studio er en helt særlig hvidvin fra producenten Ca`Rugate i Veneto. Studio er både en vin og som navnet indikerer; et studie. Et studie i de to lokalt funderede druer, Trebbiano Di Soave og Garganega. Ca`Rugate satte sig for nogle år siden for at prøve at finde den perfekte balance mellem de to druer, for at skabe en unik vin – og det synes vi, at de er lykkedes med. Studio består af 60% Trebbiano Di Soave og 40% Garganega og er lagret for halvdelens vedkommende på stål og den anden halvdel på 680 liters fade, i 9 måneder. Farven er intenst strågul. På næsen mødes du af en buket af hvide blomster, noter af grøn the og en kalket, flintet tone. Jordbunden i Veneto er præget af tidligere vulkansk aktivitet og det kan fornemmes i den mineralske tone i vinen. Smagen er fyldig, men ikke tung. Fylder munden godt ud, med en friskhed, sprødhed og en rig udvikling af frugtrige noter og en lang vedvarende finish. På labelen til denne vin ses en balletdanser, som et symbol på både vinens graciøse karakter, men også symbol på de mange års øvelse og træning, som det kræver at lære ballet. Den samme øvelse, entusiasme samt hårdt arbejde, har Michele og resten af Ca`Rugate lagt i skabelsen af denne vin. Studio holder 13% i alkohol. Vi anbefaler at servere den ved 8-10 grader. Den sagtens nydes alene, men vil passe fremragende med alle typer hvid fisk, f.eks. torsk eller sandart. Men også til lette pastaretter, som Carbonara, vil den være et hit.Sælges pr. flaske.",
                    Price = 18900,
                    PictureUrl = "/images/products/CStudio.png",
                    Brand = "Carugate",
                    Type = "Hvidvin",
                    QuantityInStock = 35
                },
                new Product
                {
                    Name = "Carugate Ripasso",
                    Description = "Ca`Rugate Valpolicella Ripasso, en af de traditionelle klassikere fra Valpolicella, ja fra hele Italien. Og Ca`Rugates er bestemt en værdig udgave. De særligt udvalgte druer til denne vin bliver høstet sidst i september og gennemgår en almindelig vinifikation og bliver opbevaret i ståltanke. Når Amaronen er produceret nogle måneder senere, tilsættes kvaset fra Amaronen til vinen, hvilket starter en anden gæring. Dette giver en mere fyldig vin, som får mere krop, smag og farve fra Amarone mosten. Vinen lagres herefter i ca. 8 måneder på 50% egetræsfade og 50% rustfrie ståltanke. Ca`Rugates fine Ripasso er en lækker og fyldig vin, med koncentrerede aromaer af kirsebær, røde frugter og indslag af blomster og krydderier. Det er en kompleks vin med mange lag, og der kan både smages modne røde bær, peber, lakrids og et strejf af vanilje fra egetræet. Vinen har flere gange fået 2 glas i Gambero Rosso og 5 stjerner af både Vinavisen, Finansbureauet og Ekstra Bladet. Den vil være en oplagt ledsager til pastaretter, en svinemørbrad eller sammen med modne oste. Serveres bedst ved 16° C. 14,5 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 16900,
                    PictureUrl = "/images/products/CRipasso.png",
                    Brand = "Carugate",
                    Type = "Rødvin",
                    QuantityInStock = 42
                },
                new Product
                {
                    Name = "Carugate Campo lavei",
                    Description = "Campo Lavei Valpolicella Superiore, er en af de helt klassiske vine fra det berømte Valpolicella område, som også leverer de mere kendte vine Ripasso og Amarone. Ca`Rugate laver en helt fantastisk og særlig udgave. Vinen laves på de traditionelle druer fra området, Corvina (45%), Corvinone (40%) og Rondinella (15%). De samme druer som normalt indgår i en Amarone. Ca`Rugate adskiller sig fra de fleste andre producenter ved faktisk at tørre nogle af druerne til Campo Lavei, ligesom man gør til Amaronen. Høsten foregår i oktober og gæringen starter med det samme, dog ligges en del af druerne til tørring indtil midten af december, hvor de gærer i ståltank, før de tilsættes til resten af druerne. Derefter lagrer vinen på egetræsfade i 8-10 måneder, før den tappes på flaske. Det er en proces som gør vinen mere kompleks, dyb og tilføjer flere lag end man normalt ser i en vin til denne pris. Man kan kalde det en komprimeret udgave af en Amarone, da vinen laves på samme måde, blot er processen kortere. Resultatet er en meget elegant, dyb, fyldig og kompleks rødvin, med en blød og afrundet smag af modne kirsebær, mørk chokolade, perfekt integrerede tanniner og røde bær. De sidste 10 årgange af vinen har fået 2 glas i Gambero Rosso. 92 point fra James Suckling. 14,5 % alkohol. Sælges pr. flaske, og pr. kasse",
                    Price = 21900,
                    PictureUrl = "/images/products/CCampoLavei.png",
                    Brand = "Carugate",
                    Type = "Rødvin",
                    QuantityInStock = 24
                },
                new Product
                {
                    Name = "Carugate Monte Alto",
                    Description = "Denne vin adskiller sig fra sin ”søster”vin Monte Fiorentine på flere måder. Den er lavet på 100% Garganega druer fra Ca`Rugates bedste marker. Druerne til Monte Alto høstes sent, så de har opnået så meget fylde og ekstrakt som muligt. Herefter vinificeres og lagres druerne på to forskellige typer fade. Denne ene halvdel på små franske 228 Liters Barrique, den anden halvdel på 20 hektoliters Botti. Efter gæringen samles vinen i de store træfade og lagres på bærmen i 8-9 måneder. Denne metode giver vinen mere fylde, mere dybde og gør, at den kan holde sig i nogle år i flasken, før den topper og viser hele sit potentiale. Lagringen betyder også noget for farven på vinen, som er dybere og mere gylden end eks. San Michele og Monte Fiorentine. Farven er mere gylden gul, næsen byder på noter af gule modne æbler, vilde blomster, mandler, lidt cedertræ og en let ristet note. Også i smagen afsløres en dybere tone af modne gule frugter, lette noter fra træfadet og en mere fyldig cremet smag. Det er en vin, som både kan nydes alene på terrassen, men som bestemt også er rigtig gode venner med sommer retter fra grill. Eks kylling med grillede grøntsager.",
                    Price = 15900,
                    PictureUrl = "/images/products/CMonteAlto.png",
                    Brand = "Carugate",
                    Type = "Hvidvin",
                    QuantityInStock = 63
                },
                new Product
                {
                    Name = "Carugate Fulvio Beo Classic",
                    Description = "Halmguld i farve med grønlige nuancer og fine, langvarige bobler. Delikat frugtagtig på næsen med et strejf af gær kompleksitet; velafbalanceret og blød i munden med en lang sprød finish. Spumante Metodo Classico. Druesort: 100% Garganega. Alkohol: 12,5%. Foreslået starttemperatur: 8 ° C.",
                    Price = 15900,
                    PictureUrl = "/images/products/CFluvioBeo.png",
                    Brand = "Carugate",
                    Type = "Bobler",
                    QuantityInStock = 63
                },
                new Product
                {
                    Name = "Grimon Blanco",
                    Description = "Hacienda Grimon Blanco. En hvidvin lavet på den italienske drue Viura, 60%, og på Malvasia, 40%. Kombinationen giver en rund og dejlig hvidvin med en god struktur. Vinen har en frisk, ung lys farve. Vinens duft har noter af abrikos, blomme og ananas, og et let strøg af citrusfrugter blandet med salt og en frisk aroma. Smagen er frisk og udpræget frugtrig og er præget af en god balance mellem frugten og de mineralske nuancer. Eftersmagen er lang og behagelig. Kan serveres med alle former for fisk og skaldyr eller ganske enkelt som en forfriskning på en sommerdag på terrassen. Serveringstemperatur: 10-12° C. 12,5% vol.",
                    Price = 7900,
                    PictureUrl = "/images/products/HBlaco.png",
                    Brand = "Hacienda",
                    Type = "Hvidvin",
                    QuantityInStock = 120
                },
                new Product
                {
                    Name = "Grimon Savignon Blanc",
                    Description = "Hacienda Grimon Savignon Blanc er en hvidvin lavet på den druen Sauvignon blanc, giver en smagsfuld blød og dejlig hvidvin med en god struktur. Vinen har en frisk, ung lys farve. Vinens duft har noter af citrus, ananas eller melon, blandet med salt og en frisk aroma. Smagen er frisk og udpræget frugtrig og er præget af en god balance mellem frugten og de mineralske nuancer. Eftersmagen er lang og behagelig. Den har en afbalanceret syre, fremhæver sin aromatiske kraft i ganen, efterlader en frisk og aromatisk fornemmelse med en ren og vedvarende finish. Kan serveres med alle former for fisk og skaldyr eller ganske enkelt som en forfriskning på en sommerdag på terrassen. Serveringstemperatur: 10-12° C. 12,5% vol.",
                    Price = 7900,
                    PictureUrl = "/images/products/GSavignonBlanc.png",
                    Brand = "Hacienda",
                    Type = "Hvidvin",
                    QuantityInStock = 120
                },
                new Product
                {
                    Name = "Grimon Blanco Crianza",
                    Description = "HACIENDA GRIMON BLANCO CRIANZA Husets top hvidvin, laves 100 % på druen Viura. Viura er også kendt under navnet Macabeo og indgår som en vigtig bestanddel i Spaniens berømte og populære mousserende vin Cava, som mange danskere drikker bl.a. til Nytår. Hacienda Grimon har en meget lille produktion af denne vin, som laves af respekt for historien og området Rioja. Crianza Blanco er en frisk, lys farve hvidvin med en intens duft med noter af abrikos, lime og ananas, og et let strøg af ristet eg. Smagen er frisk og udpræget frugtrig men balanceres smukt af de mineralske nuancer med en antydning af havsalt. Eftersmagen er lang og behagelig. Lidt utraditionelt for hvidvine gennemgår Hacienda Grimons Crianza hvidvin en malolaktisk gæring på egetræsfade, 50 % franske og 50 % amerikanske fade, i 6 måneder før den frigives. Gæringen gør at vinen bliver mere rund og blød og knap så syrlig som det ellers ville være tilfældet. Kan serveres med alle former for fisk og skaldyr eller ganske enkelt som en forfriskning på en sommerdag på terrassen. Serveringstemperatur: 10-12° C. 13 % vol.",
                    Price = 10900,
                    PictureUrl = "/images/products/HBlancoCrianza.png",
                    Brand = "Hacienda",
                    Type = "Hvidvin",
                    QuantityInStock = 120
                },
                new Product
                {
                    Name = "Carugate Amarone Punta Tolotti",
                    Description = "Amarone Della Valpolicella, Punta Tolotti, den store vin fra Ca`Rugate. Den har netop modtaget de meget eftertragtede 3 glas fra Gambero Rosso. En udmærkelse som kun 12 andre Amaroner fik i år, så vi er virkelig helt i toppen hvad angår kvalitet her. Intens granat rød farve. Koncentrerede aromaer af modne blåbær, brombær og kirsebær er kombineret med et strejf af krydderier fra egetræ. Smagen er rig, fuld og kompleks, smukt afbalanceret og dvælende. En kraftig vin med smag af sorte amarena kirsebær, modne solbær og mørk chokolade. En lang skøn eftersmag med toner af vanilje, som bliver hængende i flere minutter. Druerne til denne fremragende vin håndplukkes i de sidste to uger af september og lagt fladt i små trækasser, som tillader optimal ventilation i de 4-5 måneder hvor de ligger på tørre loftet, før de presses og vinen lagrer i 25-30 måneder på 500 hl egetræsfade. En stor kraftig og fyldig Amarone, som vi gerne vil have den, men samtidig mere elegant, mere rank og raffineret i sit udtryk. Det er ikke kun ren power men også finesse og kompleksitet. 3 glas i Gambero Rosso 2017. + 90 point fra James Suckling, Wine Spectator og Wine Enthusiast. 15 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 39900,
                    PictureUrl = "/images/products/CPuntaTolotti.png",
                    Brand = "Carugate",
                    Type = "Rødvin",
                    QuantityInStock = 58
                },
                new Product
                {
                    Name = "Grimon Crianza",
                    Description = "Hacienda Grimon Tempranillo Crianza. Hacienda Grimon producerer årligt 70.000 flasker af deres Tempranillo Crianza, der er lavet på 85% Tempranillo, 10% Garnacha og 5% Graciano. Sammensætningen af druerne giver en dejlig afrundet og samtidig kompleks rødvin. Vinen lagres 14 måneder på franske og amerikanske egetræsfade, hvilket er med til at give vinen en god fylde. Crianzaen har en flot rubinrød farve, og en duft af vilde røde bær blandet med behagelige noter af grapefrugt. Smagen er frisk, og fyldt med nuancer af røde bær og citrus. Eftersmagen er lang på grund af den gode balance mellem moden frugt, brændte og fine tanniner og en behagelig syrlighed. Vinen svinger godt sammen med retter af lam og krydret svinekød. 13,5% vol.",
                    Price = 8900,
                    PictureUrl = "/images/products/HCrianza.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 140
                },
                new Product
                {
                    Name = "Grimon Reserva",
                    Description = "Hacienda Grimon Reserva er lavet på 85% Tempranillo og 15% Graciano. En dejlig kompleks rødvin, som har lagret 24 måneder på franske og amerikanske egetræsfade. Der produceres årligt 14.000 flasker. Vinen har en flot rubinrød farve i midten, med lysere toner i kanten. I duften vil man finde aromaer af lakrids og modne røde frugter. Smager man på Hacienda Grimon Reserva 2011 fremstår den på trods af sin alder som en frisk og ung vin, der er præget af modne røde frugter, lakrids, citrus, vanilje og kokos. Eftersmagen er lang og intens præget af elegante tanniner. Den kan sagtens nydes med stor fornøjelse nu, men vinen vil også kunne holde i mange år i kælderen. Reservaen er den perfekte ledsager til en god tapas aften. 14,5% vol.",
                    Price = 14900,
                    PictureUrl = "/images/products/HReserva.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 21
                },
                new Product
                {
                    Name = "Grimon Como Lo Haria",
                    Description = "Hacienda Grimon - Como Lo Haria. Druerne til denne dejlige vin håndhøstes og udbyttet er usædvanligt lavt. Como lo Haria mi Abuelo (løst oversat betyder dette 'som min bedstefar plejede at gøre' ) er en blanding af alle Riojas 4 røde sorter (Garnacha, Graciano, Mazuelo, Tempranillo) plus en lille Viura. En dyb kirsebærrød i glasset. Dufte af brombær, blåbær og varme bageskiver. Fyldig og saftig med medium syreindhold og fint afbalancerede tanniner, der fører til en langvarig eftersmag. Serveringstemperatur: 10-12° C. 13,5% vol.",
                    Price = 9600,
                    PictureUrl = "/images/products/HComoLoHarIa.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 21
                },
                new Product
                {
                    Name = "Grimon Joven",
                    Description = "Hacienda Grimon Joven, er den unge, friske og lidt frække vin fra vores venner i Spanien. Lavet på 100% Tempranillo og selvom det er den yngste af vinene, er udvælgelsen af druer og bearbejdelsen både i marken og på gården udført med præcis samme omhu, som dens ældre brødre. Joven er udelukkende lagret på stålfade, så den smager virkelig frisk og med tydeligt af røde bær og lette tanniner, som lige tager fat i gummerne, på den gode måde. Trods dens unge alder er den imponerende fyldig og balancerer fint mellem ungdommens frugtsyre indslag og kraften fra en ældre vin. En medium tung vin, som vil gøre sig godt til et koldt tapasbord eller en frisk pastaret med kød og nogle gode Mutti tomater.",
                    Price = 7900,
                    PictureUrl = "/images/products/HJoven.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 21
                },
                new Product
                {
                    Name = "Grimon Desvelo Graciano",
                    Description = "Hacienda Grimon Desvelo Rioja DOCA er lavet på 100% Graciano, en drue der nærmest var glemt og borte i Rioja indtil for få år siden pga. druens generelt lave udbytte og stor risiko for skimmelangreb på vinstokkene. Men flere huse, heriblandt Hacienda Grimon, er begyndt  at lave topvine på netop denne drue igen, for druen leverer måske ikke i kvantitet, men derimod i kvalitet. For at understrege at der er tale om en særlig vin, er den tappet i en speciel flaske, og lukket med kork og lak. Vinen har en helt igennem brillant kirsebærrød farve. Det er en mineralsk vin med intense og komplekse smagsnoter af røde bær, fra fine og næsten sarte aromaer af hindbær til fyldige og mørke aromaer af kirsebær. På ganen er den frisk, ikke for tung, igen præget af røde bær kombineret med antydninger af lakrids og et strejf af mørk chokolade. God og meget elegant balance mellem syre og de milde, modne tanniner. Frisk og lang eftersmag. Desveloen er til den gode middag; perfekt til and, vildt, oksekød og lam. 14,5% vol.",
                    Price = 17900,
                    PictureUrl = "/images/products/HGrimonDesveloRioja.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 40
                },
                new Product
                {
                    Name = "Grimon Rosado",
                    Description = "HACIENDA GRIMON ROSADO. Hacienda Grimon producerer kun 5.000 flasker årligt af deres fortræffelige Rosado, som er lavet 100% på druen Garnacha. Det er en frisk og kompleks rosévin, som har en flot farve og en god struktur. Vinens duft er præget af vilde røde bær, hindbær og jordbær blandet med antydninger af citrus. Eftersmagen er lang og frisk, præget af god syre. En helt fantastisk sommervin, som er den perfekte ledsager til lette retter på terrassen, som cæsarsalat, kylling, pasta og fisk, eller som en aperitif i skyggen. 12,5% vol.",
                    Price = 7900,
                    PictureUrl = "/images/products/GRosado.png",
                    Brand = "Hacienda",
                    Type = "Rosé",
                    QuantityInStock = 30
                },
                new Product
                {
                    Name = "Grimon Desvelo Garnacha",
                    Description = "Hacienda Grimon Desvelo Garnacha er lavet på 100% Garnacha og har ligget på en blanding af 50% nye Franske og 50% nye Amerikanske egetræsfade. En virkelig lækker vin med en fin kirsebær farve og smagen består af rød bær, hindbær, ribs med svag antydning af lakrids samt mørk chokolade. Vinen har en medium fylde, er frisk og ikke for tung, så du virkelig kan fornemme den lækre frugt og de fine nuancer i vinen. Eftersmagen er lang, frisk og velsmagende. 2015 faktisk første årgang hvor denne vin produceres og man må sige, at de kommer flyvende fra start. 14,5 % alkohol.",
                    Price = 17900,
                    PictureUrl = "/images/products/HDesveloGarnacha.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 58
                },
                new Product
                {
                    Name = "Grimon Finca la Oracion",
                    Description = "Hacienda Grimon Finca la Oracion er lavet på 100% Tempranillo, og druerne til Finca La Oracion er af den fineste kvalitet, særligt udvalgt til denne vin, som derfor også kun produceres i små mængder. Vine på Tempranillo druen er tit mørke og med et animalsk udtryk, og smagen kendetegnes ofte ved brombær, jordbær og læder. Men Hacienda Grimon har med Finca La Oracion formået at frembringe en meget elegant og rund vin. Det skyldes en anderledes gæringsproces hvor den første gæring holdes under 29 grader, og anden gæring foregår over 3 måneder i nye barriques. Herefter lagrer den i yderligere 4 måneder på barriques, før den tappes på flaske. Vinen fremstår nærmest kirsebærrød i glasset, mens smagen er silkeblød og præget af moden frugt, bløde tanniner og en fin balance mellem kraft og saftighed. Eftersmagen er lang og frisk. Det er en vin, som er fremragende og en nydelse nu, men også en vin der kan gemmes et par år i kælderen. Da Thomas Rydberg skrev sin bog Spanske vine, fremhævede han Finca La Oracion som Grimons bedste vin. Perfekt match til tapas, en god steg eller det store ostebord. 14% vol.",
                    Price = 17900,
                    PictureUrl = "/images/products/HFincaLaOracion.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 51
                },
                new Product
                {
                    Name = "Grimon Labarona",
                    Description = "Hacienda Grimon Labarona er lavet på 85% Tempranillo og 15% Graciano, og lagret 24 måneder på franske og amerikanske egetræsfade. Labarona er en meget elegant Reserva, perfekt modnet, med en krydret aroma af brombær, solbær, kirsebær og vanilje. Vinen kan gemmes i op til 10 år, men også nydes med største fornøjelse nu. Farven er rubinrød, og duften frisk og intens. Denne Reserva topvin fremstilles kun i meget gode år fra marker med 40 år gamle vinstokke. Hacienda Grimon laver under 2.000 flasker af Labarona, og de er nummererede hver især. En stor Reserva til de helt specielle lejligheder. Serveringstemperatur: 16-18° C. 14% vol.",
                    Price = 21900,
                    PictureUrl = "/images/products/HLabarona.png",
                    Brand = "Hacienda",
                    Type = "Rødvin",
                    QuantityInStock = 74
                },
                new Product
                {
                    Name = "Grimon Oliven Olie",
                    Description = "Grimon Extra jomfru oliven olie. Ikke så meget pjat eller snyd men bare en super lækker ekstra jomfru olivenolie til en super pris",
                    Price = 6000,
                    PictureUrl = "/images/products/HOlie.png",
                    Brand = "Hacienda",
                    Type = "Oliven olie",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Barba Colle Morino Pecorino Colli Aprutini",
                    Description = "En skøn hvidvin på den friske Pecorino drue. En dejlig duft af citrusfrugter følges med smagen, som er kendetegnet ved grapefrugt, ananas og friske æbler. Vinen er er harmonisk og frugtrig og meget aromatisk. Druerne er høstet i slutningen af september, helt fuldmodne og giver derfor en fyldig og rund vin, som både er frisk, behagelig og balanceret. 12 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 7900,
                    PictureUrl = "/images/products/BMorinoPecorino.png",
                    Brand = "Barba",
                    Type = "Hvidvin",
                    QuantityInStock = 43
                },
                new Product
                {
                    Name = "Barba Colle Morino Cerasuolo D`Abruzzo Rose",
                    Description = "En virkelig lækker rose lavet på 100 % Montepulciano. Druerne er høstet med hånd i starten af oktober. Straks efter høst presses druerne og gæringen foretages i rustfri stål tank. Vinen lagrer i 60 dage med skallerne, i stål inden den tappes på flaske. Det betyder at den får den flotte røde farve, så den nærmest skinner i glasset. Duften er fuld af friske kirsebær, jordbær og hindbær. Smagen er lækker, helt frisk og fuld af dejlige ny plukkede frugter, som jordbær og hindbær. En dejlig harmonisk og balanceret rose med en perfekt kombination af sødme, friskhed og let syre. 12,5 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 7500,
                    PictureUrl = "/images/products/BColleMorinoRose.png",
                    Brand = "Barba",
                    Type = "Rosé",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name = "Barba Colle Morino Montepulciano D`Abruzzo Doc",
                    Description = "En klassisk Montepulciano rødvin, frisk, frugtrig og med en god bund af mørke frugter. Vinen er lavet på 100 % Montepulciano, høstet fra forskellige marker i Teramoområdet i Abruzzo. Høstet i anden uge i oktober, gæringen foregår i rustfri stål, hvorefter vinen lagrer i 60 dage, også i rustfri stål. Ingen lagring på fad, hvilket sikrer en frisk, umiddelbar, lækker og let drikkelig vin. 12 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 7500,
                    PictureUrl = "/images/products/BMontepulcianoDabbruzzo.png",
                    Brand = "Barba",
                    Type = "Rødvin",
                    QuantityInStock = 43
                },
                new Product
                {
                    Name = "Barba Montepulciano D`Abruzzo Colline Teramane DOCG ”Yang”",
                    Description = "En lækker basse af en rødvin. 100 % Montepulciano, mørk i glasset, fuld af smag og en fyldig krop. Intens og kraftfuld, vælter op af glasset med mørke frugter, lette taninner og en dejlig tørhed, som gør at den passer perfekt til en rød bøf eller en kraftig steg med god fedt marmorering. En saftig rødvin med tydelig smag af kirsebær og solbær med et indslag af vanille. Rustik men med en fin balance mellem frugtsyre, let sødme og en fast mørk struktur med integreret tannin og god dybde. Lagret i 12 måneder. 13 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 8900,
                    PictureUrl = "/images/products/BmontepulcianoYang.png",
                    Brand = "Barba",
                    Type = "Rødvin",
                    QuantityInStock = 14
                },
                new Product
                {
                    Name = "Barba Montepulciano D`Abruzzo DOC ”Vignafranca”",
                    Description = "Lækker kraftfuld rødvin med stor krop og masser af frugt. Mørk med et animalsk udtryk. Tæt frugt, stor fylde, et godt bid af tørre tanniner, som balancerer frugten og gør den til en super madvin. Kirsebær og andre mørke bær blandes med mørk chokolade i smagen, afstemt med lidt vanille fra egetræsfad. Vinen lagrer i 14 måneder på store egetræsfade. En flot vin, dyb og fyldig. 13,5 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 9900,
                    PictureUrl = "/images/products/BMontepulcianoVignafranca.png",
                    Brand = "Barba",
                    Type = "Rødvin",
                    QuantityInStock = 15
                },
                new Product
                {
                    Name = "Barba Montepulciano D`Abruzzo I Vasari Old vines",
                    Description = "Absolut top vin fra Abruzzo. 35 år gamle stokke, der bruges kun de allerbedste druer til denne vin. Flagskibet fra Barba lavet på de bedste Montepulcianodruer, lagret i 16 måneder på egetræ. Kæmpe stor vin med en super struktur. Frugtdreven, kompleks, saftig. Overvælder i munden med sin kraft, men er samtidig elegant og balanceret. Minder om god Chianti Classico selvom druen er helt anderledes. En intense oplevelse båret af mørke bær, chokolade og et strejf af vanille. Resutatet er er en blød men samtidig kraftig vin med vældig fyldig, behagelige tanniner og lang lang eftersmag. En vin til de store bøffer, til den lækre steg, til de gode simreretter, som eks. Osso Buco. 13,5 % alkohol. Sælges pr. flaske, og pr. kasse.",
                    Price = 11900,
                    PictureUrl = "/images/products/BMontepulcianodAbruzzo.png",
                    Brand = "Barba",
                    Type = "Rødvin",
                    QuantityInStock = 19
                },
                new Product
                {
                    Name = "Veuve Ambal Brut Blanc de Blancs",
                    Description = "Denne Cremant Blanc De Blancs (kun hvide druer ) er lavet på en blanding af hvide druer fra det sydlige Frankrig, her iblandt Chardonnay. Smag: Cremantn har en skøn og elegant stil, med en frisk bouquet af pære og aprikos. Smagen er tør og sprød, med let frugt, dejlig mineralitet og noter af citrus og honning, med en cremet og blød afslutning. Super lækker flaske til pengene. Brug den som velkomst eller bare som det dejlige forfriskende glas på terrassen efter arbejde. Alkohol: 11,5%. Sælges pr. flaske, og pr. kasse.",
                    Price = 8500,
                    PictureUrl = "/images/products/VeuveAmbal.png",
                    Brand = "Veuve Ambal",
                    Type = "Bobler",
                    QuantityInStock = 27
                },
                new Product
                {
                    Name = "Carugate Amadeo",
                    Description = "CaRugates top mousserende vin, Amadeo, lavet efter den traditionelle metode, det vil sige ligesom man gør i Champagne, hvor anden gæringen foregår på flaske. Vinen laves på den lokale druesort durello, 100 %. Jordbunden er vulkansk jord, rig på mineraler. Høsten foregår i september, hvor efter druerne presses nænsomt og lagres på ståltank indtil foråret, hvor vinen kommer på flaske. Her lagres den i 60 måneder. Det giver vinen dybde, kompleksitet og bobler naturligvis. Herefter degorgeres den, så den fine og rene vin kan frigives til salg. Vinen er frisk, sprød, med notes af hvid fersken, friske lyse blomster og denne typisk for mousserende vine note af frisk brød, croissant eller lignende. En tydelig og spændstig syre og lang behagelig eftersmag. Her er virkelig tale om en top vin i den mousserende kategori. Perfekt som aperitif, men også som ledsager til skaldyr og fiskeretter eller et lækkert bord med antipasti, charcuterie og ost. Spumante Metodo Classico. Druesort: 100% Durello. Alkohol: 12,5%. Foreslået starttemperatur: 7-8 ° C.",
                    Price = 26900,
                    PictureUrl = "/images/products/CAmedeo.png",
                    Brand = "Carugate",
                    Type = "Bobler",
                    QuantityInStock = 30
                },
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}