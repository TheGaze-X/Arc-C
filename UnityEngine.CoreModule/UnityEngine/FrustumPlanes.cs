using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[Serializable]
	public struct FrustumPlanes
	{
		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x0")]
		public float left;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x4")]
		public float right;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x8")]
		public float bottom;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0xC")]
		public float top;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x10")]
		public float zNear;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x14")]
		public float zFar;
	}
}
