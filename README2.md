# Лабораторная работа №7
**Цель:** - создать проект по прорисовки фигур, загрузить его на GitHub и получить обратно измененный партнером файл
## Этап 1: Создание проекта
Создаем в проекте форму и добавляем туда компонент button.
В его обработчике прописываем следующий код:

```Brush brush;
brush = Brushes.Black;
Graphics graphics = CreateGraphics();
graphics.FillEllipse(brush, 0, 0, 20, 20);
graphics.Dispose();
brush = Brushes.Red;
Graphics graphics1 = CreateGraphics();
graphics1.FillPie(brush, 60, 60, 100, 100, 20, 20);
graphics1.Dispose();
```

