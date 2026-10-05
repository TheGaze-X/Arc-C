using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001EB4 RID: 7860
	[Token(Token = "0x2001EB4")]
	[Serializable]
	public struct AutoSpeed
	{
		// Token: 0x0400C47C RID: 50300
		[Token(Token = "0x400C47C")]
		[FieldOffset(Offset = "0x0")]
		public Sprite Image;

		// Token: 0x0400C47D RID: 50301
		[Token(Token = "0x400C47D")]
		[FieldOffset(Offset = "0x8")]
		public float AutoWaitBaseTime;

		// Token: 0x0400C47E RID: 50302
		[Token(Token = "0x400C47E")]
		[FieldOffset(Offset = "0xC")]
		public float AutoWaitTimePerText;

		// Token: 0x0400C47F RID: 50303
		[Token(Token = "0x400C47F")]
		[FieldOffset(Offset = "0x10")]
		public float TypeWriterDelay;

		// Token: 0x0400C480 RID: 50304
		[Token(Token = "0x400C480")]
		[FieldOffset(Offset = "0x14")]
		public float AnimateRatio;
	}
}
