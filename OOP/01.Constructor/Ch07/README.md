# (User-Defined) Static Constructor

## 목표

## 정적 생성자
- 정적 생성자는 클래스에 오직 1개만 존재할 수 있다.
- 정적 생성자는 매개변수를 갖지 않는다.
- 정적 생성자는 접근 제어자를 지정할 수 없다.
- 정적
  - 정적 생성자는 정적 멤버 변수만 접근할 수 있다.
  - 정적 생성자는 한번만 호출된다.
There can be only one static constructor in a class.
The static constructor should be without any parameters.
It can only access the static members of the class.
There should not be any access modifier in the static constructor definition.
If a class is static then we cannot create the object for the static class.
Static constructor will be invoked only once i.e. at the time of first object creation of the class, from 2nd object creation onwards static constructor will not be called.
