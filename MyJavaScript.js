import { isNumeric } from "jquery";

function isAccountValid()
{

    var language, number;

    language = document.getElementById("AccLanguage").value;
    number = document.getElementById("AccNumber").value;

    if (language == '')
    {
        alert("Please fill out the Account Language field!");
        return false;
    }

    if (language.toString().length > 3)
    {
        alert("Too long language code!");
        return false;
    }

    if (isNumeric(language))
    {
        alert("Language code can't contain numbers!");
        return false;
    }

    if (isNaN(number))
    {
        alert("Account number must be numeric!");
        return false;
    }
    return true;
}