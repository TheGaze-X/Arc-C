using System;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036FE RID: 14078
	[Token(Token = "0x20036FE")]
	public class CanvasAlphaTweenSetter : FloatTweenSetter
	{
		// Token: 0x060165A8 RID: 91560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165A8")]
		[Address(RVA = "0xEC1450", Offset = "0xEC0050", VA = "0x180EC1450")]
		public CanvasAlphaTweenSetter(CanvasGroup canvasGroup, CanvasAlphaTweenSetter.Options options)
		{
		}

		// Token: 0x060165A9 RID: 91561 RVA: 0x00090B10 File Offset: 0x0008ED10
		[Token(Token = "0x60165A9")]
		[Address(RVA = "0xEC1320", Offset = "0xEBFF20", VA = "0x180EC1320", Slot = "7")]
		protected override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060165AA RID: 91562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165AA")]
		[Address(RVA = "0xEC1380", Offset = "0xEBFF80", VA = "0x180EC1380", Slot = "4")]
		protected override void SetValueImpl(float value)
		{
		}

		// Token: 0x0401AE37 RID: 110135
		[Token(Token = "0x401AE37")]
		private const float DEFAULT_DURATION = 0.16f;

		// Token: 0x0401AE38 RID: 110136
		[Token(Token = "0x401AE38")]
		[FieldOffset(Offset = "0x30")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0401AE39 RID: 110137
		[Token(Token = "0x401AE39")]
		[FieldOffset(Offset = "0x38")]
		private CanvasAlphaTweenSetter.Options m_options;

		// Token: 0x0401AE3A RID: 110138
		[Token(Token = "0x401AE3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AE3B RID: 110139
		[Token(Token = "0x401AE3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x0401AE3C RID: 110140
		[Token(Token = "0x401AE3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetValueImpl;

		// Token: 0x020036FF RID: 14079
		[Token(Token = "0x20036FF")]
		public struct Options : ILuaCallCSharp
		{
			// Token: 0x0401AE3D RID: 110141
			[Token(Token = "0x401AE3D")]
			[FieldOffset(Offset = "0x0")]
			public Interpolator.EaseType ease;

			// Token: 0x0401AE3E RID: 110142
			[Token(Token = "0x401AE3E")]
			[FieldOffset(Offset = "0x4")]
			public float duration;
		}
	}
}
