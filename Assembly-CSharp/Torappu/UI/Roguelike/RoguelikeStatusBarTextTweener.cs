using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005318 RID: 21272
	[Token(Token = "0x2005318")]
	public class RoguelikeStatusBarTextTweener : IHotfixable
	{
		// Token: 0x0601F630 RID: 128560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F630")]
		[Address(RVA = "0x191D5B0", Offset = "0x191C1B0", VA = "0x18191D5B0")]
		public RoguelikeStatusBarTextTweener(Text text, Color normalColor, Color increaseColor, Color decreaseColor)
		{
		}

		// Token: 0x0601F631 RID: 128561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F631")]
		[Address(RVA = "0x191D440", Offset = "0x191C040", VA = "0x18191D440")]
		public void Reset(int endCnt)
		{
		}

		// Token: 0x0601F632 RID: 128562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F632")]
		[Address(RVA = "0x191D0C0", Offset = "0x191BCC0", VA = "0x18191D0C0")]
		public void Play(int endCnt)
		{
		}

		// Token: 0x0402A300 RID: 172800
		[Token(Token = "0x402A300")]
		private const float TWEEN_DURATION = 0.5f;

		// Token: 0x0402A301 RID: 172801
		[Token(Token = "0x402A301")]
		[FieldOffset(Offset = "0x10")]
		private Color m_normalColor;

		// Token: 0x0402A302 RID: 172802
		[Token(Token = "0x402A302")]
		[FieldOffset(Offset = "0x20")]
		private Color m_increaseColor;

		// Token: 0x0402A303 RID: 172803
		[Token(Token = "0x402A303")]
		[FieldOffset(Offset = "0x30")]
		private Color m_decreaseColor;

		// Token: 0x0402A304 RID: 172804
		[Token(Token = "0x402A304")]
		[FieldOffset(Offset = "0x40")]
		private Text m_text;

		// Token: 0x0402A305 RID: 172805
		[Token(Token = "0x402A305")]
		[FieldOffset(Offset = "0x48")]
		private int m_count;

		// Token: 0x0402A306 RID: 172806
		[Token(Token = "0x402A306")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cachedCount;

		// Token: 0x0402A307 RID: 172807
		[Token(Token = "0x402A307")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_countTweener;

		// Token: 0x0402A308 RID: 172808
		[Token(Token = "0x402A308")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_colorTweener;

		// Token: 0x0402A309 RID: 172809
		[Token(Token = "0x402A309")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402A30A RID: 172810
		[Token(Token = "0x402A30A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402A30B RID: 172811
		[Token(Token = "0x402A30B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Play;
	}
}
