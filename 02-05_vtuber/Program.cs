using System;

namespace _02_05_vtuber
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
Vtuber (paizaランク B 相当)
問題にチャレンジして、ユーザー同士で解答を教え合ったり、コードを公開してみよう！

シェア用URL:
https://paiza.jp/works/mondai/query_primer/query_primer__vtuber
問題文のURLをコピーする
 下記の問題をプログラミングしてみよう！
あなたは流行に乗っかり、Vtuber としての活動をスタートしました。活動も軌道にのり、配信をするたびに視聴者が superchat を送ってくれたり、メンバーシップ制度に加入してくれるようになりました。
（わからない方は 「youtube superchat」「youtube membership」 などで検索してみてください。）
あなたはお礼として superchat を読むお礼配信をおこなうことにしました。
その配信で、前回の配信の superchat の総額が高いアカウントから順に、superchat をした全てのアカウントの名前を読んだ後、メンバーシップに入ってくれた全てのアカウントの名前を辞書順昇順で読むことにしました。
superchat の金額が同じ場合、同じ金額の中で辞書順降順でアカウント名を読むことにしました。
前回の配信の superchat とメンバーシップ加入の履歴が与えられるので、読む順番にアカウント名を出力するプログラムを作成してください。

▼　下記解答欄にコードを記入してみよう

入力される値
N
E_1
...
E_N


・1 行目では、superchat とメンバーシップ加入の回数の和 N が与えられます。
・続く N 行のうち、 i 行目では、i 番目のイベントの内容 E_i が以下のいずれかの形式で与えれられます。

name give money !
name さんが money 円の superchat を送ったことを表す。


name join membership!
name さんがメンバーシップに加入したことを表す。

入力値最終行の末尾に改行が１つ入ります。
文字列は標準入力から渡されます。 標準入力からの値取得方法はこちらをご確認ください
期待する出力
name_s_1
...
name_m_1
...


・superchat の総額が高い人から順にアカウント名を 1 行 1 アカウントで出力したのち、メンバーシップに加入した人のアカウント名を 辞書順に 1 行 1 アカウントで以上の形式で出力してください。
・superchat の総額が同じである場合、同じ金額の中で辞書順の降順(z → a)でアカウント名を出力してください。
・また、出力の末尾には改行を入れてください。
条件
・1 ≦ N ≦ 100,000
・S_i は "name give money !" , "name join membership!" のいずれか
・name は長さ 20 文字以下の英数字からなる文字列
・100 ≦ money ≦ 50000
・アカウント名に重複はないことが保証されている。
・1 つのアカウントについて、メンバーシップに加入するイベントが複数回起こることはない。

入力例1
5
aiueo give 2489 !
kk join membership!
coffee_addiction join membership!
so_cute give 837 !
yoyo give 9284 !

出力例1
yoyo
aiueo
so_cute
coffee_addiction
kk

入力例2
20
eicuf give 15492 !
ishaz join membership!
aehah give 17153 !
sheeh join membership!
uquai give 21723 !
eefah join membership!
uquai give 5189 !
daike join membership!
ahtoo give 16460 !
eefah give 11801 !
thaep give 45466 !
eicuf give 13505 !
thaep join membership!
ikoem join membership!
aehah join membership!
thiil join membership!
sheeh give 28624 !
ikoem give 13729 !
uquai give 39891 !
eefah give 31131 !

出力例2
uquai
thaep
eefah
eicuf
sheeh
aehah
ahtoo
ikoem
aehah
daike
eefah
ikoem
ishaz
sheeh
thaep
thiil
*/