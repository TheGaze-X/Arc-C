using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041EE RID: 16878
	[Token(Token = "0x20041EE")]
	public class SandboxV2DungeonEventState : SandboxV2TransparentState, IValueMsgReceiver
	{
		// Token: 0x0601A0CD RID: 106701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0CD")]
		[Address(RVA = "0x12E7E40", Offset = "0x12E6A40", VA = "0x1812E7E40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A0CE RID: 106702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0CE")]
		[Address(RVA = "0x12E7F00", Offset = "0x12E6B00", VA = "0x1812E7F00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A0CF RID: 106703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0CF")]
		[Address(RVA = "0x12E83E0", Offset = "0x12E6FE0", VA = "0x1812E83E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A0D0 RID: 106704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0D0")]
		[Address(RVA = "0x12E8440", Offset = "0x12E7040", VA = "0x1812E8440", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601A0D1 RID: 106705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D1")]
		[Address(RVA = "0x12E9B20", Offset = "0x12E8720", VA = "0x1812E9B20")]
		private void _OnJumpToDungeonState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0D2 RID: 106706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D2")]
		[Address(RVA = "0x12E9820", Offset = "0x12E8420", VA = "0x1812E9820")]
		private void _OnJumpToCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A0D3 RID: 106707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D3")]
		[Address(RVA = "0x12E9240", Offset = "0x12E7E40", VA = "0x1812E9240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A0D4 RID: 106708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D4")]
		[Address(RVA = "0x12E8B70", Offset = "0x12E7770", VA = "0x1812E8B70")]
		private void _HandleExpedition()
		{
		}

		// Token: 0x0601A0D5 RID: 106709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D5")]
		[Address(RVA = "0x12E8910", Offset = "0x12E7510", VA = "0x1812E8910")]
		private void _HandleChoice()
		{
		}

		// Token: 0x0601A0D6 RID: 106710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D6")]
		[Address(RVA = "0x12EA010", Offset = "0x12E8C10", VA = "0x1812EA010")]
		private void _OpenExpeditionSquad()
		{
		}

		// Token: 0x0601A0D7 RID: 106711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D7")]
		[Address(RVA = "0x12EA0D0", Offset = "0x12E8CD0", VA = "0x1812EA0D0")]
		private void _OpenReceiveItemsDialog(List<RewardItemModel> rewardList, Action onConfirm)
		{
		}

		// Token: 0x0601A0D8 RID: 106712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D8")]
		[Address(RVA = "0x12E9370", Offset = "0x12E7F70", VA = "0x1812E9370")]
		private void _InitNodeEventData()
		{
		}

		// Token: 0x0601A0D9 RID: 106713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0D9")]
		[Address(RVA = "0x12EA3B0", Offset = "0x12E8FB0", VA = "0x1812EA3B0")]
		private void _UpdateView(bool isEnter, bool playAnim)
		{
		}

		// Token: 0x0601A0DA RID: 106714 RVA: 0x000A0320 File Offset: 0x0009E520
		[Token(Token = "0x601A0DA")]
		[Address(RVA = "0x12E8790", Offset = "0x12E7390", VA = "0x1812E8790")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601A0DB RID: 106715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0DB")]
		[Address(RVA = "0x12E9550", Offset = "0x12E8150", VA = "0x1812E9550")]
		private void _OnBackPress()
		{
		}

		// Token: 0x0601A0DC RID: 106716 RVA: 0x000A0338 File Offset: 0x0009E538
		[Token(Token = "0x601A0DC")]
		[Address(RVA = "0x12E8610", Offset = "0x12E7210", VA = "0x1812E8610")]
		private bool _CheckEventStatus()
		{
			return default(bool);
		}

		// Token: 0x0601A0DD RID: 106717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0DD")]
		[Address(RVA = "0x12E8830", Offset = "0x12E7430", VA = "0x1812E8830")]
		private void _ExitEvent()
		{
		}

		// Token: 0x0601A0DE RID: 106718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0DE")]
		[Address(RVA = "0x12E94B0", Offset = "0x12E80B0", VA = "0x1812E94B0")]
		private void _NextEvent()
		{
		}

		// Token: 0x0601A0DF RID: 106719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0DF")]
		[Address(RVA = "0x12E7EA0", Offset = "0x12E6AA0", VA = "0x1812E7EA0")]
		public void OnBackPress()
		{
		}

		// Token: 0x0601A0E0 RID: 106720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E0")]
		[Address(RVA = "0x12E81B0", Offset = "0x12E6DB0", VA = "0x1812E81B0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A0E1 RID: 106721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E1")]
		[Address(RVA = "0x12E95E0", Offset = "0x12E81E0", VA = "0x1812E95E0")]
		private void _OnChoiceSelect(string choiceId)
		{
		}

		// Token: 0x0601A0E2 RID: 106722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E2")]
		[Address(RVA = "0x12E8E70", Offset = "0x12E7A70", VA = "0x1812E8E70")]
		private void _HandleService(Action<SandboxV2EventChoiceResponse> onSuccess, Action onFail)
		{
		}

		// Token: 0x0601A0E3 RID: 106723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E3")]
		[Address(RVA = "0x12E9ED0", Offset = "0x12E8AD0", VA = "0x1812E9ED0")]
		private void _OnSuccessNext(SandboxV2EventChoiceResponse response)
		{
		}

		// Token: 0x0601A0E4 RID: 106724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E4")]
		[Address(RVA = "0x12E9DF0", Offset = "0x12E89F0", VA = "0x1812E9DF0")]
		private void _OnSuccessLeave(SandboxV2EventChoiceResponse response)
		{
		}

		// Token: 0x0601A0E5 RID: 106725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E5")]
		[Address(RVA = "0x12E9C80", Offset = "0x12E8880", VA = "0x1812E9C80")]
		private void _OnSuccessImpl(List<RewardItemModel> rewards, Action callBack)
		{
		}

		// Token: 0x0601A0E6 RID: 106726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E6")]
		[Address(RVA = "0x12E9750", Offset = "0x12E8350", VA = "0x1812E9750")]
		private void _OnFail()
		{
		}

		// Token: 0x0601A0E7 RID: 106727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E7")]
		[Address(RVA = "0x12EA580", Offset = "0x12E9180", VA = "0x1812EA580")]
		public SandboxV2DungeonEventState()
		{
		}

		// Token: 0x0601A0E8 RID: 106728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E8")]
		[Address(RVA = "0x12A1BB0", Offset = "0x12A07B0", VA = "0x1812A1BB0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A0E9 RID: 106729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0E9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601A0EA RID: 106730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0EA")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04020CFE RID: 134398
		[Token(Token = "0x4020CFE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2EventView _eventView;

		// Token: 0x04020CFF RID: 134399
		[Token(Token = "0x4020CFF")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04020D00 RID: 134400
		[Token(Token = "0x4020D00")]
		[FieldOffset(Offset = "0x80")]
		private string m_topicId;

		// Token: 0x04020D01 RID: 134401
		[Token(Token = "0x4020D01")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2DungeonPage m_page;

		// Token: 0x04020D02 RID: 134402
		[Token(Token = "0x4020D02")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2DungeonController m_controller;

		// Token: 0x04020D03 RID: 134403
		[Token(Token = "0x4020D03")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2EventProperty m_eventProp;

		// Token: 0x04020D04 RID: 134404
		[Token(Token = "0x4020D04")]
		[NonSerialized]
		public const int ON_CHOICE_SELECT = 0;

		// Token: 0x04020D05 RID: 134405
		[Token(Token = "0x4020D05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020D06 RID: 134406
		[Token(Token = "0x4020D06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020D07 RID: 134407
		[Token(Token = "0x4020D07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020D08 RID: 134408
		[Token(Token = "0x4020D08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04020D09 RID: 134409
		[Token(Token = "0x4020D09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToDungeonState;

		// Token: 0x04020D0A RID: 134410
		[Token(Token = "0x4020D0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelectState;

		// Token: 0x04020D0B RID: 134411
		[Token(Token = "0x4020D0B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D0C RID: 134412
		[Token(Token = "0x4020D0C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleExpedition;

		// Token: 0x04020D0D RID: 134413
		[Token(Token = "0x4020D0D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleChoice;

		// Token: 0x04020D0E RID: 134414
		[Token(Token = "0x4020D0E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenExpeditionSquad;

		// Token: 0x04020D0F RID: 134415
		[Token(Token = "0x4020D0F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenReceiveItemsDialog;

		// Token: 0x04020D10 RID: 134416
		[Token(Token = "0x4020D10")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitNodeEventData;

		// Token: 0x04020D11 RID: 134417
		[Token(Token = "0x4020D11")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04020D12 RID: 134418
		[Token(Token = "0x4020D12")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x04020D13 RID: 134419
		[Token(Token = "0x4020D13")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnBackPress;

		// Token: 0x04020D14 RID: 134420
		[Token(Token = "0x4020D14")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckEventStatus;

		// Token: 0x04020D15 RID: 134421
		[Token(Token = "0x4020D15")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ExitEvent;

		// Token: 0x04020D16 RID: 134422
		[Token(Token = "0x4020D16")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__NextEvent;

		// Token: 0x04020D17 RID: 134423
		[Token(Token = "0x4020D17")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBackPress;

		// Token: 0x04020D18 RID: 134424
		[Token(Token = "0x4020D18")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020D19 RID: 134425
		[Token(Token = "0x4020D19")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnChoiceSelect;

		// Token: 0x04020D1A RID: 134426
		[Token(Token = "0x4020D1A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleService;

		// Token: 0x04020D1B RID: 134427
		[Token(Token = "0x4020D1B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnSuccessNext;

		// Token: 0x04020D1C RID: 134428
		[Token(Token = "0x4020D1C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnSuccessLeave;

		// Token: 0x04020D1D RID: 134429
		[Token(Token = "0x4020D1D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnSuccessImpl;

		// Token: 0x04020D1E RID: 134430
		[Token(Token = "0x4020D1E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnFail;

		// Token: 0x04020D1F RID: 134431
		[Token(Token = "0x4020D1F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
