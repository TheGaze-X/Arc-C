using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF0 RID: 19952
	[Token(Token = "0x2004DF0")]
	public class NameCardSkinListItemView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x0601DD22 RID: 122146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD22")]
		[Address(RVA = "0x1757270", Offset = "0x1755E70", VA = "0x181757270")]
		private void _InitIfNot(bool isSubSkinSelected)
		{
		}

		// Token: 0x0601DD23 RID: 122147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD23")]
		[Address(RVA = "0x1756DD0", Offset = "0x17559D0", VA = "0x181756DD0")]
		public void Render(NameCardSkinListItemViewModel model, bool isSubSkinList, bool isSelected, bool subSkinFastMode)
		{
		}

		// Token: 0x0601DD24 RID: 122148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD24")]
		[Address(RVA = "0x17569D0", Offset = "0x17555D0", VA = "0x1817569D0")]
		public void OnSkinSelectClick()
		{
		}

		// Token: 0x0601DD25 RID: 122149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD25")]
		[Address(RVA = "0x1756CC0", Offset = "0x17558C0", VA = "0x181756CC0")]
		public void OnToChangeSubSkinClick()
		{
		}

		// Token: 0x0601DD26 RID: 122150 RVA: 0x000AC710 File Offset: 0x000AA910
		[Token(Token = "0x601DD26")]
		[Address(RVA = "0x1757110", Offset = "0x1755D10", VA = "0x181757110")]
		private static bool _CheckIfNameCardSkinUnlocked(string skinId)
		{
			return default(bool);
		}

		// Token: 0x0601DD27 RID: 122151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD27")]
		[Address(RVA = "0x17571C0", Offset = "0x1755DC0", VA = "0x1817571C0")]
		private static void _ConsumeNameCardSkinTrack(string skinId)
		{
		}

		// Token: 0x0601DD28 RID: 122152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD28")]
		[Address(RVA = "0x1756930", Offset = "0x1755530", VA = "0x181756930", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DD29 RID: 122153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD29")]
		[Address(RVA = "0x17574D0", Offset = "0x17560D0", VA = "0x1817574D0")]
		public NameCardSkinListItemView()
		{
		}

		// Token: 0x04027800 RID: 161792
		[Token(Token = "0x4027800")]
		private const string PLAYER_NAME_FORMAT = "{0}#{1}";

		// Token: 0x04027801 RID: 161793
		[Token(Token = "0x4027801")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x04027802 RID: 161794
		[Token(Token = "0x4027802")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x04027803 RID: 161795
		[Token(Token = "0x4027803")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _playerNameText;

		// Token: 0x04027804 RID: 161796
		[Token(Token = "0x4027804")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _playerIdText;

		// Token: 0x04027805 RID: 161797
		[Token(Token = "0x4027805")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x04027806 RID: 161798
		[Token(Token = "0x4027806")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x04027807 RID: 161799
		[Token(Token = "0x4027807")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _selectedFrame;

		// Token: 0x04027808 RID: 161800
		[Token(Token = "0x4027808")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newSkinTrackPoint;

		// Token: 0x04027809 RID: 161801
		[Token(Token = "0x4027809")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _hasSubSkinBtn;

		// Token: 0x0402780A RID: 161802
		[Token(Token = "0x402780A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _subSkinSelectAnim;

		// Token: 0x0402780B RID: 161803
		[Token(Token = "0x402780B")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0402780C RID: 161804
		[Token(Token = "0x402780C")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402780D RID: 161805
		[Token(Token = "0x402780D")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402780E RID: 161806
		[Token(Token = "0x402780E")]
		[FieldOffset(Offset = "0xA0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402780F RID: 161807
		[Token(Token = "0x402780F")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_subSkinSelectTween;

		// Token: 0x04027810 RID: 161808
		[Token(Token = "0x4027810")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_cachedIsSubSkinList;

		// Token: 0x04027811 RID: 161809
		[Token(Token = "0x4027811")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_cachedIsSelected;

		// Token: 0x04027812 RID: 161810
		[Token(Token = "0x4027812")]
		[FieldOffset(Offset = "0xB8")]
		private NameCardSkinListItemViewModel m_cachedModel;

		// Token: 0x04027813 RID: 161811
		[Token(Token = "0x4027813")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027814 RID: 161812
		[Token(Token = "0x4027814")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027815 RID: 161813
		[Token(Token = "0x4027815")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSkinSelectClick;

		// Token: 0x04027816 RID: 161814
		[Token(Token = "0x4027816")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnToChangeSubSkinClick;

		// Token: 0x04027817 RID: 161815
		[Token(Token = "0x4027817")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfNameCardSkinUnlocked;

		// Token: 0x04027818 RID: 161816
		[Token(Token = "0x4027818")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ConsumeNameCardSkinTrack;

		// Token: 0x04027819 RID: 161817
		[Token(Token = "0x4027819")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0402781A RID: 161818
		[Token(Token = "0x402781A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
