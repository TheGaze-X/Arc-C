using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005734 RID: 22324
	[Token(Token = "0x2005734")]
	public class RL02ClassicEndingTopView : RoguelikeClassicEndingTopView
	{
		// Token: 0x17004CB6 RID: 19638
		// (set) Token: 0x06020B81 RID: 134017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CB6")]
		public override Action onShowReport
		{
			[Token(Token = "0x6020B81")]
			[Address(RVA = "0x1B06DE0", Offset = "0x1B059E0", VA = "0x181B06DE0", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x06020B82 RID: 134018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CB7")]
		protected override string showAnimName
		{
			[Token(Token = "0x6020B82")]
			[Address(RVA = "0x1B06D70", Offset = "0x1B05970", VA = "0x181B06D70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020B83 RID: 134019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B83")]
		[Address(RVA = "0x1B06BF0", Offset = "0x1B057F0", VA = "0x181B06BF0", Slot = "6")]
		protected override void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020B84 RID: 134020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B84")]
		[Address(RVA = "0x1B06B80", Offset = "0x1B05780", VA = "0x181B06B80")]
		public void OnShowReportClicked()
		{
		}

		// Token: 0x06020B85 RID: 134021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B85")]
		[Address(RVA = "0x1B06D10", Offset = "0x1B05910", VA = "0x181B06D10")]
		public RL02ClassicEndingTopView()
		{
		}

		// Token: 0x0402C693 RID: 181907
		[Token(Token = "0x402C693")]
		private const string SHOW_ANIM_NAME = "anim_in";

		// Token: 0x0402C694 RID: 181908
		[Token(Token = "0x402C694")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _failTitleId;

		// Token: 0x0402C695 RID: 181909
		[Token(Token = "0x402C695")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402C696 RID: 181910
		[Token(Token = "0x402C696")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlSuccess;

		// Token: 0x0402C697 RID: 181911
		[Token(Token = "0x402C697")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlFailed;

		// Token: 0x0402C698 RID: 181912
		[Token(Token = "0x402C698")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onShowReport;

		// Token: 0x0402C699 RID: 181913
		[Token(Token = "0x402C699")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onShowReport;

		// Token: 0x0402C69A RID: 181914
		[Token(Token = "0x402C69A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showAnimName;

		// Token: 0x0402C69B RID: 181915
		[Token(Token = "0x402C69B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C69C RID: 181916
		[Token(Token = "0x402C69C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShowReportClicked;

		// Token: 0x0402C69D RID: 181917
		[Token(Token = "0x402C69D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
