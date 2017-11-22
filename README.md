# Statistics Extension Methods
Mean, Variance, Standard Deviation as IEnumerable extensions

# Features!

 - IEnumerable Extension methods for Variance and Standrad Deviation.
    ```sh
    new IEnumerable<Int32>(){1,2,3,4,5,6}.Variance();
    ```
- Extension methods for Average, Variance and Standard Deviation for field in List<Class>
   For example:
  ```sh
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            double Median = employees.Median(i => Convert.ToDouble(i.Age));
    ```
