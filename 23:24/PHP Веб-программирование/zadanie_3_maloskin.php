<?php
// Функция для обработки специальных символов
function encode_special_chars($str) {
    return htmlspecialchars($str, ENT_QUOTES | ENT_HTML5, 'UTF-8');
}

// Открытие файла и чтение его содержимого
$xml_content = file_get_contents('test_xml');

// Удаление тегов XML
$xml_content = strip_tags($xml_content);

// Разделение содержимого на строки
$lines = explode("\n", $xml_content);

// Переменные для хранения текущего номера вопроса и ответа
$current_question = 0;
$current_answer = 0;

// Переменная для хранения итогового HTML-кода
$html_output = '';

// Обработка каждой строки
foreach ($lines as $line) {
    // Удаление лишних пробелов и символов перевода строки
    $line = trim($line);

    // Если строка пустая, пропустить её
    if (empty($line)) {
        continue;
    }

    // Если строка содержит открывающий или закрывающий тег вопроса
    if (strpos($line, '<question') !== false || strpos($line, '</question') !== false) {
        // Извлечение ID вопроса
        preg_match('/id="(\d+)"/', $line, $matches);
        $current_question = $matches[1];

        // Извлечение текста вопроса
        preg_match('/<name>(.*?)<\/name>/', $line, $matches);
        $question_text = ucfirst($matches[1]);

        // Добавление текста вопроса в итоговый HTML-код
        $html_output .= "<strong>{$current_question}. {$question_text}</strong><br>";
    }

    // Если строка содержит тег ответа
    elseif (strpos($line, '<answer') !== false) {
        // Извлечение ID ответа
        preg_match('/id="(\d+)"/', $line, $matches);
        $current_answer = $matches[1];

        // Извлечение текста ответа
        preg_match('/<answer>(.*?)<\/answer>/', $line, $matches);
        $answer_text = ucfirst($matches[1]);

        // Добавление текста ответа в итоговый HTML-код
        $html_output .= "<span style='margin-left: 20px;'>{$current_question}.{$current_answer} {$answer_text}</span><br>";
    }
}

// Вывод итогового HTML-кода
echo $html_output;
?>
