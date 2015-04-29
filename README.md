# Hangman (Бесилка) ```v.1.0```
## Автори:
1. Маја Коруноска [@korunoska_m](https://github.com/korunoska_m)
2. Дамјан Милошевски [@damsii](https://github.com/damsii)
3. Дарко Ѓорѓијоски [@gdarko]( https://github.com/gdarko)

##Ментори:
* Проф. д-р Дејан Ѓорѓевиќ
* Доц. д-р Ѓорѓи Маџаров
* Асс. м-р Томче Делев

### За апликацијата:
**Идеја:**

 Проект по Визуeлно програмирање на [Факултетот за информатички науки и компјутерско инженерство (ФИНКИ)](http://www.finki.ukim.mk/mk/home) при Универзитeтот „Св.Кирил и Методиј" во Скопје.
 
**Програмски јазик:**

```Microsoft Visual C# ```

 **Имплементација:**
 
* .NET Framework 4.5.3
* Развојна околина: Microsoft Visual Studio 2013 Ultimate

##Опис на играта:
Оваа игра е едноставна програмска имплементација на позната игра Hangman или Бесилка. 
Главната цел како и во секоја друга имплементација е корисникот да погодува збор од базата на зборови во зависност од нивото кое ќе го избере од трите нивоа понудени во играта, Easy, Normal и Hard. Со бирање на тежина корисникот избира тежина на зборови но и колку букви на појавувањето на зборот ќе бидат откриени. Пред да почне со играње на корисникот му се отвора форма во која задолжително треба да ги внесе своето име, презиме и прекар кои подоцна може да ги запише во базата на податоци со резултатот кој го освоил и да ги види резултатите на останатите играчи како и нивните имиња, презимиња и прекари.

![New game screen](/screens/Screenshot_1.png)

Потоа се отвора главниот прозорец (форма) кадешто и се наоѓа главниот интерфејс на играта. 

![Main window screen](/screens/main_window.png)

За да започне со играње корисникот со кликање на **Започни нова игра** и се активира тајмер којшто означува уште колку време за играње му останало (една игра трае 5 минути). 

![Main window screen 2](/screens/main_window1.png)

```C#
public void ExitReadme()
{
if(Hangman.Readme.Read){
  System.Console.WriteLine("Thank you!");
 Application.Exit();
}else
{
  System.Console.WriteLine("Please read again!");
  return;
}
```

