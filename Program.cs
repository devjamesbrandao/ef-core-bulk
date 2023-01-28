using EFCoreBulk.Context;
using Microsoft.EntityFrameworkCore;

var contexto = new TimeContext();

// BULK UPDATE
contexto.Times
    .Where(x => x.ClassificacaoCampeonatoBrasileiro == 2 && x.Nome == "Corinthians")
    .ExecuteUpdate(u => u.SetProperty(p => p.ClassificacaoCampeonatoBrasileiro, c => 1));

// SQL gerado
// UPDATE [t]
// SET [t].[ClassificacaoCampeonatoBrasileiro] = 1
// FROM [Times] AS [t]
// WHERE [t].[ClassificacaoCampeonatoBrasileiro] = 2 AND [t].[Nome] = N'Corinthians'


// BULK DELETE
var rows = contexto.Times
    .Where(t => t.Nome.Contains("Flamengo"))
    .ExecuteDelete();

// SQL Gerado
// DELETE FROM [t]
// FROM [Times] AS [t]
// WHERE [t].[Nome] LIKE N'%Flamengo%'






