namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeiro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioID = c.Int(nullable: false, identity: true),
                        CodNivel = c.Int(nullable: false),
                        Cargo = c.String(),
                        Nivel = c.String(),
                        TempoDeCasaEmAnos = c.Int(nullable: false),
                        SalarioInicial = c.Double(nullable: false),
                        QtdeBonus = c.Int(nullable: false),
                        DataAdmissao = c.DateTime(nullable: false),
                        PessoaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioID);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Rg = c.String(),
                        Cpf = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.PessoaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoa");
            DropTable("dbo.Funcionario");
        }
    }
}
