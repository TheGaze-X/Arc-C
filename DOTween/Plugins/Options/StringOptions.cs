using System;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public struct StringOptions : IPlugOptions
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x3754A40", Offset = "0x3753640", VA = "0x183754A40", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x0")]
		public bool richTextEnabled;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x4")]
		public ScrambleMode scrambleMode;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x8")]
		public char[] scrambledChars;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x10")]
		internal int startValueStrippedLength;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x14")]
		internal int changeValueStrippedLength;
	}
}
