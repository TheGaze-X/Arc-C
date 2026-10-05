using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200221D RID: 8733
	[Token(Token = "0x200221D")]
	public interface ILocatable
	{
		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x0600DBEC RID: 56300
		[Token(Token = "0x17001BAF")]
		Vector2 mapPosition { [Token(Token = "0x600DBEC")] get; }

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x0600DBED RID: 56301
		[Token(Token = "0x17001BB0")]
		Vector3 mapPositionV3 { [Token(Token = "0x600DBED")] get; }

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x0600DBEE RID: 56302
		[Token(Token = "0x17001BB1")]
		Vector3 worldPosition { [Token(Token = "0x600DBEE")] get; }

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x0600DBEF RID: 56303
		[Token(Token = "0x17001BB2")]
		GridPosition gridPosition { [Token(Token = "0x600DBEF")] get; }

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x0600DBF0 RID: 56304
		[Token(Token = "0x17001BB3")]
		Vector2 faceTo { [Token(Token = "0x600DBF0")] get; }

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x0600DBF1 RID: 56305
		[Token(Token = "0x17001BB4")]
		float height { [Token(Token = "0x600DBF1")] get; }
	}
}
