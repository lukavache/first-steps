const name = document.getElementById('name')
const lname = document.getElementById('lname')
const email = document.getElementById('email')
const mobile = document.getElementById('mobile')
const password = document.getElementById('password')
const rpassword = document.getElementById('rpassword')
const form = document.getElementById('form')
const errorElement = document.getElementById('error')

name.addEventListener('input', validate);
lname.addEventListener('input', validate);
password.addEventListener('input', validate);
rpassword.addEventListener('input', validate);
email.addEventListener('input', validate);
mobile.addEventListener('input', validate);

const pass_reg = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$/;

function validate (e) {
    let target = e.target;

    if (e.target.name == "name") {
     if (e.target.value.length > 5) {
      e.target.classList.add('valid');
      e.target.classList.remove('invalid');
     } else {
      e.target.classList.add('invalid');
      e.target.classList.remove('valid');
     }
    }

    if (e.target.name == "lname") {
     if (e.target.value.length > 5) {
      e.target.classList.add('valid');
      e.target.classList.remove('invalid');
     } else {
      e.target.classList.add('invalid');
      e.target.classList.remove('valid');
     }
    }

    if (e.target.name == "email") {
    if (CheckEmail(e.target)) {
        e.target.classList.add('valid');
        e.target.classList.remove('invalid');
       } else {
        e.target.classList.add('invalid');
        e.target.classList.remove('valid');
       }
   }

    if (e.target.name == "mobile") {
    if (CheckMobile(e.target) === 1) {
        e.target.classList.add('valid');
        e.target.classList.remove('invalid');
       } else {
        e.target.classList.add('invalid');
        e.target.classList.remove('valid');
       }
   }

    if (e.target.name == "password") {
    if (pass_reg.test(e.target.value)) {
        e.target.classList.add('valid');
        e.target.classList.remove('invalid');
       } else {
        e.target.classList.add('invalid');
        e.target.classList.remove('valid');
       }
   }

    if (e.target.name == "rpassword") {
    if (password.value == rpassword.value) {
        e.target.classList.add('valid');
        e.target.classList.remove('invalid');
       } else {
        e.target.classList.add('invalid');
        e.target.classList.remove('valid');
       }
    }
}
    


function ShowError(input, message) {
    const formControl = input.parentElement;
    formControl.className = "form-group error";
    const small = formControl.querySelector('small');
    small.innerText = message;
}


function ShowSuccess(input) {
    const formControl = input.parentElement;
    formControl.className = "form-group success";
}

function CheckEmail(input) {
    const char = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (char.test(input.value.trim())) {
      ShowSuccess(input);
    }else {
      ShowError(input, "Email is not valid");
    }
}

function CheckMobile(input) {
    const char = /^\+?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$/;
    if (char.test(input.value.trim())) {
      ShowSuccess(input);
    }else {
      ShowError(input, "Mobile is not valid");
    }
}

function CheckRequired(inputErr) {
    inputErr.forEach(function(input){
      if (input.value.trim() === "") {
        ShowError(input, `${getFieldName(input)} is required`);
      }else {
        ShowSuccess(input);
      }
    });
}

function CheckLenght(input, min, max) {
    if (input.value.length < min) {
        ShowError(input, `${getFieldName(input)} must be at least ${min} characters`);
    }
    else if(input.value.length > max){
        ShowError(input, `${getFieldName(input)} must be less then ${max} characters`);
    }
    else {
        ShowSuccess(input);
    }
}

function CheckPasswordsMatch(input1,input2) {
    if (input1.value !== input2.value /*&& input1.value.length !== input2.value.length*/) {
        ShowError(input2, "Password do not match");
    }
}

function getFieldName(input) {
    return input.id.charAt(0).toUpperCase() + input.id.slice(1)
}







 form.addEventListener('submit', (e) => {
//     let messages = []
//     if (password.value.length <= 5) {
//         messages.push('Password must be longer than 5 characters');
//     }

//     if (password.value.length >= 10) {
//         messages.push('Password must be less than 10 characters');
//     }

//     if (password.value !== rpassword.value) {
//         messages.push('Passwords must be same');
//     }

//     if (password.value.length !== rpassword.value.length) {
//         messages.push('Password mismatch!');
//     }

    

    e.preventDefault();

    CheckRequired([name, lname, email, mobile, password, rpassword]);
    CheckLenght(name, 5, 15);
    CheckLenght(lname, 5, 15);
    CheckLenght(password, 5, 25);
    CheckEmail(email);
    CheckMobile(mobile);
    CheckPasswordsMatch(password, rpassword);
    //errorElement.innerText = messages.join('\n ');

    var name = document.getElementById('name').value
    var body = document.getElementById('form').value

    fetch("https://jsonplaceholder.typicode.com/posts/1",{
        method:'POST',
        body:JSON.stringify({
            title:name,
            body:form
        }),
        headers:{
            "Content-Type":"application/json; charset=UTF-8"
        }
    })
    .then(function(response){
        return response.json()
    })
    .then(function(data){
        console.log(data)
    })



});

var Input = document.getElementById('name');
var Input1 = document.getElementById('lname');
var Input2 = document.getElementById('email');
var Input3 = document.getElementById('mobile');
var Input4 = document.getElementById('password');
var Input5 = document.getElementById('rpassword');

document.querySelector('form').addEventListener('submit', function (e) {
    e.preventDefault();
    console.log(Input.value,Input1.value,Input2.value,Input3.value,Input4.value,Input5.value);    
});



function F1(ele, val)
{
    if (document.getElementById(ele) && val != "")
    {
        document.getElementById(ele).value = val;
    }
}

F1("name", "Jonny");
F1("lname", "Johnson");
F1("email", "JonnyJohnson@gmail.com");
F1("mobile", "1111111111");
F1("password", "John123");
F1("rpassword", "John123");

