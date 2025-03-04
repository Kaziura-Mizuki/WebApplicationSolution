# 2025年新入社員研修開発環境構築

## Visual Studio2022のインストール手順
1.[ここをクリック](https://visualstudio.microsoft.com/ja/vs/community/)してサイトにアクセスし、Visual Studio Community 2022の無償ダウンロードボタンが下のほうにあると思いますのでそこをクリックして
　インストーラーをダウンロードして下さい。ダウンロード出来たらダウンロードしたインストーラーを実行してインストールして下さい。
2.インストール中にワークロードの項目があると思いますので以下のように選択して下さい。
　・Web&クラウド："ASP.NETとWeb開発"にチェックを入れる。
　・デスクトップとモバイル：".NETデスクトップ開発"にチェックを入れる。
　・他のツールセット："データの保存と処理"にチェックを入れる。
 
※[VSC2022インストール手順参考サイト](https://qiita.com/mmake/items/e0abb649683b96e2226a)

## SQL Server2022とSQL Server Management Studio(SSMS)のインストール手順
1．[ここをクリック](https://qiita.com/portfoliokns3/items/9e3d1196d680a39dd223)してサイトにアクセスし、サイトを参考にして進める。

## SSMSから自PC内のSQL Serverに接続する手順(以下英語ver)
1．SSMSを起動すると画像にような画面が表示されると思います。そして画面左側のオブジェクトエクスプローラーのコンセントのようなアイコンをクリックして接続モーダルを表示させます。

2.画像のような接続モーダルが表示されれば、必要な情報を入力していきます。まず、Server nameに接続したいサーバーを入力するのですが、入力欄の右側の下向き矢印をクリックして下さい。
　すると接続先のサーバー候補がいくつか表示されると思います。その中の"Browse for more..."をクリックすると小さいモーダルが表示されると思います。
  
3.次にプラスのアイコンをクリックするとDatabase Engine配下に自PC名が表示されると思いますのでそれを選択した状態でOKをクリックして下さい。

4.先のモーダルに戻り、Server nameには自PCの名前が入っていると思いますので最後にTrust server certificateにチェックを入れてConnectをクリックして下さい。
　するとオブジェクトエクスプローラーに接続したサーバーが追加されています。
  (一度接続したサーバーはServer nameで選択し、Connectをクリックするだけで接続されます。)

## サーバーに新しいログインユーザーとデータベースを作成する手順
1.SSMSを起動し、オブジェクトエクスプローラーに先程追加したサーバーがある状態からスタートします。
2.まず、新しいログインユーザーを作成します。プラスのアイコンをクリックして画像にように開いていくと、サーバー名(自PC名)/Security/Logins配下に既にデフォルトでいくつかログインユーザーが登録されていると思います。

3.ここに新しくログインユーザーを登録するには、まずLoginsフォルダを右クリックして、次にNew Login...をクリックするとモーダルが表示されます。このモーダルにログインユーザーの情報を入力していきますので、入力した情報はどこかにメモする等して保管してください。

4.入力する箇所は画像のようにまずLogin nameに任意のログインユーザー名を入力し、SQL Server authenticationにチェックを入れて任意のパスワードを入力してください。入力出来たらOKをクリックして下さい。
　Logins配下に新しく登録したログインユーザーが追加されていると思います。

5.次にサーバーに新しいデータベースを作成します。サーバー名(自PC名)/Databasesフォルダを右クリックして、New Database...をクリックするとモーダルが表示されます。
　そのモーダルのDatabase nameにUserと入力してOKをクリックするとDatabases配下にUserというデータベースが作成されます。

## データベースに新しいテーブルを追加する手順
1.作成したデータベースをプラスのアイコンをクリックして開くと、画像のような構造になってるのでその中のTablesを右クリックしてNew →　Table...の順にクリックして下さい。
　すると右側にテーブルの構造を設定するタブが表示されると思います。

2.そのタブで画像のようにまずColumn NameがIdでData Typeがintのカラムを入力し、次にColumn NameがNameでData Typeが"nvarchar(50)"のカラムを入力して下さい。
  また、Idのカラムはプライマリキーなので右クリックして、Set Primary Keyをクリックしてプライマリキーを設定して下さい。
  完了したらCtrl + Sを押してテーブル名を入力するよう求められるのでUserと入力してOKをクリックして下さい。

3.作成したテーブルにデータを入力します。Tables配下にdbo.Userというテーブルがあると思いますのでそれを右クリックしてEdit Top 200 Rowsをクリックすると画面右側にデータを入力するタブが表示されます。
　そこでIdには半角で0以降の数値を入力し、Nameには好きな名前を入力しタブを閉じて下さい。先ほどと同様にdbo.Userを右クリックして今度はSelect Top 1000 Rowsをクリックして下さい。
  すると画面右側に先ほど入力したデータが表形式で表示されるはずです。
