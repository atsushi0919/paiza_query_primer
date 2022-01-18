﻿using System;

namespace _03_02_interval_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/*
区間和 (paizaランク C 相当)
問題にチャレンジして、ユーザー同士で解答を教え合ったり、コードを公開してみよう！

シェア用URL:
https://paiza.jp/works/mondai/query_primer/query_primer__interval_sum
問題文のURLをコピーする
 下記の問題をプログラミングしてみよう！
長さ N の数列 A と、K 個の区間 (l_1,r_1) ... (l_K,r_K) が与えられるので、各区間についての A の区間和 A_{l_i} + ... + A_{r_i} (1 ≦ i ≦ K) を求めてください。

▼　下記解答欄にコードを記入してみよう

入力される値
N K
A_1
...
A_N
l_1 r_1
...
l_K r_K


・1 行目では、配列 A の要素数 N と与えられる整数の数 K が与えられます。
・続く N 行では、配列 A の要素が A_1 から順に与えられます。
・続く K 行では、和を求めるのに使う区間の値 l , r が与えられます。

入力値最終行の末尾に改行が１つ入ります。
文字列は標準入力から渡されます。 標準入力からの値取得方法はこちらをご確認ください
期待する出力
ans_1
...
ans_K


・i 行目に A_{l_i} + ... + A_{r_i} の和 ans_i (1 ≦ i ≦ K)を出力してください。
・また、出力の末尾には改行を入れてください。
条件
・1 ≦ N , K ≦ 100,000
・-100 ≦ A_i ≦ 100 (1 ≦ i ≦ N)
・1 ≦ l_i ≦ r_i ≦ N (1 ≦ i ≦ K)

入力例1
4 2
16
88
10
-65
2 4
1 2

出力例1
33
104

入力例2
10 5
82
-37
40
-72
-24
-54
57
-6
42
-24
8 9
6 9
2 3
4 4
1 5

出力例2
36
39
3
-72
-11
*/