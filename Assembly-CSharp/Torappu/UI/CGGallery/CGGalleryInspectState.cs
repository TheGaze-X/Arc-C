using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006012 RID: 24594
	[Token(Token = "0x2006012")]
	public class CGGalleryInspectState : PopupFadeState, CGGalleryPage.IBackControl, IValueMsgReceiver
	{
		// Token: 0x060238FE RID: 145662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60238FE")]
		[Address(RVA = "0x1E32EB0", Offset = "0x1E31AB0", VA = "0x181E32EB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x060238FF RID: 145663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005404")]
		public Func<bool> backAction
		{
			[Token(Token = "0x60238FF")]
			[Address(RVA = "0x1E34A20", Offset = "0x1E33620", VA = "0x181E34A20", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x06023900 RID: 145664 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06023901 RID: 145665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400008F")]
		public event Action<bool> onBackHideChanged
		{
			[Token(Token = "0x6023900")]
			[Address(RVA = "0x1E34920", Offset = "0x1E33520", VA = "0x181E34920", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6023901")]
			[Address(RVA = "0x1E34AD0", Offset = "0x1E336D0", VA = "0x181E34AD0", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06023902 RID: 145666 RVA: 0x000C1428 File Offset: 0x000BF628
		[Token(Token = "0x6023902")]
		[Address(RVA = "0x1E34580", Offset = "0x1E33180", VA = "0x181E34580")]
		private bool _OverrideBackPress()
		{
			return default(bool);
		}

		// Token: 0x06023903 RID: 145667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023903")]
		[Address(RVA = "0x1E33140", Offset = "0x1E31D40", VA = "0x181E33140", Slot = "34")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06023904 RID: 145668 RVA: 0x000C1440 File Offset: 0x000BF640
		[Token(Token = "0x6023904")]
		[Address(RVA = "0x1E33AC0", Offset = "0x1E326C0", VA = "0x181E33AC0")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x06023905 RID: 145669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023905")]
		[Address(RVA = "0x1E33E90", Offset = "0x1E32A90", VA = "0x181E33E90")]
		private void _OnNextCg(ValueBundle msg)
		{
		}

		// Token: 0x06023906 RID: 145670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023906")]
		[Address(RVA = "0x1E33F80", Offset = "0x1E32B80", VA = "0x181E33F80")]
		private void _OnPrevCg(ValueBundle msg)
		{
		}

		// Token: 0x06023907 RID: 145671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023907")]
		[Address(RVA = "0x1E34600", Offset = "0x1E33200", VA = "0x181E34600")]
		private void _PlayStory(ValueBundle msg)
		{
		}

		// Token: 0x06023908 RID: 145672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023908")]
		[Address(RVA = "0x1E33C60", Offset = "0x1E32860", VA = "0x181E33C60")]
		private void _OnAddFav(string cgId)
		{
		}

		// Token: 0x06023909 RID: 145673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023909")]
		[Address(RVA = "0x1E34070", Offset = "0x1E32C70", VA = "0x181E34070")]
		private void _OnRemFav(string cgId)
		{
		}

		// Token: 0x0602390A RID: 145674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602390A")]
		[Address(RVA = "0x1E34430", Offset = "0x1E33030", VA = "0x181E34430")]
		private void _OnTransitionEnd()
		{
		}

		// Token: 0x0602390B RID: 145675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602390B")]
		[Address(RVA = "0x1E342A0", Offset = "0x1E32EA0", VA = "0x181E342A0")]
		private void _OnSetUIState(bool isShow)
		{
		}

		// Token: 0x0602390C RID: 145676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602390C")]
		[Address(RVA = "0x1E34820", Offset = "0x1E33420", VA = "0x181E34820")]
		private void _SetBackButton(bool isHide)
		{
		}

		// Token: 0x0602390D RID: 145677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602390D")]
		[Address(RVA = "0x1E338E0", Offset = "0x1E324E0", VA = "0x181E338E0", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x0602390E RID: 145678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602390E")]
		[Address(RVA = "0x1E32F10", Offset = "0x1E31B10", VA = "0x181E32F10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602390F RID: 145679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602390F")]
		[Address(RVA = "0x1E33700", Offset = "0x1E32300", VA = "0x181E33700", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06023910 RID: 145680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023910")]
		[Address(RVA = "0x1E335A0", Offset = "0x1E321A0", VA = "0x181E335A0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06023911 RID: 145681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023911")]
		[Address(RVA = "0x1E33050", Offset = "0x1E31C50", VA = "0x181E33050", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06023912 RID: 145682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023912")]
		[Address(RVA = "0x1E348B0", Offset = "0x1E334B0", VA = "0x181E348B0")]
		public CGGalleryInspectState()
		{
		}

		// Token: 0x06023915 RID: 145685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023915")]
		[Address(RVA = "0x15A0840", Offset = "0x159F440", VA = "0x1815A0840")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x06023916 RID: 145686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023916")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023917 RID: 145687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023917")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06023918 RID: 145688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023918")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06023919 RID: 145689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023919")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403135A RID: 201562
		[Token(Token = "0x403135A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CGGalleryInspectView _view;

		// Token: 0x0403135B RID: 201563
		[Token(Token = "0x403135B")]
		[FieldOffset(Offset = "0x78")]
		private CGGalleryPage m_page;

		// Token: 0x0403135C RID: 201564
		[Token(Token = "0x403135C")]
		[FieldOffset(Offset = "0x80")]
		private CGGalleryViewModel m_viewModel;

		// Token: 0x0403135D RID: 201565
		[Token(Token = "0x403135D")]
		[NonSerialized]
		public const int MSG_NEXT_CG = 10;

		// Token: 0x0403135E RID: 201566
		[Token(Token = "0x403135E")]
		[NonSerialized]
		public const int MSG_PREV_CG = 11;

		// Token: 0x0403135F RID: 201567
		[Token(Token = "0x403135F")]
		[NonSerialized]
		public const int MSG_PLAY_STORY = 12;

		// Token: 0x04031360 RID: 201568
		[Token(Token = "0x4031360")]
		[NonSerialized]
		public const int MSG_ADD_FAV = 13;

		// Token: 0x04031361 RID: 201569
		[Token(Token = "0x4031361")]
		[NonSerialized]
		public const int MSG_REM_FAV = 14;

		// Token: 0x04031362 RID: 201570
		[Token(Token = "0x4031362")]
		[NonSerialized]
		public const int MSG_SET_UI_STATE = 15;

		// Token: 0x04031363 RID: 201571
		[Token(Token = "0x4031363")]
		[NonSerialized]
		public const int MSG_TRANSITION_TW_END = 16;

		// Token: 0x04031365 RID: 201573
		[Token(Token = "0x4031365")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isUIShow;

		// Token: 0x04031366 RID: 201574
		[Token(Token = "0x4031366")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031367 RID: 201575
		[Token(Token = "0x4031367")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_backAction;

		// Token: 0x04031368 RID: 201576
		[Token(Token = "0x4031368")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_onBackHideChanged;

		// Token: 0x04031369 RID: 201577
		[Token(Token = "0x4031369")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_onBackHideChanged;

		// Token: 0x0403136A RID: 201578
		[Token(Token = "0x403136A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OverrideBackPress;

		// Token: 0x0403136B RID: 201579
		[Token(Token = "0x403136B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403136C RID: 201580
		[Token(Token = "0x403136C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x0403136D RID: 201581
		[Token(Token = "0x403136D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnNextCg;

		// Token: 0x0403136E RID: 201582
		[Token(Token = "0x403136E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPrevCg;

		// Token: 0x0403136F RID: 201583
		[Token(Token = "0x403136F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayStory;

		// Token: 0x04031370 RID: 201584
		[Token(Token = "0x4031370")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAddFav;

		// Token: 0x04031371 RID: 201585
		[Token(Token = "0x4031371")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnRemFav;

		// Token: 0x04031372 RID: 201586
		[Token(Token = "0x4031372")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnTransitionEnd;

		// Token: 0x04031373 RID: 201587
		[Token(Token = "0x4031373")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSetUIState;

		// Token: 0x04031374 RID: 201588
		[Token(Token = "0x4031374")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetBackButton;

		// Token: 0x04031375 RID: 201589
		[Token(Token = "0x4031375")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x04031376 RID: 201590
		[Token(Token = "0x4031376")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031377 RID: 201591
		[Token(Token = "0x4031377")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04031378 RID: 201592
		[Token(Token = "0x4031378")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04031379 RID: 201593
		[Token(Token = "0x4031379")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403137A RID: 201594
		[Token(Token = "0x403137A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
