using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036EA RID: 14058
	[Token(Token = "0x20036EA")]
	[RequireComponent(typeof(CanvasGroup))]
	public class UITweenFade : BasicTween<float>
	{
		// Token: 0x0601652F RID: 91439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601652F")]
		[Address(RVA = "0xED53A0", Offset = "0xED3FA0", VA = "0x180ED53A0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06016530 RID: 91440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016530")]
		[Address(RVA = "0xED5260", Offset = "0xED3E60", VA = "0x180ED5260", Slot = "7")]
		protected override Tweener ConstructTweener(float fromValue, float toValue, float duration)
		{
			return null;
		}

		// Token: 0x06016531 RID: 91441 RVA: 0x00090900 File Offset: 0x0008EB00
		[Token(Token = "0x6016531")]
		[Address(RVA = "0xED5330", Offset = "0xED3F30", VA = "0x180ED5330", Slot = "5")]
		protected override float GetTweenValue()
		{
			return 0f;
		}

		// Token: 0x06016532 RID: 91442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016532")]
		[Address(RVA = "0xED5420", Offset = "0xED4020", VA = "0x180ED5420", Slot = "6")]
		protected override void SetTweenValue(float val)
		{
		}

		// Token: 0x06016533 RID: 91443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016533")]
		[Address(RVA = "0xED54A0", Offset = "0xED40A0", VA = "0x180ED54A0")]
		public UITweenFade()
		{
		}

		// Token: 0x0401AD99 RID: 109977
		[Token(Token = "0x401AD99")]
		[FieldOffset(Offset = "0x50")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0401AD9A RID: 109978
		[Token(Token = "0x401AD9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401AD9B RID: 109979
		[Token(Token = "0x401AD9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConstructTweener;

		// Token: 0x0401AD9C RID: 109980
		[Token(Token = "0x401AD9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTweenValue;

		// Token: 0x0401AD9D RID: 109981
		[Token(Token = "0x401AD9D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTweenValue;

		// Token: 0x0401AD9E RID: 109982
		[Token(Token = "0x401AD9E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
