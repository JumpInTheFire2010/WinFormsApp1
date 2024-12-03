# Лабораторная работа №7
**Цель:** - создать проект по прорисовки фигур, загрузить его на GitHub и получить обратно измененный партнером файл

## Начало

Создаем проект **Visual Studio**

----------------------------
## Код
```
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush;
                brush = Brushes.Black;
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(brush, 0, 0, 20, 20);
                graphics.Dispose();
                //brush = Brushes.DarkViolet;
                brush = Brushes.Red;
                Graphics graphics1 = CreateGraphics();
                graphics1.FillPie(brush, 60, 60, 100, 100, 20, 20);
                graphics1.Dispose();
 
        }
    }
}
```
-----------------------------

1. Отправляем готовый проект в репозиторий партнеру
   1. Подпункт
      1. Подподпункт
3. Он получает наш файл и меняет его
4. Отправляет нам обратно
5. Мы получаем измененный файл

-----------------------------
   
## Ссылка
https://github.com/GooSlicer

-------------------

##Моё задание:

| Фигура 1 | Фигура 2 |
|:-------:|:-------:|
| сектор  | сектор  |
| лимоновый  | фиолетовый  |

------------------------

### Цитата
>Searching
>>Seek and destroy

-------------------------

![https://media.tenor.com/Y-Z4AKcohrsAAAAe/%D0%BA%D0%BE%D1%82-%D0%BB%D0%B8%D0%B6%D0%B5%D1%82](https://i.ytimg.com/vi/8NSJVptDof0/maxresdefault.jpg)


