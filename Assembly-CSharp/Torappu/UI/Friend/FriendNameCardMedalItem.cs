using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using Torappu.UI.Medal;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE9 RID: 19945
	[Token(Token = "0x2004DE9")]
	public class FriendNameCardMedalItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DD0B RID: 122123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD0B")]
		[Address(RVA = "0x1752FE0", Offset = "0x1751BE0", VA = "0x181752FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DD0C RID: 122124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD0C")]
		[Address(RVA = "0x1752B20", Offset = "0x1751720", VA = "0x181752B20")]
		public void RenderSelfDIY(FriendNameCardMedalItem.Options options)
		{
		}

		// Token: 0x0601DD0D RID: 122125 RVA: 0x000AC6E0 File Offset: 0x000AA8E0
		[Token(Token = "0x601DD0D")]
		[Address(RVA = "0x1752EB0", Offset = "0x1751AB0", VA = "0x181752EB0")]
		private bool _CheckMedalAvail(string medalId)
		{
			return default(bool);
		}

		// Token: 0x0601DD0E RID: 122126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD0E")]
		[Address(RVA = "0x1752720", Offset = "0x1751320", VA = "0x181752720")]
		public void RenderOtherDIY(PlayerMedalCustomLayout viewModel, FriendNameCardMedalItem.Options options)
		{
		}

		// Token: 0x0601DD0F RID: 122127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD0F")]
		[Address(RVA = "0x1752480", Offset = "0x1751080", VA = "0x181752480")]
		public void RenderNo(FriendNameCardMedalItem.Options options)
		{
		}

		// Token: 0x0601DD10 RID: 122128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD10")]
		[Address(RVA = "0x1752170", Offset = "0x1750D70", VA = "0x181752170")]
		public void RenderInfo(MedalGroupViewModel viewModel, FriendNameCardMedalItem.Options options)
		{
		}

		// Token: 0x0601DD11 RID: 122129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD11")]
		[Address(RVA = "0x17531B0", Offset = "0x1751DB0", VA = "0x1817531B0")]
		private void _SetBoolFlag(bool isSelect, bool currentSelect)
		{
		}

		// Token: 0x0601DD12 RID: 122130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD12")]
		[Address(RVA = "0x1753570", Offset = "0x1752170", VA = "0x181753570")]
		private void _UpdateBtnGraphic(UIMedalGroupView groupView)
		{
		}

		// Token: 0x0601DD13 RID: 122131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD13")]
		[Address(RVA = "0x1752090", Offset = "0x1750C90", VA = "0x181752090")]
		public void OnClick()
		{
		}

		// Token: 0x0601DD14 RID: 122132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD14")]
		[Address(RVA = "0x1753270", Offset = "0x1751E70", VA = "0x181753270")]
		private void _SetCrossAppShareMedalOption(FriendNameCardMedalItem.MedalStatus medalStatus, UIMedalGroupView.GroupOptions groupOptions, UIMedalGroupView.DIYOptions diyOptions)
		{
		}

		// Token: 0x0601DD15 RID: 122133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD15")]
		[Address(RVA = "0x1753680", Offset = "0x1752280", VA = "0x181753680")]
		public FriendNameCardMedalItem()
		{
		}

		// Token: 0x040277B8 RID: 161720
		[Token(Token = "0x40277B8")]
		private const string GRAPHIC_GROUP_ID = "medal_group_hotspot";

		// Token: 0x040277B9 RID: 161721
		[Token(Token = "0x40277B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040277BA RID: 161722
		[Token(Token = "0x40277BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _diyContainer;

		// Token: 0x040277BB RID: 161723
		[Token(Token = "0x40277BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x040277BC RID: 161724
		[Token(Token = "0x40277BC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x040277BD RID: 161725
		[Token(Token = "0x40277BD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _toggleState;

		// Token: 0x040277BE RID: 161726
		[Token(Token = "0x40277BE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _ableToChoose;

		// Token: 0x040277BF RID: 161727
		[Token(Token = "0x40277BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _emptyIcon;

		// Token: 0x040277C0 RID: 161728
		[Token(Token = "0x40277C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _btnGraphic;

		// Token: 0x040277C1 RID: 161729
		[Token(Token = "0x40277C1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartDynAssetContent _crossAppShareNormalMedalContent;

		// Token: 0x040277C2 RID: 161730
		[Token(Token = "0x40277C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartDynAssetContent _crossAppShareDiyMedalContent;

		// Token: 0x040277C3 RID: 161731
		[Token(Token = "0x40277C3")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public UINameCardEvent onClickEvent;

		// Token: 0x040277C4 RID: 161732
		[Token(Token = "0x40277C4")]
		[FieldOffset(Offset = "0x70")]
		private NameCardMedalType m_type;

		// Token: 0x040277C5 RID: 161733
		[Token(Token = "0x40277C5")]
		[FieldOffset(Offset = "0x78")]
		private MedalGroupViewModel m_groupViewModel;

		// Token: 0x040277C6 RID: 161734
		[Token(Token = "0x40277C6")]
		[FieldOffset(Offset = "0x80")]
		private UIMedalGroupView m_medalGroup;

		// Token: 0x040277C7 RID: 161735
		[Token(Token = "0x40277C7")]
		[FieldOffset(Offset = "0x88")]
		private UIMedalGroupView m_diyMedalGroup;

		// Token: 0x040277C8 RID: 161736
		[Token(Token = "0x40277C8")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040277C9 RID: 161737
		[Token(Token = "0x40277C9")]
		[FieldOffset(Offset = "0xA0")]
		private PlayerMedalCustomLayout m_viewModelTempCache;

		// Token: 0x040277CA RID: 161738
		[Token(Token = "0x40277CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040277CB RID: 161739
		[Token(Token = "0x40277CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderSelfDIY;

		// Token: 0x040277CC RID: 161740
		[Token(Token = "0x40277CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckMedalAvail;

		// Token: 0x040277CD RID: 161741
		[Token(Token = "0x40277CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderOtherDIY;

		// Token: 0x040277CE RID: 161742
		[Token(Token = "0x40277CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderNo;

		// Token: 0x040277CF RID: 161743
		[Token(Token = "0x40277CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x040277D0 RID: 161744
		[Token(Token = "0x40277D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetBoolFlag;

		// Token: 0x040277D1 RID: 161745
		[Token(Token = "0x40277D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateBtnGraphic;

		// Token: 0x040277D2 RID: 161746
		[Token(Token = "0x40277D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040277D3 RID: 161747
		[Token(Token = "0x40277D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetCrossAppShareMedalOption;

		// Token: 0x040277D4 RID: 161748
		[Token(Token = "0x40277D4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DEA RID: 19946
		[Token(Token = "0x2004DEA")]
		public struct Options
		{
			// Token: 0x040277D5 RID: 161749
			[Token(Token = "0x40277D5")]
			[FieldOffset(Offset = "0x0")]
			public bool isSelect;

			// Token: 0x040277D6 RID: 161750
			[Token(Token = "0x40277D6")]
			[FieldOffset(Offset = "0x1")]
			public bool currentSelect;

			// Token: 0x040277D7 RID: 161751
			[Token(Token = "0x40277D7")]
			[FieldOffset(Offset = "0x8")]
			public UIPage page;

			// Token: 0x040277D8 RID: 161752
			[Token(Token = "0x40277D8")]
			[FieldOffset(Offset = "0x10")]
			public bool usePool;
		}

		// Token: 0x02004DEB RID: 19947
		[Token(Token = "0x2004DEB")]
		private enum MedalStatus
		{
			// Token: 0x040277DA RID: 161754
			[Token(Token = "0x40277DA")]
			NORMAL,
			// Token: 0x040277DB RID: 161755
			[Token(Token = "0x40277DB")]
			DIY,
			// Token: 0x040277DC RID: 161756
			[Token(Token = "0x40277DC")]
			NO_INFO
		}
	}
}
