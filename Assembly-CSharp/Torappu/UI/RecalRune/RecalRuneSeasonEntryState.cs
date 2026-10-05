using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x02004788 RID: 18312
	[Token(Token = "0x2004788")]
	public class RecalRuneSeasonEntryState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601BB79 RID: 113529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB79")]
		[Address(RVA = "0x1509450", Offset = "0x1508050", VA = "0x181509450", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601BB7A RID: 113530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB7A")]
		[Address(RVA = "0x1509090", Offset = "0x1507C90", VA = "0x181509090")]
		public void EventOnClaimJuniorRewardClicked()
		{
		}

		// Token: 0x0601BB7B RID: 113531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB7B")]
		[Address(RVA = "0x15090F0", Offset = "0x1507CF0", VA = "0x1815090F0")]
		public void EventOnClaimSeniorRewardClicked()
		{
		}

		// Token: 0x0601BB7C RID: 113532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB7C")]
		[Address(RVA = "0x1508FE0", Offset = "0x1507BE0", VA = "0x181508FE0")]
		public void EventOnChangeSeasonClicked()
		{
		}

		// Token: 0x0601BB7D RID: 113533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB7D")]
		[Address(RVA = "0x1509150", Offset = "0x1507D50", VA = "0x181509150")]
		public void EventOnMedalClicked()
		{
		}

		// Token: 0x0601BB7E RID: 113534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB7E")]
		[Address(RVA = "0x1509270", Offset = "0x1507E70", VA = "0x181509270", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BB7F RID: 113535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB7F")]
		[Address(RVA = "0x15092D0", Offset = "0x1507ED0", VA = "0x1815092D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BB80 RID: 113536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB80")]
		[Address(RVA = "0x15095D0", Offset = "0x15081D0", VA = "0x1815095D0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601BB81 RID: 113537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB81")]
		[Address(RVA = "0x15098D0", Offset = "0x15084D0", VA = "0x1815098D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601BB82 RID: 113538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB82")]
		[Address(RVA = "0x1509F10", Offset = "0x1508B10", VA = "0x181509F10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BB83 RID: 113539 RVA: 0x000A5F30 File Offset: 0x000A4130
		[Token(Token = "0x601BB83")]
		[Address(RVA = "0x150A1C0", Offset = "0x1508DC0", VA = "0x18150A1C0")]
		private bool _UpdateData()
		{
			return default(bool);
		}

		// Token: 0x0601BB84 RID: 113540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB84")]
		[Address(RVA = "0x1509FE0", Offset = "0x1508BE0", VA = "0x181509FE0")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x0601BB85 RID: 113541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB85")]
		[Address(RVA = "0x1509C50", Offset = "0x1508850", VA = "0x181509C50")]
		private void _ClaimReward(RecalRuneRewardType rewardType)
		{
		}

		// Token: 0x0601BB86 RID: 113542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB86")]
		[Address(RVA = "0x150A0E0", Offset = "0x1508CE0", VA = "0x18150A0E0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0601BB87 RID: 113543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB87")]
		[Address(RVA = "0x150A370", Offset = "0x1508F70", VA = "0x18150A370")]
		public RecalRuneSeasonEntryState()
		{
		}

		// Token: 0x0601BB8A RID: 113546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB8A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601BB8B RID: 113547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB8B")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0601BB8C RID: 113548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB8C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04024060 RID: 147552
		[Token(Token = "0x4024060")]
		[NonSerialized]
		public const int MSG_STAGE_CLICK = 0;

		// Token: 0x04024061 RID: 147553
		[Token(Token = "0x4024061")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecalRuneSeasonEntryView _view;

		// Token: 0x04024062 RID: 147554
		[Token(Token = "0x4024062")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x04024063 RID: 147555
		[Token(Token = "0x4024063")]
		[FieldOffset(Offset = "0x88")]
		private RecalRuneSeasonEntryProperty m_prop;

		// Token: 0x04024064 RID: 147556
		[Token(Token = "0x4024064")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04024065 RID: 147557
		[Token(Token = "0x4024065")]
		[FieldOffset(Offset = "0x98")]
		private RecalRunePage m_page;

		// Token: 0x04024066 RID: 147558
		[Token(Token = "0x4024066")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_entryTween;

		// Token: 0x04024067 RID: 147559
		[Token(Token = "0x4024067")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04024068 RID: 147560
		[Token(Token = "0x4024068")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClaimJuniorRewardClicked;

		// Token: 0x04024069 RID: 147561
		[Token(Token = "0x4024069")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClaimSeniorRewardClicked;

		// Token: 0x0402406A RID: 147562
		[Token(Token = "0x402406A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnChangeSeasonClicked;

		// Token: 0x0402406B RID: 147563
		[Token(Token = "0x402406B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnMedalClicked;

		// Token: 0x0402406C RID: 147564
		[Token(Token = "0x402406C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402406D RID: 147565
		[Token(Token = "0x402406D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402406E RID: 147566
		[Token(Token = "0x402406E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0402406F RID: 147567
		[Token(Token = "0x402406F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04024070 RID: 147568
		[Token(Token = "0x4024070")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024071 RID: 147569
		[Token(Token = "0x4024071")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04024072 RID: 147570
		[Token(Token = "0x4024072")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x04024073 RID: 147571
		[Token(Token = "0x4024073")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClaimReward;

		// Token: 0x04024074 RID: 147572
		[Token(Token = "0x4024074")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04024075 RID: 147573
		[Token(Token = "0x4024075")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
