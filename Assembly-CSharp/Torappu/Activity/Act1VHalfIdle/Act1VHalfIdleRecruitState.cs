using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077EE RID: 30702
	[Token(Token = "0x20077EE")]
	public class Act1VHalfIdleRecruitState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602B133 RID: 176435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B133")]
		[Address(RVA = "0x26E1A00", Offset = "0x26E0600", VA = "0x1826E1A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B134 RID: 176436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B134")]
		[Address(RVA = "0x26E0FF0", Offset = "0x26DFBF0", VA = "0x1826E0FF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B135 RID: 176437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B135")]
		[Address(RVA = "0x26E12E0", Offset = "0x26DFEE0", VA = "0x1826E12E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B136 RID: 176438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B136")]
		[Address(RVA = "0x26E17D0", Offset = "0x26E03D0", VA = "0x1826E17D0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602B137 RID: 176439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B137")]
		[Address(RVA = "0x26E1050", Offset = "0x26DFC50", VA = "0x1826E1050")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x0602B138 RID: 176440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B138")]
		[Address(RVA = "0x26E1850", Offset = "0x26E0450", VA = "0x1826E1850", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602B139 RID: 176441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B139")]
		[Address(RVA = "0x26E1FB0", Offset = "0x26E0BB0", VA = "0x1826E1FB0")]
		private void _OnTabClicked(string tabId)
		{
		}

		// Token: 0x0602B13A RID: 176442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B13A")]
		[Address(RVA = "0x26E1BE0", Offset = "0x26E07E0", VA = "0x1826E1BE0")]
		private void _OnGachaCompleted(ValueBundle msg)
		{
		}

		// Token: 0x0602B13B RID: 176443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B13B")]
		[Address(RVA = "0x26E10E0", Offset = "0x26DFCE0", VA = "0x1826E10E0")]
		public void OnBtnRecruitDetailClicked()
		{
		}

		// Token: 0x0602B13C RID: 176444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B13C")]
		[Address(RVA = "0x26E2060", Offset = "0x26E0C60", VA = "0x1826E2060")]
		public Act1VHalfIdleRecruitState()
		{
		}

		// Token: 0x0602B13D RID: 176445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B13D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602B13E RID: 176446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B13E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403E3CA RID: 254922
		[Token(Token = "0x403E3CA")]
		[NonSerialized]
		public const int MSG_ON_TAB_CLICKED = 0;

		// Token: 0x0403E3CB RID: 254923
		[Token(Token = "0x403E3CB")]
		[NonSerialized]
		public const int MSG_ON_GACHA_COMPLETED = 1;

		// Token: 0x0403E3CC RID: 254924
		[Token(Token = "0x403E3CC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x0403E3CD RID: 254925
		[Token(Token = "0x403E3CD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleRecruitTabListView _tabListView;

		// Token: 0x0403E3CE RID: 254926
		[Token(Token = "0x403E3CE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0403E3CF RID: 254927
		[Token(Token = "0x403E3CF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animEntryFront;

		// Token: 0x0403E3D0 RID: 254928
		[Token(Token = "0x403E3D0")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0403E3D1 RID: 254929
		[Token(Token = "0x403E3D1")]
		[FieldOffset(Offset = "0xA8")]
		private Act1VHalfIdleRecruitStateBean m_stateBean;

		// Token: 0x0403E3D2 RID: 254930
		[Token(Token = "0x403E3D2")]
		[FieldOffset(Offset = "0xB0")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x0403E3D3 RID: 254931
		[Token(Token = "0x403E3D3")]
		[FieldOffset(Offset = "0xB8")]
		private Act1VHalfIdleRecruitPage m_page;

		// Token: 0x0403E3D4 RID: 254932
		[Token(Token = "0x403E3D4")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_entryTween;

		// Token: 0x0403E3D5 RID: 254933
		[Token(Token = "0x403E3D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E3D6 RID: 254934
		[Token(Token = "0x403E3D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E3D7 RID: 254935
		[Token(Token = "0x403E3D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E3D8 RID: 254936
		[Token(Token = "0x403E3D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403E3D9 RID: 254937
		[Token(Token = "0x403E3D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0403E3DA RID: 254938
		[Token(Token = "0x403E3DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403E3DB RID: 254939
		[Token(Token = "0x403E3DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnTabClicked;

		// Token: 0x0403E3DC RID: 254940
		[Token(Token = "0x403E3DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnGachaCompleted;

		// Token: 0x0403E3DD RID: 254941
		[Token(Token = "0x403E3DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnRecruitDetailClicked;

		// Token: 0x0403E3DE RID: 254942
		[Token(Token = "0x403E3DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077EF RID: 30703
		[Token(Token = "0x20077EF")]
		private class TabDataSource : UITabPager.TabDataSource
		{
			// Token: 0x0602B13F RID: 176447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B13F")]
			[Address(RVA = "0x26ED100", Offset = "0x26EBD00", VA = "0x1826ED100")]
			public TabDataSource(Act1VHalfIdleRecruitState closure)
			{
			}

			// Token: 0x0602B140 RID: 176448 RVA: 0x000DAC10 File Offset: 0x000D8E10
			[Token(Token = "0x602B140")]
			[Address(RVA = "0x26ECFA0", Offset = "0x26EBBA0", VA = "0x1826ECFA0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x0602B141 RID: 176449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B141")]
			[Address(RVA = "0x26ED070", Offset = "0x26EBC70", VA = "0x1826ED070", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x0403E3DF RID: 254943
			[Token(Token = "0x403E3DF")]
			[FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleRecruitState m_closure;

			// Token: 0x0403E3E0 RID: 254944
			[Token(Token = "0x403E3E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E3E1 RID: 254945
			[Token(Token = "0x403E3E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTabCount;

			// Token: 0x0403E3E2 RID: 254946
			[Token(Token = "0x403E3E2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTab;
		}
	}
}
