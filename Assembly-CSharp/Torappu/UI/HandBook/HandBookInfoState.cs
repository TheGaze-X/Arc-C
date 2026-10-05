using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006681 RID: 26241
	[Token(Token = "0x2006681")]
	public class HandBookInfoState : PopupFadeState
	{
		// Token: 0x06025AC2 RID: 154306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AC2")]
		[Address(RVA = "0x2095D20", Offset = "0x2094920", VA = "0x182095D20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025AC3 RID: 154307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AC3")]
		[Address(RVA = "0x2096E70", Offset = "0x2095A70", VA = "0x182096E70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025AC4 RID: 154308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AC4")]
		[Address(RVA = "0x20960A0", Offset = "0x2094CA0", VA = "0x1820960A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025AC5 RID: 154309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AC5")]
		[Address(RVA = "0x2095670", Offset = "0x2094270", VA = "0x182095670", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025AC6 RID: 154310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AC6")]
		[Address(RVA = "0x2096420", Offset = "0x2095020", VA = "0x182096420")]
		public void OnSwitchIllustrationClicked()
		{
		}

		// Token: 0x06025AC7 RID: 154311 RVA: 0x000C8B50 File Offset: 0x000C6D50
		[Token(Token = "0x6025AC7")]
		[Address(RVA = "0x2097160", Offset = "0x2095D60", VA = "0x182097160")]
		private bool _LockIllustAnimation(float duration)
		{
			return default(bool);
		}

		// Token: 0x06025AC8 RID: 154312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AC8")]
		[Address(RVA = "0x2098980", Offset = "0x2097580", VA = "0x182098980")]
		private IEnumerator _UnlockIllustAnimCoroutine(float duration)
		{
			return null;
		}

		// Token: 0x06025AC9 RID: 154313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AC9")]
		[Address(RVA = "0x2097E80", Offset = "0x2096A80", VA = "0x182097E80")]
		private void _RefreshState()
		{
		}

		// Token: 0x06025ACA RID: 154314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ACA")]
		[Address(RVA = "0x2094FA0", Offset = "0x2093BA0", VA = "0x182094FA0")]
		public void EventOnBackToSlider()
		{
		}

		// Token: 0x06025ACB RID: 154315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ACB")]
		[Address(RVA = "0x2095580", Offset = "0x2094180", VA = "0x182095580")]
		public void EventOnStageLocked()
		{
		}

		// Token: 0x06025ACC RID: 154316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ACC")]
		[Address(RVA = "0x2095220", Offset = "0x2093E20", VA = "0x182095220")]
		public void EventOnStageDetailLocked()
		{
		}

		// Token: 0x06025ACD RID: 154317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ACD")]
		[Address(RVA = "0x2095020", Offset = "0x2093C20", VA = "0x182095020")]
		public void EventOnButtonCharacterInfo()
		{
		}

		// Token: 0x06025ACE RID: 154318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ACE")]
		[Address(RVA = "0x2096480", Offset = "0x2095080", VA = "0x182096480")]
		public void OnUnspreadIllustrationClicked()
		{
		}

		// Token: 0x06025ACF RID: 154319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ACF")]
		[Address(RVA = "0x2096270", Offset = "0x2094E70", VA = "0x182096270")]
		public void OnSpreadIllustrationClicked()
		{
		}

		// Token: 0x06025AD0 RID: 154320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AD0")]
		[Address(RVA = "0x2096640", Offset = "0x2095240", VA = "0x182096640")]
		public void OnVoiceLangBtnClick()
		{
		}

		// Token: 0x06025AD1 RID: 154321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AD1")]
		[Address(RVA = "0x2095C40", Offset = "0x2094840", VA = "0x182095C40")]
		public void OnDesignerBtnClick()
		{
		}

		// Token: 0x06025AD2 RID: 154322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AD2")]
		[Address(RVA = "0x20968F0", Offset = "0x20954F0", VA = "0x1820968F0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06025AD3 RID: 154323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AD3")]
		[Address(RVA = "0x20956D0", Offset = "0x20942D0", VA = "0x1820956D0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06025AD4 RID: 154324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AD4")]
		[Address(RVA = "0x2096A50", Offset = "0x2095650", VA = "0x182096A50", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06025AD5 RID: 154325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AD5")]
		[Address(RVA = "0x2095830", Offset = "0x2094430", VA = "0x182095830", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06025AD6 RID: 154326 RVA: 0x000C8B68 File Offset: 0x000C6D68
		[Token(Token = "0x6025AD6")]
		[Address(RVA = "0x2097D10", Offset = "0x2096910", VA = "0x182097D10")]
		private UIAnimationLocation _PickAnimation(UIPopupState.TransactionContext context)
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x06025AD7 RID: 154327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AD7")]
		[Address(RVA = "0x2098740", Offset = "0x2097340", VA = "0x182098740")]
		private void _ShowCharacterInfo(int chrInstId)
		{
		}

		// Token: 0x06025AD8 RID: 154328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AD8")]
		[Address(RVA = "0x20959A0", Offset = "0x20945A0", VA = "0x1820959A0")]
		public void OnCollectionRequest(string id)
		{
		}

		// Token: 0x06025AD9 RID: 154329 RVA: 0x000C8B80 File Offset: 0x000C6D80
		[Token(Token = "0x6025AD9")]
		[Address(RVA = "0x2096E00", Offset = "0x2095A00", VA = "0x182096E00", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06025ADA RID: 154330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025ADA")]
		[Address(RVA = "0x2096780", Offset = "0x2095380", VA = "0x182096780", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06025ADB RID: 154331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ADB")]
		[Address(RVA = "0x20980A0", Offset = "0x2096CA0", VA = "0x1820980A0")]
		private void _ReloadHandBookInfo([Optional] HandBookCardViewModel newCardModel)
		{
		}

		// Token: 0x06025ADC RID: 154332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ADC")]
		[Address(RVA = "0x2098020", Offset = "0x2096C20", VA = "0x182098020")]
		private void _RefreshVoiceLangInfo()
		{
		}

		// Token: 0x06025ADD RID: 154333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ADD")]
		[Address(RVA = "0x2097710", Offset = "0x2096310", VA = "0x182097710")]
		private void _OnIllustSpread()
		{
		}

		// Token: 0x06025ADE RID: 154334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ADE")]
		[Address(RVA = "0x2097790", Offset = "0x2096390", VA = "0x182097790")]
		private void _OnIllustUnspread()
		{
		}

		// Token: 0x06025ADF RID: 154335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ADF")]
		[Address(RVA = "0x20972A0", Offset = "0x2095EA0", VA = "0x1820972A0")]
		private void _OnAvgItemClicked(string storyId)
		{
		}

		// Token: 0x06025AE0 RID: 154336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE0")]
		[Address(RVA = "0x2097A00", Offset = "0x2096600", VA = "0x182097A00")]
		private void _OnVoiceLangItemClicked(VoiceLangType voiceLangType)
		{
		}

		// Token: 0x06025AE1 RID: 154337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE1")]
		[Address(RVA = "0x20981F0", Offset = "0x2096DF0", VA = "0x1820981F0")]
		private void _SendChangeRogueNpcVoiceLangReq(VoiceLangType voiceLangType)
		{
		}

		// Token: 0x06025AE2 RID: 154338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE2")]
		[Address(RVA = "0x2098430", Offset = "0x2097030", VA = "0x182098430")]
		private void _SetCharVoiceLangReq(VoiceLangType voiceLangType)
		{
		}

		// Token: 0x06025AE3 RID: 154339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE3")]
		[Address(RVA = "0x2097810", Offset = "0x2096410", VA = "0x182097810")]
		private void _OnSetVoiceLangSuc()
		{
		}

		// Token: 0x06025AE4 RID: 154340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE4")]
		[Address(RVA = "0x2098A40", Offset = "0x2097640", VA = "0x182098A40")]
		private void _UpdateNewVoiceVisited()
		{
		}

		// Token: 0x06025AE5 RID: 154341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE5")]
		[Address(RVA = "0x20986A0", Offset = "0x20972A0", VA = "0x1820986A0")]
		private void _SetTopMenuActive(bool isActive)
		{
		}

		// Token: 0x06025AE6 RID: 154342 RVA: 0x000C8B98 File Offset: 0x000C6D98
		[Token(Token = "0x6025AE6")]
		[Address(RVA = "0x20970C0", Offset = "0x2095CC0", VA = "0x1820970C0")]
		private bool _IsDuringTransiting()
		{
			return default(bool);
		}

		// Token: 0x06025AE7 RID: 154343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE7")]
		[Address(RVA = "0x20988D0", Offset = "0x20974D0", VA = "0x1820988D0")]
		private void _StopAudios()
		{
		}

		// Token: 0x06025AE8 RID: 154344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE8")]
		[Address(RVA = "0x2097AD0", Offset = "0x20966D0", VA = "0x182097AD0")]
		private void _OpenUnlockStoryPage()
		{
		}

		// Token: 0x06025AE9 RID: 154345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AE9")]
		[Address(RVA = "0x2098B30", Offset = "0x2097730", VA = "0x182098B30")]
		public HandBookInfoState()
		{
		}

		// Token: 0x06025AEE RID: 154350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AEE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025AEF RID: 154351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AEF")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06025AF0 RID: 154352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AF0")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06025AF1 RID: 154353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AF1")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06025AF2 RID: 154354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AF2")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x06025AF3 RID: 154355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AF3")]
		[Address(RVA = "0x180FE00", Offset = "0x180EA00", VA = "0x18180FE00")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x06025AF4 RID: 154356 RVA: 0x000C8BB0 File Offset: 0x000C6DB0
		[Token(Token = "0x6025AF4")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06025AF5 RID: 154357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AF5")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04034EE2 RID: 216802
		[Token(Token = "0x4034EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookInfoStateBean _stateBean;

		// Token: 0x04034EE3 RID: 216803
		[Token(Token = "0x4034EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HandBookInfoView _infoView;

		// Token: 0x04034EE4 RID: 216804
		[Token(Token = "0x4034EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _avgTrackPoint;

		// Token: 0x04034EE5 RID: 216805
		[Token(Token = "0x4034EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UICommonTrackPoint _stageTrackPoint;

		// Token: 0x04034EE6 RID: 216806
		[Token(Token = "0x4034EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonTrackPoint _newVoiceTrackPoint;

		// Token: 0x04034EE7 RID: 216807
		[Token(Token = "0x4034EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _infoButton;

		// Token: 0x04034EE8 RID: 216808
		[Token(Token = "0x4034EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIPointClickListener _pointSpreadIllustClicked;

		// Token: 0x04034EE9 RID: 216809
		[Token(Token = "0x4034EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CharacterInfoIllustSpreadPanel _spreadPanel;

		// Token: 0x04034EEA RID: 216810
		[Token(Token = "0x4034EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Trans Effects")]
		private UIAnimationLocation _enterFromCharInfo;

		// Token: 0x04034EEB RID: 216811
		[Token(Token = "0x4034EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Trans Effects")]
		private UIAnimationLocation _enterOtherwise;

		// Token: 0x04034EEC RID: 216812
		[Token(Token = "0x4034EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private HandBookVoiceLangView _voiceLangView;

		// Token: 0x04034EED RID: 216813
		[Token(Token = "0x4034EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private HandBookDesignerView _designerView;

		// Token: 0x04034EEE RID: 216814
		[Token(Token = "0x4034EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private HandBookInfoStageView _lockedStageView;

		// Token: 0x04034EEF RID: 216815
		[Token(Token = "0x4034EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04034EF0 RID: 216816
		[Token(Token = "0x4034EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_flag;

		// Token: 0x04034EF1 RID: 216817
		[Token(Token = "0x4034EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string m_cacheStoryId;

		// Token: 0x04034EF2 RID: 216818
		[Token(Token = "0x4034EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_inited;

		// Token: 0x04034EF3 RID: 216819
		[Token(Token = "0x4034EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private HandBookVoiceLangView m_voiceLangView;

		// Token: 0x04034EF4 RID: 216820
		[Token(Token = "0x4034EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private HandBookInfoStageView m_lockedStageView;

		// Token: 0x04034EF5 RID: 216821
		[Token(Token = "0x4034EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private HandBookDesignerView m_designerView;

		// Token: 0x04034EF6 RID: 216822
		[Token(Token = "0x4034EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UnityEvent _onIllustrationSpread;

		// Token: 0x04034EF7 RID: 216823
		[Token(Token = "0x4034EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIAnimationLocation _illustSpreadAnim;

		// Token: 0x04034EF8 RID: 216824
		[Token(Token = "0x4034EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UnityEvent _unspreadIllustEvent;

		// Token: 0x04034EF9 RID: 216825
		[Token(Token = "0x4034EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool m_isIllustAnimating;

		// Token: 0x04034EFA RID: 216826
		[Token(Token = "0x4034EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034EFB RID: 216827
		[Token(Token = "0x4034EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034EFC RID: 216828
		[Token(Token = "0x4034EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04034EFD RID: 216829
		[Token(Token = "0x4034EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034EFE RID: 216830
		[Token(Token = "0x4034EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSwitchIllustrationClicked;

		// Token: 0x04034EFF RID: 216831
		[Token(Token = "0x4034EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LockIllustAnimation;

		// Token: 0x04034F00 RID: 216832
		[Token(Token = "0x4034F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UnlockIllustAnimCoroutine;

		// Token: 0x04034F01 RID: 216833
		[Token(Token = "0x4034F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshState;

		// Token: 0x04034F02 RID: 216834
		[Token(Token = "0x4034F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBackToSlider;

		// Token: 0x04034F03 RID: 216835
		[Token(Token = "0x4034F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnStageLocked;

		// Token: 0x04034F04 RID: 216836
		[Token(Token = "0x4034F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnStageDetailLocked;

		// Token: 0x04034F05 RID: 216837
		[Token(Token = "0x4034F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnButtonCharacterInfo;

		// Token: 0x04034F06 RID: 216838
		[Token(Token = "0x4034F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnUnspreadIllustrationClicked;

		// Token: 0x04034F07 RID: 216839
		[Token(Token = "0x4034F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSpreadIllustrationClicked;

		// Token: 0x04034F08 RID: 216840
		[Token(Token = "0x4034F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnVoiceLangBtnClick;

		// Token: 0x04034F09 RID: 216841
		[Token(Token = "0x4034F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDesignerBtnClick;

		// Token: 0x04034F0A RID: 216842
		[Token(Token = "0x4034F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04034F0B RID: 216843
		[Token(Token = "0x4034F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04034F0C RID: 216844
		[Token(Token = "0x4034F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04034F0D RID: 216845
		[Token(Token = "0x4034F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04034F0E RID: 216846
		[Token(Token = "0x4034F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PickAnimation;

		// Token: 0x04034F0F RID: 216847
		[Token(Token = "0x4034F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ShowCharacterInfo;

		// Token: 0x04034F10 RID: 216848
		[Token(Token = "0x4034F10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnCollectionRequest;

		// Token: 0x04034F11 RID: 216849
		[Token(Token = "0x4034F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04034F12 RID: 216850
		[Token(Token = "0x4034F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04034F13 RID: 216851
		[Token(Token = "0x4034F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ReloadHandBookInfo;

		// Token: 0x04034F14 RID: 216852
		[Token(Token = "0x4034F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RefreshVoiceLangInfo;

		// Token: 0x04034F15 RID: 216853
		[Token(Token = "0x4034F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnIllustSpread;

		// Token: 0x04034F16 RID: 216854
		[Token(Token = "0x4034F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnIllustUnspread;

		// Token: 0x04034F17 RID: 216855
		[Token(Token = "0x4034F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnAvgItemClicked;

		// Token: 0x04034F18 RID: 216856
		[Token(Token = "0x4034F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnVoiceLangItemClicked;

		// Token: 0x04034F19 RID: 216857
		[Token(Token = "0x4034F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SendChangeRogueNpcVoiceLangReq;

		// Token: 0x04034F1A RID: 216858
		[Token(Token = "0x4034F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__SetCharVoiceLangReq;

		// Token: 0x04034F1B RID: 216859
		[Token(Token = "0x4034F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnSetVoiceLangSuc;

		// Token: 0x04034F1C RID: 216860
		[Token(Token = "0x4034F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__UpdateNewVoiceVisited;

		// Token: 0x04034F1D RID: 216861
		[Token(Token = "0x4034F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SetTopMenuActive;

		// Token: 0x04034F1E RID: 216862
		[Token(Token = "0x4034F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__IsDuringTransiting;

		// Token: 0x04034F1F RID: 216863
		[Token(Token = "0x4034F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__StopAudios;

		// Token: 0x04034F20 RID: 216864
		[Token(Token = "0x4034F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OpenUnlockStoryPage;

		// Token: 0x04034F21 RID: 216865
		[Token(Token = "0x4034F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
