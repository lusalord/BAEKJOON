# [Ruby V] Fast Spanning Tree - 18473 

[문제 링크](https://www.acmicpc.net/problem/18473) 

### 성능 요약

메모리: 113172 KB, 시간: 852 ms

### 분류

자료 구조, 분리 집합, 우선순위 큐, 작은 집합에서 큰 집합으로 합치는 테크닉

### 제출 일자

2026년 4월 15일 22:49:43

### 문제 설명

<p>Wang Xiuhan has an initially empty undirected graph on n vertices.</p>

<p>Each vertex has a weight, which is a non-negative integer.</p>

<p>Also, he has m tuples (a<sub>i</sub>, b<sub>i</sub>, s<sub>i</sub>), where 1 ≤ a<sub>i</sub>, b<sub>i</sub> ≤ n, a<sub>i</sub> ≠ b<sub>i</sub>, and s<sub>i</sub> is a non-negative integer.</p>

<p>After that, he starts the following process:</p>

<ul>
	<li>If there is no such i that a<sub>i</sub> and b<sub>i</sub> lie in different connected components of the graph and (total weight of vertices in the component of a<sub>i</sub>) + (total weight of vertices in the component of b<sub>i</sub>) ≥ s<sub>i</sub>, end the process.</li>
	<li>Otherwise, choose the smallest such i, add an edge between a<sub>i</sub> and b<sub>i</sub> to the graph, write this i in the notepad, and repeat the process (but now on the larger graph).</li>
</ul>

<p>After the process was completed, a misfortune happened... Someone stole his notepad! Can you help him restore all numbers efficiently?</p>

### 입력 

 <p>The first line of input contains two integers n and m: the number of vertices in Xiuhan’s graph and the number of tuples he has (1 ≤ n, m ≤ 300 000).</p>

<p>The second line contains n space-separated integers, w<sub>1</sub>, w<sub>2</sub>, . . . , w<sub>n</sub>: weights of the vertices (0 ≤ w<sub>i</sub> ≤ 10<sup>6</sup>).</p>

<p>The next m lines contain a description of Xiuhan’s tuples. Each of these lines contains three integers a<sub>i</sub>, b<sub>i</sub>, s<sub>i</sub> (1 ≤ a<sub>i</sub>, b<sub>i</sub> ≤ n, a<sub>i</sub> ≠ b<sub>i</sub>, 0 ≤ s<sub>i</sub> ≤ 10<sup>6</sup>).</p>

### 출력 

 <p>On the first line, print one integer: the number of integers Xiuhan wrote in the notepad.</p>

<p>On the next line, you should write all these integers in the order he wrote them.</p>

