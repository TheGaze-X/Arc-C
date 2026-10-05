using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	internal class SliderState
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		[RequiredByNativeCode]
		public SliderState()
		{
		}

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x10")]
		public float dragStartPos;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x14")]
		public float dragStartValue;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x18")]
		public bool isDragging;
	}
}
