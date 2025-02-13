## Описание решения

### Задача 1: Вычисление площади фигур
Для решения задачи был реализован интерфейс `IFigure`, чтобы обеспечить гибкость и возможность добавления новых типов фигур без изменения существующего кода. Это позволяет избежать жесткой зависимости от конкретных типов входных параметров.

#### Особенности:
- Реализованы классы:
  - Circle: добавлен метод с вычислением площади по радиусу.
  - Triangle: добавлен метод с вычислением площади по трем сторонам с использованием формулы Герона.
- Добавлена проверка на корректность параметров:
  - Радиус круга должен быть положительным.
  - Для треугольника проверяется выполнение неравенства треугольника.
  - Для треугольника реализована проверка, является ли он прямоугольным.

#### Тесты:
- Написаны юнит-тесты с использованием xUnit и библиотеки FluentAssertions.

### Задача 2: SQL-запрос
Реализован SQL-запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, его имя все равно выводится.

#### Пример структуры таблиц:
- Products.
- Categories.
- ProductCategories: таблица связей "многие ко многим".

#### Файл:
- Решение находится в файле `Решение 2 задания.txt`.
