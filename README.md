# Example of S.O.L.I.D and Good Practices
This project was built with the goal to show a few of the most used patterns, good practices of programming and the practical application of S.O.L.I.D concepts .

### **What is S.O.L.I.D?**
SOLID is a concept promoted by [Robert C. Martin](https://en.wikipedia.org/wiki/Robert_C._Martin), also known as Uncle Bob, that aggregates five programming design principles with the aim of making the application code more readable, expandable and maintainable.
The word "SOLID" is a acronym that means:
* **S** -> Single Responsability Principle
* **O** -> Open/Closed Principle
* **L** -> Liskov Substitution Principle
* **I** -> Interface Segregation Principle
* **D** -> Dependency Inversion Principle

**TODO** Description of each one.

### **Design Patterns**
#### What is "Design Patterns"?
Design patterns are a group of common solutions for common problems.  
Here we have implemented two of them, **Factory** and **Template Method**.

#### **TEMPLATE METHOD**
According the site [OODesign](http://www.oodesign.com/template-method-pattern.html): *"A template method defines an algorithm in a base class using abstract operations that subclasses override to provide concrete behavior."*  
In short: We can define pieces of a algorithm thats allow the implementation of one or more of these steps by the subclasses.

[Example of a Template Method implementation](solid/Sample2/BankTemplate.cs)

#### **FACTORY**
According the site [OODesign](http://www.oodesign.com/factory-pattern.html): *"Creates objects without exposing the instantiation logic to the client and refers to the newly created object through a common interface"*

[Example of a Factory implementation](solid/Sample2/BankFactory.cs)

## Learn more:
[Gang of Four](http://www.blackwasp.co.uk/gofpatterns.aspx)  
[Design patterns](http://www.oodesign.com/)  
[SOLID](https://scotch.io/bar-talk/s-o-l-i-d-the-first-five-principles-of-object-oriented-design)  