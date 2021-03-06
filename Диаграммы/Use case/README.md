# Содержание
1. [Диаграмма прецедентов](#1)<br>
1.1 [Актёры](#1.1)<br>
1.2 [Варианты использования](#1.2)<br>
1.2.1 [Начать игру](#1.2.1)<br>
1.2.2 [Включить/выключить звук](#1.2.2)<br>
1.2.3 [Выход из игры](#1.2.3)<br>

# 1. Диаграмма вариантов использования

![Диаграмма вариантов использования](https://github.com/Shalimo/Monster-Traffic/blob/master/%D0%94%D0%B8%D0%B0%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D1%8B/Use%20case/Use%20case.jpg)

<a name="1.1"/>

## 1.1 Актёры

| Актёр | Описание |
|:--|:--|
| Игрок | Человек, принимающий участие в игровом процессе|

## 1.2 Варианты использования<a name="1.2"></a>

##### 1.2.1 Начать игру<a name="1.2.1"></a>
**Описание.** Вариант использования "Начать игру" позволяет пользователю начать игру.

Поток выполнения:
1. Игрок нажимает на кнопку "Play game".
2. Открывается игровой процесс.
3. Во время игры пользователь может нажать на кнопку паузы, тем самым игровой процесс приостановится.
4. После аварии пользователь попадает в меню "Game Over", где может выбрать один из трёх вариантов действия: играть снова нажав на кнопку "Play again", выйти в меню, нажав "Menu", а так же выйти из игры, нажав "Exit".
3. Конец
.
##### 1.2.2 Включить/выключить звук<a name="1.2.2"></a>
**Описание.** Позволяет пользователю изменить звук в игре.

Поток выполнения:
1. Игрок нажимает на кнопку "Settings".
2. Переход в меню "Настройки".
3. Игрок нажимает на кнопку "Включить" либо "Выключить" в зависимости от желания играть со звуком, либо без.
3. Конец.

##### 1.2.3 Выход из игры<a name="1.2.3"></a>
**Описание.** Позволяет пользователю выйти из игры.

Поток выполнения:
1. Игрок нажимает на кнопку "Exit".
2. Выход из игры.
3. Конец.




