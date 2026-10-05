using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007471 RID: 29809
	[Token(Token = "0x2007471")]
	public class Act35sideEntryCarvingPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x0602A0D2 RID: 172242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D2")]
		[Address(RVA = "0x25975E0", Offset = "0x25961E0", VA = "0x1825975E0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A0D3 RID: 172243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D3")]
		[Address(RVA = "0x25979A0", Offset = "0x25965A0", VA = "0x1825979A0")]
		public void OpenCarving()
		{
		}

		// Token: 0x0602A0D4 RID: 172244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D4")]
		[Address(RVA = "0x2597B90", Offset = "0x2596790", VA = "0x182597B90")]
		private void _OnOpenCarvingPage()
		{
		}

		// Token: 0x0602A0D5 RID: 172245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D5")]
		[Address(RVA = "0x2597D50", Offset = "0x2596950", VA = "0x182597D50")]
		public Act35sideEntryCarvingPlugin()
		{
		}

		// Token: 0x0403C55F RID: 247135
		[Token(Token = "0x403C55F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UISpineLocation _animHappy;

		// Token: 0x0403C560 RID: 247136
		[Token(Token = "0x403C560")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UISpineLocation _animNormal;

		// Token: 0x0403C561 RID: 247137
		[Token(Token = "0x403C561")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _carvingEnable;

		// Token: 0x0403C562 RID: 247138
		[Token(Token = "0x403C562")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _carvingDisable;

		// Token: 0x0403C563 RID: 247139
		[Token(Token = "0x403C563")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _carvingNew;

		// Token: 0x0403C564 RID: 247140
		[Token(Token = "0x403C564")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDisable;

		// Token: 0x0403C565 RID: 247141
		[Token(Token = "0x403C565")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelCarvingBtn;

		// Token: 0x0403C566 RID: 247142
		[Token(Token = "0x403C566")]
		[FieldOffset(Offset = "0x70")]
		private Act35sideEntryCarvingViewModel m_viewModel;

		// Token: 0x0403C567 RID: 247143
		[Token(Token = "0x403C567")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C568 RID: 247144
		[Token(Token = "0x403C568")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenCarving;

		// Token: 0x0403C569 RID: 247145
		[Token(Token = "0x403C569")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnOpenCarvingPage;

		// Token: 0x0403C56A RID: 247146
		[Token(Token = "0x403C56A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
