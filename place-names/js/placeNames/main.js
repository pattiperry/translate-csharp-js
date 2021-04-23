// Put your code here

//array of places
let places = ["Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

console.log("   All Place Names ")

for(let place of places){
    console.log(place)
}


let theNames = names.filter((place) => {
    if (place.startsWith("The")) {
      return place;
    }
  });
  
  console.log("'The' Place Names");
  theNames.forEach((place) => console.log(place));