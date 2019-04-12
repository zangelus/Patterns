1. When to use it

The Composite pattern is usefull when hierarchical or heterogeneus data/objects have to be treated with uniformity (as if they were the same when indeed they are different). This means,treating data without having to cast objects, evaluate their type, check if the object is a parent or a child or if an object contain other objects prior to calling a method.

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
