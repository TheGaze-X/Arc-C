using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x02006955 RID: 26965
	[Token(Token = "0x2006955")]
	[Serializable]
	public struct StageButtonPatch
	{
		// Token: 0x06026997 RID: 158103 RVA: 0x000CBD18 File Offset: 0x000C9F18
		[Token(Token = "0x6026997")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04036761 RID: 223073
		[Token(Token = "0x4036761")]
		[FieldOffset(Offset = "0x0")]
		public string stageId;

		// Token: 0x04036762 RID: 223074
		[Token(Token = "0x4036762")]
		[FieldOffset(Offset = "0x8")]
		public float posX;

		// Token: 0x04036763 RID: 223075
		[Token(Token = "0x4036763")]
		[FieldOffset(Offset = "0xC")]
		public float posY;

		// Token: 0x04036764 RID: 223076
		[Token(Token = "0x4036764")]
		[FieldOffset(Offset = "0x10")]
		public string btnRes;

		// Token: 0x04036765 RID: 223077
		[Token(Token = "0x4036765")]
		[FieldOffset(Offset = "0x18")]
		public string lineTo;
	}
}
