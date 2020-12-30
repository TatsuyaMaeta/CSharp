もしプロジェクトを作る方法を忘れてしまったら

https://docs.microsoft.com/ja-jp/dotnet/core/tutorials/with-visual-studio-code

vscodeのターミナルで
dotnet new console
と打てばファイル一覧が生成される

実行する際は dotnet run  で動く

〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜

Visual Studioでのプロジェクトの作り方

１：　⌘　＋　⇧　＋　Ｎ (新しいソリューション)
２：コンソールアプリケーション(C#)
３：.NET Core3.1（対象のフレームワーク）
４：プロジェクト名を決めて　参照先を /Users/git-repo/CSharp/dayにする　※dayの後の日付の詳細を指定する事！

※Gitの管理はもう既にされているので指定する必要なし

〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜〜

Sample
Exercise


C#ファイルをデバッグして記述内容を確認するとき
　
　⌘　＋　⌥
　cotrol + F5

どちらかで実行



文頭でusingのネームスペースを追加する

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLineでよく使う引数使用表示
("{0}{1}{2}{3}{4}",a,b,c,d,e);

Sec7　　 -56
1CSファイルにつき1classが普通
	-57
ファイル名とクラス名は原則一致させる(管理しやすい)
同クラス内にて同じ名前のメソッドを作成できる(引数の数と戻り値が異なる場合)








