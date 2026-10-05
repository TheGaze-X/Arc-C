using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004064 RID: 16484
	[Token(Token = "0x2004064")]
	public class SandboxV2AdminMainTypeItemData
	{
		// Token: 0x060197FA RID: 104442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197FA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AdminMainTypeItemData()
		{
		}

		// Token: 0x0401FC79 RID: 130169
		[Token(Token = "0x401FC79")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x0401FC7A RID: 130170
		[Token(Token = "0x401FC7A")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		// Token: 0x0401FC7B RID: 130171
		[Token(Token = "0x401FC7B")]
		[FieldOffset(Offset = "0x20")]
		public bool actived;
	}
}
