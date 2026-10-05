using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036EB RID: 14059
	[Token(Token = "0x20036EB")]
	[RequireComponent(typeof(Text))]
	public class UITweenIntText : BasicTween<int>, IHotfixable
	{
		// Token: 0x06016534 RID: 91444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016534")]
		[Address(RVA = "0xED5710", Offset = "0xED4310", VA = "0x180ED5710", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06016535 RID: 91445 RVA: 0x00090918 File Offset: 0x0008EB18
		[Token(Token = "0x6016535")]
		[Address(RVA = "0xED56B0", Offset = "0xED42B0", VA = "0x180ED56B0", Slot = "5")]
		protected override int GetTweenValue()
		{
			return 0;
		}

		// Token: 0x06016536 RID: 91446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016536")]
		[Address(RVA = "0xED5850", Offset = "0xED4450", VA = "0x180ED5850", Slot = "6")]
		protected override void SetTweenValue(int val)
		{
		}

		// Token: 0x06016537 RID: 91447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016537")]
		[Address(RVA = "0xED5510", Offset = "0xED4110", VA = "0x180ED5510", Slot = "7")]
		protected override Tweener ConstructTweener(int fromValue, int toValue, float duration)
		{
			return null;
		}

		// Token: 0x06016538 RID: 91448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016538")]
		[Address(RVA = "0xED5960", Offset = "0xED4560", VA = "0x180ED5960")]
		public UITweenIntText()
		{
		}

		// Token: 0x0401AD9F RID: 109983
		[Token(Token = "0x401AD9F")]
		[FieldOffset(Offset = "0x50")]
		private Text m_text;

		// Token: 0x0401ADA0 RID: 109984
		[Token(Token = "0x401ADA0")]
		[FieldOffset(Offset = "0x58")]
		private int m_currNum;

		// Token: 0x0401ADA1 RID: 109985
		[Token(Token = "0x401ADA1")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_cachedTween;

		// Token: 0x0401ADA2 RID: 109986
		[Token(Token = "0x401ADA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401ADA3 RID: 109987
		[Token(Token = "0x401ADA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTweenValue;

		// Token: 0x0401ADA4 RID: 109988
		[Token(Token = "0x401ADA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetTweenValue;

		// Token: 0x0401ADA5 RID: 109989
		[Token(Token = "0x401ADA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ConstructTweener;

		// Token: 0x0401ADA6 RID: 109990
		[Token(Token = "0x401ADA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
