using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using WebApplication2.Models;
using Microsoft.Extensions.Logging;
using static WebApplication2.Models.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication2.Service;


namespace WebApplication2.Service
{
    public class HomeService
    {
        private readonly AppDbContext _context;

        public HomeService(AppDbContext context)
        {
            _context = context;
        }

        public List<HomeViewModel> GetDataService()
        {
            List<HomeViewModel> list = new List<HomeViewModel>(); //HomeViewModelのリストを作成
            var query = (from m in _context.User //LINQを用いてUserテーブルからデータを取得しリスト化したものをqueryに代入
                         select m).ToList();
            if (query != null)
            {
                for (var i = 0; i < query.Count; i++){ //queryの中にあるリストの長さ分だけ繰り返すfor文
                    HomeViewModel homeViewModel = new HomeViewModel(); //HomeViewModelのインスタンスを作成(データを入れるためのモデルクラス。箱のようなもの)
                    homeViewModel.Id = query[i].Id; //queryのi番目のIdをhomeViewModelのIdに代入
                    homeViewModel.Name = query[i].Name;　//queryのi番目のNameをhomeViewModelのNameに代入
                    list.Add(homeViewModel);　//listにhomeViewModelを追加
                }
            }
            return list;　//listを呼び出し元であるHomeControllerクラスのGetData()に返す
        }


        //目標:GetDataServiceTodoメソッドを修正し、データベースコンテキストから取得したデータをhomeViewModelに格納して、それらをリスト化して返すようにして下さい。
        //ヒント:GetDataServiceメソッドを参考にして下さい。
        public List<HomeViewModel> GetDataServiceTodo()
        {
            return null;
        }
    }
}
