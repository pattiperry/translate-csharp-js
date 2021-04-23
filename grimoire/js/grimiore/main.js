// Put your code here

const book = (name, isEvil, energyRequired ) => {
    return {
        Name: name,
        IsEvil: isEvil,
        EnergyRequired: energyRequired
    }
}

const GetAllBooks = () => 
{
    const books = [
        book(
           "Turn enemy into a newt",
           true,
           5.1
        ),
        book(
            "Conjure some gold for a local charity",
            false,
            2.99
        ),
        book(
            "Give a deaf person the ability to heal",
            false,
            12.2
        ),
        book(
            "Make yourself emperor of the universe",
            true,
            100.0
        ),
        book(
            "Convince your relative your political views are correct",
            false,
            2921.5
        )

    ]
    return books;
}

console.log("Do you believe in magic?")
console.log("------------------------")
const books = GetAllBooks()

for(let currentBook of books) {
    if(currentBook.IsEvil === true) 
    {
        console.log (`${currentBook.Name}`)
    }
    else (currentBook.IsEvil === false)
    {
        console.log (`${currentBook.Name} ${"   Yup I Am an Evil Book"}`)
    }
}
