module a {
    class A2 {
        //x
        static x: string;
        // blahblah
        static blahblah: string;
    }

    // Renamed
    class TestName {
        //x
        static x: string;
        // blahblah

        static blahblah: string;
    }

}


class MoveTypeToAnotherNamespace {

}

//Abc
class Abc {
    constructor(say: number);
    constructor(public say1: number) {
        let say2 = say1;
        var s = say2;
    }

    static say(s: string) {
        Abc.say("asd");
    }
}

interface Person {
    //firstName1
    firstName1: string;
    lastName: string;
}
function greeter(person: Person) {
    let string1 = "Hello, " + person.firstName1 + " " + person.lastName;
    //string
    return string1;
}

class ReproClass {
    private _saturation = 0;
    private _saturation2 = 0;

    get PropertyName() {
        return this._saturation;
    }

    get PropertyName2() {
        return this._saturation2;
    }
}