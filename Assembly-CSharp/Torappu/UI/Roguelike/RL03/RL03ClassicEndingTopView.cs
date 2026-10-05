using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005817 RID: 22551
	[Token(Token = "0x2005817")]
	public class RL03ClassicEndingTopView : RoguelikeClassicEndingTopView
	{
		// Token: 0x17004D5A RID: 19802
		// (set) Token: 0x06020F48 RID: 134984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D5A")]
		public override Action onShowReport
		{
			[Token(Token = "0x6020F48")]
			[Address(RVA = "0x1B47640", Offset = "0x1B46240", VA = "0x181B47640", Slot = "4")]
			set
			{
			}
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x06020F49 RID: 134985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D5B")]
		protected override string showAnimName
		{
			[Token(Token = "0x6020F49")]
			[Address(RVA = "0x1B475D0", Offset = "0x1B461D0", VA = "0x181B475D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020F4A RID: 134986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F4A")]
		[Address(RVA = "0x1B471F0", Offset = "0x1B45DF0", VA = "0x181B471F0", Slot = "6")]
		protected override void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020F4B RID: 134987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F4B")]
		[Address(RVA = "0x1B47420", Offset = "0x1B46020", VA = "0x181B47420")]
		private void _RenderDifficultIcon(RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x06020F4C RID: 134988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F4C")]
		[Address(RVA = "0x1B47180", Offset = "0x1B45D80", VA = "0x181B47180")]
		public void OnShowReportClicked()
		{
		}

		// Token: 0x06020F4D RID: 134989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F4D")]
		[Address(RVA = "0x1B47570", Offset = "0x1B46170", VA = "0x181B47570")]
		public RL03ClassicEndingTopView()
		{
		}

		// Token: 0x0402CCEA RID: 183530
		[Token(Token = "0x402CCEA")]
		private const string SHOW_ANIM_NAME = "anim_in";

		// Token: 0x0402CCEB RID: 183531
		[Token(Token = "0x402CCEB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _failTitleId;

		// Token: 0x0402CCEC RID: 183532
		[Token(Token = "0x402CCEC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _failIconId;

		// Token: 0x0402CCED RID: 183533
		[Token(Token = "0x402CCED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402CCEE RID: 183534
		[Token(Token = "0x402CCEE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _titleIcon;

		// Token: 0x0402CCEF RID: 183535
		[Token(Token = "0x402CCEF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlSuccess;

		// Token: 0x0402CCF0 RID: 183536
		[Token(Token = "0x402CCF0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlFailed;

		// Token: 0x0402CCF1 RID: 183537
		[Token(Token = "0x402CCF1")]
		[FieldOffset(Offset = "0x68")]
		private Action m_onShowReport;

		// Token: 0x0402CCF2 RID: 183538
		[Token(Token = "0x402CCF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onShowReport;

		// Token: 0x0402CCF3 RID: 183539
		[Token(Token = "0x402CCF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showAnimName;

		// Token: 0x0402CCF4 RID: 183540
		[Token(Token = "0x402CCF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CCF5 RID: 183541
		[Token(Token = "0x402CCF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDifficultIcon;

		// Token: 0x0402CCF6 RID: 183542
		[Token(Token = "0x402CCF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnShowReportClicked;

		// Token: 0x0402CCF7 RID: 183543
		[Token(Token = "0x402CCF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
