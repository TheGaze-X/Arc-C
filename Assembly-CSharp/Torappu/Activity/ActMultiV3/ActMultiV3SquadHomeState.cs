using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FC8 RID: 28616
	[Token(Token = "0x2006FC8")]
	public class ActMultiV3SquadHomeState : State, IValueMsgReceiver
	{
		// Token: 0x06028A2E RID: 166446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A2E")]
		[Address(RVA = "0x23F6590", Offset = "0x23F5190", VA = "0x1823F6590", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028A2F RID: 166447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A2F")]
		[Address(RVA = "0x23F6E50", Offset = "0x23F5A50", VA = "0x1823F6E50", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028A30 RID: 166448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A30")]
		[Address(RVA = "0x23F6C80", Offset = "0x23F5880", VA = "0x1823F6C80", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06028A31 RID: 166449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A31")]
		[Address(RVA = "0x23F87A0", Offset = "0x23F73A0", VA = "0x1823F87A0")]
		private void _RegisterFromCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x06028A32 RID: 166450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A32")]
		[Address(RVA = "0x23F9930", Offset = "0x23F8530", VA = "0x1823F9930")]
		private void _TryPlayCharVoice(TemplateCharSelectMainViewModel charSelectModel)
		{
		}

		// Token: 0x06028A33 RID: 166451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A33")]
		[Address(RVA = "0x23F89B0", Offset = "0x23F75B0", VA = "0x1823F89B0")]
		private void _RegisterFromEffectSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x06028A34 RID: 166452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A34")]
		[Address(RVA = "0x23F8F00", Offset = "0x23F7B00", VA = "0x1823F8F00")]
		private void _RegisterToEffectSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x06028A35 RID: 166453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A35")]
		[Address(RVA = "0x23F8CA0", Offset = "0x23F78A0", VA = "0x1823F8CA0")]
		private void _RegisterToCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x06028A36 RID: 166454 RVA: 0x000D27B0 File Offset: 0x000D09B0
		[Token(Token = "0x6028A36")]
		[Address(RVA = "0x23F7930", Offset = "0x23F6530", VA = "0x1823F7930")]
		private CommonCharSelectCustomization _GenCharSelectCustom()
		{
			return default(CommonCharSelectCustomization);
		}

		// Token: 0x06028A37 RID: 166455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A37")]
		[Address(RVA = "0x23F70B0", Offset = "0x23F5CB0", VA = "0x1823F70B0")]
		private TemplateCharSelectCardViewModel _CreateCharSelectCard(int instId, TemplateCharSelectCharInputData inputNullable, PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x06028A38 RID: 166456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A38")]
		[Address(RVA = "0x23F65F0", Offset = "0x23F51F0", VA = "0x1823F65F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028A39 RID: 166457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A39")]
		[Address(RVA = "0x23F6C00", Offset = "0x23F5800", VA = "0x1823F6C00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06028A3A RID: 166458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A3A")]
		[Address(RVA = "0x23F9BF0", Offset = "0x23F87F0", VA = "0x1823F9BF0")]
		private void _UpdateSquadEffectTrackPoint()
		{
		}

		// Token: 0x06028A3B RID: 166459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A3B")]
		[Address(RVA = "0x23F7AE0", Offset = "0x23F66E0", VA = "0x1823F7AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028A3C RID: 166460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A3C")]
		[Address(RVA = "0x23F7FC0", Offset = "0x23F6BC0", VA = "0x1823F7FC0")]
		private void _OnRoutedToOtherPage(UIRouteTarget target, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x06028A3D RID: 166461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A3D")]
		[Address(RVA = "0x23F7400", Offset = "0x23F6000", VA = "0x1823F7400")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x06028A3E RID: 166462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A3E")]
		[Address(RVA = "0x23F90F0", Offset = "0x23F7CF0", VA = "0x1823F90F0")]
		private void _SaveCurrSquadIdToLocalCache()
		{
		}

		// Token: 0x06028A3F RID: 166463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A3F")]
		[Address(RVA = "0x23F6A30", Offset = "0x23F5630", VA = "0x1823F6A30", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028A40 RID: 166464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A40")]
		[Address(RVA = "0x23F74B0", Offset = "0x23F60B0", VA = "0x1823F74B0")]
		private void _EventOnCharItemClick(object objVal)
		{
		}

		// Token: 0x06028A41 RID: 166465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A41")]
		[Address(RVA = "0x23F7CA0", Offset = "0x23F68A0", VA = "0x1823F7CA0")]
		private void _NavToCharSelectState(ActMultiV3IdentityType idType, bool isSingle, bool needScroll, string charId)
		{
		}

		// Token: 0x06028A42 RID: 166466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A42")]
		[Address(RVA = "0x23F8110", Offset = "0x23F6D10", VA = "0x1823F8110")]
		private TemplateCharSelectController.InputParam _ParseCharSelectInput(ActMultiV3IdentityType idType, bool isSingle, bool needScroll, string targetCharId)
		{
			return null;
		}

		// Token: 0x06028A43 RID: 166467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A43")]
		[Address(RVA = "0x23F7E70", Offset = "0x23F6A70", VA = "0x1823F7E70")]
		private void _NavToEffectSelectState()
		{
		}

		// Token: 0x06028A44 RID: 166468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A44")]
		[Address(RVA = "0x23F7800", Offset = "0x23F6400", VA = "0x1823F7800")]
		private void _EventOnTeamFull(TemplateCharSelectController.InputParam input)
		{
		}

		// Token: 0x06028A45 RID: 166469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A45")]
		[Address(RVA = "0x23F75D0", Offset = "0x23F61D0", VA = "0x1823F75D0")]
		private void _EventOnSquadSelect(string squadId)
		{
		}

		// Token: 0x06028A46 RID: 166470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A46")]
		[Address(RVA = "0x23F9800", Offset = "0x23F8400", VA = "0x1823F9800")]
		private void _SelectSquadTab(string squadId)
		{
		}

		// Token: 0x06028A47 RID: 166471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A47")]
		[Address(RVA = "0x23F9290", Offset = "0x23F7E90", VA = "0x1823F9290")]
		private void _SaveSquadIfNeed(Action nextStep)
		{
		}

		// Token: 0x06028A48 RID: 166472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A48")]
		[Address(RVA = "0x23F6490", Offset = "0x23F5090", VA = "0x1823F6490")]
		public void EventOnBtnHighPriEditClick()
		{
		}

		// Token: 0x06028A49 RID: 166473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A49")]
		[Address(RVA = "0x23F6510", Offset = "0x23F5110", VA = "0x1823F6510")]
		public void EventOnBtnLowPriEditClick()
		{
		}

		// Token: 0x06028A4A RID: 166474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A4A")]
		[Address(RVA = "0x23F63D0", Offset = "0x23F4FD0", VA = "0x1823F63D0")]
		public void EventOnBtnEffectEditClick()
		{
		}

		// Token: 0x06028A4B RID: 166475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A4B")]
		[Address(RVA = "0x23F9DD0", Offset = "0x23F89D0", VA = "0x1823F9DD0")]
		public ActMultiV3SquadHomeState()
		{
		}

		// Token: 0x06028A4D RID: 166477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A4D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028A4E RID: 166478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A4E")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06028A4F RID: 166479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A4F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028A50 RID: 166480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A50")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04039E63 RID: 237155
		[Token(Token = "0x4039E63")]
		[NonSerialized]
		public const int MSG_SQUAD_SELECT = 1;

		// Token: 0x04039E64 RID: 237156
		[Token(Token = "0x4039E64")]
		[NonSerialized]
		public const int MSG_CHAR_ITEM_CLICK = 2;

		// Token: 0x04039E65 RID: 237157
		[Token(Token = "0x4039E65")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3SquadHomeView _view;

		// Token: 0x04039E66 RID: 237158
		[Token(Token = "0x4039E66")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActMultiV3CharSelectCharItemView _charSelectItemView;

		// Token: 0x04039E67 RID: 237159
		[Token(Token = "0x4039E67")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04039E68 RID: 237160
		[Token(Token = "0x4039E68")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04039E69 RID: 237161
		[Token(Token = "0x4039E69")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04039E6A RID: 237162
		[Token(Token = "0x4039E6A")]
		[FieldOffset(Offset = "0x78")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04039E6B RID: 237163
		[Token(Token = "0x4039E6B")]
		[FieldOffset(Offset = "0x80")]
		private ActMultiV3SquadHomeStateBean m_stateBean;

		// Token: 0x04039E6C RID: 237164
		[Token(Token = "0x4039E6C")]
		[FieldOffset(Offset = "0x88")]
		private TemplateCharSelectController.InputParam m_cacheCharSelectInput;

		// Token: 0x04039E6D RID: 237165
		[Token(Token = "0x4039E6D")]
		[FieldOffset(Offset = "0x90")]
		private List<RequestSquadSlot> m_cachePreferSlotList;

		// Token: 0x04039E6E RID: 237166
		[Token(Token = "0x4039E6E")]
		[FieldOffset(Offset = "0x98")]
		private List<RequestSquadSlot> m_cacheBackupSlotList;

		// Token: 0x04039E6F RID: 237167
		[Token(Token = "0x4039E6F")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cacheActId;

		// Token: 0x04039E70 RID: 237168
		[Token(Token = "0x4039E70")]
		[FieldOffset(Offset = "0xA8")]
		private ActMultiV3MapModeType m_cacheModeType;

		// Token: 0x04039E71 RID: 237169
		[Token(Token = "0x4039E71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039E72 RID: 237170
		[Token(Token = "0x4039E72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04039E73 RID: 237171
		[Token(Token = "0x4039E73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04039E74 RID: 237172
		[Token(Token = "0x4039E74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterFromCharSelectState;

		// Token: 0x04039E75 RID: 237173
		[Token(Token = "0x4039E75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryPlayCharVoice;

		// Token: 0x04039E76 RID: 237174
		[Token(Token = "0x4039E76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterFromEffectSelectState;

		// Token: 0x04039E77 RID: 237175
		[Token(Token = "0x4039E77")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RegisterToEffectSelectState;

		// Token: 0x04039E78 RID: 237176
		[Token(Token = "0x4039E78")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RegisterToCharSelectState;

		// Token: 0x04039E79 RID: 237177
		[Token(Token = "0x4039E79")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenCharSelectCustom;

		// Token: 0x04039E7A RID: 237178
		[Token(Token = "0x4039E7A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateCharSelectCard;

		// Token: 0x04039E7B RID: 237179
		[Token(Token = "0x4039E7B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039E7C RID: 237180
		[Token(Token = "0x4039E7C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04039E7D RID: 237181
		[Token(Token = "0x4039E7D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateSquadEffectTrackPoint;

		// Token: 0x04039E7E RID: 237182
		[Token(Token = "0x4039E7E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039E7F RID: 237183
		[Token(Token = "0x4039E7F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRoutedToOtherPage;

		// Token: 0x04039E80 RID: 237184
		[Token(Token = "0x4039E80")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04039E81 RID: 237185
		[Token(Token = "0x4039E81")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SaveCurrSquadIdToLocalCache;

		// Token: 0x04039E82 RID: 237186
		[Token(Token = "0x4039E82")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039E83 RID: 237187
		[Token(Token = "0x4039E83")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnCharItemClick;

		// Token: 0x04039E84 RID: 237188
		[Token(Token = "0x4039E84")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__NavToCharSelectState;

		// Token: 0x04039E85 RID: 237189
		[Token(Token = "0x4039E85")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ParseCharSelectInput;

		// Token: 0x04039E86 RID: 237190
		[Token(Token = "0x4039E86")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__NavToEffectSelectState;

		// Token: 0x04039E87 RID: 237191
		[Token(Token = "0x4039E87")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnTeamFull;

		// Token: 0x04039E88 RID: 237192
		[Token(Token = "0x4039E88")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnSquadSelect;

		// Token: 0x04039E89 RID: 237193
		[Token(Token = "0x4039E89")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SelectSquadTab;

		// Token: 0x04039E8A RID: 237194
		[Token(Token = "0x4039E8A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SaveSquadIfNeed;

		// Token: 0x04039E8B RID: 237195
		[Token(Token = "0x4039E8B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnBtnHighPriEditClick;

		// Token: 0x04039E8C RID: 237196
		[Token(Token = "0x4039E8C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnBtnLowPriEditClick;

		// Token: 0x04039E8D RID: 237197
		[Token(Token = "0x4039E8D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EventOnBtnEffectEditClick;

		// Token: 0x04039E8E RID: 237198
		[Token(Token = "0x4039E8E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
