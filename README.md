# My first Webapi in .NET
> By Valentina Orjuela Tapia

---
In this challenge 4, you will be able to see a webapi with access to a database using Entity Framework Core.

### GET
```html
 public IEnumerable<Person> Get()
        {
            using (var context = new AdventureWorks2019Context())
            {
                //get all People
                return context.People.ToList();

                //get Person by BussinesEntityID
                return context.People.Where(pe => pe.BusinessEntityId == 1).ToList();

            }
        }
```

### POST
```html
public IEnumerable<Culture> Get()
        {
            using (var context = new AdventureWorks2019Context())
            {
                //Add culture
                Culture culture = new Culture();
                culture.CultureId = "VOT";
                culture.Name = "Danzas";

                context.Cultures.Add(culture);
                context.SaveChanges();
                return context.Cultures.Where(cul => cul.CultureId == "VOT").ToList();
            }
        }
```

### DELEETE
```html
public IEnumerable<Person> Get()
        {
            using (var context = new AdventureWorks2019Context())
            {
                //delete BussinesEntityAddress
                Person persona = context.People.Where(per => per.BusinessEntityId == 2).FirstOrDefault();
                context.People.Remove(persona);

                context.SaveChanges();

                return context.People.Where(per => per.BusinessEntityId == 2).ToList();
            }
        }
```

---

### SQL query
```html
select  MiddleName, count(*)
from Person.Person
group by MiddleName
having count(*) > 20;
```
