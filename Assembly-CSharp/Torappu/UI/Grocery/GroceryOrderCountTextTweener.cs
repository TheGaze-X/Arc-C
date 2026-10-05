using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CC7 RID: 19655
	[Token(Token = "0x2004CC7")]
	public class GroceryOrderCountTextTweener : IHotfixable
	{
		// Token: 0x0601D710 RID: 120592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D710")]
		[Address(RVA = "0x16FAA40", Offset = "0x16F9640", VA = "0x1816FAA40")]
		public GroceryOrderCountTextTweener(Text text, float dur)
		{
		}

		// Token: 0x0601D711 RID: 120593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D711")]
		[Address(RVA = "0x16FA6A0", Offset = "0x16F92A0", VA = "0x1816FA6A0")]
		public void Play(int endCnt, bool isFastMode = false)
		{
		}

		// Token: 0x0601D712 RID: 120594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D712")]
		[Address(RVA = "0x16FA8F0", Offset = "0x16F94F0", VA = "0x1816FA8F0")]
		public void Reset(int endCnt)
		{
		}

		// Token: 0x04026CDD RID: 158941
		[Token(Token = "0x4026CDD")]
		[FieldOffset(Offset = "0x10")]
		private Text m_text;

		// Token: 0x04026CDE RID: 158942
		[Token(Token = "0x4026CDE")]
		[FieldOffset(Offset = "0x18")]
		private Tween m_exactCountTweener;

		// Token: 0x04026CDF RID: 158943
		[Token(Token = "0x4026CDF")]
		[FieldOffset(Offset = "0x20")]
		private float m_dur;

		// Token: 0x04026CE0 RID: 158944
		[Token(Token = "0x4026CE0")]
		[FieldOffset(Offset = "0x24")]
		private int m_cachedCount;

		// Token: 0x04026CE1 RID: 158945
		[Token(Token = "0x4026CE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04026CE2 RID: 158946
		[Token(Token = "0x4026CE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04026CE3 RID: 158947
		[Token(Token = "0x4026CE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;
	}
}
