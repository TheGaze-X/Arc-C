using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D18 RID: 19736
	[Token(Token = "0x2004D18")]
	public class GrocerySellResultTextTween : IHotfixable
	{
		// Token: 0x0601D92C RID: 121132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D92C")]
		[Address(RVA = "0x171AD30", Offset = "0x1719930", VA = "0x18171AD30")]
		public GrocerySellResultTextTween(Text text, GrocerySellResultTextTween.TextFormat format = GrocerySellResultTextTween.TextFormat.NORMAL)
		{
		}

		// Token: 0x0601D92D RID: 121133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D92D")]
		[Address(RVA = "0x171ACB0", Offset = "0x17198B0", VA = "0x18171ACB0")]
		public GrocerySellResultTextTween(GrocerySellSpacingTextItem specialText)
		{
		}

		// Token: 0x0601D92E RID: 121134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D92E")]
		[Address(RVA = "0x171A7F0", Offset = "0x17193F0", VA = "0x18171A7F0")]
		public void Play(int beginCnt, int endCnt, float duration, float delay = 0f)
		{
		}

		// Token: 0x0601D92F RID: 121135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D92F")]
		[Address(RVA = "0x171AAF0", Offset = "0x17196F0", VA = "0x18171AAF0")]
		public void Reset(int endVal)
		{
		}

		// Token: 0x040270CD RID: 159949
		[Token(Token = "0x40270CD")]
		private const string NORMAL_FORMAT = "{0}";

		// Token: 0x040270CE RID: 159950
		[Token(Token = "0x40270CE")]
		private const string NEGATIVE_FORMAT = "-{0}";

		// Token: 0x040270CF RID: 159951
		[Token(Token = "0x40270CF")]
		private const string POSITIVE_FORMAT = "+{0}";

		// Token: 0x040270D0 RID: 159952
		[Token(Token = "0x40270D0")]
		[FieldOffset(Offset = "0x10")]
		private Text m_text;

		// Token: 0x040270D1 RID: 159953
		[Token(Token = "0x40270D1")]
		[FieldOffset(Offset = "0x18")]
		private GrocerySellSpacingTextItem m_specialText;

		// Token: 0x040270D2 RID: 159954
		[Token(Token = "0x40270D2")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isSpecialText;

		// Token: 0x040270D3 RID: 159955
		[Token(Token = "0x40270D3")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_tweener;

		// Token: 0x040270D4 RID: 159956
		[Token(Token = "0x40270D4")]
		[FieldOffset(Offset = "0x30")]
		private string m_format;

		// Token: 0x040270D5 RID: 159957
		[Token(Token = "0x40270D5")]
		[FieldOffset(Offset = "0x38")]
		private int m_count;

		// Token: 0x040270D6 RID: 159958
		[Token(Token = "0x40270D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040270D7 RID: 159959
		[Token(Token = "0x40270D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x040270D8 RID: 159960
		[Token(Token = "0x40270D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x040270D9 RID: 159961
		[Token(Token = "0x40270D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x02004D19 RID: 19737
		[Token(Token = "0x2004D19")]
		public enum TextFormat
		{
			// Token: 0x040270DB RID: 159963
			[Token(Token = "0x40270DB")]
			NORMAL,
			// Token: 0x040270DC RID: 159964
			[Token(Token = "0x40270DC")]
			NEGATIVE,
			// Token: 0x040270DD RID: 159965
			[Token(Token = "0x40270DD")]
			POSITIVE
		}
	}
}
