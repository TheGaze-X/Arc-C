using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.BP;
using Torappu.Building.UI.ToDoNotify;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DDE RID: 7646
	[Token(Token = "0x2001DDE")]
	public class BuildingFloatToDoNotifyState : BuildingFloatState
	{
		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x00046320 File Offset: 0x00044520
		[Token(Token = "0x170016D6")]
		protected override FloatState state
		{
			[Token(Token = "0x600BCA4")]
			[Address(RVA = "0x33A6810", Offset = "0x33A5410", VA = "0x1833A6810", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA5")]
		[Address(RVA = "0x33A41C0", Offset = "0x33A2DC0", VA = "0x1833A41C0", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA6")]
		[Address(RVA = "0x33A40B0", Offset = "0x33A2CB0", VA = "0x1833A40B0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA7")]
		[Address(RVA = "0x33A3C30", Offset = "0x33A2830", VA = "0x1833A3C30", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA8")]
		[Address(RVA = "0x33A3E50", Offset = "0x33A2A50", VA = "0x1833A3E50", Slot = "7")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA9")]
		[Address(RVA = "0x33A3BA0", Offset = "0x33A27A0", VA = "0x1833A3BA0")]
		public void EventOnTabNormalClicked()
		{
		}

		// Token: 0x0600BCAA RID: 48298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAA")]
		[Address(RVA = "0x33A3B10", Offset = "0x33A2710", VA = "0x1833A3B10")]
		public void EventOnTabEmerClicked()
		{
		}

		// Token: 0x0600BCAB RID: 48299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAB")]
		[Address(RVA = "0x33A5370", Offset = "0x33A3F70", VA = "0x1833A5370")]
		private void _OnPlayerDataChanged(object arg)
		{
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAC")]
		[Address(RVA = "0x33A4EA0", Offset = "0x33A3AA0", VA = "0x1833A4EA0")]
		private void _OnHilightedMaskClicked(object arg)
		{
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAD")]
		[Address(RVA = "0x33A56C0", Offset = "0x33A42C0", VA = "0x1833A56C0")]
		private void _OnToDoItemClicked(BuildingToDoNotifyItemModel selectedModel)
		{
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAE")]
		[Address(RVA = "0x33A4B40", Offset = "0x33A3740", VA = "0x1833A4B40")]
		private void _OnGainAllIntimacySuc(BuildingGainAllIntimacyResponse response, string voiceChar)
		{
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAF")]
		[Address(RVA = "0x33A51F0", Offset = "0x33A3DF0", VA = "0x1833A51F0")]
		private void _OnNewProductItemClicked(BuildingToDoNotifyItemModel selectedModel)
		{
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB0")]
		[Address(RVA = "0x33A4FB0", Offset = "0x33A3BB0", VA = "0x1833A4FB0")]
		private void _OnNewFavorItemClicked(BuildingToDoNotifyItemModel selectedModel)
		{
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB1")]
		[Address(RVA = "0x33A5100", Offset = "0x33A3D00", VA = "0x1833A5100")]
		private void _OnNewOrdersItemClicked(BuildingToDoNotifyItemModel selectedModel)
		{
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB2")]
		[Address(RVA = "0x33A4AE0", Offset = "0x33A36E0", VA = "0x1833A4AE0")]
		private void _OnBatchWorkClicked()
		{
		}

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB3")]
		[Address(RVA = "0x33A4A80", Offset = "0x33A3680", VA = "0x1833A4A80")]
		private void _OnBatchRestClicked()
		{
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB4")]
		[Address(RVA = "0x33A5400", Offset = "0x33A4000", VA = "0x1833A5400")]
		private void _OnProcessBatchOrder(BuildingDeliveryBatchOrderResponse resp)
		{
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BCB5")]
		[Address(RVA = "0x33A4870", Offset = "0x33A3470", VA = "0x1833A4870")]
		private List<BuildingUIResMenu.SyncSettleInfo> _GenSyncSettleInfos(BlueprintMode bpMode, Dictionary<string, List<ItemBundle>> rewardPairs)
		{
			return null;
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BCB6")]
		[Address(RVA = "0x33A42A0", Offset = "0x33A2EA0", VA = "0x1833A42A0")]
		private List<BuildingUIResMenu.SyncSettleInfo> _CalculateRoomSettleInfos(BlueprintMode bpMode, string slotId, List<ItemBundle> rewards)
		{
			return null;
		}

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB7")]
		[Address(RVA = "0x33A4640", Offset = "0x33A3240", VA = "0x1833A4640")]
		private void _DoBatchOrderToast(ListDict<ItemType, int> otherCountDict)
		{
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB8")]
		[Address(RVA = "0x33A5F20", Offset = "0x33A4B20", VA = "0x1833A5F20")]
		private void _SendGainAllIntimacyService()
		{
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BCB9")]
		[Address(RVA = "0x33A5B60", Offset = "0x33A4760", VA = "0x1833A5B60")]
		private string _PickRandomCharForGainAllIntimacyVoice()
		{
			return null;
		}

		// Token: 0x0600BCBA RID: 48314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBA")]
		[Address(RVA = "0x33A6350", Offset = "0x33A4F50", VA = "0x1833A6350")]
		private void _UpdateStatus(BuildingToDoCategory targetCategory, BuildingData.BuildingToDoType targetType)
		{
		}

		// Token: 0x0600BCBB RID: 48315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBB")]
		[Address(RVA = "0x33A6650", Offset = "0x33A5250", VA = "0x1833A6650")]
		private void _UpdateView()
		{
		}

		// Token: 0x0600BCBC RID: 48316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBC")]
		[Address(RVA = "0x33A6210", Offset = "0x33A4E10", VA = "0x1833A6210")]
		private static void _TrySwitchToOverview()
		{
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBD")]
		[Address(RVA = "0x33A6490", Offset = "0x33A5090", VA = "0x1833A6490")]
		private static void _UpdateTabButton(TwoStateToggle toggle, Text[] textsCount, BuildingToDoNotifyModel viewModel, BuildingToDoCategory tabCategory, BuildingToDoCategory selectedCategory)
		{
		}

		// Token: 0x0600BCBE RID: 48318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBE")]
		[Address(RVA = "0x33A4F20", Offset = "0x33A3B20", VA = "0x1833A4F20")]
		private void _OnLocalTrackUpdate(object arg)
		{
		}

		// Token: 0x0600BCBF RID: 48319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBF")]
		[Address(RVA = "0x33A6720", Offset = "0x33A5320", VA = "0x1833A6720")]
		public BuildingFloatToDoNotifyState()
		{
		}

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC0")]
		[Address(RVA = "0x33A31C0", Offset = "0x33A1DC0", VA = "0x1833A31C0")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BCC1 RID: 48321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC1")]
		[Address(RVA = "0x33A2C40", Offset = "0x33A1840", VA = "0x1833A2C40")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BCC2 RID: 48322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC2")]
		[Address(RVA = "0x33A2B20", Offset = "0x33A1720", VA = "0x1833A2B20")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BCC3 RID: 48323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC3")]
		[Address(RVA = "0x33A2B80", Offset = "0x33A1780", VA = "0x1833A2B80")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400BCC2 RID: 48322
		[Token(Token = "0x400BCC2")]
		private const float TOAST_DELAY = 0.5f;

		// Token: 0x0400BCC3 RID: 48323
		[Token(Token = "0x400BCC3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingToDoNotifyView _notifyView;

		// Token: 0x0400BCC4 RID: 48324
		[Token(Token = "0x400BCC4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _toggleNormal;

		// Token: 0x0400BCC5 RID: 48325
		[Token(Token = "0x400BCC5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _toggleEmer;

		// Token: 0x0400BCC6 RID: 48326
		[Token(Token = "0x400BCC6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text[] _textsNormalCount;

		// Token: 0x0400BCC7 RID: 48327
		[Token(Token = "0x400BCC7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text[] _textsEmerCount;

		// Token: 0x0400BCC8 RID: 48328
		[Token(Token = "0x400BCC8")]
		[FieldOffset(Offset = "0x68")]
		private BuildingToDoCategory m_selectedCategory;

		// Token: 0x0400BCC9 RID: 48329
		[Token(Token = "0x400BCC9")]
		[FieldOffset(Offset = "0x6C")]
		private BuildingData.BuildingToDoType m_selectedType;

		// Token: 0x0400BCCA RID: 48330
		[Token(Token = "0x400BCCA")]
		[FieldOffset(Offset = "0x70")]
		private BuildingToDoNotifyModel m_viewModel;

		// Token: 0x0400BCCB RID: 48331
		[Token(Token = "0x400BCCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BCCC RID: 48332
		[Token(Token = "0x400BCCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BCCD RID: 48333
		[Token(Token = "0x400BCCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BCCE RID: 48334
		[Token(Token = "0x400BCCE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BCCF RID: 48335
		[Token(Token = "0x400BCCF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BCD0 RID: 48336
		[Token(Token = "0x400BCD0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnTabNormalClicked;

		// Token: 0x0400BCD1 RID: 48337
		[Token(Token = "0x400BCD1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnTabEmerClicked;

		// Token: 0x0400BCD2 RID: 48338
		[Token(Token = "0x400BCD2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400BCD3 RID: 48339
		[Token(Token = "0x400BCD3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnHilightedMaskClicked;

		// Token: 0x0400BCD4 RID: 48340
		[Token(Token = "0x400BCD4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnToDoItemClicked;

		// Token: 0x0400BCD5 RID: 48341
		[Token(Token = "0x400BCD5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGainAllIntimacySuc;

		// Token: 0x0400BCD6 RID: 48342
		[Token(Token = "0x400BCD6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnNewProductItemClicked;

		// Token: 0x0400BCD7 RID: 48343
		[Token(Token = "0x400BCD7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnNewFavorItemClicked;

		// Token: 0x0400BCD8 RID: 48344
		[Token(Token = "0x400BCD8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnNewOrdersItemClicked;

		// Token: 0x0400BCD9 RID: 48345
		[Token(Token = "0x400BCD9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnBatchWorkClicked;

		// Token: 0x0400BCDA RID: 48346
		[Token(Token = "0x400BCDA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBatchRestClicked;

		// Token: 0x0400BCDB RID: 48347
		[Token(Token = "0x400BCDB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnProcessBatchOrder;

		// Token: 0x0400BCDC RID: 48348
		[Token(Token = "0x400BCDC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GenSyncSettleInfos;

		// Token: 0x0400BCDD RID: 48349
		[Token(Token = "0x400BCDD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CalculateRoomSettleInfos;

		// Token: 0x0400BCDE RID: 48350
		[Token(Token = "0x400BCDE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoBatchOrderToast;

		// Token: 0x0400BCDF RID: 48351
		[Token(Token = "0x400BCDF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SendGainAllIntimacyService;

		// Token: 0x0400BCE0 RID: 48352
		[Token(Token = "0x400BCE0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PickRandomCharForGainAllIntimacyVoice;

		// Token: 0x0400BCE1 RID: 48353
		[Token(Token = "0x400BCE1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateStatus;

		// Token: 0x0400BCE2 RID: 48354
		[Token(Token = "0x400BCE2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0400BCE3 RID: 48355
		[Token(Token = "0x400BCE3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TrySwitchToOverview;

		// Token: 0x0400BCE4 RID: 48356
		[Token(Token = "0x400BCE4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateTabButton;

		// Token: 0x0400BCE5 RID: 48357
		[Token(Token = "0x400BCE5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnLocalTrackUpdate;

		// Token: 0x0400BCE6 RID: 48358
		[Token(Token = "0x400BCE6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
