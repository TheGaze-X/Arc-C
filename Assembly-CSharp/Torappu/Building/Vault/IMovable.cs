using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A11 RID: 6673
	[Token(Token = "0x2001A11")]
	public interface IMovable
	{
		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x0600A741 RID: 42817
		// (set) Token: 0x0600A742 RID: 42818
		[Token(Token = "0x1700134E")]
		Vector2 gridPos { [Token(Token = "0x600A741")] get; [Token(Token = "0x600A742")] set; }

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x0600A743 RID: 42819
		[Token(Token = "0x1700134F")]
		GridMap gridMap { [Token(Token = "0x600A743")] get; }

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x0600A744 RID: 42820
		[Token(Token = "0x17001350")]
		float moveSpeed { [Token(Token = "0x600A744")] get; }
	}
}
