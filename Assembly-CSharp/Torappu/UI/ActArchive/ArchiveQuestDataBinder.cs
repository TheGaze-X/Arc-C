using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BEF RID: 27631
	[Token(Token = "0x2006BEF")]
	public class ArchiveQuestDataBinder : DataBinder<ArchiveQuestProperty>
	{
		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x06027748 RID: 161608 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027749 RID: 161609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D21")]
		public ArchiveQuestController controller
		{
			[Token(Token = "0x6027748")]
			[Address(RVA = "0x22A03D0", Offset = "0x229EFD0", VA = "0x1822A03D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6027749")]
			[Address(RVA = "0x22A0430", Offset = "0x229F030", VA = "0x1822A0430")]
			set
			{
			}
		}

		// Token: 0x0602774A RID: 161610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602774A")]
		[Address(RVA = "0x229E390", Offset = "0x229CF90", VA = "0x18229E390", Slot = "7")]
		public override void OnValueChanged(ArchiveQuestProperty property)
		{
		}

		// Token: 0x0602774B RID: 161611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602774B")]
		[Address(RVA = "0x229F090", Offset = "0x229DC90", VA = "0x18229F090")]
		private void _Refresh(int focusIndex, bool isFastMode)
		{
		}

		// Token: 0x0602774C RID: 161612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602774C")]
		[Address(RVA = "0x22A0030", Offset = "0x229EC30", VA = "0x1822A0030")]
		private void _TryPlayAnimSelectionToDetail(int focusIndex, bool isFastMode)
		{
		}

		// Token: 0x0602774D RID: 161613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602774D")]
		[Address(RVA = "0x229FE30", Offset = "0x229EA30", VA = "0x18229FE30")]
		private void _TryPlayAnimDetailToSelection()
		{
		}

		// Token: 0x0602774E RID: 161614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602774E")]
		[Address(RVA = "0x229FA40", Offset = "0x229E640", VA = "0x18229FA40")]
		private void _ResetDetail()
		{
		}

		// Token: 0x0602774F RID: 161615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602774F")]
		[Address(RVA = "0x229EF10", Offset = "0x229DB10", VA = "0x18229EF10")]
		private void _RefreshIndex(int focusIndex)
		{
		}

		// Token: 0x06027750 RID: 161616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027750")]
		[Address(RVA = "0x229EE50", Offset = "0x229DA50", VA = "0x18229EE50")]
		private void _RefreshArrow()
		{
		}

		// Token: 0x06027751 RID: 161617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027751")]
		[Address(RVA = "0x229E870", Offset = "0x229D470", VA = "0x18229E870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027752 RID: 161618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027752")]
		[Address(RVA = "0x229F7E0", Offset = "0x229E3E0", VA = "0x18229F7E0")]
		private void _RenderFocusItem()
		{
		}

		// Token: 0x06027753 RID: 161619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027753")]
		[Address(RVA = "0x229F350", Offset = "0x229DF50", VA = "0x18229F350")]
		private void _RenderAVG(ArchiveQuestAVGItemModel model, string archiveId)
		{
		}

		// Token: 0x06027754 RID: 161620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027754")]
		[Address(RVA = "0x229F610", Offset = "0x229E210", VA = "0x18229F610")]
		private void _RenderCG(ArchiveQuestCGItemModel model)
		{
		}

		// Token: 0x06027755 RID: 161621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027755")]
		[Address(RVA = "0x229FCA0", Offset = "0x229E8A0", VA = "0x18229FCA0")]
		private Sprite _TryLoadSpriteFromAutoPackHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06027756 RID: 161622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027756")]
		[Address(RVA = "0x229EC80", Offset = "0x229D880", VA = "0x18229EC80")]
		private void _OpenAvgSelectDialog(ArchiveQuestAVGItemModel itemModel)
		{
		}

		// Token: 0x06027757 RID: 161623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027757")]
		[Address(RVA = "0x229E7E0", Offset = "0x229D3E0", VA = "0x18229E7E0")]
		private ArchiveQuestItemModel _GetSelectedItemModel()
		{
			return null;
		}

		// Token: 0x06027758 RID: 161624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027758")]
		[Address(RVA = "0x229EBC0", Offset = "0x229D7C0", VA = "0x18229EBC0")]
		private void _OnSelectedAvg(int index)
		{
		}

		// Token: 0x06027759 RID: 161625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027759")]
		[Address(RVA = "0x229FAE0", Offset = "0x229E6E0", VA = "0x18229FAE0")]
		private void _StartAvg(string storyId)
		{
		}

		// Token: 0x0602775A RID: 161626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602775A")]
		[Address(RVA = "0x229E730", Offset = "0x229D330", VA = "0x18229E730")]
		private string _GetCgPath(string picPath)
		{
			return null;
		}

		// Token: 0x0602775B RID: 161627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602775B")]
		[Address(RVA = "0x229E0B0", Offset = "0x229CCB0", VA = "0x18229E0B0")]
		public void EventOnClickLeftArrow()
		{
		}

		// Token: 0x0602775C RID: 161628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602775C")]
		[Address(RVA = "0x229E130", Offset = "0x229CD30", VA = "0x18229E130")]
		public void EventOnClickRightArrow()
		{
		}

		// Token: 0x0602775D RID: 161629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602775D")]
		[Address(RVA = "0x229DD70", Offset = "0x229C970", VA = "0x18229DD70")]
		public void EventOnClickAvg()
		{
		}

		// Token: 0x0602775E RID: 161630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602775E")]
		[Address(RVA = "0x229E290", Offset = "0x229CE90", VA = "0x18229E290")]
		public void EventOnSelectTypeMain()
		{
		}

		// Token: 0x0602775F RID: 161631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602775F")]
		[Address(RVA = "0x229E310", Offset = "0x229CF10", VA = "0x18229E310")]
		public void EventOnSelectTypeSide()
		{
		}

		// Token: 0x06027760 RID: 161632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027760")]
		[Address(RVA = "0x229E1B0", Offset = "0x229CDB0", VA = "0x18229E1B0")]
		public void EventOnSelectTypeLocked()
		{
		}

		// Token: 0x06027761 RID: 161633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027761")]
		[Address(RVA = "0x22A02B0", Offset = "0x229EEB0", VA = "0x1822A02B0")]
		public ArchiveQuestDataBinder()
		{
		}

		// Token: 0x04037E7E RID: 228990
		[Token(Token = "0x4037E7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("QuestTypeSelection")]
		private ArchiveQuestTypeBtnView[] _btnViews;

		// Token: 0x04037E7F RID: 228991
		[Token(Token = "0x4037E7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("QuestTypeSelection")]
		private CanvasGroup _canvasSelection;

		// Token: 0x04037E80 RID: 228992
		[Token(Token = "0x4037E80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Detail")]
		private CanvasGroup _canvasDetail;

		// Token: 0x04037E81 RID: 228993
		[Token(Token = "0x4037E81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Detail_avg")]
		private GameObject _panelAvg;

		// Token: 0x04037E82 RID: 228994
		[Token(Token = "0x4037E82")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Detail_avg")]
		private TwoStateToggle _toggleTitleView;

		// Token: 0x04037E83 RID: 228995
		[Token(Token = "0x4037E83")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Detail_avg")]
		private Text _questTypeName;

		// Token: 0x04037E84 RID: 228996
		[Token(Token = "0x4037E84")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Detail_avg")]
		private Text _questName;

		// Token: 0x04037E85 RID: 228997
		[Token(Token = "0x4037E85")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Detail_avg")]
		private Text _textAvgDesc;

		// Token: 0x04037E86 RID: 228998
		[Token(Token = "0x4037E86")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Detail_avg")]
		private Text _textRegionName;

		// Token: 0x04037E87 RID: 228999
		[Token(Token = "0x4037E87")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Detail_avg")]
		private Text _textRegionNameEn;

		// Token: 0x04037E88 RID: 229000
		[Token(Token = "0x4037E88")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Detail_avg")]
		private SimpleLayoutContent _npcPicContent;

		// Token: 0x04037E89 RID: 229001
		[Token(Token = "0x4037E89")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Detail_avg")]
		private UIDynImage _imgAvgLoader;

		// Token: 0x04037E8A RID: 229002
		[Token(Token = "0x4037E8A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Detail_avg")]
		private GameObject _objBtnAvg;

		// Token: 0x04037E8B RID: 229003
		[Token(Token = "0x4037E8B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Detail_avg")]
		private GameObject _objImgAvg;

		// Token: 0x04037E8C RID: 229004
		[Token(Token = "0x4037E8C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Detail_cg")]
		private GameObject _panelCg;

		// Token: 0x04037E8D RID: 229005
		[Token(Token = "0x4037E8D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Detail_cg")]
		private GameObject _objImgCg;

		// Token: 0x04037E8E RID: 229006
		[Token(Token = "0x4037E8E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Detail_cg")]
		private UIDynImage _imgCgLoader;

		// Token: 0x04037E8F RID: 229007
		[Token(Token = "0x4037E8F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Detail_cg")]
		private Text _cgTitle;

		// Token: 0x04037E90 RID: 229008
		[Token(Token = "0x4037E90")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Detail_cg")]
		private Text _cgDesc;

		// Token: 0x04037E91 RID: 229009
		[Token(Token = "0x4037E91")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Detail")]
		private CanvasGroup _arrowLeft;

		// Token: 0x04037E92 RID: 229010
		[Token(Token = "0x4037E92")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Detail")]
		private CanvasGroup _arrowRight;

		// Token: 0x04037E93 RID: 229011
		[Token(Token = "0x4037E93")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Detail")]
		private ArchiveQuestListView _listView;

		// Token: 0x04037E94 RID: 229012
		[Token(Token = "0x4037E94")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Detail")]
		private UIAnimationLocation _contentAnimationLocation;

		// Token: 0x04037E95 RID: 229013
		[Token(Token = "0x4037E95")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Detail")]
		private GameObject _objFakeFolder;

		// Token: 0x04037E96 RID: 229014
		[Token(Token = "0x4037E96")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Detail")]
		private UIAnimationLocation _animSelectionToDetail;

		// Token: 0x04037E97 RID: 229015
		[Token(Token = "0x4037E97")]
		[FieldOffset(Offset = "0xF8")]
		private string m_floatHubPath;

		// Token: 0x04037E98 RID: 229016
		[Token(Token = "0x4037E98")]
		[FieldOffset(Offset = "0x100")]
		private List<string> m_npcIconIdList;

		// Token: 0x04037E99 RID: 229017
		[Token(Token = "0x4037E99")]
		[FieldOffset(Offset = "0x108")]
		private Action<SandboxV2ArchiveQuestType> m_actionOnSelectQuestType;

		// Token: 0x04037E9A RID: 229018
		[Token(Token = "0x4037E9A")]
		[FieldOffset(Offset = "0x110")]
		private Action<int> m_actionOnSelectIndex;

		// Token: 0x04037E9B RID: 229019
		[Token(Token = "0x4037E9B")]
		[FieldOffset(Offset = "0x118")]
		private ArchiveQuestController m_controller;

		// Token: 0x04037E9C RID: 229020
		[Token(Token = "0x4037E9C")]
		[FieldOffset(Offset = "0x120")]
		private ArchiveQuestDataBinder.NpcPicAdapter m_adapter;

		// Token: 0x04037E9D RID: 229021
		[Token(Token = "0x4037E9D")]
		[FieldOffset(Offset = "0x128")]
		private ArchiveQuestContentAnimator m_contentAnimator;

		// Token: 0x04037E9E RID: 229022
		[Token(Token = "0x4037E9E")]
		[FieldOffset(Offset = "0x130")]
		private bool m_hasInited;

		// Token: 0x04037E9F RID: 229023
		[Token(Token = "0x4037E9F")]
		[FieldOffset(Offset = "0x138")]
		private string m_archiveId;

		// Token: 0x04037EA0 RID: 229024
		[Token(Token = "0x4037EA0")]
		[FieldOffset(Offset = "0x140")]
		private string m_cachedCgId;

		// Token: 0x04037EA1 RID: 229025
		[Token(Token = "0x4037EA1")]
		[FieldOffset(Offset = "0x148")]
		private List<ArchiveQuestItemModel> m_cachedItems;

		// Token: 0x04037EA2 RID: 229026
		[Token(Token = "0x4037EA2")]
		[FieldOffset(Offset = "0x150")]
		private SandboxV2ArchiveQuestType m_cachedType;

		// Token: 0x04037EA3 RID: 229027
		[Token(Token = "0x4037EA3")]
		[FieldOffset(Offset = "0x154")]
		private int m_cachedFocusIndex;

		// Token: 0x04037EA4 RID: 229028
		[Token(Token = "0x4037EA4")]
		[FieldOffset(Offset = "0x158")]
		private int m_previousIndex;

		// Token: 0x04037EA5 RID: 229029
		[Token(Token = "0x4037EA5")]
		[FieldOffset(Offset = "0x15C")]
		private int m_nextIndex;

		// Token: 0x04037EA6 RID: 229030
		[Token(Token = "0x4037EA6")]
		[FieldOffset(Offset = "0x160")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04037EA7 RID: 229031
		[Token(Token = "0x4037EA7")]
		[FieldOffset(Offset = "0x170")]
		private Sequence m_sequenceDetailToSelection;

		// Token: 0x04037EA8 RID: 229032
		[Token(Token = "0x4037EA8")]
		[FieldOffset(Offset = "0x178")]
		private Sequence m_sequenceSelectiongToDetail;

		// Token: 0x04037EA9 RID: 229033
		[Token(Token = "0x4037EA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037EAA RID: 229034
		[Token(Token = "0x4037EAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037EAB RID: 229035
		[Token(Token = "0x4037EAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037EAC RID: 229036
		[Token(Token = "0x4037EAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04037EAD RID: 229037
		[Token(Token = "0x4037EAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryPlayAnimSelectionToDetail;

		// Token: 0x04037EAE RID: 229038
		[Token(Token = "0x4037EAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryPlayAnimDetailToSelection;

		// Token: 0x04037EAF RID: 229039
		[Token(Token = "0x4037EAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetDetail;

		// Token: 0x04037EB0 RID: 229040
		[Token(Token = "0x4037EB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshIndex;

		// Token: 0x04037EB1 RID: 229041
		[Token(Token = "0x4037EB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshArrow;

		// Token: 0x04037EB2 RID: 229042
		[Token(Token = "0x4037EB2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037EB3 RID: 229043
		[Token(Token = "0x4037EB3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderFocusItem;

		// Token: 0x04037EB4 RID: 229044
		[Token(Token = "0x4037EB4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderAVG;

		// Token: 0x04037EB5 RID: 229045
		[Token(Token = "0x4037EB5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderCG;

		// Token: 0x04037EB6 RID: 229046
		[Token(Token = "0x4037EB6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryLoadSpriteFromAutoPackHub;

		// Token: 0x04037EB7 RID: 229047
		[Token(Token = "0x4037EB7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenAvgSelectDialog;

		// Token: 0x04037EB8 RID: 229048
		[Token(Token = "0x4037EB8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetSelectedItemModel;

		// Token: 0x04037EB9 RID: 229049
		[Token(Token = "0x4037EB9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnSelectedAvg;

		// Token: 0x04037EBA RID: 229050
		[Token(Token = "0x4037EBA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartAvg;

		// Token: 0x04037EBB RID: 229051
		[Token(Token = "0x4037EBB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetCgPath;

		// Token: 0x04037EBC RID: 229052
		[Token(Token = "0x4037EBC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnClickLeftArrow;

		// Token: 0x04037EBD RID: 229053
		[Token(Token = "0x4037EBD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnClickRightArrow;

		// Token: 0x04037EBE RID: 229054
		[Token(Token = "0x4037EBE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnClickAvg;

		// Token: 0x04037EBF RID: 229055
		[Token(Token = "0x4037EBF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnSelectTypeMain;

		// Token: 0x04037EC0 RID: 229056
		[Token(Token = "0x4037EC0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnSelectTypeSide;

		// Token: 0x04037EC1 RID: 229057
		[Token(Token = "0x4037EC1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnSelectTypeLocked;

		// Token: 0x04037EC2 RID: 229058
		[Token(Token = "0x4037EC2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BF0 RID: 27632
		[Token(Token = "0x2006BF0")]
		private class NpcPicAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06027764 RID: 161636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027764")]
			[Address(RVA = "0x22B97D0", Offset = "0x22B83D0", VA = "0x1822B97D0")]
			public NpcPicAdapter(ArchiveQuestDataBinder closure)
			{
			}

			// Token: 0x17005D22 RID: 23842
			// (get) Token: 0x06027765 RID: 161637 RVA: 0x000CE6E8 File Offset: 0x000CC8E8
			[Token(Token = "0x17005D22")]
			public override int count
			{
				[Token(Token = "0x6027765")]
				[Address(RVA = "0x22B9850", Offset = "0x22B8450", VA = "0x1822B9850", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027766 RID: 161638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027766")]
			[Address(RVA = "0x22B9600", Offset = "0x22B8200", VA = "0x1822B9600", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037EC3 RID: 229059
			[Token(Token = "0x4037EC3")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveQuestDataBinder m_closure;

			// Token: 0x04037EC4 RID: 229060
			[Token(Token = "0x4037EC4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037EC5 RID: 229061
			[Token(Token = "0x4037EC5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037EC6 RID: 229062
			[Token(Token = "0x4037EC6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
