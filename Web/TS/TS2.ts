import { Student } from "./Student";

class Class2 {
    static x: string;

    constructor(public firstName: string, public middleInitial: string, public lastName: string) {
        new Student("Jane", "M.", "User");
    }
}