using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Birthday
{
	// Token: 0x020061D6 RID: 25046
	[Token(Token = "0x20061D6")]
	public class BirthdaySettingState : PopupFloatState, ICompDialogCallBack, IValueMsgReceiver
	{
		// Token: 0x0602422F RID: 148015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602422F")]
		[Address(RVA = "0x1EDBD60", Offset = "0x1EDA960", VA = "0x181EDBD60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024230 RID: 148016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024230")]
		[Address(RVA = "0x1EDC580", Offset = "0x1EDB180", VA = "0x181EDC580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024231 RID: 148017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024231")]
		[Address(RVA = "0x1EDC020", Offset = "0x1EDAC20", VA = "0x181EDC020", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06024232 RID: 148018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024232")]
		[Address(RVA = "0x1EDD650", Offset = "0x1EDC250", VA = "0x181EDD650")]
		private void _UpdateData()
		{
		}

		// Token: 0x06024233 RID: 148019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024233")]
		[Address(RVA = "0x1EDC340", Offset = "0x1EDAF40", VA = "0x181EDC340", Slot = "34")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024234 RID: 148020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024234")]
		[Address(RVA = "0x1EDD3B0", Offset = "0x1EDBFB0", VA = "0x181EDD3B0")]
		private void _OnSetDateClick()
		{
		}

		// Token: 0x06024235 RID: 148021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024235")]
		[Address(RVA = "0x1EDD590", Offset = "0x1EDC190", VA = "0x181EDD590")]
		private void _OnSetRegisterDateClick()
		{
		}

		// Token: 0x06024236 RID: 148022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024236")]
		[Address(RVA = "0x1EDC780", Offset = "0x1EDB380", VA = "0x181EDC780")]
		private void _OnCloseClick()
		{
		}

		// Token: 0x06024237 RID: 148023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024237")]
		[Address(RVA = "0x1EDC830", Offset = "0x1EDB430", VA = "0x181EDC830")]
		private void _OnConfirmClick()
		{
		}

		// Token: 0x06024238 RID: 148024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024238")]
		[Address(RVA = "0x1EDD000", Offset = "0x1EDBC00", VA = "0x181EDD000")]
		private void _OnJudgeConfirm()
		{
		}

		// Token: 0x06024239 RID: 148025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024239")]
		[Address(RVA = "0x1EDBDC0", Offset = "0x1EDA9C0", VA = "0x181EDBDC0", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602423A RID: 148026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602423A")]
		[Address(RVA = "0x1EDCE50", Offset = "0x1EDBA50", VA = "0x181EDCE50")]
		private void _OnDateSelect(ValueBundle output)
		{
		}

		// Token: 0x0602423B RID: 148027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602423B")]
		[Address(RVA = "0x1EDD6E0", Offset = "0x1EDC2E0", VA = "0x181EDD6E0")]
		public BirthdaySettingState()
		{
		}

		// Token: 0x0602423D RID: 148029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602423D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040323ED RID: 205805
		[Token(Token = "0x40323ED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x040323EE RID: 205806
		[Token(Token = "0x40323EE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BirthdaySettingView _view;

		// Token: 0x040323EF RID: 205807
		[Token(Token = "0x40323EF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040323F0 RID: 205808
		[Token(Token = "0x40323F0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x040323F1 RID: 205809
		[Token(Token = "0x40323F1")]
		[FieldOffset(Offset = "0x8C")]
		private int m_dateSelectDlg;

		// Token: 0x040323F2 RID: 205810
		[Token(Token = "0x40323F2")]
		[FieldOffset(Offset = "0x90")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x040323F3 RID: 205811
		[Token(Token = "0x40323F3")]
		[FieldOffset(Offset = "0x98")]
		private BirthdaySettingProperty m_prop;

		// Token: 0x040323F4 RID: 205812
		[Token(Token = "0x40323F4")]
		[NonSerialized]
		public const int ON_SET_DATE_CLICK = 0;

		// Token: 0x040323F5 RID: 205813
		[Token(Token = "0x40323F5")]
		[NonSerialized]
		public const int ON_SET_REGISTER_DATE_CLICK = 1;

		// Token: 0x040323F6 RID: 205814
		[Token(Token = "0x40323F6")]
		[NonSerialized]
		public const int ON_CONFIRM_CLICK = 2;

		// Token: 0x040323F7 RID: 205815
		[Token(Token = "0x40323F7")]
		[NonSerialized]
		public const int ON_CLOSE_CLICK = 3;

		// Token: 0x040323F8 RID: 205816
		[Token(Token = "0x40323F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040323F9 RID: 205817
		[Token(Token = "0x40323F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040323FA RID: 205818
		[Token(Token = "0x40323FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040323FB RID: 205819
		[Token(Token = "0x40323FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040323FC RID: 205820
		[Token(Token = "0x40323FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040323FD RID: 205821
		[Token(Token = "0x40323FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSetDateClick;

		// Token: 0x040323FE RID: 205822
		[Token(Token = "0x40323FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSetRegisterDateClick;

		// Token: 0x040323FF RID: 205823
		[Token(Token = "0x40323FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCloseClick;

		// Token: 0x04032400 RID: 205824
		[Token(Token = "0x4032400")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnConfirmClick;

		// Token: 0x04032401 RID: 205825
		[Token(Token = "0x4032401")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJudgeConfirm;

		// Token: 0x04032402 RID: 205826
		[Token(Token = "0x4032402")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032403 RID: 205827
		[Token(Token = "0x4032403")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnDateSelect;

		// Token: 0x04032404 RID: 205828
		[Token(Token = "0x4032404")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
