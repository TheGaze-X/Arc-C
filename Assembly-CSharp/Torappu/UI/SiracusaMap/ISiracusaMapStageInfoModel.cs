using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F98 RID: 16280
	[Token(Token = "0x2003F98")]
	public interface ISiracusaMapStageInfoModel : IHotfixable
	{
		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x06019408 RID: 103432
		[Token(Token = "0x17003C49")]
		string stageId { [Token(Token = "0x6019408")] get; }

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x06019409 RID: 103433
		[Token(Token = "0x17003C4A")]
		StageViewModel normalStage { [Token(Token = "0x6019409")] get; }

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0601940A RID: 103434
		[Token(Token = "0x17003C4B")]
		int rankNum { [Token(Token = "0x601940A")] get; }

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0601940B RID: 103435
		[Token(Token = "0x17003C4C")]
		string pointId { [Token(Token = "0x601940B")] get; }
	}
}
