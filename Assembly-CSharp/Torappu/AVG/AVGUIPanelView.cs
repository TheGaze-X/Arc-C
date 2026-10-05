using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F40 RID: 8000
	[Token(Token = "0x2001F40")]
	public class AVGUIPanelView : MonoBehaviour, IAVGDataSubscriber<AVGStoryCache>, IHotfixable
	{
		// Token: 0x0600C6DF RID: 50911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DF")]
		[Address(RVA = "0x3484EB0", Offset = "0x3483AB0", VA = "0x183484EB0")]
		public void SetController(AVGController controller)
		{
		}

		// Token: 0x0600C6E0 RID: 50912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E0")]
		[Address(RVA = "0x3484D60", Offset = "0x3483960", VA = "0x183484D60", Slot = "4")]
		public void OnValueChanged(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E1")]
		[Address(RVA = "0x3485BE0", Offset = "0x34847E0", VA = "0x183485BE0")]
		private void _UpdateUI(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6E2 RID: 50914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E2")]
		[Address(RVA = "0x34855C0", Offset = "0x34841C0", VA = "0x1834855C0")]
		private void _UpdateLogBtn()
		{
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E3")]
		[Address(RVA = "0x3485650", Offset = "0x3484250", VA = "0x183485650")]
		private void _UpdateReaderModeBtn()
		{
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E4")]
		[Address(RVA = "0x3484F30", Offset = "0x3483B30", VA = "0x183484F30")]
		private void _UpdateAutoPlayModeUI(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E5")]
		[Address(RVA = "0x34859C0", Offset = "0x34845C0", VA = "0x1834859C0")]
		private void _UpdateTheaterModeUI(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E6")]
		[Address(RVA = "0x3485180", Offset = "0x3483D80", VA = "0x183485180")]
		private void _UpdateExecuteModeUI(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E7")]
		[Address(RVA = "0x3485740", Offset = "0x3484340", VA = "0x183485740")]
		private void _UpdateSpeedButtonIcon(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E8")]
		[Address(RVA = "0x3485E60", Offset = "0x3484A60", VA = "0x183485E60")]
		public AVGUIPanelView()
		{
		}

		// Token: 0x0400CC73 RID: 52339
		[Token(Token = "0x400CC73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("UI Elements")]
		private GameObject _speedBtn;

		// Token: 0x0400CC74 RID: 52340
		[Token(Token = "0x400CC74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("UI Elements")]
		private AVGAutoButton _autoBtn;

		// Token: 0x0400CC75 RID: 52341
		[Token(Token = "0x400CC75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("UI Elements")]
		private GameObject _readerModeBtn;

		// Token: 0x0400CC76 RID: 52342
		[Token(Token = "0x400CC76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("UI Elements")]
		private GameObject _hideuiBtn;

		// Token: 0x0400CC77 RID: 52343
		[Token(Token = "0x400CC77")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("UI Elements")]
		private GameObject _settingBtn;

		// Token: 0x0400CC78 RID: 52344
		[Token(Token = "0x400CC78")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("UI Elements")]
		private GameObject _dialogPanel;

		// Token: 0x0400CC79 RID: 52345
		[Token(Token = "0x400CC79")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("UI Elements")]
		private GameObject _logBtn;

		// Token: 0x0400CC7A RID: 52346
		[Token(Token = "0x400CC7A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("AutoSpeed Resources")]
		private AutoSpeed _dialogDefaultSpeed;

		// Token: 0x0400CC7B RID: 52347
		[Token(Token = "0x400CC7B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("AutoSpeed Resources")]
		private AutoSpeed[] _btnAutoSpeed;

		// Token: 0x0400CC7C RID: 52348
		[Token(Token = "0x400CC7C")]
		[FieldOffset(Offset = "0x70")]
		private AVGController m_controller;

		// Token: 0x0400CC7D RID: 52349
		[Token(Token = "0x400CC7D")]
		[FieldOffset(Offset = "0x78")]
		private AVGStoryCache m_prevCache;

		// Token: 0x0400CC7E RID: 52350
		[Token(Token = "0x400CC7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetController;

		// Token: 0x0400CC7F RID: 52351
		[Token(Token = "0x400CC7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CC80 RID: 52352
		[Token(Token = "0x400CC80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateUI;

		// Token: 0x0400CC81 RID: 52353
		[Token(Token = "0x400CC81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateLogBtn;

		// Token: 0x0400CC82 RID: 52354
		[Token(Token = "0x400CC82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateReaderModeBtn;

		// Token: 0x0400CC83 RID: 52355
		[Token(Token = "0x400CC83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateAutoPlayModeUI;

		// Token: 0x0400CC84 RID: 52356
		[Token(Token = "0x400CC84")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateTheaterModeUI;

		// Token: 0x0400CC85 RID: 52357
		[Token(Token = "0x400CC85")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateExecuteModeUI;

		// Token: 0x0400CC86 RID: 52358
		[Token(Token = "0x400CC86")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateSpeedButtonIcon;

		// Token: 0x0400CC87 RID: 52359
		[Token(Token = "0x400CC87")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
