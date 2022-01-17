﻿using System;

namespace _02_01_idle_group
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
アイドルグループ (paizaランク B 相当)
問題にチャレンジして、ユーザー同士で解答を教え合ったり、コードを公開してみよう！

シェア用URL:
https://paiza.jp/works/mondai/query_primer/query_primer__idle_group
問題文のURLをコピーする
 下記の問題をプログラミングしてみよう！
N 人組のロボットアイドルグループのマネージャーとなった paiza 君は、グループに所属しているアイドル全員の名前を把握しておく必要があります。アイドルグループにはメンバーの加入と脱退がつきものなので、そのたびにメンバーを覚えたり忘れたりする必要があります。
paiza 君は仕事として握手会の度にアイドル全員の名前を書き出します。
ロボットの名前はほとんどが乱数的に付けられたものなので覚えるのが大変です。
そこで、イベント（メンバーの加入・脱退と握手会）が与えられるので、それらに伴う paiza 君の仕事をおこなうプログラムを作成しましょう。

▼　下記解答欄にコードを記入してみよう

入力される値
N K
name_1
...
name_N
S_1
...
S_K


・1 行目では、アイドルグループの初期メンバー数 N とイベントの回数 K が与えられます。
・続く N 行では、N 人の初期メンバーの名前が与えられます。
・続く K 行では、起こったイベントを表す文字列が時系列順に与えられます。

入力値最終行の末尾に改行が１つ入ります。
文字列は標準入力から渡されます。 標準入力からの値取得方法はこちらをご確認ください
期待する出力
・握手会の予定に応じて出力してください。
具体的には handshake が与えられる度、その時点でのグループの全メンバーの名前を辞書順に改行区切りで出力してください。
・また、出力の末尾には改行を入れてください。

条件
・1 ≦ N , K ≦ 100,000
・name_i はアルファベット小文字(a ~ z)と数字(0 ~ 9)から成る 20 文字以下の文字列です。 (1 ≦ i ≦ N)
・S_i (1 ≦ i ≦ K) は次のいずれかの形式で与えられます。

・join name
name という名前のアイドルが加入することを表します。
name はアルファベット小文字(a ~ z)と数字(0 ~ 9)から成る 20 文字以下の文字列です。

・leave name
name という名前のアイドルが脱退することを表します。
name はアルファベット小文字(a ~ z)と数字(0 ~ 9)から成る 20 文字以下の文字列です。
脱退時に name という名前のアイドルがグループにいることが保証されています。

・handshake
握手会がおこなわれることを表します。
握手会時点でのグループの全メンバーの名前を辞書順に改行区切りで出力してください。
グループのメンバーが 0 人であるときには何も出力しないでください。

・アイドルグループに所属するメンバーの名前は重複しないことが保証されています。
・握手会がおこなわれるのは 10 回以下であることが保証されています。

入力例1
2 7
nene
ao
handshake
leave nene
join neko
join koko
handshake
leave neko
handshake

出力例1
ao
nene
ao
koko
neko
ao
koko

入力例2
5 10
nene
nana
koko
sasa
kiki
handshake
leave nene
leave kiki
leave nana
leave koko
leave sasa
handshake
join riri
join vivi
handshake

出力例2
kiki
koko
nana
nene
sasa
riri
vivi
*/