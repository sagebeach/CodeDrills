function getTotalStart() {
  OrderItems = "";
  RunningPrice = "";
  var runningTotal = 0; //this initializes the runningTotal that will be added onto by the rest of the script.
  var sizeCost = 0; //variable controls the price of the pizza size
  var sizeArray = document.getElementsByName('Size'); //var controls the creation of an array containing the values of the inputs contained within the name selector.
  var sizeChoice;
  for (var i = 0; i < sizeArray.length; i++) { //this loops the if condition for each iteration in the array stored within sizeArray
    if(sizeArray[i].checked) { //asks if the current element in the array is checked
      sizeChoice = sizeArray[i].value; //on true - creates a variable that containes the variable name of the user selected value.
      OrderItems = OrderItems+sizeChoice+"<br>"; //this outputs the variable int/strings to the html modal 'reciept'
    }
  }
  //sets the cost of the pizza for the calculation
  if (sizeChoice === "Personal") {
    sizeCost = 6;
    RunningPrice = RunningPrice+sizeCost+"<br>";
  } else if (sizeChoice === "Medium") {
      sizeCost = 10;
    RunningPrice = RunningPrice+sizeCost+"<br>";
  } else if (sizeChoice === "Large") {
      sizeCost = 14;
    RunningPrice = RunningPrice+sizeCost+"<br>";
  } else if (sizeChoice === "Extra Large") {
      sizeCost = 16;
    RunningPrice = RunningPrice+sizeCost+"<br>";
  }
  runningTotal = sizeCost; //adds the cost of the pizza size to the runing total
  getCrust(runningTotal,OrderItems,RunningPrice); //passes the relevant variables into the next function
}

//crust choices, conditionally adds to runningTotal
function getCrust(runningTotal,OrderItems,RunningPrice) {
  var crustCost = 0;
  var crustChoice; //adds the name of the selected crust value onto the 'reciept' modal
  var crustArray = document.getElementsByName('Crust'); //creates an array of the crust values
  for (var j = 0; j < crustArray.length; j++) {
    if (crustArray[j].checked) { //same function as the sizeArray
      crustChoice = crustArray[j].value;
      OrderItems = OrderItems + crustChoice +"<br>";
    }
    if (crustChoice === "Cheese Stuffed Crust") { //Cheese Stuffed crust costs an additional $3.
      crustCost = 3; //Specifies change in price to the variable crustCost rather than the runningTotal because if later options also have an additional cost then they can be added in easier.
    }
  }
  runningTotal = (runningTotal + crustCost); //adds any additional cost from the crust onto the runningTotal
  RunningPrice = RunningPrice + crustCost + "<br>";
  getSauce(runningTotal,OrderItems,RunningPrice); //passes the relevant variables into the next function
}

//Sauce choices handler
function getSauce(runningTotal,OrderItems,RunningPrice) { //passes the relevant variables into the next function
  var sauceCost = 0; //Currently no additional charges apply to sauce options, this variable is initialized for future proofing additions of new options.
  var sauceChoice;
  var sauceArray = document.getElementsByName('Sauce');
  for (var k = 0; k < sauceArray.length; k++) {
    if (sauceArray[k].checked) {
      sauceChoice = sauceArray[k].value; //collects the name of the sauce value to add to the 'reciept'
      OrderItems = OrderItems + sauceChoice +"<br>";
    }
    //add future option price increases here
  }
  runningTotal = (runningTotal + sauceCost);
  RunningPrice = RunningPrice + sauceCost + "<br>";
  getVegetables(runningTotal,OrderItems,RunningPrice);
}

//Vegetable choices, requires different handling because this user input is provided by check boxes.
function getVegetables(runningTotal,OrderItems,RunningPrice) {
  var vegetablesCost = 0;
  var vegetablesChoices = []; //initializes this variable as an array so it can collect the names of multiple selected values.
  var vegetablesArray = document.getElementsByName('Vegetables');
  for (var l = 0; l < vegetablesArray.length; l++) {
    if (vegetablesArray[l].checked) {
      vegetablesChoices.push(vegetablesArray[l].value);
    }
  }
  var vegetablesCount = vegetablesChoices.length;
  if (vegetablesCount >= 2) {
    vegetablesCost = (vegetablesCount - 1);
  } else {
    vegetablesCost = 0;
  }
  runningTotal = (runningTotal + vegetablesCost);
  for (var l = 0; l < vegetablesChoices.length; l++) {
    OrderItems = OrderItems + vegetablesChoices[l] + "<br>";
    if (vegetablesCount <= 1) {
      RunningPrice = RunningPrice + 0 + "<br>";
      vegetablesCount = vegetablesCount - 1;
    } else if (vegetablesCount == 2){
      RunningPrice = RunningPrice + 1 + "<br>";
      vegetablesCount = vegetablesCount - 1;
    } else {
      RunningPrice = RunningPrice + 1 + "<br>";
      vegetablesCount = vegetablesCount - 1;
    }
  }
  getMeats(runningTotal,OrderItems,RunningPrice);
}


