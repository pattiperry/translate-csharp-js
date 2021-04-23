// Put your code here



const Enemy = (firstName, lastName, isReallyHated, offenses) => {
    return {
        FirstName: firstName,
        LastName: lastName,
        IsReallyHated: isReallyHated,
        Offenses: offenses,
    };
};

const GetEnemies = () => 
{
    const enemies = [
        Enemy(
            "Joshua",
            "Flowers",
            true,
            "Being a jerk to me in elementary school", 
            "Not being nice to me in elementary school"
            
        ),
        Enemy(
            "Darth",
            "Vader",
            false,
            "Cut off Luke's hand",
            "Murdered all those kids", 
            "Unkind management practices"
        ),
        Enemy(
            "Betty",
            "Rudelady",
            true,
            "Phone calls in the theater",
            "Phone calls on the bus", 
            "Phone calls in line at the grocery store", 
            "Poor conversationalist"
        ),
        Enemy(
            "Leon",
            "Peck",
            false,
            "Keeps giving me a hotplate"
        )
    ]
    return enemies
}

console.log("My Enemies List")
console.log("---------------")
const enemies = GetEnemies()

for(let myEnemy of enemies) {
    if(myEnemy.IsReallyHated)
    {
        console.log(`${myEnemy.FirstName} ${myEnemy.LastName} (Really, really hated)`)
    }
    else 
    {
        console.log(`${myEnemy.FirstName} ${myEnemy.LastName}`)
    }
}


    
       
    
    
        
    
    
    
         
    






