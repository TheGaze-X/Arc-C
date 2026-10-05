using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F3D RID: 7997
	[Token(Token = "0x2001F3D")]
	public class AVGReaderSettingDialog : UICompDialog<AVGReaderSettingDialog.Input>
	{
		// Token: 0x0600C6CE RID: 50894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6CE")]
		[Address(RVA = "0x34842B0", Offset = "0x3482EB0", VA = "0x1834842B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C6CF RID: 50895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6CF")]
		[Address(RVA = "0x3484210", Offset = "0x3482E10", VA = "0x183484210", Slot = "18")]
		protected override void OnRender(AVGReaderSettingDialog.Input input)
		{
		}

		// Token: 0x0600C6D0 RID: 50896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D0")]
		[Address(RVA = "0x3484520", Offset = "0x3483120", VA = "0x183484520")]
		private void _SendSettingChangedMsg()
		{
		}

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D1")]
		[Address(RVA = "0x3483D90", Offset = "0x3482990", VA = "0x183483D90")]
		public void EventOnFontSettingToggleChanged(int idx)
		{
		}

		// Token: 0x0600C6D2 RID: 50898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D2")]
		[Address(RVA = "0x3483F70", Offset = "0x3482B70", VA = "0x183483F70")]
		public void EventOnLineSpaceSettingToggleChanged(int idx)
		{
		}

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D3")]
		[Address(RVA = "0x3483CA0", Offset = "0x34828A0", VA = "0x183483CA0")]
		public void EventOnBgAlphaSettingChanged(int idx)
		{
		}

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D4")]
		[Address(RVA = "0x3484060", Offset = "0x3482C60", VA = "0x183484060")]
		public void EventOnPureModeSwitch(TwoStateToggle.State state)
		{
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D5")]
		[Address(RVA = "0x3483E80", Offset = "0x3482A80", VA = "0x183483E80")]
		public void EventOnHideSetting()
		{
		}

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D6")]
		[Address(RVA = "0x3484120", Offset = "0x3482D20", VA = "0x183484120", Slot = "11")]
		protected override void OnDestroySubClass()
		{
		}

		// Token: 0x0600C6D7 RID: 50903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D7")]
		[Address(RVA = "0x3484690", Offset = "0x3483290", VA = "0x183484690")]
		public AVGReaderSettingDialog()
		{
		}

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D8")]
		[Address(RVA = "0x1E376C0", Offset = "0x1E362C0", VA = "0x181E376C0")]
		private void <>xLuaBaseProxy_OnDestroySubClass()
		{
		}

		// Token: 0x0400CC53 RID: 52307
		[Token(Token = "0x400CC53")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AVGReaderSettingView _view;

		// Token: 0x0400CC54 RID: 52308
		[Token(Token = "0x400CC54")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AVGFontPreset[] _fontSets;

		// Token: 0x0400CC55 RID: 52309
		[Token(Token = "0x400CC55")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AVGReaderLineSpacePreset[] _lineSpaceSets;

		// Token: 0x0400CC56 RID: 52310
		[Token(Token = "0x400CC56")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AVGReaderAlphaPreset[] _alphaSets;

		// Token: 0x0400CC57 RID: 52311
		[Token(Token = "0x400CC57")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backTarget;

		// Token: 0x0400CC58 RID: 52312
		[Token(Token = "0x400CC58")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0400CC59 RID: 52313
		[Token(Token = "0x400CC59")]
		[FieldOffset(Offset = "0xA0")]
		private AVGUIStateEngineController m_uiController;

		// Token: 0x0400CC5A RID: 52314
		[Token(Token = "0x400CC5A")]
		[FieldOffset(Offset = "0xA8")]
		private UICompDialogFinder m_finder;

		// Token: 0x0400CC5B RID: 52315
		[Token(Token = "0x400CC5B")]
		[FieldOffset(Offset = "0xB8")]
		private Transform m_mainDialogTransform;

		// Token: 0x0400CC5C RID: 52316
		[Token(Token = "0x400CC5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400CC5D RID: 52317
		[Token(Token = "0x400CC5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0400CC5E RID: 52318
		[Token(Token = "0x400CC5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendSettingChangedMsg;

		// Token: 0x0400CC5F RID: 52319
		[Token(Token = "0x400CC5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFontSettingToggleChanged;

		// Token: 0x0400CC60 RID: 52320
		[Token(Token = "0x400CC60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnLineSpaceSettingToggleChanged;

		// Token: 0x0400CC61 RID: 52321
		[Token(Token = "0x400CC61")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBgAlphaSettingChanged;

		// Token: 0x0400CC62 RID: 52322
		[Token(Token = "0x400CC62")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnPureModeSwitch;

		// Token: 0x0400CC63 RID: 52323
		[Token(Token = "0x400CC63")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnHideSetting;

		// Token: 0x0400CC64 RID: 52324
		[Token(Token = "0x400CC64")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroySubClass;

		// Token: 0x0400CC65 RID: 52325
		[Token(Token = "0x400CC65")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F3E RID: 7998
		[Token(Token = "0x2001F3E")]
		public class Input
		{
			// Token: 0x0600C6D9 RID: 50905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6D9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0400CC66 RID: 52326
			[Token(Token = "0x400CC66")]
			[FieldOffset(Offset = "0x10")]
			public AVGUIStateEngineController uiController;

			// Token: 0x0400CC67 RID: 52327
			[Token(Token = "0x400CC67")]
			[FieldOffset(Offset = "0x18")]
			public Transform mainDialogTransform;
		}
	}
}
