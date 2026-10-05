using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EB1 RID: 20145
	[Token(Token = "0x2004EB1")]
	public class FifthAnnivExploreOptionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E0E4 RID: 123108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0E4")]
		[Address(RVA = "0x17BF920", Offset = "0x17BE520", VA = "0x1817BF920")]
		public void Render(FifthAnnivExploreDecisionModel decisionModel, FifthAnnivExploreOptionModel optionModel, bool isSelect)
		{
		}

		// Token: 0x0601E0E5 RID: 123109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0E5")]
		[Address(RVA = "0x17C03B0", Offset = "0x17BEFB0", VA = "0x1817C03B0")]
		private void _RenderImpl()
		{
		}

		// Token: 0x0601E0E6 RID: 123110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0E6")]
		[Address(RVA = "0x17BFE10", Offset = "0x17BEA10", VA = "0x1817BFE10")]
		private void _PlaySwitchAnimIfNeed(FifthAnnivExploreDecisionModel decisionModel, bool isSelect)
		{
		}

		// Token: 0x0601E0E7 RID: 123111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0E7")]
		[Address(RVA = "0x17C0020", Offset = "0x17BEC20", VA = "0x1817C0020")]
		private void _RenderEventPart()
		{
		}

		// Token: 0x0601E0E8 RID: 123112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E0E8")]
		[Address(RVA = "0x17BFAC0", Offset = "0x17BE6C0", VA = "0x1817BFAC0")]
		private string _GetPercentageStr(float winRate)
		{
			return null;
		}

		// Token: 0x0601E0E9 RID: 123113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0E9")]
		[Address(RVA = "0x17C05A0", Offset = "0x17BF1A0", VA = "0x1817C05A0")]
		private void _RenderTargetPart()
		{
		}

		// Token: 0x0601E0EA RID: 123114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0EA")]
		[Address(RVA = "0x17BFB70", Offset = "0x17BE770", VA = "0x1817BFB70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E0EB RID: 123115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0EB")]
		[Address(RVA = "0x17BF7D0", Offset = "0x17BE3D0", VA = "0x1817BF7D0")]
		public void EventOnOptionClick()
		{
		}

		// Token: 0x0601E0EC RID: 123116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0EC")]
		[Address(RVA = "0x17BF680", Offset = "0x17BE280", VA = "0x1817BF680")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x0601E0ED RID: 123117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0ED")]
		[Address(RVA = "0x17C0820", Offset = "0x17BF420", VA = "0x1817C0820")]
		public FifthAnnivExploreOptionItemView()
		{
		}

		// Token: 0x04027FAF RID: 163759
		[Token(Token = "0x4027FAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04027FB0 RID: 163760
		[Token(Token = "0x4027FB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04027FB1 RID: 163761
		[Token(Token = "0x4027FB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgConfirmBg;

		// Token: 0x04027FB2 RID: 163762
		[Token(Token = "0x4027FB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorRed;

		// Token: 0x04027FB3 RID: 163763
		[Token(Token = "0x4027FB3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorYellow;

		// Token: 0x04027FB4 RID: 163764
		[Token(Token = "0x4027FB4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorGreen;

		// Token: 0x04027FB5 RID: 163765
		[Token(Token = "0x4027FB5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnSelectGo;

		// Token: 0x04027FB6 RID: 163766
		[Token(Token = "0x4027FB6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Event Part")]
		private GameObject _eventPartGo;

		// Token: 0x04027FB7 RID: 163767
		[Token(Token = "0x4027FB7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Event Part")]
		private Text _textWinRateShrink;

		// Token: 0x04027FB8 RID: 163768
		[Token(Token = "0x4027FB8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Event Part")]
		private Text _textWinRateExpand;

		// Token: 0x04027FB9 RID: 163769
		[Token(Token = "0x4027FB9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Event Part")]
		private GameObject _attrDeltaListGo;

		// Token: 0x04027FBA RID: 163770
		[Token(Token = "0x4027FBA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Event Part")]
		private SimpleLayoutContent _attrDeltaList;

		// Token: 0x04027FBB RID: 163771
		[Token(Token = "0x4027FBB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Event Part")]
		private SimpleLayoutContent _attrCondList;

		// Token: 0x04027FBC RID: 163772
		[Token(Token = "0x4027FBC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Target Part")]
		private GameObject _targetPartGo;

		// Token: 0x04027FBD RID: 163773
		[Token(Token = "0x4027FBD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Target Part")]
		private Text _textSelect;

		// Token: 0x04027FBE RID: 163774
		[Token(Token = "0x4027FBE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Target Part")]
		private GameObject _disableMaskGo;

		// Token: 0x04027FBF RID: 163775
		[Token(Token = "0x4027FBF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Target Part")]
		private UIAtlasImage _imgDecoCircle;

		// Token: 0x04027FC0 RID: 163776
		[Token(Token = "0x4027FC0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Target Part")]
		private float _alphaDisable;

		// Token: 0x04027FC1 RID: 163777
		[Token(Token = "0x4027FC1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animExpand;

		// Token: 0x04027FC2 RID: 163778
		[Token(Token = "0x4027FC2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _lowWinRateThres;

		// Token: 0x04027FC3 RID: 163779
		[Token(Token = "0x4027FC3")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _highWinRateThres;

		// Token: 0x04027FC4 RID: 163780
		[Token(Token = "0x4027FC4")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_animSwitchTween;

		// Token: 0x04027FC5 RID: 163781
		[Token(Token = "0x4027FC5")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasInited;

		// Token: 0x04027FC6 RID: 163782
		[Token(Token = "0x4027FC6")]
		[FieldOffset(Offset = "0xE8")]
		private FifthAnnivExploreOptionItemView.AttrDeltaListAdapter m_attrDeltaListAdapter;

		// Token: 0x04027FC7 RID: 163783
		[Token(Token = "0x4027FC7")]
		[FieldOffset(Offset = "0xF0")]
		private FifthAnnivExploreOptionItemView.AttrCondListAdapter m_attrCondListAdapter;

		// Token: 0x04027FC8 RID: 163784
		[Token(Token = "0x4027FC8")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027FC9 RID: 163785
		[Token(Token = "0x4027FC9")]
		[FieldOffset(Offset = "0x108")]
		private FifthAnnivExploreOptionModel m_optionModel;

		// Token: 0x04027FCA RID: 163786
		[Token(Token = "0x4027FCA")]
		[FieldOffset(Offset = "0x110")]
		private PlayerMainlineExplore.DecisionNodeType m_decisionType;

		// Token: 0x04027FCB RID: 163787
		[Token(Token = "0x4027FCB")]
		[FieldOffset(Offset = "0x114")]
		private int m_cacheEnterSeqNum;

		// Token: 0x04027FCC RID: 163788
		[Token(Token = "0x4027FCC")]
		[FieldOffset(Offset = "0x118")]
		private int m_cacheSwitchPlanSeqNum;

		// Token: 0x04027FCD RID: 163789
		[Token(Token = "0x4027FCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027FCE RID: 163790
		[Token(Token = "0x4027FCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderImpl;

		// Token: 0x04027FCF RID: 163791
		[Token(Token = "0x4027FCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnimIfNeed;

		// Token: 0x04027FD0 RID: 163792
		[Token(Token = "0x4027FD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEventPart;

		// Token: 0x04027FD1 RID: 163793
		[Token(Token = "0x4027FD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetPercentageStr;

		// Token: 0x04027FD2 RID: 163794
		[Token(Token = "0x4027FD2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderTargetPart;

		// Token: 0x04027FD3 RID: 163795
		[Token(Token = "0x4027FD3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027FD4 RID: 163796
		[Token(Token = "0x4027FD4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnOptionClick;

		// Token: 0x04027FD5 RID: 163797
		[Token(Token = "0x4027FD5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x04027FD6 RID: 163798
		[Token(Token = "0x4027FD6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EB2 RID: 20146
		[Token(Token = "0x2004EB2")]
		private class AttrDeltaListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E0EE RID: 123118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E0EE")]
			[Address(RVA = "0x17B2240", Offset = "0x17B0E40", VA = "0x1817B2240")]
			public AttrDeltaListAdapter(FifthAnnivExploreOptionItemView closure)
			{
			}

			// Token: 0x17004688 RID: 18056
			// (get) Token: 0x0601E0EF RID: 123119 RVA: 0x000AD4D8 File Offset: 0x000AB6D8
			[Token(Token = "0x17004688")]
			public override int count
			{
				[Token(Token = "0x601E0EF")]
				[Address(RVA = "0x17B22C0", Offset = "0x17B0EC0", VA = "0x1817B22C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E0F0 RID: 123120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E0F0")]
			[Address(RVA = "0x17B2020", Offset = "0x17B0C20", VA = "0x1817B2020", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027FD7 RID: 163799
			[Token(Token = "0x4027FD7")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreOptionItemView m_closure;

			// Token: 0x04027FD8 RID: 163800
			[Token(Token = "0x4027FD8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027FD9 RID: 163801
			[Token(Token = "0x4027FD9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027FDA RID: 163802
			[Token(Token = "0x4027FDA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004EB3 RID: 20147
		[Token(Token = "0x2004EB3")]
		private class AttrCondListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E0F1 RID: 123121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E0F1")]
			[Address(RVA = "0x17B1E70", Offset = "0x17B0A70", VA = "0x1817B1E70")]
			public AttrCondListAdapter(FifthAnnivExploreOptionItemView closure)
			{
			}

			// Token: 0x17004689 RID: 18057
			// (get) Token: 0x0601E0F2 RID: 123122 RVA: 0x000AD4F0 File Offset: 0x000AB6F0
			[Token(Token = "0x17004689")]
			public override int count
			{
				[Token(Token = "0x601E0F2")]
				[Address(RVA = "0x17B1EF0", Offset = "0x17B0AF0", VA = "0x1817B1EF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E0F3 RID: 123123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E0F3")]
			[Address(RVA = "0x17B1A20", Offset = "0x17B0620", VA = "0x1817B1A20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027FDB RID: 163803
			[Token(Token = "0x4027FDB")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreOptionItemView m_closure;

			// Token: 0x04027FDC RID: 163804
			[Token(Token = "0x4027FDC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027FDD RID: 163805
			[Token(Token = "0x4027FDD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027FDE RID: 163806
			[Token(Token = "0x4027FDE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
