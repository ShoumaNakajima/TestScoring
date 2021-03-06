# TestScoring(テストの評価を保存するアプリケーション)

## 課題内容

WindowsFormsで画面入出力を行うアプリケーション作成

○レギュレーション

要C#8.0の新機能、要LINQ、DB利用はオプション課題（使っていれば加点）

○提出方法

リポジトリのURLを #nwプログラミング_情報リテラシー に連絡

## このアプリでできること（作成した目的）

学校（ヒューマン）でのテスト結果の保存し、管理することを目的としたアプリケーションです。

年度などの時期や教科の名前、生徒の名前とテストの点数を入力することでテストの結果を保存できます。

そして、追加した情報の一覧を表示したり、検索機能で表示内容を絞ることもできます。

## 使い方

### 環境

・Windows10のOSでは動きます。

### ダウンロード

・今のところはできません（できるようにする予定）

### 使用手順

基本的な使い方は

「編集や追加、保存を行う　→　検索や一覧で保存したデータを確認する」というものです。

最初にアプリを開いたときは何もデータが存在しない状態なので「ScoreFile.xmlが見つかりませんでした」と出ますが、
一度保存をしてしまうと次からは表示されないため、あまり気にしないでください。

#### 最初の画面

>左側の画面
>
>・編集
>
>・追加
>
>・保存
>
>右側の画面
>
>・保存したデータの表示
>
>を行う画面となっています。

- 左側の新規追加の画面

時期→年度は西暦で、そして前期か後期を選択します。

教科名→追加したい教科の名前を入力します。

名前→追加したい生徒名を入力します。

点数→生徒の点数を入力します。

入力し終えたら追加ボタンを押します。→データの追加完了！

これでは、まだ保存できていないので保存ボタンを押して保存すると次にアプリケーションを開いたときに保存したデータが残っています。

（注）保存をしないでアプリケーションを終了してしまうと以前にアプリケーションを開いたときの状態に戻ります

編集ボタンを押すと編集画面を開くため編集画面のところで説明します。

- 右側の検索、一覧を表示する画面

時期→年度は西暦で、そして前期か後期を選択します。

この時点で検索をすると時期だけの検索でヒットしたデータのみを表示します。（検索画面が出てくる）

教科名→検索したい教科名を入力します。（PullDown Menuには追加した教科名が入っているので使うと便利です）

ここで検索すると時期と教科名の検索でヒットしたデータのみを表示します。

一覧ボタンでは追加されたすべてのデータを表示します。

アピールボタンは、このアプリケーションを作成するうえで難しかったこと、意識したことを書いているメッセージボックスを表示させます。


#### 編集画面

編集画面では、表形式でデータの修正、削除ができる画面です。（修正は今のところできないです）

削除は削除したい行を選択し、削除ボタンを押すだけでデータを削除できます。


## 改善点や実現できていない点

- 技術面

for、foreach,ForEachの使い分けがあまりできていない。

アプリケーションを開いた部分の初期化の処理など関数として切り出すことが出来る部分などが多数存在する。

コメントがない。

変数名がcomboBox1などのままにしているので、変えていきたい。

- UI/UX関連

編集画面での修正ができない。


Readmeが読みにくい。

検索画面と一覧画面で要素がないのにwindowが生成されてしまう。

- 改善できていないバグ

編集画面で削除をするとき一番下の何も入力されていない行を選択すると例外処理になる。


