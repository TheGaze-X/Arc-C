using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x0200747E RID: 29822
	[Token(Token = "0x200747E")]
	public class Act33SignPlugin : MonoBehaviour, ITemplateActivityExtraSignPlugin, IHotfixable
	{
		// Token: 0x0602A0F4 RID: 172276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F4")]
		[Address(RVA = "0x25BE370", Offset = "0x25BCF70", VA = "0x1825BE370", Slot = "4")]
		public void InitPlugin(ExtraSignPluginOptions options)
		{
		}

		// Token: 0x0602A0F5 RID: 172277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F5")]
		[Address(RVA = "0x25BE570", Offset = "0x25BD170", VA = "0x1825BE570", Slot = "5")]
		public void RefreshPlugin()
		{
		}

		// Token: 0x0602A0F6 RID: 172278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F6")]
		[Address(RVA = "0x25BED40", Offset = "0x25BD940", VA = "0x1825BED40")]
		private void _RenderInfoPanel(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A0F7 RID: 172279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0F7")]
		[Address(RVA = "0x25BE930", Offset = "0x25BD530", VA = "0x1825BE930")]
		private string _GenRedpackTips(Act33SignRedpackViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0602A0F8 RID: 172280 RVA: 0x000D7598 File Offset: 0x000D5798
		[Token(Token = "0x602A0F8")]
		[Address(RVA = "0x25BEAE0", Offset = "0x25BD6E0", VA = "0x1825BEAE0")]
		private bool _JudgeShouldReplaceNew(int closestDay, Act33SignRedpackItemViewModel newItem)
		{
			return default(bool);
		}

		// Token: 0x0602A0F9 RID: 172281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F9")]
		[Address(RVA = "0x25BF090", Offset = "0x25BDC90", VA = "0x1825BF090")]
		private void _RenderListView(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A0FA RID: 172282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0FA")]
		[Address(RVA = "0x25BEBB0", Offset = "0x25BD7B0", VA = "0x1825BEBB0")]
		private void _RenderDetailView(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A0FB RID: 172283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0FB")]
		[Address(RVA = "0x25BE450", Offset = "0x25BD050", VA = "0x1825BE450")]
		public void OnRedpackListClick()
		{
		}

		// Token: 0x0602A0FC RID: 172284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0FC")]
		[Address(RVA = "0x25BE3F0", Offset = "0x25BCFF0", VA = "0x1825BE3F0")]
		public void OnRedpackDetailClick()
		{
		}

		// Token: 0x0602A0FD RID: 172285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0FD")]
		[Address(RVA = "0x25BF160", Offset = "0x25BDD60", VA = "0x1825BF160")]
		public Act33SignPlugin()
		{
		}

		// Token: 0x0403C5A6 RID: 247206
		[Token(Token = "0x403C5A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act33SignRedpackDetailView _detailView;

		// Token: 0x0403C5A7 RID: 247207
		[Token(Token = "0x403C5A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act33SignRedpackListView _listView;

		// Token: 0x0403C5A8 RID: 247208
		[Token(Token = "0x403C5A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x0403C5A9 RID: 247209
		[Token(Token = "0x403C5A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _redpackAvailablePanel;

		// Token: 0x0403C5AA RID: 247210
		[Token(Token = "0x403C5AA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nextRedpackTips;

		// Token: 0x0403C5AB RID: 247211
		[Token(Token = "0x403C5AB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text[] _mainRewardCountDowns;

		// Token: 0x0403C5AC RID: 247212
		[Token(Token = "0x403C5AC")]
		[FieldOffset(Offset = "0x48")]
		private ExtraSignPluginOptions m_optionStruct;

		// Token: 0x0403C5AD RID: 247213
		[Token(Token = "0x403C5AD")]
		[FieldOffset(Offset = "0x50")]
		private Act33SignRedpackViewModel m_viewModel;

		// Token: 0x0403C5AE RID: 247214
		[Token(Token = "0x403C5AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitPlugin;

		// Token: 0x0403C5AF RID: 247215
		[Token(Token = "0x403C5AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlugin;

		// Token: 0x0403C5B0 RID: 247216
		[Token(Token = "0x403C5B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderInfoPanel;

		// Token: 0x0403C5B1 RID: 247217
		[Token(Token = "0x403C5B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenRedpackTips;

		// Token: 0x0403C5B2 RID: 247218
		[Token(Token = "0x403C5B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__JudgeShouldReplaceNew;

		// Token: 0x0403C5B3 RID: 247219
		[Token(Token = "0x403C5B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderListView;

		// Token: 0x0403C5B4 RID: 247220
		[Token(Token = "0x403C5B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderDetailView;

		// Token: 0x0403C5B5 RID: 247221
		[Token(Token = "0x403C5B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRedpackListClick;

		// Token: 0x0403C5B6 RID: 247222
		[Token(Token = "0x403C5B6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRedpackDetailClick;

		// Token: 0x0403C5B7 RID: 247223
		[Token(Token = "0x403C5B7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
