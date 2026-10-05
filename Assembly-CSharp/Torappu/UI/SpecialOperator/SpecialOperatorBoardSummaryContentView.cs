using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E64 RID: 15972
	[Token(Token = "0x2003E64")]
	public class SpecialOperatorBoardSummaryContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D70 RID: 101744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D70")]
		[Address(RVA = "0x1175B90", Offset = "0x1174790", VA = "0x181175B90")]
		public void Render(SpecialOperatorBoardSummaryModel model, SpecialOperatorBoardSummaryContentView.Param param)
		{
		}

		// Token: 0x06018D71 RID: 101745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D71")]
		[Address(RVA = "0x1175FE0", Offset = "0x1174BE0", VA = "0x181175FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018D72 RID: 101746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D72")]
		[Address(RVA = "0x1176470", Offset = "0x1175070", VA = "0x181176470")]
		public SpecialOperatorBoardSummaryContentView()
		{
		}

		// Token: 0x0401E8BA RID: 125114
		[Token(Token = "0x401E8BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401E8BB RID: 125115
		[Token(Token = "0x401E8BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401E8BC RID: 125116
		[Token(Token = "0x401E8BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _attrDetailContainer;

		// Token: 0x0401E8BD RID: 125117
		[Token(Token = "0x401E8BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imagePotential;

		// Token: 0x0401E8BE RID: 125118
		[Token(Token = "0x401E8BE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageEvolve;

		// Token: 0x0401E8BF RID: 125119
		[Token(Token = "0x401E8BF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSubProf;

		// Token: 0x0401E8C0 RID: 125120
		[Token(Token = "0x401E8C0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgSubProf;

		// Token: 0x0401E8C1 RID: 125121
		[Token(Token = "0x401E8C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCurrLv;

		// Token: 0x0401E8C2 RID: 125122
		[Token(Token = "0x401E8C2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textMaxLv;

		// Token: 0x0401E8C3 RID: 125123
		[Token(Token = "0x401E8C3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCurrExp;

		// Token: 0x0401E8C4 RID: 125124
		[Token(Token = "0x401E8C4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textMaxExp;

		// Token: 0x0401E8C5 RID: 125125
		[Token(Token = "0x401E8C5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgExpProgress;

		// Token: 0x0401E8C6 RID: 125126
		[Token(Token = "0x401E8C6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _equipList;

		// Token: 0x0401E8C7 RID: 125127
		[Token(Token = "0x401E8C7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _skillList;

		// Token: 0x0401E8C8 RID: 125128
		[Token(Token = "0x401E8C8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _talentList;

		// Token: 0x0401E8C9 RID: 125129
		[Token(Token = "0x401E8C9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _masterList;

		// Token: 0x0401E8CA RID: 125130
		[Token(Token = "0x401E8CA")]
		[FieldOffset(Offset = "0x98")]
		private UICharacterAttrDetailView m_attrDetailView;

		// Token: 0x0401E8CB RID: 125131
		[Token(Token = "0x401E8CB")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0401E8CC RID: 125132
		[Token(Token = "0x401E8CC")]
		[FieldOffset(Offset = "0xA8")]
		private SpecialOperatorBoardSummaryModel m_model;

		// Token: 0x0401E8CD RID: 125133
		[Token(Token = "0x401E8CD")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E8CE RID: 125134
		[Token(Token = "0x401E8CE")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E8CF RID: 125135
		[Token(Token = "0x401E8CF")]
		[FieldOffset(Offset = "0xD0")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0401E8D0 RID: 125136
		[Token(Token = "0x401E8D0")]
		[FieldOffset(Offset = "0xD8")]
		private SpecialOperatorBoardSummaryContentView.EquipListAdapter m_equipListAdapter;

		// Token: 0x0401E8D1 RID: 125137
		[Token(Token = "0x401E8D1")]
		[FieldOffset(Offset = "0xE0")]
		private SpecialOperatorBoardSummaryContentView.SkillListAdapter m_skillListAdapter;

		// Token: 0x0401E8D2 RID: 125138
		[Token(Token = "0x401E8D2")]
		[FieldOffset(Offset = "0xE8")]
		private SpecialOperatorBoardSummaryContentView.UnlockableListAdapter m_talentListAdapter;

		// Token: 0x0401E8D3 RID: 125139
		[Token(Token = "0x401E8D3")]
		[FieldOffset(Offset = "0xF0")]
		private SpecialOperatorBoardSummaryContentView.UnlockableListAdapter m_masterListAdapter;

		// Token: 0x0401E8D4 RID: 125140
		[Token(Token = "0x401E8D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E8D5 RID: 125141
		[Token(Token = "0x401E8D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E8D6 RID: 125142
		[Token(Token = "0x401E8D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E65 RID: 15973
		[Token(Token = "0x2003E65")]
		public struct Param
		{
			// Token: 0x0401E8D7 RID: 125143
			[Token(Token = "0x401E8D7")]
			[FieldOffset(Offset = "0x0")]
			public bool isFirstRender;

			// Token: 0x0401E8D8 RID: 125144
			[Token(Token = "0x401E8D8")]
			[FieldOffset(Offset = "0x1")]
			public bool isSelected;
		}

		// Token: 0x02003E66 RID: 15974
		[Token(Token = "0x2003E66")]
		private class UnlockableListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018D73 RID: 101747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D73")]
			[Address(RVA = "0x1180F70", Offset = "0x117FB70", VA = "0x181180F70")]
			public void SetData(int totalCnt, int unlockCnt)
			{
			}

			// Token: 0x17003B4A RID: 15178
			// (get) Token: 0x06018D74 RID: 101748 RVA: 0x0009C270 File Offset: 0x0009A470
			[Token(Token = "0x17003B4A")]
			public override int count
			{
				[Token(Token = "0x6018D74")]
				[Address(RVA = "0x1181060", Offset = "0x117FC60", VA = "0x181181060", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018D75 RID: 101749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018D75")]
			[Address(RVA = "0x1180D90", Offset = "0x117F990", VA = "0x181180D90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018D76 RID: 101750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D76")]
			[Address(RVA = "0x1181000", Offset = "0x117FC00", VA = "0x181181000")]
			public UnlockableListAdapter()
			{
			}

			// Token: 0x0401E8D9 RID: 125145
			[Token(Token = "0x401E8D9")]
			[FieldOffset(Offset = "0x20")]
			private int m_totalCnt;

			// Token: 0x0401E8DA RID: 125146
			[Token(Token = "0x401E8DA")]
			[FieldOffset(Offset = "0x24")]
			private int m_unlockCnt;

			// Token: 0x0401E8DB RID: 125147
			[Token(Token = "0x401E8DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0401E8DC RID: 125148
			[Token(Token = "0x401E8DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E8DD RID: 125149
			[Token(Token = "0x401E8DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401E8DE RID: 125150
			[Token(Token = "0x401E8DE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003E67 RID: 15975
		[Token(Token = "0x2003E67")]
		private class SkillListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018D77 RID: 101751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D77")]
			[Address(RVA = "0x116AC70", Offset = "0x1169870", VA = "0x18116AC70")]
			public SkillListAdapter(SpecialOperatorBoardSummaryContentView closure)
			{
			}

			// Token: 0x17003B4B RID: 15179
			// (get) Token: 0x06018D78 RID: 101752 RVA: 0x0009C288 File Offset: 0x0009A488
			[Token(Token = "0x17003B4B")]
			public override int count
			{
				[Token(Token = "0x6018D78")]
				[Address(RVA = "0x116ACF0", Offset = "0x11698F0", VA = "0x18116ACF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018D79 RID: 101753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018D79")]
			[Address(RVA = "0x116AA60", Offset = "0x1169660", VA = "0x18116AA60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E8DF RID: 125151
			[Token(Token = "0x401E8DF")]
			private const int SKILL_MIN_SHOW_CNT = 3;

			// Token: 0x0401E8E0 RID: 125152
			[Token(Token = "0x401E8E0")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorBoardSummaryContentView m_closure;

			// Token: 0x0401E8E1 RID: 125153
			[Token(Token = "0x401E8E1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E8E2 RID: 125154
			[Token(Token = "0x401E8E2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E8E3 RID: 125155
			[Token(Token = "0x401E8E3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02003E68 RID: 15976
		[Token(Token = "0x2003E68")]
		private class EquipListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018D7A RID: 101754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D7A")]
			[Address(RVA = "0x116A7A0", Offset = "0x11693A0", VA = "0x18116A7A0")]
			public EquipListAdapter(SpecialOperatorBoardSummaryContentView closure)
			{
			}

			// Token: 0x17003B4C RID: 15180
			// (get) Token: 0x06018D7B RID: 101755 RVA: 0x0009C2A0 File Offset: 0x0009A4A0
			[Token(Token = "0x17003B4C")]
			public override int count
			{
				[Token(Token = "0x6018D7B")]
				[Address(RVA = "0x116A820", Offset = "0x1169420", VA = "0x18116A820", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018D7C RID: 101756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018D7C")]
			[Address(RVA = "0x116A520", Offset = "0x1169120", VA = "0x18116A520", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E8E4 RID: 125156
			[Token(Token = "0x401E8E4")]
			private const int EQUIP_MIN_SHOW_CNT = 3;

			// Token: 0x0401E8E5 RID: 125157
			[Token(Token = "0x401E8E5")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorBoardSummaryContentView m_closure;

			// Token: 0x0401E8E6 RID: 125158
			[Token(Token = "0x401E8E6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E8E7 RID: 125159
			[Token(Token = "0x401E8E7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E8E8 RID: 125160
			[Token(Token = "0x401E8E8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
