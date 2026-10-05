using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200406A RID: 16490
	[Token(Token = "0x200406A")]
	[Serializable]
	public class SandboxV2AdminMainViewDef
	{
		// Token: 0x0601981D RID: 104477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601981D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AdminMainViewDef()
		{
		}

		// Token: 0x0401FCB0 RID: 130224
		[Token(Token = "0x401FCB0")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2AdminMainViewBase viewPrefab;

		// Token: 0x0401FCB1 RID: 130225
		[Token(Token = "0x401FCB1")]
		[FieldOffset(Offset = "0x18")]
		public Transform container;
	}
}
