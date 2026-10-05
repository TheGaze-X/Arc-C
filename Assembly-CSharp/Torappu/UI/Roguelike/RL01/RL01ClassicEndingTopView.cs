using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057B5 RID: 22453
	[Token(Token = "0x20057B5")]
	public class RL01ClassicEndingTopView : RoguelikeClassicEndingTopView
	{
		// Token: 0x17004CFB RID: 19707
		// (set) Token: 0x06020D60 RID: 134496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CFB")]
		public override Action onShowReport
		{
			[Token(Token = "0x6020D60")]
			[Address(RVA = "0x1B1B9D0", Offset = "0x1B1A5D0", VA = "0x181B1B9D0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x06020D61 RID: 134497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CFC")]
		protected override string showAnimName
		{
			[Token(Token = "0x6020D61")]
			[Address(RVA = "0x1B1B960", Offset = "0x1B1A560", VA = "0x181B1B960", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020D62 RID: 134498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D62")]
		[Address(RVA = "0x1B1B810", Offset = "0x1B1A410", VA = "0x181B1B810", Slot = "6")]
		protected override void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020D63 RID: 134499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D63")]
		[Address(RVA = "0x1B1B7A0", Offset = "0x1B1A3A0", VA = "0x181B1B7A0")]
		public void OnShowReportClicked()
		{
		}

		// Token: 0x06020D64 RID: 134500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D64")]
		[Address(RVA = "0x1B1B900", Offset = "0x1B1A500", VA = "0x181B1B900")]
		public RL01ClassicEndingTopView()
		{
		}

		// Token: 0x0402C9E6 RID: 182758
		[Token(Token = "0x402C9E6")]
		private const string SHOW_ANIM_NAME = "anim_in";

		// Token: 0x0402C9E7 RID: 182759
		[Token(Token = "0x402C9E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _failTitleId;

		// Token: 0x0402C9E8 RID: 182760
		[Token(Token = "0x402C9E8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402C9E9 RID: 182761
		[Token(Token = "0x402C9E9")]
		[FieldOffset(Offset = "0x48")]
		private Action m_onShowReport;

		// Token: 0x0402C9EA RID: 182762
		[Token(Token = "0x402C9EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onShowReport;

		// Token: 0x0402C9EB RID: 182763
		[Token(Token = "0x402C9EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showAnimName;

		// Token: 0x0402C9EC RID: 182764
		[Token(Token = "0x402C9EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C9ED RID: 182765
		[Token(Token = "0x402C9ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShowReportClicked;

		// Token: 0x0402C9EE RID: 182766
		[Token(Token = "0x402C9EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
