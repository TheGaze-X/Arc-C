using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006519 RID: 25881
	[Token(Token = "0x2006519")]
	public class ArtMagazineCoverPage : UIPage, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06025326 RID: 152358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025326")]
		[Address(RVA = "0x2035330", Offset = "0x2033F30", VA = "0x182035330", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x06025327 RID: 152359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025327")]
		[Address(RVA = "0x2035700", Offset = "0x2034300", VA = "0x182035700", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06025328 RID: 152360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025328")]
		[Address(RVA = "0x2035680", Offset = "0x2034280", VA = "0x182035680", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x06025329 RID: 152361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025329")]
		[Address(RVA = "0x2035B00", Offset = "0x2034700", VA = "0x182035B00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602532A RID: 152362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602532A")]
		[Address(RVA = "0x20358E0", Offset = "0x20344E0", VA = "0x1820358E0")]
		private IEnumerator _CoTryOpenFirstMeetRewardsDlg()
		{
			return null;
		}

		// Token: 0x0602532B RID: 152363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602532B")]
		[Address(RVA = "0x2035FE0", Offset = "0x2034BE0", VA = "0x182035FE0")]
		private void _TryShowFirstMeetRewardsDlg()
		{
		}

		// Token: 0x0602532C RID: 152364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602532C")]
		[Address(RVA = "0x2035990", Offset = "0x2034590", VA = "0x182035990")]
		private void _CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
		}

		// Token: 0x0602532D RID: 152365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602532D")]
		[Address(RVA = "0x20351E0", Offset = "0x2033DE0", VA = "0x1820351E0", Slot = "25")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602532E RID: 152366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602532E")]
		[Address(RVA = "0x20353F0", Offset = "0x2033FF0", VA = "0x1820353F0", Slot = "24")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602532F RID: 152367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602532F")]
		[Address(RVA = "0x2035EA0", Offset = "0x2034AA0", VA = "0x182035EA0")]
		private void _OpenNameCardPage()
		{
		}

		// Token: 0x06025330 RID: 152368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025330")]
		[Address(RVA = "0x2035DE0", Offset = "0x20349E0", VA = "0x182035DE0")]
		private void _OpenLeafOverviewPage()
		{
		}

		// Token: 0x06025331 RID: 152369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025331")]
		[Address(RVA = "0x2036100", Offset = "0x2034D00", VA = "0x182036100")]
		public ArtMagazineCoverPage()
		{
		}

		// Token: 0x06025332 RID: 152370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025332")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06025333 RID: 152371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025333")]
		[Address(RVA = "0xE98780", Offset = "0xE97380", VA = "0x180E98780")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06025334 RID: 152372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025334")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x040342B0 RID: 213680
		[Token(Token = "0x40342B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _objDialogBlocker;

		// Token: 0x040342B1 RID: 213681
		[Token(Token = "0x40342B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _firstRewardDlgDelayShow;

		// Token: 0x040342B2 RID: 213682
		[Token(Token = "0x40342B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x040342B3 RID: 213683
		[Token(Token = "0x40342B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040342B4 RID: 213684
		[Token(Token = "0x40342B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ArtMagazineCoverFrontUIView _frontUIView;

		// Token: 0x040342B5 RID: 213685
		[Token(Token = "0x40342B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ArtMagazineCoverLeafsView _leafsView;

		// Token: 0x040342B6 RID: 213686
		[Token(Token = "0x40342B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool m_inited;

		// Token: 0x040342B7 RID: 213687
		[Token(Token = "0x40342B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x040342B8 RID: 213688
		[Token(Token = "0x40342B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int m_firstRewardDlgInstId;

		// Token: 0x040342B9 RID: 213689
		[Token(Token = "0x40342B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ArtMagazineCoverViewModelProperty m_coverViewProperty;

		// Token: 0x040342BA RID: 213690
		[Token(Token = "0x40342BA")]
		[NonSerialized]
		public const int EVENT_OPEN_NAME_CARD_PAGE = 0;

		// Token: 0x040342BB RID: 213691
		[Token(Token = "0x40342BB")]
		[NonSerialized]
		public const int EVENT_OPEN_LEAF_OVERVIEW_PAGE = 1;

		// Token: 0x040342BC RID: 213692
		[Token(Token = "0x40342BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040342BD RID: 213693
		[Token(Token = "0x40342BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040342BE RID: 213694
		[Token(Token = "0x40342BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x040342BF RID: 213695
		[Token(Token = "0x40342BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040342C0 RID: 213696
		[Token(Token = "0x40342C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CoTryOpenFirstMeetRewardsDlg;

		// Token: 0x040342C1 RID: 213697
		[Token(Token = "0x40342C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryShowFirstMeetRewardsDlg;

		// Token: 0x040342C2 RID: 213698
		[Token(Token = "0x40342C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateCommonTopMenu;

		// Token: 0x040342C3 RID: 213699
		[Token(Token = "0x40342C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040342C4 RID: 213700
		[Token(Token = "0x40342C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040342C5 RID: 213701
		[Token(Token = "0x40342C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenNameCardPage;

		// Token: 0x040342C6 RID: 213702
		[Token(Token = "0x40342C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenLeafOverviewPage;

		// Token: 0x040342C7 RID: 213703
		[Token(Token = "0x40342C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
