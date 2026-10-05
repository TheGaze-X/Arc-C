using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	internal class TweenLink
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x375DB70", Offset = "0x375C770", VA = "0x18375DB70")]
		public TweenLink(GameObject target, LinkBehaviour behaviour)
		{
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x10")]
		public readonly GameObject target;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x18")]
		public readonly LinkBehaviour behaviour;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x1C")]
		public bool lastSeenActive;
	}
}
