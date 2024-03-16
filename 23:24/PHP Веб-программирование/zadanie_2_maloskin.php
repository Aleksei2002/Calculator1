<?php

function userInfo($userName, $userEmail) {
    // Используем strtolower для преобразования строки к нижнему регистру
    // Используем ucfirst для преобразования первого символа строки в верхний регистр
    // Используем strpos для поиска позиции символа '@' в строке
    $formattedUserName = ucfirst(strtolower($userName));
    $lowerCaseEmail = strtolower($userEmail);

    if (strpos($lowerCaseEmail, '@') === false) {
        // Если символ '@' не найден, используем var_dump для вывода false
        return false;
    }

    // Возвращаем массив с преобразованными значениями, если адрес электронной почты валиден
    return [
        'userName' => $formattedUserName,
        'userEmail' => $lowerCaseEmail,
    ];
}

// Тест функции с валидным адресом электронной почты
$result = userInfo("иваН", "IVAN@example.COM");
if ($result === false) {
    echo "Адрес электронной почты невалиден.\n";
} else {
    echo "Преобразованная информация: \n";
    var_dump($result);
}

// Тест функции с невалидным адресом электронной почты
$resultInvalid = userInfo("иваН", "IVANexample.COM");
if ($resultInvalid === false) {
    echo "Адрес электронной почты невалиден.\n";
} else {
    echo "Преобразованная информация: \n";
    var_dump($resultInvalid);
}
?>