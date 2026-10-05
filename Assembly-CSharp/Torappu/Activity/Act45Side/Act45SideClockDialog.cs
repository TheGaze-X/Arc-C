using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072D9 RID: 29401
	[Token(Token = "0x20072D9")]
	public class Act45SideClockDialog : UICompDialog<Act45SideClockDialog.Input>
	{
		// Token: 0x060299BF RID: 170431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299BF")]
		[Address(RVA = "0x24F2D60", Offset = "0x24F1960", VA = "0x1824F2D60", Slot = "18")]
		protected override void OnRender(Act45SideClockDialog.Input input)
		{
		}

		// Token: 0x060299C0 RID: 170432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C0")]
		[Address(RVA = "0x24F2FC0", Offset = "0x24F1BC0", VA = "0x1824F2FC0")]
		public Act45SideClockDialog()
		{
		}

		// Token: 0x0403B830 RID: 243760
		[Token(Token = "0x403B830")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0403B831 RID: 243761
		[Token(Token = "0x403B831")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_tween;

		// Token: 0x0403B832 RID: 243762
		[Token(Token = "0x403B832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403B833 RID: 243763
		[Token(Token = "0x403B833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072DA RID: 29402
		[Token(Token = "0x20072DA")]
		public class Input
		{
			// Token: 0x060299C2 RID: 170434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60299C2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}
	}
}
