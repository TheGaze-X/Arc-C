using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007320 RID: 29472
	[Token(Token = "0x2007320")]
	public class Act42SideGunTaskEntryState : PopupFadeState, ICompDialogCallBack, IValueMsgReceiver
	{
		// Token: 0x06029AC3 RID: 170691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC3")]
		[Address(RVA = "0x250D760", Offset = "0x250C360", VA = "0x18250D760", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06029AC4 RID: 170692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029AC4")]
		[Address(RVA = "0x250D5E0", Offset = "0x250C1E0", VA = "0x18250D5E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029AC5 RID: 170693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029AC5")]
		[Address(RVA = "0x250DB60", Offset = "0x250C760", VA = "0x18250DB60", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029AC6 RID: 170694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC6")]
		[Address(RVA = "0x250E270", Offset = "0x250CE70", VA = "0x18250E270")]
		private void _OnGunTaskDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x06029AC7 RID: 170695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC7")]
		[Address(RVA = "0x250DEB0", Offset = "0x250CAB0", VA = "0x18250DEB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029AC8 RID: 170696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC8")]
		[Address(RVA = "0x250D6F0", Offset = "0x250C2F0", VA = "0x18250D6F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029AC9 RID: 170697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AC9")]
		[Address(RVA = "0x250DA20", Offset = "0x250C620", VA = "0x18250DA20", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06029ACA RID: 170698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ACA")]
		[Address(RVA = "0x250DAB0", Offset = "0x250C6B0", VA = "0x18250DAB0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029ACB RID: 170699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ACB")]
		[Address(RVA = "0x250DCC0", Offset = "0x250C8C0", VA = "0x18250DCC0")]
		public void TriggerEnterAnim()
		{
		}

		// Token: 0x06029ACC RID: 170700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ACC")]
		[Address(RVA = "0x250EC60", Offset = "0x250D860", VA = "0x18250EC60")]
		private void _UpdateData()
		{
		}

		// Token: 0x06029ACD RID: 170701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ACD")]
		[Address(RVA = "0x250EBE0", Offset = "0x250D7E0", VA = "0x18250EBE0")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x06029ACE RID: 170702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ACE")]
		[Address(RVA = "0x250D640", Offset = "0x250C240", VA = "0x18250D640", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06029ACF RID: 170703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ACF")]
		[Address(RVA = "0x250EA20", Offset = "0x250D620", VA = "0x18250EA20")]
		private void _OnTrustorClicked(ValueBundle val)
		{
		}

		// Token: 0x06029AD0 RID: 170704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD0")]
		[Address(RVA = "0x250E3B0", Offset = "0x250CFB0", VA = "0x18250E3B0")]
		private void _OnRewardAvailClicked()
		{
		}

		// Token: 0x06029AD1 RID: 170705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD1")]
		[Address(RVA = "0x250E730", Offset = "0x250D330", VA = "0x18250E730")]
		private void _OnRewardDetailClicked()
		{
		}

		// Token: 0x06029AD2 RID: 170706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD2")]
		[Address(RVA = "0x250DFC0", Offset = "0x250CBC0", VA = "0x18250DFC0")]
		private void _OnArchiveClicked()
		{
		}

		// Token: 0x06029AD3 RID: 170707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD3")]
		[Address(RVA = "0x250EE50", Offset = "0x250DA50", VA = "0x18250EE50")]
		public Act42SideGunTaskEntryState()
		{
		}

		// Token: 0x06029AD6 RID: 170710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029AD6")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029AD7 RID: 170711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029AD8 RID: 170712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD8")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06029AD9 RID: 170713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AD9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B9FE RID: 244222
		[Token(Token = "0x403B9FE")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "entry";

		// Token: 0x0403B9FF RID: 244223
		[Token(Token = "0x403B9FF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403BA00 RID: 244224
		[Token(Token = "0x403BA00")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act42sideGunTaskEntryView _entryView;

		// Token: 0x0403BA01 RID: 244225
		[Token(Token = "0x403BA01")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UICommonTrackPoint _panelRewardTrack;

		// Token: 0x0403BA02 RID: 244226
		[Token(Token = "0x403BA02")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0403BA03 RID: 244227
		[Token(Token = "0x403BA03")]
		[FieldOffset(Offset = "0x94")]
		private int m_rewardDlgInst;

		// Token: 0x0403BA04 RID: 244228
		[Token(Token = "0x403BA04")]
		[FieldOffset(Offset = "0x98")]
		private Act42sideGunTaskPage m_page;

		// Token: 0x0403BA05 RID: 244229
		[Token(Token = "0x403BA05")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x0403BA06 RID: 244230
		[Token(Token = "0x403BA06")]
		[FieldOffset(Offset = "0xA8")]
		private string m_selectedTrustorId;

		// Token: 0x0403BA07 RID: 244231
		[Token(Token = "0x403BA07")]
		[FieldOffset(Offset = "0xB0")]
		private Act42SideGunTaskEntryStateBean m_stateBean;

		// Token: 0x0403BA08 RID: 244232
		[Token(Token = "0x403BA08")]
		[NonSerialized]
		public const int ON_TRUSTOR_CLICK = 0;

		// Token: 0x0403BA09 RID: 244233
		[Token(Token = "0x403BA09")]
		[NonSerialized]
		public const int ON_REWARD_AVAIL_CLICK = 1;

		// Token: 0x0403BA0A RID: 244234
		[Token(Token = "0x403BA0A")]
		[NonSerialized]
		public const int ON_REWARD_DETAIL_CLICK = 2;

		// Token: 0x0403BA0B RID: 244235
		[Token(Token = "0x403BA0B")]
		[NonSerialized]
		public const int ON_TOKEN_DETAIL_CLICK = 3;

		// Token: 0x0403BA0C RID: 244236
		[Token(Token = "0x403BA0C")]
		[NonSerialized]
		public const int ON_ARCHIVE_CLICK = 4;

		// Token: 0x0403BA0D RID: 244237
		[Token(Token = "0x403BA0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403BA0E RID: 244238
		[Token(Token = "0x403BA0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403BA0F RID: 244239
		[Token(Token = "0x403BA0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403BA10 RID: 244240
		[Token(Token = "0x403BA10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnGunTaskDetailState;

		// Token: 0x0403BA11 RID: 244241
		[Token(Token = "0x403BA11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BA12 RID: 244242
		[Token(Token = "0x403BA12")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403BA13 RID: 244243
		[Token(Token = "0x403BA13")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403BA14 RID: 244244
		[Token(Token = "0x403BA14")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403BA15 RID: 244245
		[Token(Token = "0x403BA15")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TriggerEnterAnim;

		// Token: 0x0403BA16 RID: 244246
		[Token(Token = "0x403BA16")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0403BA17 RID: 244247
		[Token(Token = "0x403BA17")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0403BA18 RID: 244248
		[Token(Token = "0x403BA18")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403BA19 RID: 244249
		[Token(Token = "0x403BA19")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnTrustorClicked;

		// Token: 0x0403BA1A RID: 244250
		[Token(Token = "0x403BA1A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnRewardAvailClicked;

		// Token: 0x0403BA1B RID: 244251
		[Token(Token = "0x403BA1B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRewardDetailClicked;

		// Token: 0x0403BA1C RID: 244252
		[Token(Token = "0x403BA1C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnArchiveClicked;

		// Token: 0x0403BA1D RID: 244253
		[Token(Token = "0x403BA1D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
