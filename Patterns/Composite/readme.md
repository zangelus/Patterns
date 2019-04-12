1. When to use it

The Composite pattern is usefull when hierarchical or heterogeneus data have to be treated with uniformity. This means,treating data without having to cast objects, evaluate their type, check if the object is a parent or a child or if an object contain other objects prior to calling a method.

"is useful anytime you may need to selectively treat a group of objects that are part of a hierarchy as "the same" when they are in fact different"

<img src="../images/Composite.png">

2. Unit test results 

```xml
<doc>
  <pag>
    <para>
      <il>Lorem ipsum dolor sit amet, </il>
      <il>consectetur adipiscing elit.</il>
    </para>
    <para>
      <il>Nulla molestie nibh id dui fringilla bibendum.</il>
      <il>Quisque sed risus ut tellus varius</il>
    </para>
  </pag>
</doc>
```
