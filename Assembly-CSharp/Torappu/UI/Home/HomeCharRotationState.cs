using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B0A RID: 19210
	[Token(Token = "0x2004B0A")]
	public class HomeCharRotationState : HomeReplaceableState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0601CDF0 RID: 118256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDF0")]
		[Address(RVA = "0x164EA50", Offset = "0x164D650", VA = "0x18164EA50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CDF1 RID: 118257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDF1")]
		[Address(RVA = "0x164EF90", Offset = "0x164DB90", VA = "0x18164EF90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CDF2 RID: 118258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDF2")]
		[Address(RVA = "0x164FB70", Offset = "0x164E770", VA = "0x18164FB70", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CDF3 RID: 118259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDF3")]
		[Address(RVA = "0x164FB00", Offset = "0x164E700", VA = "0x18164FB00", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601CDF4 RID: 118260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDF4")]
		[Address(RVA = "0x164F080", Offset = "0x164DC80", VA = "0x18164F080", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CDF5 RID: 118261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDF5")]
		[Address(RVA = "0x164EF20", Offset = "0x164DB20", VA = "0x18164EF20")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0601CDF6 RID: 118262 RVA: 0x000A9B30 File Offset: 0x000A7D30
		[Token(Token = "0x601CDF6")]
		[Address(RVA = "0x1650580", Offset = "0x164F180", VA = "0x181650580", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601CDF7 RID: 118263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDF7")]
		[Address(RVA = "0x164FCE0", Offset = "0x164E8E0", VA = "0x18164FCE0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601CDF8 RID: 118264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDF8")]
		[Address(RVA = "0x164FF10", Offset = "0x164EB10", VA = "0x18164FF10", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CDF9 RID: 118265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDF9")]
		[Address(RVA = "0x1650B10", Offset = "0x164F710", VA = "0x181650B10")]
		private void _EventToOpenHomeBackGroundChangeState(IStateBean stateBean)
		{
		}

		// Token: 0x0601CDFA RID: 118266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDFA")]
		[Address(RVA = "0x1650C50", Offset = "0x164F850", VA = "0x181650C50")]
		private void _EventToOpenHomeThemeChangeState(IStateBean stateBean)
		{
		}

		// Token: 0x0601CDFB RID: 118267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDFB")]
		[Address(RVA = "0x16508B0", Offset = "0x164F4B0", VA = "0x1816508B0")]
		private void _EventRoutedFromBackgroundAndThemeChangeState(IStateBean stateBean)
		{
		}

		// Token: 0x0601CDFC RID: 118268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDFC")]
		[Address(RVA = "0x16509A0", Offset = "0x164F5A0", VA = "0x1816509A0")]
		private void _EventRoutedFromSkinSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601CDFD RID: 118269 RVA: 0x000A9B48 File Offset: 0x000A7D48
		[Token(Token = "0x601CDFD")]
		[Address(RVA = "0x16513D0", Offset = "0x164FFD0", VA = "0x1816513D0")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601CDFE RID: 118270 RVA: 0x000A9B60 File Offset: 0x000A7D60
		[Token(Token = "0x601CDFE")]
		[Address(RVA = "0x1651340", Offset = "0x164FF40", VA = "0x181651340")]
		private bool _IsPanelHide(HomeCharRotationViewModel model)
		{
			return default(bool);
		}

		// Token: 0x0601CDFF RID: 118271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDFF")]
		[Address(RVA = "0x1650F50", Offset = "0x164FB50", VA = "0x181650F50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CE00 RID: 118272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE00")]
		[Address(RVA = "0x1652D50", Offset = "0x1651950", VA = "0x181652D50")]
		private void _TryPlayDynEntranceOnBack()
		{
		}

		// Token: 0x0601CE01 RID: 118273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE01")]
		[Address(RVA = "0x1652BC0", Offset = "0x16517C0", VA = "0x181652BC0")]
		private void _StartPreviewMode()
		{
		}

		// Token: 0x0601CE02 RID: 118274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE02")]
		[Address(RVA = "0x1650E30", Offset = "0x164FA30", VA = "0x181650E30")]
		private void _ExitPreviewMode()
		{
		}

		// Token: 0x0601CE03 RID: 118275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE03")]
		[Address(RVA = "0x164EC20", Offset = "0x164D820", VA = "0x18164EC20", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CE04 RID: 118276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE04")]
		[Address(RVA = "0x164ECD0", Offset = "0x164D8D0", VA = "0x18164ECD0", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CE05 RID: 118277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE05")]
		[Address(RVA = "0x16501C0", Offset = "0x164EDC0", VA = "0x1816501C0", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CE06 RID: 118278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE06")]
		[Address(RVA = "0x1650290", Offset = "0x164EE90", VA = "0x181650290", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CE07 RID: 118279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE07")]
		[Address(RVA = "0x164F1B0", Offset = "0x164DDB0", VA = "0x18164F1B0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601CE08 RID: 118280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE08")]
		[Address(RVA = "0x16505F0", Offset = "0x164F1F0", VA = "0x1816505F0")]
		private void _ChangeListShow(long intVal)
		{
		}

		// Token: 0x0601CE09 RID: 118281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE09")]
		[Address(RVA = "0x1652350", Offset = "0x1650F50", VA = "0x181652350")]
		private void _SelectSkinInRotationList(string uniqueSkinTag)
		{
		}

		// Token: 0x0601CE0A RID: 118282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE0A")]
		[Address(RVA = "0x1651D80", Offset = "0x1650980", VA = "0x181651D80")]
		private void _OpenChangeSecretaryState()
		{
		}

		// Token: 0x0601CE0B RID: 118283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE0B")]
		[Address(RVA = "0x1652100", Offset = "0x1650D00", VA = "0x181652100")]
		private void _OpenPresetListDialog()
		{
		}

		// Token: 0x0601CE0C RID: 118284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE0C")]
		[Address(RVA = "0x1651C60", Offset = "0x1650860", VA = "0x181651C60")]
		private void _OpenChangeSecretarySkinState()
		{
		}

		// Token: 0x0601CE0D RID: 118285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE0D")]
		[Address(RVA = "0x1651B50", Offset = "0x1650750", VA = "0x181651B50")]
		private void _OpenChangeBackgroundState()
		{
		}

		// Token: 0x0601CE0E RID: 118286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE0E")]
		[Address(RVA = "0x1651EB0", Offset = "0x1650AB0", VA = "0x181651EB0")]
		private void _OpenChangeThemeState()
		{
		}

		// Token: 0x0601CE0F RID: 118287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE0F")]
		[Address(RVA = "0x1651FC0", Offset = "0x1650BC0", VA = "0x181651FC0")]
		private void _OpenIllustEditState()
		{
		}

		// Token: 0x0601CE10 RID: 118288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE10")]
		[Address(RVA = "0x16527C0", Offset = "0x16513C0", VA = "0x1816527C0")]
		private void _SetSecretary(string skinTag)
		{
		}

		// Token: 0x0601CE11 RID: 118289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE11")]
		[Address(RVA = "0x1651740", Offset = "0x1650340", VA = "0x181651740")]
		private void _OnPresetListBtnClicked(long direction)
		{
		}

		// Token: 0x0601CE12 RID: 118290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE12")]
		[Address(RVA = "0x1651A30", Offset = "0x1650630", VA = "0x181651A30")]
		private void _OnSkinListBtnClicked(long direction)
		{
		}

		// Token: 0x0601CE13 RID: 118291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE13")]
		[Address(RVA = "0x1652440", Offset = "0x1651040", VA = "0x181652440")]
		private void _SetDisplay()
		{
		}

		// Token: 0x0601CE14 RID: 118292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE14")]
		[Address(RVA = "0x1651880", Offset = "0x1650480", VA = "0x181651880")]
		private void _OnSetDisplaySucceed(string instId, string skinTag)
		{
		}

		// Token: 0x0601CE15 RID: 118293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE15")]
		[Address(RVA = "0x1651680", Offset = "0x1650280", VA = "0x181651680")]
		private void _OnBackgroundClicked()
		{
		}

		// Token: 0x0601CE16 RID: 118294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE16")]
		[Address(RVA = "0x164ED70", Offset = "0x164D970", VA = "0x18164ED70")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x0601CE17 RID: 118295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE17")]
		[Address(RVA = "0x164EE80", Offset = "0x164DA80", VA = "0x18164EE80")]
		public void OnCharRotationListBackClicked()
		{
		}

		// Token: 0x0601CE18 RID: 118296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE18")]
		[Address(RVA = "0x164E9D0", Offset = "0x164D5D0", VA = "0x18164E9D0", Slot = "22")]
		public override void DismissSelf()
		{
		}

		// Token: 0x0601CE19 RID: 118297 RVA: 0x000A9B78 File Offset: 0x000A7D78
		[Token(Token = "0x601CE19")]
		[Address(RVA = "0x1650760", Offset = "0x164F360", VA = "0x181650760")]
		private bool _CheckAndCloseVirtualPage()
		{
			return default(bool);
		}

		// Token: 0x0601CE1A RID: 118298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE1A")]
		[Address(RVA = "0x164EAB0", Offset = "0x164D6B0", VA = "0x18164EAB0", Slot = "34")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601CE1B RID: 118299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE1B")]
		[Address(RVA = "0x16514A0", Offset = "0x16500A0", VA = "0x1816514A0")]
		private void _ModifyIllustViewConfig(bool show)
		{
		}

		// Token: 0x0601CE1C RID: 118300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE1C")]
		[Address(RVA = "0x1652CE0", Offset = "0x16518E0", VA = "0x181652CE0")]
		private void _SyncIllustView()
		{
		}

		// Token: 0x0601CE1D RID: 118301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE1D")]
		[Address(RVA = "0x1653300", Offset = "0x1651F00", VA = "0x181653300")]
		private void _UpdateIllustView(bool show)
		{
		}

		// Token: 0x0601CE1E RID: 118302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE1E")]
		[Address(RVA = "0x1650830", Offset = "0x164F430", VA = "0x181650830")]
		private void _DisposeIllustConfig()
		{
		}

		// Token: 0x0601CE1F RID: 118303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE1F")]
		[Address(RVA = "0x1653060", Offset = "0x1651C60", VA = "0x181653060")]
		private void _UpdateHomeBackgroundAndTheme()
		{
		}

		// Token: 0x0601CE20 RID: 118304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE20")]
		[Address(RVA = "0x1652F80", Offset = "0x1651B80", VA = "0x181652F80")]
		private void _UpdateBackground(HomeDisplayController displayController, string bgId)
		{
		}

		// Token: 0x0601CE21 RID: 118305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE21")]
		[Address(RVA = "0x1653590", Offset = "0x1652190", VA = "0x181653590")]
		private void _UpdateTheme(HomeDisplayController displayController, string tmId)
		{
		}

		// Token: 0x0601CE22 RID: 118306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE22")]
		[Address(RVA = "0x1653670", Offset = "0x1652270", VA = "0x181653670")]
		public HomeCharRotationState()
		{
		}

		// Token: 0x0601CE25 RID: 118309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE25")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CE26 RID: 118310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE26")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CE27 RID: 118311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE27")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601CE28 RID: 118312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE28")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601CE29 RID: 118313 RVA: 0x000A9B90 File Offset: 0x000A7D90
		[Token(Token = "0x601CE29")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601CE2A RID: 118314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE2A")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601CE2B RID: 118315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE2B")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CE2C RID: 118316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE2C")]
		[Address(RVA = "0x1637780", Offset = "0x1636380", VA = "0x181637780")]
		private void <>xLuaBaseProxy_DismissSelf()
		{
		}

		// Token: 0x04025E03 RID: 155139
		[Token(Token = "0x4025E03")]
		[NonSerialized]
		public const int CHANGE_ROTATION_LIST = 0;

		// Token: 0x04025E04 RID: 155140
		[Token(Token = "0x4025E04")]
		[NonSerialized]
		public const int SELECT_SKIN_IN_ROTATION_LIST = 1;

		// Token: 0x04025E05 RID: 155141
		[Token(Token = "0x4025E05")]
		[NonSerialized]
		public const int OPEN_SECRETARY_CHANGE_STATE = 2;

		// Token: 0x04025E06 RID: 155142
		[Token(Token = "0x4025E06")]
		[NonSerialized]
		public const int OPEN_PRESET_LIST_DIALOG = 3;

		// Token: 0x04025E07 RID: 155143
		[Token(Token = "0x4025E07")]
		[NonSerialized]
		public const int OPEN_SECRETARY_CHANGE_SKIN_STATE = 4;

		// Token: 0x04025E08 RID: 155144
		[Token(Token = "0x4025E08")]
		[NonSerialized]
		public const int SET_SECRETARY = 5;

		// Token: 0x04025E09 RID: 155145
		[Token(Token = "0x4025E09")]
		[NonSerialized]
		public const int ON_PRESET_LIST_BTN_CLICKED = 6;

		// Token: 0x04025E0A RID: 155146
		[Token(Token = "0x4025E0A")]
		[NonSerialized]
		public const int ON_SKIN_LIST_BTN_CLICKED = 7;

		// Token: 0x04025E0B RID: 155147
		[Token(Token = "0x4025E0B")]
		[NonSerialized]
		public const int SET_DISPLAY = 8;

		// Token: 0x04025E0C RID: 155148
		[Token(Token = "0x4025E0C")]
		[NonSerialized]
		public const int OPEN_BACKGROUND_CHANGE_STATE = 9;

		// Token: 0x04025E0D RID: 155149
		[Token(Token = "0x4025E0D")]
		[NonSerialized]
		public const int OPEN_THEME_CHANGE_STATE = 10;

		// Token: 0x04025E0E RID: 155150
		[Token(Token = "0x4025E0E")]
		[NonSerialized]
		public const int OPEN_ILLUST_EDIT_STATE = 11;

		// Token: 0x04025E0F RID: 155151
		[Token(Token = "0x4025E0F")]
		[NonSerialized]
		public const int ON_BACKGROUND_CLICKED = 12;

		// Token: 0x04025E10 RID: 155152
		[Token(Token = "0x4025E10")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HomeCharRotationView _view;

		// Token: 0x04025E11 RID: 155153
		[Token(Token = "0x4025E11")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04025E12 RID: 155154
		[Token(Token = "0x4025E12")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backPressRect;

		// Token: 0x04025E13 RID: 155155
		[Token(Token = "0x4025E13")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _charRotationListBackPressRect;

		// Token: 0x04025E14 RID: 155156
		[Token(Token = "0x4025E14")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04025E15 RID: 155157
		[Token(Token = "0x4025E15")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04025E16 RID: 155158
		[Token(Token = "0x4025E16")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04025E17 RID: 155159
		[Token(Token = "0x4025E17")]
		[FieldOffset(Offset = "0xA0")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04025E18 RID: 155160
		[Token(Token = "0x4025E18")]
		[FieldOffset(Offset = "0xA8")]
		private int m_dialogInstId;

		// Token: 0x04025E19 RID: 155161
		[Token(Token = "0x4025E19")]
		[FieldOffset(Offset = "0xB0")]
		private HomeSecretaryChangeSkinStateBean.InputParams m_toChangeSkinParams;

		// Token: 0x04025E1A RID: 155162
		[Token(Token = "0x4025E1A")]
		[FieldOffset(Offset = "0xD0")]
		private HomeSecretaryChangeStateBean.InputParams m_toChangeCharParams;

		// Token: 0x04025E1B RID: 155163
		[Token(Token = "0x4025E1B")]
		[FieldOffset(Offset = "0xE0")]
		private UISwitchTween m_showTween;

		// Token: 0x04025E1C RID: 155164
		[Token(Token = "0x4025E1C")]
		[FieldOffset(Offset = "0xE8")]
		private HomeIllustView m_illustView;

		// Token: 0x04025E1D RID: 155165
		[Token(Token = "0x4025E1D")]
		[FieldOffset(Offset = "0xF0")]
		private HomeIllustView.DisplayHandler m_illustDisplayHandler;

		// Token: 0x04025E1E RID: 155166
		[Token(Token = "0x4025E1E")]
		[FieldOffset(Offset = "0xF8")]
		private int m_instId;

		// Token: 0x04025E1F RID: 155167
		[Token(Token = "0x4025E1F")]
		[FieldOffset(Offset = "0x100")]
		private HomeCharRotationStateBean m_stateBean;

		// Token: 0x04025E20 RID: 155168
		[Token(Token = "0x4025E20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025E21 RID: 155169
		[Token(Token = "0x4025E21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025E22 RID: 155170
		[Token(Token = "0x4025E22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025E23 RID: 155171
		[Token(Token = "0x4025E23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04025E24 RID: 155172
		[Token(Token = "0x4025E24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025E25 RID: 155173
		[Token(Token = "0x4025E25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025E26 RID: 155174
		[Token(Token = "0x4025E26")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04025E27 RID: 155175
		[Token(Token = "0x4025E27")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04025E28 RID: 155176
		[Token(Token = "0x4025E28")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04025E29 RID: 155177
		[Token(Token = "0x4025E29")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventToOpenHomeBackGroundChangeState;

		// Token: 0x04025E2A RID: 155178
		[Token(Token = "0x4025E2A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventToOpenHomeThemeChangeState;

		// Token: 0x04025E2B RID: 155179
		[Token(Token = "0x4025E2B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventRoutedFromBackgroundAndThemeChangeState;

		// Token: 0x04025E2C RID: 155180
		[Token(Token = "0x4025E2C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventRoutedFromSkinSelectState;

		// Token: 0x04025E2D RID: 155181
		[Token(Token = "0x4025E2D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04025E2E RID: 155182
		[Token(Token = "0x4025E2E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsPanelHide;

		// Token: 0x04025E2F RID: 155183
		[Token(Token = "0x4025E2F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025E30 RID: 155184
		[Token(Token = "0x4025E30")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryPlayDynEntranceOnBack;

		// Token: 0x04025E31 RID: 155185
		[Token(Token = "0x4025E31")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartPreviewMode;

		// Token: 0x04025E32 RID: 155186
		[Token(Token = "0x4025E32")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ExitPreviewMode;

		// Token: 0x04025E33 RID: 155187
		[Token(Token = "0x4025E33")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x04025E34 RID: 155188
		[Token(Token = "0x4025E34")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04025E35 RID: 155189
		[Token(Token = "0x4025E35")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x04025E36 RID: 155190
		[Token(Token = "0x4025E36")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04025E37 RID: 155191
		[Token(Token = "0x4025E37")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025E38 RID: 155192
		[Token(Token = "0x4025E38")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ChangeListShow;

		// Token: 0x04025E39 RID: 155193
		[Token(Token = "0x4025E39")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SelectSkinInRotationList;

		// Token: 0x04025E3A RID: 155194
		[Token(Token = "0x4025E3A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OpenChangeSecretaryState;

		// Token: 0x04025E3B RID: 155195
		[Token(Token = "0x4025E3B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OpenPresetListDialog;

		// Token: 0x04025E3C RID: 155196
		[Token(Token = "0x4025E3C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OpenChangeSecretarySkinState;

		// Token: 0x04025E3D RID: 155197
		[Token(Token = "0x4025E3D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OpenChangeBackgroundState;

		// Token: 0x04025E3E RID: 155198
		[Token(Token = "0x4025E3E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OpenChangeThemeState;

		// Token: 0x04025E3F RID: 155199
		[Token(Token = "0x4025E3F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OpenIllustEditState;

		// Token: 0x04025E40 RID: 155200
		[Token(Token = "0x4025E40")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__SetSecretary;

		// Token: 0x04025E41 RID: 155201
		[Token(Token = "0x4025E41")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnPresetListBtnClicked;

		// Token: 0x04025E42 RID: 155202
		[Token(Token = "0x4025E42")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnSkinListBtnClicked;

		// Token: 0x04025E43 RID: 155203
		[Token(Token = "0x4025E43")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SetDisplay;

		// Token: 0x04025E44 RID: 155204
		[Token(Token = "0x4025E44")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__OnSetDisplaySucceed;

		// Token: 0x04025E45 RID: 155205
		[Token(Token = "0x4025E45")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnBackgroundClicked;

		// Token: 0x04025E46 RID: 155206
		[Token(Token = "0x4025E46")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x04025E47 RID: 155207
		[Token(Token = "0x4025E47")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnCharRotationListBackClicked;

		// Token: 0x04025E48 RID: 155208
		[Token(Token = "0x4025E48")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x04025E49 RID: 155209
		[Token(Token = "0x4025E49")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__CheckAndCloseVirtualPage;

		// Token: 0x04025E4A RID: 155210
		[Token(Token = "0x4025E4A")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04025E4B RID: 155211
		[Token(Token = "0x4025E4B")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ModifyIllustViewConfig;

		// Token: 0x04025E4C RID: 155212
		[Token(Token = "0x4025E4C")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__SyncIllustView;

		// Token: 0x04025E4D RID: 155213
		[Token(Token = "0x4025E4D")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__UpdateIllustView;

		// Token: 0x04025E4E RID: 155214
		[Token(Token = "0x4025E4E")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__DisposeIllustConfig;

		// Token: 0x04025E4F RID: 155215
		[Token(Token = "0x4025E4F")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__UpdateHomeBackgroundAndTheme;

		// Token: 0x04025E50 RID: 155216
		[Token(Token = "0x4025E50")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__UpdateBackground;

		// Token: 0x04025E51 RID: 155217
		[Token(Token = "0x4025E51")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__UpdateTheme;

		// Token: 0x04025E52 RID: 155218
		[Token(Token = "0x4025E52")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
