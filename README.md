<h1 align="center">Welcome to TestProyTDD 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-1.0-blue.svg?cacheSeconds=2592000" />
  <a href="#" target="_blank">
    <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  </a>
  <a href="https://twitter.com/rayrogarr" target="_blank">
    <img alt="Twitter: rayrogarr" src="https://img.shields.io/twitter/follow/rayrogarr.svg?style=social" />
  </a>
</p>

> Tecnical test for .Net software developer position &#34;Next Permutation Exercise&#34;

## Author

👤 **Ing. Raymundo Rodríguez García**

* Twitter: [@rayrogarr](https://twitter.com/rayrogarr)
* Github: [@rayrogar](https://github.com/rayrogar)
* LinkedIn: [@rayrogar](https://linkedin.com/in/rayrogar)

## Test Description
  <h2 align = "center"> Next Permutation 🧮</h2>

  A permutation of an array of integers is an arrangement of its members into a sequence or linear order.

For example, for arr = [1,2,3], the following are all the permutations of arr: [1,2,3], [1,3,2], [2, 1, 3], [2, 3, 1], [3,1,2], [3,2,1].
The next permutation of an array of integers is the next lexicographically greater permutation of its integer. More formally, if all the permutations of the array are sorted in one container according to their lexicographical order, then the next permutation of that array is the permutation that follows it in the sorted container. If such arrangement is not possible, the array must be rearranged as the lowest possible order (i.e., sorted in ascending order).

For example, the next permutation of arr = [1,2,3] is [1,3,2].
Similarly, the next permutation of arr = [2,3,1] is [3,1,2].
While the next permutation of arr = [3,2,1] is [1,2,3] because [3,2,1] does not have a lexicographical larger rearrangement.
Given an array of integers nums, find the next permutation of nums.

The replacement must be in place and use only constant extra memory.

**Example 1**
```
Input: nums = [1,2,3]
Output: [1,3,2]
```
**Example 2**
```
Input: nums = [3,2,1]
Output: [1,2,3]
```
**Example 3**
```
Input: nums = [1,1,5]
Output: [1,5,1]
```
**Constraints:**
```
1 <= nums.length <= 100
0 <= nums[i] <= 100
```

**Final remarks** 📝

• You can add whatever technology or best practice you know . This means you should, on top of the best solution, use:
Docker, linters, microservices, etc.

• For the chosen technology that must be used modern standards of the language. C# | min C++ 17.

      • For solutions developed in C#, minimum .NET 6.0 framework is a must.
• Minimum code coverage must be 85%.

• There must be Unit, Integration and E2E tests.

• The system should be designed with caching and scalability in mind.

• Use git commits and good practices which you can think of.

• You have 7 days to complete the exercise, but feel free to submit earlier if you finish it before.

• Write the program using TDD or BDD techniques.

• Upload the code to a public GitHub repository and share the link with us.


****VIP BONUS TIP: Get [more] the attention of our experts and deliver a deployed version of the solution. Eg: CI/CD pipeline
using GitLab CI or GitHub Actions.**


## Aproach

The problem asked to us to give an integer array that is the next permutation of an array enter by params. What is that? Well, it is a permutation of the numbers in that array that represents exactly one place begger in the array of all permutation of these numbers.

With this in mind, we can generate all the ordered permutation of those numbers or at least those permutation until we reach the array given to us, then return the next permutation. It sounds kind of easy but, they told us to do that work "In Place", with only constant extra memory. 

After I generated some permutation for aleatory arrays, I figured out that to generate the next permutation we first try to move the last number -in the futute source(s)- of the array to the first left position in where that value is less than 's' -in the future target(t)-. If we couldn't, we move to the next left number. If we can't move any number is because we found the bigger permutation, so revert the array and return the answer. 

This is not completly right because in this situation [1,3,4,2] it's better to move the 4 in 3rd position than the 2 in the last position, sence [1,4,2,3] < [2,1,3,4]. So we need to adjust the algoritm, and how we do that? Well if we find another two candidates in between our first choice that full fill the conditions for the swap, those candidates will become our answer and look first for anothers two candidates in between them. Notice in the example that the next permutation for [1,4,3,2] it is [1,4,2,3] and don't [1,4,3,2] that we get after swap the 4 int the 3rd position with the 3 in the 2nd position. That is because [1,4,2,3] < [1,4,3,2] and how we solved that new issue? Well, we could sort the array at the rigth of the 's' position so we get the less array posible, because always ascending array is less than descending array.

I hope that this explanation it is clear enough!!


  

## Show your support

Give a ⭐️ if this project helped you!

***
_This README was generated with ❤️ by [readme-md-generator](https://github.com/kefranabg/readme-md-generator)_
