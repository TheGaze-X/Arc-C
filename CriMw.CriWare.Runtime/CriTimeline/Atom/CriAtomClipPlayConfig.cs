using System;
using Il2CppDummyDll;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public struct CriAtomClipPlayConfig
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x3709B60", Offset = "0x3708760", VA = "0x183709B60")]
		public CriAtomClipPlayConfig(CriAtomClipBase clip, long startTimeMs, double speedRate, bool loop)
		{
		}

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x0")]
		public readonly CriAtomClipBase clip;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x8")]
		public readonly long startTimeMs;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x10")]
		public readonly double speedRate;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool loop;
	}
}
