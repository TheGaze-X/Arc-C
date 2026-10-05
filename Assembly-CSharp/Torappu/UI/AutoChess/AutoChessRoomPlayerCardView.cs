using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062D7 RID: 25303
	[Token(Token = "0x20062D7")]
	public class AutoChessRoomPlayerCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024798 RID: 149400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024798")]
		[Address(RVA = "0x1F4A5A0", Offset = "0x1F491A0", VA = "0x181F4A5A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024799 RID: 149401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024799")]
		[Address(RVA = "0x1F4A8A0", Offset = "0x1F494A0", VA = "0x181F4A8A0")]
		private void _OnReadyStateChanged(bool isShow)
		{
		}

		// Token: 0x0602479A RID: 149402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602479A")]
		[Address(RVA = "0x1F4A950", Offset = "0x1F49550", VA = "0x181F4A950")]
		private void _SendMsg(int key, ValueBundle value)
		{
		}

		// Token: 0x0602479B RID: 149403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602479B")]
		[Address(RVA = "0x1F4A110", Offset = "0x1F48D10", VA = "0x181F4A110")]
		public void Render(int idx, AutoChessRoomPlayerCardViewModel viewModel)
		{
		}

		// Token: 0x0602479C RID: 149404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602479C")]
		[Address(RVA = "0x1F4A050", Offset = "0x1F48C50", VA = "0x181F4A050")]
		public void EventOnClickMenu()
		{
		}

		// Token: 0x0602479D RID: 149405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602479D")]
		[Address(RVA = "0x1F49E30", Offset = "0x1F48A30", VA = "0x181F49E30")]
		public void EventOnClickInvite()
		{
		}

		// Token: 0x0602479E RID: 149406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602479E")]
		[Address(RVA = "0x1F49F90", Offset = "0x1F48B90", VA = "0x181F49F90")]
		public void EventOnClickKick()
		{
		}

		// Token: 0x0602479F RID: 149407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602479F")]
		[Address(RVA = "0x1F49D80", Offset = "0x1F48980", VA = "0x181F49D80")]
		public void EventOnClickDiffServerBtn()
		{
		}

		// Token: 0x060247A0 RID: 149408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A0")]
		[Address(RVA = "0x1F49CA0", Offset = "0x1F488A0", VA = "0x181F49CA0")]
		public void EventOnClickCheckNameCard()
		{
		}

		// Token: 0x060247A1 RID: 149409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A1")]
		[Address(RVA = "0x1F49BB0", Offset = "0x1F487B0", VA = "0x181F49BB0")]
		public void EventOnClickAddFriend()
		{
		}

		// Token: 0x060247A2 RID: 149410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A2")]
		[Address(RVA = "0x1F4AA30", Offset = "0x1F49630", VA = "0x181F4AA30")]
		public AutoChessRoomPlayerCardView()
		{
		}

		// Token: 0x04032CBD RID: 208061
		[Token(Token = "0x4032CBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x04032CBE RID: 208062
		[Token(Token = "0x4032CBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _playerInObj;

		// Token: 0x04032CBF RID: 208063
		[Token(Token = "0x4032CBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _inviteOptionToggle;

		// Token: 0x04032CC0 RID: 208064
		[Token(Token = "0x4032CC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessPlayerInfoCardView _infoCardViewPrefab;

		// Token: 0x04032CC1 RID: 208065
		[Token(Token = "0x4032CC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _infoCardContainer;

		// Token: 0x04032CC2 RID: 208066
		[Token(Token = "0x4032CC2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _kickObj;

		// Token: 0x04032CC3 RID: 208067
		[Token(Token = "0x4032CC3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _hostTagObj;

		// Token: 0x04032CC4 RID: 208068
		[Token(Token = "0x4032CC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _selfTagObj;

		// Token: 0x04032CC5 RID: 208069
		[Token(Token = "0x4032CC5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _selfFrameObJ;

		// Token: 0x04032CC6 RID: 208070
		[Token(Token = "0x4032CC6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _readyInAnim;

		// Token: 0x04032CC7 RID: 208071
		[Token(Token = "0x4032CC7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _readyOutAnim;

		// Token: 0x04032CC8 RID: 208072
		[Token(Token = "0x4032CC8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x04032CC9 RID: 208073
		[Token(Token = "0x4032CC9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _nameCardOptionObj;

		// Token: 0x04032CCA RID: 208074
		[Token(Token = "0x4032CCA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _nameCardOptionHotspot;

		// Token: 0x04032CCB RID: 208075
		[Token(Token = "0x4032CCB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _unfoldMenuAnim;

		// Token: 0x04032CCC RID: 208076
		[Token(Token = "0x4032CCC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _firstEmptyVariant;

		// Token: 0x04032CCD RID: 208077
		[Token(Token = "0x4032CCD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _followingEmptyVariant;

		// Token: 0x04032CCE RID: 208078
		[Token(Token = "0x4032CCE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ThreeStateToggle _friendStateToggle;

		// Token: 0x04032CCF RID: 208079
		[Token(Token = "0x4032CCF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TwoStateToggle _diffServerToggle;

		// Token: 0x04032CD0 RID: 208080
		[Token(Token = "0x4032CD0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _disconnectObj;

		// Token: 0x04032CD1 RID: 208081
		[Token(Token = "0x4032CD1")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x04032CD2 RID: 208082
		[Token(Token = "0x4032CD2")]
		[FieldOffset(Offset = "0xD8")]
		private string m_cacheUID;

		// Token: 0x04032CD3 RID: 208083
		[Token(Token = "0x4032CD3")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032CD4 RID: 208084
		[Token(Token = "0x4032CD4")]
		[FieldOffset(Offset = "0xF0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032CD5 RID: 208085
		[Token(Token = "0x4032CD5")]
		[FieldOffset(Offset = "0x100")]
		private CharUISkinStruct m_cacheIllustSkin;

		// Token: 0x04032CD6 RID: 208086
		[Token(Token = "0x4032CD6")]
		[FieldOffset(Offset = "0x118")]
		private AnimationSwitchTween m_unfoldMenuSwitch;

		// Token: 0x04032CD7 RID: 208087
		[Token(Token = "0x4032CD7")]
		[FieldOffset(Offset = "0x120")]
		private UIBiAnimClipSwitchTween m_readyAnimSwitch;

		// Token: 0x04032CD8 RID: 208088
		[Token(Token = "0x4032CD8")]
		[FieldOffset(Offset = "0x128")]
		private AutoChessPlayerInfoCardView m_infoCardView;

		// Token: 0x04032CD9 RID: 208089
		[Token(Token = "0x4032CD9")]
		[FieldOffset(Offset = "0x130")]
		private FriendState m_cacheFriendState;

		// Token: 0x04032CDA RID: 208090
		[Token(Token = "0x4032CDA")]
		[FieldOffset(Offset = "0x138")]
		private UICharacterIllust m_cacheIllust;

		// Token: 0x04032CDB RID: 208091
		[Token(Token = "0x4032CDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032CDC RID: 208092
		[Token(Token = "0x4032CDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnReadyStateChanged;

		// Token: 0x04032CDD RID: 208093
		[Token(Token = "0x4032CDD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendMsg;

		// Token: 0x04032CDE RID: 208094
		[Token(Token = "0x4032CDE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032CDF RID: 208095
		[Token(Token = "0x4032CDF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClickMenu;

		// Token: 0x04032CE0 RID: 208096
		[Token(Token = "0x4032CE0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickInvite;

		// Token: 0x04032CE1 RID: 208097
		[Token(Token = "0x4032CE1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickKick;

		// Token: 0x04032CE2 RID: 208098
		[Token(Token = "0x4032CE2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClickDiffServerBtn;

		// Token: 0x04032CE3 RID: 208099
		[Token(Token = "0x4032CE3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClickCheckNameCard;

		// Token: 0x04032CE4 RID: 208100
		[Token(Token = "0x4032CE4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnClickAddFriend;

		// Token: 0x04032CE5 RID: 208101
		[Token(Token = "0x4032CE5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
