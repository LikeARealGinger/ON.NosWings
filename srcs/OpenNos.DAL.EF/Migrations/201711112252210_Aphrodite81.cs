namespace OpenNos.DAL.EF.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Aphrodite81 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuestReward", "Design", c => c.Byte(nullable: false));
            AddColumn("dbo.QuestReward", "Rarity", c => c.Byte(nullable: false));
            AddColumn("dbo.QuestReward", "Upgrade", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuestReward", "Upgrade");
            DropColumn("dbo.QuestReward", "Rarity");
            DropColumn("dbo.QuestReward", "Design");
        }
    }
}
