# AUTO BACKUP
# 1.0.1
# Desenvolvido por: Hilton M Moreira

A aplica��o Auto Backup foi desenvolvida com um prop�sito especifico de sincronizar as pastas (Desktop, Documents e Pictures) do usu�rio que estiver logado no Sistema operacional como uma Unidade de Rede previamente configurada no arquivo �config.xml�.

A aplica��o requere que uma carga inicial seja realizada, para s� ent�o iniciar os observadores de altera��es. 

A cada altera��o nas pastas observadas, o sistema realiza o sincronismo de toda pasta com a unidade de destino.

Esse sincronismo � realizado com o aplicativo Robust File Copy  dispon�vel Windows, a partir da vers�o 8.

O Sincronismo � realizado em todas as a��es (Cria��o, Altera��o e Exclus�o) e em apenas uma dire��o, isso quer dizer que todas as altera��es na origem refletir�o no destinho, mas as altera��es do destino n�o refletir�o na origem.

O Aplicativo Auto Backup foi desenvolvido na linguagem C# por Hilton M Moreira, hiltonmm@gmail.com, possui c�digo aberto e pode ser modificado e distribu�do livremente, desde que mantido os cr�ditos de autoria.

O c�digo fonte e o aplicativo est�o dispon�veis para download em https://github.com/hiltonmm/AutoBackup

Ditst
https://github.com/hiltonmm/AutoBackup/tree/Desenvolvimento/Aplicativo/Dist

# NOTAS DA VERS�O
* FIX: Inicializa��o dos observadores 
* FIX: Repeti��o das sincroniza��o quando detectado altera��o nos arquivos dos aplicativos GoogleDrive e NextCloud. (Criado lista de arquivos)
* Recompilação
