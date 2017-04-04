using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace GrmWebAppAdmSiSv01.Models.Sindicato
{

    public class GrmAdmSiSModelContext : DbContext
    {
        public GrmAdmSiSModelContext()
            : base("name=GrmAdmSiSConnection")
        {
            //
        }

        public DbSet<Pais> dbPais { get; set; }
        public DbSet<Uf> dbUfs { get; set; }
        public DbSet<Municipio> dbMunicipios { get; set; }

        public static GrmAdmSiSModelContext Create()
        {
            return new GrmAdmSiSModelContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //aiterar convencao de id
            //modelBuilder.Properties()
            //    .Where(p => p.Name == "Id" + p.ReflectedType.Name)
            //    .Configure(p => p.IsKey());
            modelBuilder
                .Properties<string>()
                .Configure(c => c.IsUnicode(false));

            modelBuilder.Properties<string>()
                .Configure(c => c.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(c => c.HasMaxLength(256));

            //-- Tabelas ---------------------------------------------------
            modelBuilder.Entity<Pais>()
                .ToTable("TB_PAIS");

            modelBuilder.Entity<Uf>()
                .ToTable("TB_UF");

            modelBuilder.Entity<Municipio>()
                .ToTable("TB_MUNICIPIO");
            
            /*
            modelBuilder.Entity<AcordoSindical>()
                .ToTable("TB_ACORDO_SIND")
                .Property(p => p.IdAcondoSindial).HasColumnName("ID_ACORDO_SIND");

            modelBuilder.Entity<AgenciaBanco>()
                .ToTable("TB_AG_BANCO");

            modelBuilder.Entity<Banco>()
                .ToTable("TB_BANCO");

            modelBuilder.Entity<Cargo>()
                .ToTable("TB_CARGO");

            modelBuilder.Entity<ContaAcessoSistema>()
                .ToTable("TB_CFG_CTA_A_SIST");

            modelBuilder.Entity<ConfigContaAcessoSistema>()
                .ToTable("TB_CFG_CTA_A_SIST");

            modelBuilder.Entity<ConfigEmpresaSistema>()
                .ToTable("TB_CFG_EMP_SIST");

            modelBuilder.Entity<ConfigUsuario>()
                .ToTable("TB_CFG_USUARIO");

            modelBuilder.Entity<ClausulaItem>()
                .ToTable("TB_CLA_ITEM");

            modelBuilder.Entity<ClassificacaoSindicato>()
                .ToTable("TB_CLASS_SIND");

            modelBuilder.Entity<Clausula>()
                .ToTable("TB_CLAUSULA");

            modelBuilder.Entity<ContaAcessoSistema>()
                .ToTable("TB_CTA_ACESSO_SIST");

            modelBuilder.Entity<ContaCorrente>()
                .ToTable("TB_CTA_CORRENTE");

            modelBuilder.Entity<EmpresaSistema>()
                .ToTable("TB_EMP_SIST");

            modelBuilder.Entity<Endereco>()
                .ToTable("TB_ENDERECO");

            modelBuilder.Entity<Funcao>()
                .ToTable("TB_FUNCAO");

            modelBuilder.Entity<Funcionario>()
                .ToTable("TB_FUNCIONARIO");

            modelBuilder.Entity<GeoEco>()
                .ToTable("TB_GEO_ECO");

            modelBuilder.Entity<GrupoClausula>()
                .ToTable("TB_GRUPO_CLA");

            modelBuilder.Entity<GrupoPermissao>()
                .ToTable("TB_GRUPO_PER");

            modelBuilder.Entity<GrupoUsuario>()
                .ToTable("TB_GRUPO_USER");

            modelBuilder.Entity<LogErro>()
                .ToTable("TB_LOG_ERRO");

            modelBuilder.Entity<LogEvento>()
                .ToTable("TB_LOG_EVENTO");

            modelBuilder.Entity<NaturezaOperacao>()
                .ToTable("TB_NAT_OP");

            modelBuilder.Entity<OrientacaoClausula>()
                .ToTable("TB_O_CLA");

            modelBuilder.Entity<OperadoraTel>()
                .ToTable("TB_OPERADORA");

            modelBuilder.Entity<OrganizacaoSindical>()
                .ToTable("TB_ORG_SIND");

            modelBuilder.Entity<Pessoa>()
                .ToTable("TB_PESSOA");

            modelBuilder.Entity<PessoaEndereco>()
                .ToTable("TB_PESSOA_END");

            modelBuilder.Entity<RegistroLicenca>()
                .ToTable("TB_REG_LIC");

            modelBuilder.Entity<Regraclausula>()
                .ToTable("TB_REGRA_CLA");

            modelBuilder.Entity<Sindicato>()
                .ToTable("TB_SIND");

            modelBuilder.Entity<Status>()
                .ToTable("TB_STATUS");

            modelBuilder.Entity<StatusValor>()
                .ToTable("TB_ST_VALOR");

            modelBuilder.Entity<TelefonePessoa>()
                .ToTable("TB_TEL_PESSOA");

            modelBuilder.Entity<TipoAcordo>()
                .ToTable("TB_TIPO_ACORDO");

            modelBuilder.Entity<TipoSindicato>()
                .ToTable("TB_TIPO_SIND");

            modelBuilder.Entity<Unidade>()
                .ToTable("TB_UNIDADE");

            modelBuilder.Entity<Usuario>()
                .ToTable("TB_USUARIO");
            
            */

        }

    }
}
