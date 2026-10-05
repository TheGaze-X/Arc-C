using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200503C RID: 20540
	[Token(Token = "0x200503C")]
	public class EnemyDuelPrepareRoomView : DataBinder<EnemyDuelPrepareRoomProperty>
	{
		// Token: 0x0601E75F RID: 124767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E75F")]
		[Address(RVA = "0x182AF30", Offset = "0x1829B30", VA = "0x18182AF30")]
		public void InitIfNot()
		{
		}

		// Token: 0x0601E760 RID: 124768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E760")]
		[Address(RVA = "0x182B980", Offset = "0x182A580", VA = "0x18182B980")]
		private void Update()
		{
		}

		// Token: 0x0601E761 RID: 124769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E761")]
		[Address(RVA = "0x182B010", Offset = "0x1829C10", VA = "0x18182B010", Slot = "7")]
		public override void OnValueChanged(EnemyDuelPrepareRoomProperty property)
		{
		}

		// Token: 0x0601E762 RID: 124770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E762")]
		[Address(RVA = "0x182B9F0", Offset = "0x182A5F0", VA = "0x18182B9F0")]
		public EnemyDuelPrepareRoomView()
		{
		}

		// Token: 0x04028C60 RID: 167008
		[Token(Token = "0x4028C60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyDuelPrepareBannerView _bannerView;

		// Token: 0x04028C61 RID: 167009
		[Token(Token = "0x4028C61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EnemyDuelPrepareModeDetailView _detailView;

		// Token: 0x04028C62 RID: 167010
		[Token(Token = "0x4028C62")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _roomIdText;

		// Token: 0x04028C63 RID: 167011
		[Token(Token = "0x4028C63")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _curPlayerNumText;

		// Token: 0x04028C64 RID: 167012
		[Token(Token = "0x4028C64")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _maxPlayerNumText;

		// Token: 0x04028C65 RID: 167013
		[Token(Token = "0x4028C65")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _roomEndTimeText;

		// Token: 0x04028C66 RID: 167014
		[Token(Token = "0x4028C66")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _playerCntRequirementText;

		// Token: 0x04028C67 RID: 167015
		[Token(Token = "0x4028C67")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EnemyDuelPrepareRoomPlayerCardAdapter _playerCardAdapter;

		// Token: 0x04028C68 RID: 167016
		[Token(Token = "0x4028C68")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] _hostObjs;

		// Token: 0x04028C69 RID: 167017
		[Token(Token = "0x4028C69")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle[] _hostToggles;

		// Token: 0x04028C6A RID: 167018
		[Token(Token = "0x4028C6A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _guestWaitBtnObj;

		// Token: 0x04028C6B RID: 167019
		[Token(Token = "0x4028C6B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _startBtnObj;

		// Token: 0x04028C6C RID: 167020
		[Token(Token = "0x4028C6C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _lackOfPlayerObj;

		// Token: 0x04028C6D RID: 167021
		[Token(Token = "0x4028C6D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _waitingPlayerReturnObj;

		// Token: 0x04028C6E RID: 167022
		[Token(Token = "0x4028C6E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GridLayoutGroup _playerCardsGridLayout;

		// Token: 0x04028C6F RID: 167023
		[Token(Token = "0x4028C6F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _npcOptionToggle;

		// Token: 0x04028C70 RID: 167024
		[Token(Token = "0x4028C70")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028C71 RID: 167025
		[Token(Token = "0x4028C71")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x04028C72 RID: 167026
		[Token(Token = "0x4028C72")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cacheModeId;

		// Token: 0x04028C73 RID: 167027
		[Token(Token = "0x4028C73")]
		[FieldOffset(Offset = "0xC0")]
		private EnemyDuelPrepareRoomStatusViewModel m_statusViewModel;

		// Token: 0x04028C74 RID: 167028
		[Token(Token = "0x4028C74")]
		[FieldOffset(Offset = "0xC8")]
		private AnimationSwitchTween m_enterSwitchTween;

		// Token: 0x04028C75 RID: 167029
		[Token(Token = "0x4028C75")]
		[FieldOffset(Offset = "0xD0")]
		private CountDownTask m_roomEndTask;

		// Token: 0x04028C76 RID: 167030
		[Token(Token = "0x4028C76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04028C77 RID: 167031
		[Token(Token = "0x4028C77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04028C78 RID: 167032
		[Token(Token = "0x4028C78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028C79 RID: 167033
		[Token(Token = "0x4028C79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
