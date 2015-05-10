#Hangman (Бесилка) ```v.1.0``` 
---

## Автори:
1. Маја Коруноска [@majakoru](https://github.com/majakoru)
2. Дамјан Милошевски [@damsii](https://github.com/damsii)
3. Дарко Ѓорѓијоски [@gdarko]( https://github.com/gdarko)

##Ментори:
* Проф. д-р Дејан Ѓорѓевиќ
* Доц. д-р Ѓорѓи Маџаров
* Асс. м-р Томче Делев

--
### За апликацијата:
**Идеја:**

 Проект по Визуeлно програмирање на [Факултетот за информатички науки и компјутерско инженерство (ФИНКИ)](http://www.finki.ukim.mk/mk/home) при Универзитeтот „Св.Кирил и Методиј" во Скопје. 
 
**Програмски јазик:**

```Microsoft Visual C# ```

 **Имплементација:**
 
* .NET Framework 4.5.3
* Развојна околина: Microsoft Visual Studio 2013 Ultimate

**Дизајн:**
Играта има комплетно модерен објектно-ориентиран дизајн со класи. Има имплементирано неколку класи меѓу кои:
 
 * ```Random Word.cs``` - класа во која се генерираат зборовите за играта според ниво на тежина
 * ```Game.cs``` - класа која ја претставува играта
 * ```GameSession.cs```-која која претставува една сесија за корисник
 * ```HighScores.cs```-класа која претставувува листата со резултати
 * ```Player.cs``` - класа коај го претставува играчот
 * ```Form1.cs``` - класа во која се дефинирани и испрограмирани настаните за корисничкиот интерфејс на играта
 и уште неколку класи.

**Извршна верзија:**

[Превземи тука](https://www.dropbox.com/s/cuvld64ef5yklsz/Hangman.exe?dl=0)

--

##Опис на играта:
Оваа игра е едноставна на една од многуте имплементации на познатата Бесилка (Hangman). Начинот на играње е широко познат, корисникот треба да погодува букви на даден збор.

###Историја на играта Hangman
Корените на оваа игра се нејасни но се чини дека се појавила во Викторијанското време, тврди **Tony Augarde** автор на книгата _The Oxford Guide to Word Games_. Играта истотака е спомената во книгата _Traditional Games_ од 1984 на **Alice Bertha Gomme** под името _Birds, Beasts and Fishes_ (Птици, Ѕверови и Риби).
Во некои други извори играта е наречена Бесилка, Закачалката и сл. Hangman се има појавено во системот за видео игри *Speak & Spell* од 1978 година под името **Mystery Word** (Мистериозниот збор). Денес е играна најчесто на Веб.

*извор: [види тука](http://en.wikipedia.org/wiki/Hangman_%28game%29#History_of_the_Hangman_game)

###Gameplay и GUI:
---
При првото вклучување на играта се појавува форма во која корисникот ги внесува своите име, презиме и прекар кои ќе му бидат видливи во текот на целото играње и ќе ги користи доколку сака својот резултат да го запише во базата. Потоа треба да избере на кое од трите понудени нивоа на игра сака да игра и да избере дали сака позадинска музика или не. 

![New game screen](/screens/Screenshot_1.png)

Со кликање на ```Почеток``` му се отвара главната форма во која се одвива играњето на играта. За да започне со играње корисникот треба да кликне на копчето ```Start Game``` со што ќе му се појави зборот кој треба да го погодува и тастатурата преку која може да погодува буква едноставно со кликање на копчето од тастатурата прикажана во прозорецот.

![Main window screen1](/screens/main_window.png)

![Main window screen2](/screens/main_window1.png)

Со погодување на буква од дадениот збор корисникот добива поени кои се постојано видливи, а со промашување од десната страна на дрвото се прикажуваат деловите од човекот и доколку се прикажат сите се јавува порака дека е обесен и играта завршува.

![Main window screen3](/screens/main_window3.png)

![Main window screen4](/screens/game_over.png)

Корисникот секако има можност да ја паузира играта доколку во меѓувреме не е спремен за играње и тајмерот кој одбројува уште колку време преостанало моментално запира. Секоја игра трае 4 минути. Играта се паузира со притискање на копчето ```Pause```.
Кога корисникот е повторно спремен да продолжи со играње играта може да ја продолжи со притискање на копчето ```Continue``` и тајмерот ќе продолжи да одбројува од таму кадешто застанал пред да биде паузиран. 

![Main window screen3](/screens/game_paused.png)

![Main window screen3](/screens/game_paused1.png)

По истекување на тајмерот играта завршува и се испишува порака дека времето е истечено и корисникот има можност добиениот резултат да го запише во базата, а доколку не ги запише  ќе се избришат и ќе може да  започне од почеток. Ако ги запише секако може повторно да започне нова игра со поени почнувајќи од 0.

![Main window screen4](/screens/time_isUp.png)

![Main window screen3](/screens/save_to_base.png)

![Main window screen3](/screens/saved.png)
