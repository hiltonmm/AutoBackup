# AUTO BACKUP
# 1.0.1
# Desenvolvido por: Hilton M Moreira

A aplicação Auto Backup foi desenvolvida com um propósito especifico de sincronizar as pastas (Desktop, Documents e Pictures) do usuário que estiver logado no Sistema operacional como uma Unidade de Rede previamente configurada no arquivo “config.xml”.

A aplicação requere que uma carga inicial seja realizada, para só então iniciar os observadores de alterações. 

A cada alteração nas pastas observadas, o sistema realiza o sincronismo de toda pasta com a unidade de destino.

Esse sincronismo é realizado com o aplicativo Robust File Copy  disponível Windows, a partir da versão 8.

O Sincronismo é realizado em todas as ações (Criação, Alteração e Exclusão) e em apenas uma direção, isso quer dizer que todas as alterações na origem refletirão no destinho, mas as alterações do destino não refletirão na origem.

O Aplicativo Auto Backup foi desenvolvido na linguagem C# por Hilton M Moreira, hiltonmm@gmail.com, possui código aberto e pode ser modificado e distribuído livremente, desde que mantido os créditos de autoria.

O código fonte e o aplicativo estão disponíveis para download em https://github.com/hiltonmm/AutoBackup

Ditst
https://github.com/hiltonmm/AutoBackup/tree/Desenvolvimento/Aplicativo/Dist

# NOTAS DA VERSÃO
* FIX: Inicialização dos observadores 
* FIX: Repetição das sincronização quando detectado alteração nos arquivos dos aplicativos GoogleDrive e NextCloud. (Criado lista de arquivos)
* RecompilaÃ§Ã£o
