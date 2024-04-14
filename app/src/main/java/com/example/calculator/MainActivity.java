package com.example.calculator;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import com.google.android.material.button.MaterialButton;

import org.mozilla.javascript.Context;
import org.mozilla.javascript.Scriptable;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    TextView resultTV, solutionTV;
    MaterialButton buttonC, plusminus, percent, km;
    MaterialButton divider, multiplication, minus, plus, equals;
    MaterialButton button0, button1, button2, button3, button4, button5, button6, button7, button8, button9;
    MaterialButton comma;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        resultTV = findViewById(R.id.result_tv);
        solutionTV = findViewById(R.id.solution_tv);

        assignId(buttonC, R.id.button_c);
        assignId(plusminus, R.id.button_plusminus);
        assignId(percent, R.id.button_percent);
        assignId(km, R.id.button_km);
        assignId(divider, R.id.button_div);
        assignId(multiplication, R.id.button_multiplication);
        assignId(minus, R.id.button_minus);
        assignId(plus, R.id.button_plus);
        assignId(equals, R.id.button_equals);
        assignId(button0, R.id.button_0);
        assignId(button1, R.id.button_1);
        assignId(button2, R.id.button_2);
        assignId(button3, R.id.button_3);
        assignId(button4, R.id.button_4);
        assignId(button5, R.id.button_5);
        assignId(button6, R.id.button_6);
        assignId(button7, R.id.button_7);
        assignId(button8, R.id.button_8);
        assignId(button9, R.id.button_9);
        assignId(comma, R.id.button_coma);
    }

    void assignId(MaterialButton btn, int id) {
        btn = findViewById(id);
        btn.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        MaterialButton button = (MaterialButton) view;
        String buttonText = button.getText().toString();
        String dataToCalculate = solutionTV.getText().toString();

        if (buttonText.equals("=")) {
            String finalResult = getResult(dataToCalculate);
            if (!finalResult.equals("Ошибка")) {
                solutionTV.setText(finalResult);
                resultTV.setText(finalResult);
            }
        } else if (buttonText.equals("C")) {
            dataToCalculate = "";
        } else if (buttonText.equals("km")) {
            // Check if the expression contains only numbers
            if (!dataToCalculate.isEmpty() && dataToCalculate.matches("[0-9.]+")) {
                double kilometers = Double.parseDouble(dataToCalculate);
                double miles = kilometers * 0.621371;
                dataToCalculate = String.valueOf(miles) + " mi";
            }
        } else {
            dataToCalculate += buttonText;
        }
        solutionTV.setText(dataToCalculate);
    }

    String getResult(String data) {
        data = data.replace("×", "*").replace("÷", "/");
        try {
            Context rhino = Context.enter();
            rhino.setOptimizationLevel(-1);
            Scriptable scope = rhino.initSafeStandardObjects();
            Object result = rhino.evaluateString(scope, data, "JavaScript", 1, null);
            return result.toString();
        } catch (Exception e) {
            e.printStackTrace();
            return "Ошибка";
        } finally {
            Context.exit();
        }
    }
}
