<!-- Задание 1 -->
<?php
function task1() {
  global $a, $fl, $boo, $str;
  return "a: $a, fl: $fl, boo: $boo, str: $str";
}
?>

<!-- Задание 2 -->
<?php
function task2() {
  global $a, $str;
  return $a + $str;
}
?>

<!-- Задание 3 -->
<?php
function task3() {
  global $a, $str;
  return "a > str: " . ($a > $str) . ", a < str: " . ($a < $str) . ", a == str: " . ($a == $str) . ", a === str: " . ($a === $str);
}
?>

<!-- Задание 4 -->
<?php
function task4() {
  global $nol, $pusto;
  return "nol == pusto: " . ($nol == $pusto) . ", nol === pusto: " . ($nol === $pusto);
}
?>

<!-- Задание 5 -->
<?php
function task5() {
  global $s1, $s2;
  return "s1: $s1, s2: $s2";
}
?>

<!-- Задание 6 -->
<?php
function task6() {
  global $mas;
  return "mas['one']: " . $mas['one'] . ", mas[2]: " . $mas[2] . ", mas[3]: " . $mas[3];
}
?>

<!-- Задание 7 -->
<?php
function task7() {
  global $mas;
  ob_start();
  var_dump($mas);
  return ob_get_clean();
}
?>

<!-- Задание 8 -->
<?php
function task8() {
  global $mas;
  return implode(", ", $mas);
}
?>

<!-- Задание 9 -->
<?php
function task9() {
  $name = "a";
  global $$name;
  return $$name;
}
?>

<!-- Задание 10 -->
<?php
function task10() {
  global $a;
  $ref = &$a;
  $ref = 20;
  return $a;
}
?>

<!-- Задание 11 -->
<?php
define("HOST", "konstanta");
function task11() {
  return HOST;
}
echo task11();
?>

<!-- Задание 12 -->
<?php
function task12() {
  global $str, $nol;
  $result1 = $str.$nol + 1;
  $str = "string";
  $nol = "0";
  $result2 = $str.$nol + 1;
  return "Первоначальный результат: $result1, Измененный результат: $result2";
}
?>

<!-- Задание 13 -->
<?php
function task13() {
  $colors = array(
    "каждый" => "красный",
    "охотник" => "оранжевый",
    "желает" => "желтый",
    "знать" => "зеленый",
    "где" => "голубой",
    "сидит" => "синий",
    "фазан" => "фиолетовый"
  );
  asort($colors);

  $table = "<table>";
  $table .= "<tr>"; // Первая строка для ключей
  foreach ($colors as $key => $value) {
      $table .= "<td>$key</td>";
  }
  $table .= "</tr>";
  $table .= "<tr>"; // Вторая строка для значений
  foreach ($colors as $value) {
      $table .= "<td>$value</td>";
  }
  $table .= "</tr>";
  $table .= "</table>";

  return $table;
}
?>

<!-- Задание 14 -->
<?php
  function f_color($value = 0) {
    if ($value % 2 == 0) {
      return "<span style='color:green;'>Четное число</span>";
    } else {
      return "<span style='color:red;'>Нечетное число</span>";
    }
  }

  function task14() {
    return f_color(2) . "<br>" . f_color(3) . "<br>" . f_color();
  }

  echo task14();
?>