using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CE6 RID: 19686
	[Token(Token = "0x2004CE6")]
	public class GroceryOrderResultSliderCountTweener : IHotfixable
	{
		// Token: 0x0601D817 RID: 120855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D817")]
		[Address(RVA = "0x17124A0", Offset = "0x17110A0", VA = "0x1817124A0")]
		public GroceryOrderResultSliderCountTweener(Slider slider, float dur)
		{
		}

		// Token: 0x0601D818 RID: 120856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D818")]
		[Address(RVA = "0x1712050", Offset = "0x1710C50", VA = "0x181712050")]
		public void Play(float endVal, bool isFastMode = false, float startVal = 0f)
		{
		}

		// Token: 0x0601D819 RID: 120857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D819")]
		[Address(RVA = "0x17123D0", Offset = "0x1710FD0", VA = "0x1817123D0")]
		private void _Reset(float endCnt)
		{
		}

		// Token: 0x04026EC3 RID: 159427
		[Token(Token = "0x4026EC3")]
		[FieldOffset(Offset = "0x10")]
		private Slider m_slider;

		// Token: 0x04026EC4 RID: 159428
		[Token(Token = "0x4026EC4")]
		[FieldOffset(Offset = "0x18")]
		private Tween m_tweener;

		// Token: 0x04026EC5 RID: 159429
		[Token(Token = "0x4026EC5")]
		[FieldOffset(Offset = "0x20")]
		private float m_dur;

		// Token: 0x04026EC6 RID: 159430
		[Token(Token = "0x4026EC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04026EC7 RID: 159431
		[Token(Token = "0x4026EC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04026EC8 RID: 159432
		[Token(Token = "0x4026EC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Reset;
	}
}
