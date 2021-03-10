#include "pch.h"
#include "CPP_Mix.h"
#define test1_2   1;
#include <iostream>
using namespace std;

class IntroduceFieldCpp123 {
public:
	char setWidth_New1(int w, bool b, int c) {
		width111 = w;
	}
	void setHeight(int h) {
		height = h;
	}

protected:
	int width111;
	int height;
};

// Base class PaintCost
class PaintCost {
public:
	void get_value(int& value, int areNnew)
	{
		value = areNnew * 70;
		return;
	}

	int getCost(int areNnew, char chara, char charInt, int t)
	{
		int value;
		get_value(value, areNnew);
		return value;
	}
};

// Derived class
class Rectangle1 : public IntroduceFieldCpp123, public PaintCost {
public:
	int getArea() {
		return (width111 * height);
	}
};

void do_not_do_work(Rectangle1& Rect, int& area)
{
	Rect.setWidth_New1(5, false, 0);
	Rect.setHeight(7);
}

int main(void) {
	Rectangle1 Rect;
	int area;
	do_not_do_work(Rect, area);

	area = Rect.getArea();

	// Print the area of the object.
	cout << "Total area: " << Rect.getArea() << endl;

	// Print the total cost of painting
	cout << "Total paint cost: $" << Rect.getCost(area, 'a', 'b', 2) << endl;

	return 0;
}

class Line12 {
public:
	void setLength_new1(int int_new, char len_some_New)&;
	unsigned getLength_New(void);
	Line12();  // This is the constructor
	~Line12();  // This is the destructor: declaration
	Line12(const Line12& obj);  // copy constructor
private:
	double length;
	int* ptr;
};

// Member functions definitions including constructor
Line12::Line12(void) {
	cout << "Object is being created" << endl;
}

void Line12::setLength_new1(int int_new, char len_some_New)&
{
	length = len_some_New;
}

unsigned Line12::getLength_New(void) {
	return length;
}

Line12::Line12(const Line12& obj) {
	cout << "Copy constructor allocating ptr." << endl;
	ptr = new int;
	*ptr = *obj.ptr; // copy the value
}

Line12::~Line12(void) {
	cout << "Object is being deleted" << endl;
}

// Main function for the program
int main1() {
	Line12 line;

	// set line length
	line.setLength_new1(0, 6.0);
	cout << "Length of line : " << line.getLength_New() << endl;

	return 0;
}

class Box {
public:
	double length;   // Length of a box
	double breadth;  // Breadth of a box
	double height;   // Height of a box
};

int* someOthereMain(int someName) {
	Box Box1;        // Declare Box1 of type Box
	Box Box2;        // Declare Box2 of type Box
	double volume = 0.0;     // Store the volume of a box here

							 // box 1 specification
	Box1.height = 5.0;
	Box1.length = 6.0;
	Box1.breadth = 7.0;

	// box 2 specification
	Box2.height = 10.0;
	Box2.length = 12.0;
	Box2.breadth = 13.0;

	// volume of box 1
	volume = Box1.height * Box1.length * Box1.breadth;
	cout << "Volume of Box1 : " << volume << endl;

	// volume of box 2
	volume = Box2.height * Box2.length * Box2.breadth;
	cout << "Volume of Box2 : " << volume << endl;
	return 0;
}
