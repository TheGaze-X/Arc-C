using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A5F RID: 6751
	[Token(Token = "0x2001A5F")]
	public interface IMoveHolder
	{
		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x0600A9F4 RID: 43508
		// (set) Token: 0x0600A9F5 RID: 43509
		[Token(Token = "0x170013EF")]
		Vector2 moveDir { [Token(Token = "0x600A9F4")] get; [Token(Token = "0x600A9F5")] set; }

		// Token: 0x0600A9F6 RID: 43510
		[Token(Token = "0x600A9F6")]
		void OnMoverStateChanged();
	}
}
