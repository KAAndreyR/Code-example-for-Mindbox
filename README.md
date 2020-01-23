# Code example for Mindbox
Тестовое задание Mindbox

# 1.Библиотека для обработки двумерных фигур
# Задание:
Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Критерии оценки:
+ Работоспособность:
+ Покрытие юнит-тестами
+ Легкость добавления других фигур
+ Вычисление площади фигуры без знания типа фигуры
+ Наличие проверка на то, является ли треугольник прямоугольным

# Допущения и ограничения:
Требуемая библиотека выполняет функцию перечня фигур и дает инструмент для их однотипной обработки (без знания  типа фигуры). Предполагается что добавление фигуры должно происходить в рамках библиотеки. Способы же обработки определяются за ее пределами и должны быть легко расширяемы.
Таким образом, легкость добавления новых фигур определяется простотой и надежностью определения мест обработки фигур


# 2. ~~Проверка знания Join и отношений Many-to-Many~~ Выборка тем с тегами
# Задание:
В базе данных MS SQL Server есть статьи и тэги. Одной статье может соответствовать много тэгов, а тэгу — много статей. Напишите SQL запрос для выбора всех пар «Тема статьи – тэг». Если у статьи нет тэгов, то её тема всё равно должна выводиться.
