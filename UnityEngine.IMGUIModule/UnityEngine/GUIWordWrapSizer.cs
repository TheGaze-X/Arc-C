using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	internal sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x59ADEE0", Offset = "0x59ACAE0", VA = "0x1859ADEE0")]
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x59ADE20", Offset = "0x59ACA20", VA = "0x1859ADE20", Slot = "8")]
		public override void CalcWidth()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x59ADD80", Offset = "0x59AC980", VA = "0x1859ADD80", Slot = "9")]
		public override void CalcHeight()
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x48")]
		private readonly GUIContent m_Content;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x50")]
		private readonly float m_ForcedMinHeight;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x54")]
		private readonly float m_ForcedMaxHeight;
	}
}
