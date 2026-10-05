using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB4 RID: 23476
	[Token(Token = "0x2005BB4")]
	public class CommonInviteDialogView : DataBinder<CommonInviteDialogProp>
	{
		// Token: 0x060220DE RID: 139486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220DE")]
		[Address(RVA = "0x1C92480", Offset = "0x1C91080", VA = "0x181C92480")]
		private void Update()
		{
		}

		// Token: 0x060220DF RID: 139487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220DF")]
		[Address(RVA = "0x1C924F0", Offset = "0x1C910F0", VA = "0x181C924F0")]
		private void _InitIfNot(CommonInviteDialog.TextConfig textConfig)
		{
		}

		// Token: 0x060220E0 RID: 139488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E0")]
		[Address(RVA = "0x1C92990", Offset = "0x1C91590", VA = "0x181C92990")]
		private void _SetRefresh(bool valid)
		{
		}

		// Token: 0x060220E1 RID: 139489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E1")]
		[Address(RVA = "0x1C928C0", Offset = "0x1C914C0", VA = "0x181C928C0")]
		private void _SetCooldownTime(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x060220E2 RID: 139490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E2")]
		[Address(RVA = "0x1C92050", Offset = "0x1C90C50", VA = "0x181C92050", Slot = "7")]
		public override void OnValueChanged(CommonInviteDialogProp property)
		{
		}

		// Token: 0x060220E3 RID: 139491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E3")]
		[Address(RVA = "0x1C91D70", Offset = "0x1C90970", VA = "0x181C91D70")]
		public void DealWithDrag(Vector2 offset)
		{
		}

		// Token: 0x060220E4 RID: 139492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E4")]
		[Address(RVA = "0x1C91FB0", Offset = "0x1C90BB0", VA = "0x181C91FB0")]
		public void OnToggleClick()
		{
		}

		// Token: 0x060220E5 RID: 139493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E5")]
		[Address(RVA = "0x1C91EE0", Offset = "0x1C90AE0", VA = "0x181C91EE0")]
		public void OnRefreshClick()
		{
		}

		// Token: 0x060220E6 RID: 139494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E6")]
		[Address(RVA = "0x1C92A20", Offset = "0x1C91620", VA = "0x181C92A20")]
		public CommonInviteDialogView()
		{
		}

		// Token: 0x0402EB1B RID: 191259
		[Token(Token = "0x402EB1B")]
		private const int REFRESH_BORDER_THRESHOLD_COUNT = 4;

		// Token: 0x0402EB1C RID: 191260
		[Token(Token = "0x402EB1C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CommonInviteDialogListAdapter _listAdapter;

		// Token: 0x0402EB1D RID: 191261
		[Token(Token = "0x402EB1D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0402EB1E RID: 191262
		[Token(Token = "0x402EB1E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelInvite;

		// Token: 0x0402EB1F RID: 191263
		[Token(Token = "0x402EB1F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelInviteEmpty;

		// Token: 0x0402EB20 RID: 191264
		[Token(Token = "0x402EB20")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelInvited;

		// Token: 0x0402EB21 RID: 191265
		[Token(Token = "0x402EB21")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelInvitedEmpty;

		// Token: 0x0402EB22 RID: 191266
		[Token(Token = "0x402EB22")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _refreshVariant;

		// Token: 0x0402EB23 RID: 191267
		[Token(Token = "0x402EB23")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _cooldownVariant;

		// Token: 0x0402EB24 RID: 191268
		[Token(Token = "0x402EB24")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _cooldownTimeText;

		// Token: 0x0402EB25 RID: 191269
		[Token(Token = "0x402EB25")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textInviteTitle;

		// Token: 0x0402EB26 RID: 191270
		[Token(Token = "0x402EB26")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textReceiveTitle;

		// Token: 0x0402EB27 RID: 191271
		[Token(Token = "0x402EB27")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textReceiveSetting;

		// Token: 0x0402EB28 RID: 191272
		[Token(Token = "0x402EB28")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textInviteEmpty;

		// Token: 0x0402EB29 RID: 191273
		[Token(Token = "0x402EB29")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("I18N Texts")]
		private Text _textReceiveEmpty;

		// Token: 0x0402EB2A RID: 191274
		[Token(Token = "0x402EB2A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0402EB2B RID: 191275
		[Token(Token = "0x402EB2B")]
		[FieldOffset(Offset = "0x98")]
		private UICompDialogFinder m_dlgFinder;

		// Token: 0x0402EB2C RID: 191276
		[Token(Token = "0x402EB2C")]
		[FieldOffset(Offset = "0xA8")]
		private CommonInviteDialogViewModel m_viewModel;

		// Token: 0x0402EB2D RID: 191277
		[Token(Token = "0x402EB2D")]
		[FieldOffset(Offset = "0xB0")]
		private SeqNumSource.Checker m_resetChecker;

		// Token: 0x0402EB2E RID: 191278
		[Token(Token = "0x402EB2E")]
		[FieldOffset(Offset = "0xB8")]
		private SeqNumSource.Checker m_listChangeChecker;

		// Token: 0x0402EB2F RID: 191279
		[Token(Token = "0x402EB2F")]
		[FieldOffset(Offset = "0xC0")]
		private CountDownTask m_countDownTask;

		// Token: 0x0402EB30 RID: 191280
		[Token(Token = "0x402EB30")]
		[FieldOffset(Offset = "0xC8")]
		private long m_cachedProtectTs;

		// Token: 0x0402EB31 RID: 191281
		[Token(Token = "0x402EB31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402EB32 RID: 191282
		[Token(Token = "0x402EB32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EB33 RID: 191283
		[Token(Token = "0x402EB33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetRefresh;

		// Token: 0x0402EB34 RID: 191284
		[Token(Token = "0x402EB34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetCooldownTime;

		// Token: 0x0402EB35 RID: 191285
		[Token(Token = "0x402EB35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402EB36 RID: 191286
		[Token(Token = "0x402EB36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealWithDrag;

		// Token: 0x0402EB37 RID: 191287
		[Token(Token = "0x402EB37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnToggleClick;

		// Token: 0x0402EB38 RID: 191288
		[Token(Token = "0x402EB38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRefreshClick;

		// Token: 0x0402EB39 RID: 191289
		[Token(Token = "0x402EB39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
