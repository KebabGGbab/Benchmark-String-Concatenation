# Benchmark-String-Concatenation
Using this benchmark, you can determine the fastest and least expensive computer resource-consuming method of joining strings
I analyzed the 8 string concatenation methods I chose:
* Interpolation
* Concatenation
* `String.Concat(string, string)`
* `string.Join(string[])`
* `string.Format(string, string)`
* `new StringBuilder(string).Append(string).ToString()`
* `new string(char[])`
* `string.Join("", List<string>)`<br>
The benchmark results are presented in the screenshot:
![image](https://github.com/KebabGGbab/Benchmark-String-Concatenation/assets/135259846/4baebb9a-65dc-42fb-ac43-6b9d0c9a02e7)