//Meat choices; same handling as vegetable choices.
function getMeats(runningTotal,OrderItems,RunningPrice) {
  var meatsCost = 0;
  var meatsChoices = []; //initializes this variable as an array so it can collect the names of multiple selected values.
  var meatsArray = document.getElementsByName('Carnivore');
  for (var l = 0; l < meatsArray.length; l++) {
    if (meatsArray[l].checked) {
      meatsChoices.push(meatsArray[l].value);
    }
  }
  var meatsCount = meatsChoices.length;
  if (meatsCount >= 2) {
    meatsCost = (meatsCount - 1);
  } else {
    meatsCost = 0;
  }
  runningTotal = (runningTotal + meatsCost);
  for (var l = 0; l < meatsChoices.length; l++) {
    OrderItems = OrderItems + meatsChoices[l] + "<br>";
    if (meatsCount <= 1) {
      RunningPrice = RunningPrice + 0 + "<br>";
      meatsCount = meatsCount - 1;
    } else if (meatsCount == 2){
      RunningPrice = RunningPrice + 1 + "<br>";
      meatsCount = meatsCount - 1;
    } else {
      RunningPrice = RunningPrice + 1 + "<br>";
      meatsCount = meatsCount - 1;
    }
  }
  getCheese(runningTotal,OrderItems,RunningPrice);
}

//test code rework
/*function getMeats(runningTotal,OrderItems,RunningPrice) {
  var meatsCost = 0;
  var meatsChoices = []; //initializes this variable as an array so it can collect the names of multiple selected values.
  var meatsArray = document.getElementsByName('Carnivore');
  for (var j = 0; j < meatsArray.length; j++) {
    if (meatsArray[j].checked) {
      meatsChoices.push(meatsArray[j].value);
    }
  }
  var meatsCount = meatsChoices.length;
  if (meatsCount > 1) {
    meatsCost = (meatsCount - 1);
  } else {
    meatsCost = 0;
  }
  runningTotal = (runningTotal + meatsCost);
  for (var j = 0; j < meatsChoices.length; j++) {
    OrderItems = OrderItems + meatsChoices[j] + "<br>";
    if (meatsCount <= 1) {
      RunningPrice = RunningPrice + 0 + "<br>";
      meatsCount = meatsCount - 1;
    } else if (meatsCount == 2){
      MeatsPrice = MeatsPrice + 1 + "<br>";
      meatsCount = meatsCount - 1;
    } else {
      RunningPrice = RunningPrice + 1 + "<br>";
      meatsCount = meatsCount - 1;
    }
  }
  getCheese(runningTotal,OrderItems,RunningPrice);
} */

//Cheese options; same handling as crust
function getCheese(runningTotal,OrderItems,RunningPrice) {
  var cheeseCost = 0;
  var cheeseChoice; //adds the name of the selected cheese value onto the 'reciept' modal
  var cheeseArray = document.getElementsByName('Cheese'); //creates an array of the cheese values
  for (var p = 0; p < cheeseArray.length; p++) {
    if (cheeseArray[p].checked) { //same function as the sizeArray
      cheeseChoice = cheeseArray[p].value;
      OrderItems = OrderItems + cheeseChoice +"<br>";
    }
    if (cheeseChoice === "Extra Cheese") { //Extra cheese costs an additional $3.
      cheeseCost = 3; //Specifies change in price to the variable cheeseCost rather than the runningTotal because if later options also have an additional cost then they can be added in easier.
    }
  }
  runningTotal = (runningTotal + cheeseCost); //adds any additional cost from the crust onto the runningTotal
  RunningPrice = RunningPrice + cheeseCost +"<br>";
  document.getElementById("ShowOrderItems").innerHTML=OrderItems;
  document.getElementById("ShowRunningPrice").innerHTML=RunningPrice;
  document.getElementById("TotalPriceValue").innerHTML = "</h3>$"+runningTotal+".00"+"</h3>";
};
