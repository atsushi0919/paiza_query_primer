﻿using System;

namespace _02_04_accounting
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
経理 (paizaランク B 相当)
問題にチャレンジして、ユーザー同士で解答を教え合ったり、コードを公開してみよう！

シェア用URL:
https://paiza.jp/works/mondai/query_primer/query_primer__accounting
問題文のURLをコピーする
 下記の問題をプログラミングしてみよう！
paiza には N 個の部署があり、名前はそれぞれ S_1 ... S_N です。
経理係となったあなたは、どの部署が何円のどのような買い物をしたかを記録するように言われました。
どの部署が何円で何を買ったかの領収書が K 枚与えられるので、各部署の会計表を作成しましょう。

▼　下記解答欄にコードを記入してみよう

入力される値
N K
S_1
...
S_N
A_1 P_1 M_1
...
A_K P_K M_K


・1 行目では、部署の数 N と与えられる領収書の枚数 K が与えられます。
・続く N 行のうち、 i 行目では、i 番目に登録されている部署名 S_i が与えられます。
・続く K 行のうち、 i 行目では、 i 枚目の領収書に書かれていた部署名 A_i , 注文番号 P_i , その金額 M_i が半角スペース区切りで与えられます。

入力値最終行の末尾に改行が１つ入ります。
文字列は標準入力から渡されます。 標準入力からの値取得方法はこちらをご確認ください
期待する出力
S_1
P_1 M_1
...
-----
S_2
P_1 M_1
...
-----
...
-----
S_N
P_1 M_1
...
-----


・各部署について次の形式で出力してください。
・1 行目では、登録されている部署名 S_i を出力してください。
・2 行目以降には、注文番号 P_1 ... とその値段 M_1 ... を入力された順に半角スペース区切りで出力してください。
・各部署の出力の後ろに以下の通り区切りを出力してください。
-----


・詳しくは入出力例を参考にしてください。
・また、出力の末尾には改行を入れてください。
条件
・1 ≦ N ≦ 100,000
・1 ≦ K ≦ 100,000
・A_i は S_j のいずれか (1 ≦ i ≦ K , 1 ≦ j ≦ N)
・S_i は 20 文字以下の文字列 (1 ≦ i ≦ N)
・0 ≦ P_i ≦ 10^10 (1 ≦ i ≦ K)
・1 ≦ M_i ≦ 10,000 (1 ≦ i ≦ K)

入力例1
3 6
A
B
C
A 1 100
B 2 100
A 3 500
C 4 895
C 5 890
A 6 2685

出力例1
A
1 100
3 500
6 2685
-----
B
2 100
-----
C
4 895
5 890
-----

入力例2
4 5
ed
bjd
bdkf
fkoe
ed 20 2093
ed 584 3388
ed 31737 3885
ed 023748 9300
fkoe 82928 274

出力例2
ed
20 2093
584 3388
31737 3885
023748 9300
-----
bjd
-----
bdkf
-----
fkoe
82928 274
-----
*/