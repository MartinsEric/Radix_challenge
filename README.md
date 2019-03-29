## Como rodar o projeto da questão 3.

Ao abrir o projeto da questão 3 no Visual Studio, siga os seguintes passos:

**1.** Aba exibir -> SQL Object Explorer.

**2.** entre em SQL Server -> localdb.

**3.** Botão direito na pasta DataBases -> clique em "add new database" -> escolha o nome `RadixDB`.

**4.** Aba ferramentas -> gerenciador de pacotes NuGet -> abra o console do gerenciador de pacotes.

**5.** Execute o seguinte comando: `Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 1.1` (Irá baixar o Entity Framework)

**6.** Agora execute o comando: `Install-Package Microsoft.EntityFrameworkCore.tools -Version 1.1` (Irá baixar as ferramentas de migration)

**7.** Após o Visual Studio reconhecer os pacotes do Entity Framework, execute outro comando: `Add-Migration Inicial`

**8.** Execute o camando: `Update-Database` para criar as tabelas no banco de dados.

**9.** O projeto ja pode ser executado.
