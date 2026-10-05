using System;
using Il2CppDummyDll;
using Torappu.Fx;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020034C7 RID: 13511
	[Token(Token = "0x20034C7")]
	[Serializable]
	public class ActionParticle
	{
		// Token: 0x0601588D RID: 88205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601588D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActionParticle()
		{
		}

		// Token: 0x04019CFC RID: 105724
		[Token(Token = "0x4019CFC")]
		[FieldOffset(Offset = "0x10")]
		public DynIllustAction action;

		// Token: 0x04019CFD RID: 105725
		[Token(Token = "0x4019CFD")]
		[FieldOffset(Offset = "0x18")]
		public GameObject particle;

		// Token: 0x04019CFE RID: 105726
		[Token(Token = "0x4019CFE")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public FxDelay fxDelay;
	}
}
