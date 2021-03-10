class IntroduceFieldTestTS {
    greeting: string = "someString";
    age: number = 1;
    static age2: number = 1;
    readonly y?: number = 1;

    static greetingStatic: string = "someString";

    constructor(greeting: string) {
        this.greeting = greeting;
        const testConst: number = 1;

        let test: number = 1; // invoke on test
        let test2: Greeter12 = new Greeter12();

        this.age++; //c-or
        test++; // current method
        this.age++; // field}

    }

    greet(greeting: string): number {
        this.greeting = greeting;
        const testConst: number = 1;

        let test: number = 1; // invoke on test
        let test2: Greeter12 = new Greeter12();

        this.age++; //c-or
        test++; // current method
        this.age++; // field}

        return 0;
    }

    static greet2(greeting: string): number {
        const testConst: number = 1;

        let test: number = 1; // invoke on test
        let test2: Greeter12 = new Greeter12();

        test++; // current method
        this.age2++;
        return 0;
    }

    get Name(): string { return null; }

    set Name(value: string) { value = "someString1" }
}

const greetingConst: string = "someString"; // invoke on "someString"

class Greeter12 {
    greeting: string;

    constructor(message: string);
    constructor();
    constructor(message?: string) {
        this.greeting = message;
    }
    greet(): string {
        return "Hello, " + this.greeting;
    }
}

class Test {

    greetTest(): void {
        let test: number = 1; // invoke on test

        test++;
    }
}