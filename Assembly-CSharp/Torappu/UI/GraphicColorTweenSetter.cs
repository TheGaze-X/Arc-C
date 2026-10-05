using System;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003700 RID: 14080
	[Token(Token = "0x2003700")]
	public class GraphicColorTweenSetter : ColorTweenSetter
	{
		// Token: 0x060165AB RID: 91563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165AB")]
		[Address(RVA = "0xEC2920", Offset = "0xEC1520", VA = "0x180EC2920")]
		public GraphicColorTweenSetter(Graphic graphic, GraphicColorTweenSetter.Options options)
		{
		}

		// Token: 0x060165AC RID: 91564 RVA: 0x00090B28 File Offset: 0x0008ED28
		[Token(Token = "0x60165AC")]
		[Address(RVA = "0xEC27D0", Offset = "0xEC13D0", VA = "0x180EC27D0", Slot = "7")]
		protected override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060165AD RID: 91565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165AD")]
		[Address(RVA = "0xEC2830", Offset = "0xEC1430", VA = "0x180EC2830", Slot = "4")]
		protected override void SetValueImpl(Color value)
		{
		}

		// Token: 0x0401AE3F RID: 110143
		[Token(Token = "0x401AE3F")]
		private const float DEFAULT_DURATION = 0.16f;

		// Token: 0x0401AE40 RID: 110144
		[Token(Token = "0x401AE40")]
		[FieldOffset(Offset = "0x58")]
		private Graphic m_graphic;

		// Token: 0x0401AE41 RID: 110145
		[Token(Token = "0x401AE41")]
		[FieldOffset(Offset = "0x60")]
		private GraphicColorTweenSetter.Options m_options;

		// Token: 0x0401AE42 RID: 110146
		[Token(Token = "0x401AE42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AE43 RID: 110147
		[Token(Token = "0x401AE43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x0401AE44 RID: 110148
		[Token(Token = "0x401AE44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetValueImpl;

		// Token: 0x02003701 RID: 14081
		[Token(Token = "0x2003701")]
		public struct Options : ILuaCallCSharp
		{
			// Token: 0x0401AE45 RID: 110149
			[Token(Token = "0x401AE45")]
			[FieldOffset(Offset = "0x0")]
			public Interpolator.EaseType ease;

			// Token: 0x0401AE46 RID: 110150
			[Token(Token = "0x401AE46")]
			[FieldOffset(Offset = "0x4")]
			public float duration;
		}
	}
}
