# Tuto SQL


## 1. Create a table
### multi-line form (standard):
```SQL
CREATE TABLE Vehicle (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name NVARCHAR(20),
    price DOUBLE(9, 2),
    year UINT,
    note NVARCHAR(200)
);
```
### one-line form:
```SQL
CREATE TABLE Vehicle (id INTEGER PRIMARY KEY AUTOINCREMENT, name NVARCHAR(20), price DOUBLE(9,2), year UINT, note NVARCHAR(200));
```

- [https://www.w3schools.com/sql/sql_create_table.asp](https://www.w3schools.com/sql/sql_create_table.asp)


## 2. Insert records
### 2.1 Insert 1 record
```SQL
INSERT INTO Vehicle (name, price, year, note)
VALUES ('Toyota Camry', 25000.00, 2022, 'Excellent condition, low mileage.');
```

### 2.2 Insert 2 records
```SQL
INSERT INTO Vehicle (name, price, year, note)
VALUES
    ('Toyota Camry', 25000.00, 2022, 'Excellent condition, low mileage.'),
    ('Honda Accord', 22000.50, 2023, 'Brand new, fully loaded.'),
    ('Ford Mustang', 35000.75, 2021, 'Low mileage, well-maintained.');
```
### 2.3 Link
- [https://www.w3schools.com/sql/sql_insert.asp](https://www.w3schools.com/sql/sql_insert.asp)

## 3. Display records
```SQL
SELECT * FROM Vehicle;
```

## 4. Empty only records of a table
```SQL
DELETE FROM Vehicle;
```


## 5. Delete the table
```SQL
DROP TABLE IF EXISTS Vehicle;
```

## ChatGPT prompts

### Create a table
```
Write me a SQL request for **sqlite** that create a table named "Vehicle" with an id field which is primary key and is auto-incremented. This table will as fields:
1. "name" nvarchar 20
2. "price" double 99,999.99
3. "year" uint
4. "note" nvarchar 200

The sql request must be in a single line form.
```