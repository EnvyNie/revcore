﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlToBin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PublicDbEntities : DbContext
    {
        public PublicDbEntities()
            : base("name=PublicDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TBL_XWWL_BOSSDROP> TBL_XWWL_BOSSDROP { get; set; }
        public DbSet<TBL_XWWL_DROP> TBL_XWWL_DROP { get; set; }
        public DbSet<TBL_XWWL_DROP_GS> TBL_XWWL_DROP_GS { get; set; }
        public DbSet<TBL_XWWL_Gg> TBL_XWWL_Gg { get; set; }
        public DbSet<TBL_XWWL_ITEM> TBL_XWWL_ITEM { get; set; }
        public DbSet<TBL_XWWL_KONGFU> TBL_XWWL_KONGFU { get; set; }
        public DbSet<TBL_XWWL_MAP> TBL_XWWL_MAP { get; set; }
        public DbSet<TBL_XWWL_MONSTER> TBL_XWWL_MONSTER { get; set; }
        public DbSet<TBL_XWWL_NPC> TBL_XWWL_NPC { get; set; }
        public DbSet<TBL_XWWL_NPC_SL> TBL_XWWL_NPC_SL { get; set; }
        public DbSet<TBL_XWWL_OPEN> TBL_XWWL_OPEN { get; set; }
        public DbSet<TBL_XWWL_SELL> TBL_XWWL_SELL { get; set; }
        public DbSet<TBL_XWWL_VOME> TBL_XWWL_VOME { get; set; }
        public DbSet<XWWL_kill> XWWL_kill { get; set; }
        public DbSet<等级奖励> 等级奖励 { get; set; }
        public DbSet<升天气功> 升天气功 { get; set; }
        public DbSet<石头属性效果> 石头属性效果 { get; set; }
        public DbSet<武勋BUFF增幅> 武勋BUFF增幅 { get; set; }
        public DbSet<物品兑换> 物品兑换 { get; set; }
        public DbSet<制作物品列表> 制作物品列表 { get; set; }
        public DbSet<装备检测> 装备检测 { get; set; }
        public DbSet<自定义转职属性> 自定义转职属性 { get; set; }
    }
}