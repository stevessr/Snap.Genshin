﻿namespace DGP.Genshin.Services.GachaStatistic
{
    /// <summary>
    /// 请求祈愿记录页面进度
    /// </summary>
    public class FetchProgress
    {
        public string? Type;
        public int Page;
        public override string ToString() => $"{this.Type} 第 {this.Page} 页";
    }
}
