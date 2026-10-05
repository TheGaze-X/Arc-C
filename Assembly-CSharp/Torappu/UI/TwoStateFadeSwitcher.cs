using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C9 RID: 14793
	[Token(Token = "0x20039C9")]
	public class TwoStateFadeSwitcher : TwoStateSwitcher, IHotfixable
	{
		// Token: 0x060175E4 RID: 95716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E4")]
		[Address(RVA = "0xFB9BF0", Offset = "0xFB87F0", VA = "0x180FB9BF0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060175E5 RID: 95717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E5")]
		[Address(RVA = "0xFB9D20", Offset = "0xFB8920", VA = "0x180FB9D20", Slot = "10")]
		protected override void OnResetState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175E6 RID: 95718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E6")]
		[Address(RVA = "0xFB9B50", Offset = "0xFB8750", VA = "0x180FB9B50", Slot = "11")]
		protected override void OnChangeState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175E7 RID: 95719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E7")]
		[Address(RVA = "0xFB9DC0", Offset = "0xFB89C0", VA = "0x180FB9DC0")]
		public TwoStateFadeSwitcher()
		{
		}

		// Token: 0x0401C38B RID: 115595
		[Token(Token = "0x401C38B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _unselect;

		// Token: 0x0401C38C RID: 115596
		[Token(Token = "0x401C38C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _select;

		// Token: 0x0401C38D RID: 115597
		[Token(Token = "0x401C38D")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_selectTween;

		// Token: 0x0401C38E RID: 115598
		[Token(Token = "0x401C38E")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_unselectTween;

		// Token: 0x0401C38F RID: 115599
		[Token(Token = "0x401C38F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C390 RID: 115600
		[Token(Token = "0x401C390")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResetState;

		// Token: 0x0401C391 RID: 115601
		[Token(Token = "0x401C391")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnChangeState;

		// Token: 0x0401C392 RID: 115602
		[Token(Token = "0x401C392")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
