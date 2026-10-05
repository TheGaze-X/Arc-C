using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F6C RID: 8044
	[Token(Token = "0x2001F6C")]
	public class AVGShowItemCutinSlot : AVGShowItemSlot
	{
		// Token: 0x0600C7DF RID: 51167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7DF")]
		[Address(RVA = "0x3490100", Offset = "0x348ED00", VA = "0x183490100", Slot = "4")]
		public override void Show(Command command, Sprite sprite, Action onShowEnd)
		{
		}

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E0")]
		[Address(RVA = "0x348FEA0", Offset = "0x348EAA0", VA = "0x18348FEA0", Slot = "5")]
		public override void Hide(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C7E1 RID: 51169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E1")]
		[Address(RVA = "0x34909B0", Offset = "0x348F5B0", VA = "0x1834909B0", Slot = "6")]
		protected override void _InitSlot()
		{
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E2")]
		[Address(RVA = "0x3490A10", Offset = "0x348F610", VA = "0x183490A10")]
		public AVGShowItemCutinSlot()
		{
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E3")]
		[Address(RVA = "0x348FA20", Offset = "0x348E620", VA = "0x18348FA20")]
		private void <>xLuaBaseProxy_Show(Command P0, Sprite P1, Action P2)
		{
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E4")]
		[Address(RVA = "0x348FA10", Offset = "0x348E610", VA = "0x18348FA10")]
		private void <>xLuaBaseProxy_Hide(Command P0, Action P1)
		{
		}

		// Token: 0x0400CE1B RID: 52763
		[Token(Token = "0x400CE1B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _defaultFadeTime;

		// Token: 0x0400CE1C RID: 52764
		[Token(Token = "0x400CE1C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _offsetTransform;

		// Token: 0x0400CE1D RID: 52765
		[Token(Token = "0x400CE1D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _maskRectTransform;

		// Token: 0x0400CE1E RID: 52766
		[Token(Token = "0x400CE1E")]
		[FieldOffset(Offset = "0x58")]
		private AVGShowItemCutinSlot.FadeStyle _showFadeStyle;

		// Token: 0x0400CE1F RID: 52767
		[Token(Token = "0x400CE1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400CE20 RID: 52768
		[Token(Token = "0x400CE20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400CE21 RID: 52769
		[Token(Token = "0x400CE21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitSlot;

		// Token: 0x0400CE22 RID: 52770
		[Token(Token = "0x400CE22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F6D RID: 8045
		[Token(Token = "0x2001F6D")]
		public enum FadeStyle
		{
			// Token: 0x0400CE24 RID: 52772
			[Token(Token = "0x400CE24")]
			fade,
			// Token: 0x0400CE25 RID: 52773
			[Token(Token = "0x400CE25")]
			horiz_expand_center,
			// Token: 0x0400CE26 RID: 52774
			[Token(Token = "0x400CE26")]
			horiz_expand_left2right,
			// Token: 0x0400CE27 RID: 52775
			[Token(Token = "0x400CE27")]
			horiz_expand_right2left,
			// Token: 0x0400CE28 RID: 52776
			[Token(Token = "0x400CE28")]
			vert_expand_center,
			// Token: 0x0400CE29 RID: 52777
			[Token(Token = "0x400CE29")]
			vert_expand_top2bottom,
			// Token: 0x0400CE2A RID: 52778
			[Token(Token = "0x400CE2A")]
			vert_expand_bottom2top
		}
	}
}
