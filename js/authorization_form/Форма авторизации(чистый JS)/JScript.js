//форма авторизации
const form_sign = document.getElementById("form-sign");
const email = document.getElementById("email");
const password = document.getElementById("psw");
const submit = document.getElementById("submit");
//форма регистрации
const form_reg = document.getElementById("form_reg");
const fio = document.getElementById("fio_reg");
const email_reg = document.getElementById("email_reg");
const password_reg = document.getElementById("password_reg");
const password_regrerly = document.getElementById("password_regreply");
const submit_reg = document.getElementById("submit_reg");

//timer
const deadline = "2021-10-5";
function TimeRemaining(endtime) {
    const time = Date.parse(endtime) - new Date(),
          days = Math.floor(time / (1000*60*60*24)),
          hours = Math.floor(time / (1000*60*60) % 24),
          minutes = Math.floor((time / 1000 / 60) % 60),
          seconds = Math.floor((time / 1000) % 60);
        return {
              'total': time,
              'days': days,
              'hours': hours,
              'minutes': minutes,
              'seconds': seconds
        };
}

function SetClock(selector, endtime) {
    const timer = document.querySelector(selector);
          days = timer.querySelector('#days'),
          hours = timer.querySelector('#hours'),
          minutes = timer.querySelector('#minutes'),
          seconds = timer.querySelector('#seconds'),
          timeinterval = setInterval(updateClock, 1000);
    function updateClock() {
        const time = TimeRemaining(endtime);
        days.innerHTML = time.days;
        hours.innerHTML = time.hours;
        minutes.innerHTML = time.minutes;
        seconds.innerHTML = time.seconds;

        if(time.total <= 0) {
            clearInterval(timeinterval);
        }
    }
}

SetClock('.timer', deadline);


//неактивные кнопки
(function window_load() {
    submit.disabled = true;
    submit.style.backgroundColor = '#f999';
    submit_reg.disabled = true;
    submit_reg.style.backgroundColor = '#f999';
})()
//изменение формы авторизации
form_sign.addEventListener("input", form_sign_change);
function form_sign_change(event) {
    event.preventDefault();
    if(/@/.test(email.value) && /[A-z]{6,20}/.test(password.value)){
        submit.disabled = false;
        submit.style.backgroundColor = '#f00';
    }
    else {
        submit.disabled = true;
        submit.style.backgroundColor = '#f999';
    }
}
//изменение формы регистрации
form_reg.addEventListener("input", form_reg_change);
function form_reg_change(event) {
    event.preventDefault();
    if(/@/.test(email_reg.value) && /[A-z]{6,20}/.test(password_reg.value) && password_reg.value == password_regrerly.value && /[А-Я]{1}[а-я]+(\s[А-Я]{1}[А-я]+)+(\s[А-Я]{1}[А-я]+)/g.test(fio.value)){
        submit_reg.disabled = false;
        submit_reg.style.backgroundColor = '#f00';
    }
    else {
        submit_reg.disabled = true;
        submit_reg.style.backgroundColor = '#f999';
    }
}
//клик кнопки авторизации
submit.addEventListener("click", click_sign)
function click_sign(event) {
    event.preventDefault();
    alert("Пользователь авторизирован");
} 
//клик кнопки регистрации
submit_reg.addEventListener("click", click_reg)
function click_reg(event) {
    event.preventDefault();
    alert("Пользователь зарегистрирован");
}
//валидация эл.почты авторизации
email.addEventListener("input", Email)
function Email() {
    const emailError = document.getElementById('EmailError');
    if(!/@/.test(email.value)) {
        emailError.innerHTML = "<p>Неверный формат электр. почты</p>";
    }
    else {
        emailError.innerHTML = "";
        
    }
}
//валидация пароля авторизации
password.addEventListener("input", Password)
function Password() {
    const passwordError = document.getElementById('PasswordError');
    if(!/[A-z]{6,20}/.test(password.value)) {
        passwordError.innerHTML = "<p>Пароль должен быть не менее 7 и не более 20 символов</p>";
    }
    else {
        passwordError.innerHTML = "";
    }
} 
//валидация ФИО
fio.addEventListener("input", FIO);
function FIO(event) {
    const fioError = document.getElementById("fioError");
    var str = event.target.value.replace(/[^А-Я ]+/ig, "");
    fio.value = str;
    if(!/[А-Я]{1}[а-я]+(\s[А-Я]{1}[А-я]+)+(\s[А-Я]{1}[А-я]+)/g.test(str)) {
        fioError.innerHTML = "<p>ФИО должно вводиться только русскими буквами. Первая буква должна быть заглавной.</p>";
    }
    else {
        fioError.innerHTML = "";
    }
}
//валидация эл.почты регистрации
email_reg.addEventListener("input", Email_reg)
function Email_reg() {
    const emailError_reg = document.getElementById('EmailError_reg');
    if(!/@/.test(email_reg.value)) {
        emailError_reg.innerHTML = "<p>Неверный формат электр. почты</p>";
    }
    else {
        emailError_reg.innerHTML = "";
    }
}
//валидация пароля регистрации
password_reg.addEventListener("input", Password_reg) 
function Password_reg() {
    const passwordError_reg = document.getElementById('PasswordError_reg');
    if(!/[A-z]{6,20}/.test(password_reg.value)) {
        passwordError_reg.innerHTML = "<p>Пароль должен быть не менее 7 и не более 20 символов</p>";
    }
    else {
        passwordError_reg.innerHTML = "";
    }
}
//проверка совпадений пароля регистрации
password_regrerly.addEventListener("input", Password_regreply)
function Password_regreply() {
    const passwordError_regrerly = document.getElementById("PassordError_regreply");
    if(!(password_reg.value == password_regrerly.value)) {
        passwordError_regrerly.innerHTML = "<p>Пароли должны совпадать</p>";
    }
    else {
        passwordError_regrerly.innerHTML = "";
    }
}