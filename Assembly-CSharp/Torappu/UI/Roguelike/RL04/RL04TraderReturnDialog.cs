using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200569C RID: 22172
	[Token(Token = "0x200569C")]
	public class RL04TraderReturnDialog : UICustomDialog<RL04TraderReturnDialog.Options>
	{
		// Token: 0x0602085C RID: 133212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602085C")]
		[Address(RVA = "0x1AB71E0", Offset = "0x1AB5DE0", VA = "0x181AB71E0", Slot = "7")]
		protected override void OnRender(RL04TraderReturnDialog.Options options)
		{
		}

		// Token: 0x0602085D RID: 133213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602085D")]
		[Address(RVA = "0x1AB7170", Offset = "0x1AB5D70", VA = "0x181AB7170")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x0602085E RID: 133214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602085E")]
		[Address(RVA = "0x1AB74E0", Offset = "0x1AB60E0", VA = "0x181AB74E0")]
		public RL04TraderReturnDialog()
		{
		}

		// Token: 0x0402C127 RID: 180519
		[Token(Token = "0x402C127")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402C128 RID: 180520
		[Token(Token = "0x402C128")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0402C129 RID: 180521
		[Token(Token = "0x402C129")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402C12A RID: 180522
		[Token(Token = "0x402C12A")]
		[FieldOffset(Offset = "0x70")]
		private Action m_onConfirm;

		// Token: 0x0402C12B RID: 180523
		[Token(Token = "0x402C12B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C12C RID: 180524
		[Token(Token = "0x402C12C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0402C12D RID: 180525
		[Token(Token = "0x402C12D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200569D RID: 22173
		[Token(Token = "0x200569D")]
		public struct Options
		{
			// Token: 0x0402C12E RID: 180526
			[Token(Token = "0x402C12E")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402C12F RID: 180527
			[Token(Token = "0x402C12F")]
			[FieldOffset(Offset = "0x8")]
			public List<PlayerRoguelikeV2.CurrentData.PlayerStatus.ZoneRewardItem> items;

			// Token: 0x0402C130 RID: 180528
			[Token(Token = "0x402C130")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;
		}
	}
}
