using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200434D RID: 17229
	[Token(Token = "0x200434D")]
	public class SandboxV2RacerInventoryDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A742 RID: 108354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A742")]
		[Address(RVA = "0x138DD80", Offset = "0x138C980", VA = "0x18138DD80")]
		public void Render(SandboxV2RacerModel model, string emptyDesc, bool showTalentRefreshBtn, int learnedSequenceNum = -1)
		{
		}

		// Token: 0x0601A743 RID: 108355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A743")]
		[Address(RVA = "0x138DC60", Offset = "0x138C860", VA = "0x18138DC60")]
		public void EventOnMarkBtnClicked()
		{
		}

		// Token: 0x0601A744 RID: 108356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A744")]
		[Address(RVA = "0x138DCF0", Offset = "0x138C8F0", VA = "0x18138DCF0")]
		public void EventOnMedalGroupBtnClicked()
		{
		}

		// Token: 0x0601A745 RID: 108357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A745")]
		[Address(RVA = "0x138E580", Offset = "0x138D180", VA = "0x18138E580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A746 RID: 108358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A746")]
		[Address(RVA = "0x138E8A0", Offset = "0x138D4A0", VA = "0x18138E8A0")]
		public SandboxV2RacerInventoryDetailView()
		{
		}

		// Token: 0x04021A32 RID: 137778
		[Token(Token = "0x4021A32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04021A33 RID: 137779
		[Token(Token = "0x4021A33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x04021A34 RID: 137780
		[Token(Token = "0x4021A34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textEmpty;

		// Token: 0x04021A35 RID: 137781
		[Token(Token = "0x4021A35")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Basic Info")]
		private Image _imgIcon;

		// Token: 0x04021A36 RID: 137782
		[Token(Token = "0x4021A36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Basic Info")]
		private GameObject _panelMark;

		// Token: 0x04021A37 RID: 137783
		[Token(Token = "0x4021A37")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Basic Info")]
		private GameObject _imgNoInfo;

		// Token: 0x04021A38 RID: 137784
		[Token(Token = "0x4021A38")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Basic Info")]
		private GameObject _panelNotMarked;

		// Token: 0x04021A39 RID: 137785
		[Token(Token = "0x4021A39")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Basic Info")]
		private GameObject _panelMarked;

		// Token: 0x04021A3A RID: 137786
		[Token(Token = "0x4021A3A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Basic Info")]
		private Text _textName;

		// Token: 0x04021A3B RID: 137787
		[Token(Token = "0x4021A3B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Basic Info")]
		private Text _textTypeName;

		// Token: 0x04021A3C RID: 137788
		[Token(Token = "0x4021A3C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Basic Info")]
		private GameObject _panelMedal;

		// Token: 0x04021A3D RID: 137789
		[Token(Token = "0x4021A3D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Basic Info")]
		private SimpleLayoutContent _contentMedal;

		// Token: 0x04021A3E RID: 137790
		[Token(Token = "0x4021A3E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Attribute Info")]
		private SimpleLayoutContent _contentAttribute;

		// Token: 0x04021A3F RID: 137791
		[Token(Token = "0x4021A3F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Attribute Info")]
		private SimpleLayoutContent _contentLevel;

		// Token: 0x04021A40 RID: 137792
		[Token(Token = "0x4021A40")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Attribute Info")]
		private UIRadarMap _radarMap;

		// Token: 0x04021A41 RID: 137793
		[Token(Token = "0x4021A41")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Attribute Info")]
		private Text[] _textRadarMapName;

		// Token: 0x04021A42 RID: 137794
		[Token(Token = "0x4021A42")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Attribute Info")]
		private SandboxV2RacerInventoryTalentView _talentPrefab;

		// Token: 0x04021A43 RID: 137795
		[Token(Token = "0x4021A43")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Attribute Info")]
		private RectTransform _bornTalentContainer;

		// Token: 0x04021A44 RID: 137796
		[Token(Token = "0x4021A44")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Attribute Info")]
		private RectTransform _learnedTalentContainer;

		// Token: 0x04021A45 RID: 137797
		[Token(Token = "0x4021A45")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x04021A46 RID: 137798
		[Token(Token = "0x4021A46")]
		[FieldOffset(Offset = "0xB8")]
		private List<SandboxV2RacerMedalModel> m_cachedMedalList;

		// Token: 0x04021A47 RID: 137799
		[Token(Token = "0x4021A47")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021A48 RID: 137800
		[Token(Token = "0x4021A48")]
		[FieldOffset(Offset = "0xD0")]
		private SandboxV2RacerInventoryDetailView.MedalAdapter m_medalAdapter;

		// Token: 0x04021A49 RID: 137801
		[Token(Token = "0x4021A49")]
		[FieldOffset(Offset = "0xD8")]
		private List<SandboxV2RacerAttributeModel> m_cachedAttributeList;

		// Token: 0x04021A4A RID: 137802
		[Token(Token = "0x4021A4A")]
		[FieldOffset(Offset = "0xE0")]
		private SandboxV2RacerInventoryDetailView.AttributeAdapter m_attributeAdapter;

		// Token: 0x04021A4B RID: 137803
		[Token(Token = "0x4021A4B")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cachedRacerLevel;

		// Token: 0x04021A4C RID: 137804
		[Token(Token = "0x4021A4C")]
		[FieldOffset(Offset = "0xF0")]
		private SandboxV2RacerInventoryDetailView.LevelAdapter m_levelAdapter;

		// Token: 0x04021A4D RID: 137805
		[Token(Token = "0x4021A4D")]
		[FieldOffset(Offset = "0xF8")]
		private SandboxV2RacerInventoryTalentView m_bornTalent;

		// Token: 0x04021A4E RID: 137806
		[Token(Token = "0x4021A4E")]
		[FieldOffset(Offset = "0x100")]
		private SandboxV2RacerInventoryTalentView m_learnedTalent;

		// Token: 0x04021A4F RID: 137807
		[Token(Token = "0x4021A4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021A50 RID: 137808
		[Token(Token = "0x4021A50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnMarkBtnClicked;

		// Token: 0x04021A51 RID: 137809
		[Token(Token = "0x4021A51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnMedalGroupBtnClicked;

		// Token: 0x04021A52 RID: 137810
		[Token(Token = "0x4021A52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021A53 RID: 137811
		[Token(Token = "0x4021A53")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200434E RID: 17230
		[Token(Token = "0x200434E")]
		private class MedalAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A747 RID: 108359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A747")]
			[Address(RVA = "0x1384F70", Offset = "0x1383B70", VA = "0x181384F70")]
			public MedalAdapter(SandboxV2RacerInventoryDetailView closure)
			{
			}

			// Token: 0x17003ECC RID: 16076
			// (get) Token: 0x0601A748 RID: 108360 RVA: 0x000A1E08 File Offset: 0x000A0008
			[Token(Token = "0x17003ECC")]
			public override int count
			{
				[Token(Token = "0x601A748")]
				[Address(RVA = "0x1384FF0", Offset = "0x1383BF0", VA = "0x181384FF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A749 RID: 108361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A749")]
			[Address(RVA = "0x1384DC0", Offset = "0x13839C0", VA = "0x181384DC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021A54 RID: 137812
			[Token(Token = "0x4021A54")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacerInventoryDetailView m_closure;

			// Token: 0x04021A55 RID: 137813
			[Token(Token = "0x4021A55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021A56 RID: 137814
			[Token(Token = "0x4021A56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021A57 RID: 137815
			[Token(Token = "0x4021A57")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200434F RID: 17231
		[Token(Token = "0x200434F")]
		private class AttributeAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A74A RID: 108362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A74A")]
			[Address(RVA = "0x1383E00", Offset = "0x1382A00", VA = "0x181383E00")]
			public AttributeAdapter(SandboxV2RacerInventoryDetailView clousre)
			{
			}

			// Token: 0x17003ECD RID: 16077
			// (get) Token: 0x0601A74B RID: 108363 RVA: 0x000A1E20 File Offset: 0x000A0020
			[Token(Token = "0x17003ECD")]
			public override int count
			{
				[Token(Token = "0x601A74B")]
				[Address(RVA = "0x1383E80", Offset = "0x1382A80", VA = "0x181383E80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A74C RID: 108364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A74C")]
			[Address(RVA = "0x1383B10", Offset = "0x1382710", VA = "0x181383B10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021A58 RID: 137816
			[Token(Token = "0x4021A58")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacerInventoryDetailView m_closure;

			// Token: 0x04021A59 RID: 137817
			[Token(Token = "0x4021A59")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021A5A RID: 137818
			[Token(Token = "0x4021A5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021A5B RID: 137819
			[Token(Token = "0x4021A5B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004350 RID: 17232
		[Token(Token = "0x2004350")]
		private class LevelAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A74D RID: 108365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A74D")]
			[Address(RVA = "0x1384B70", Offset = "0x1383770", VA = "0x181384B70")]
			public LevelAdapter(SandboxV2RacerInventoryDetailView closure)
			{
			}

			// Token: 0x17003ECE RID: 16078
			// (get) Token: 0x0601A74E RID: 108366 RVA: 0x000A1E38 File Offset: 0x000A0038
			[Token(Token = "0x17003ECE")]
			public override int count
			{
				[Token(Token = "0x601A74E")]
				[Address(RVA = "0x1384BF0", Offset = "0x13837F0", VA = "0x181384BF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A74F RID: 108367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A74F")]
			[Address(RVA = "0x1384A70", Offset = "0x1383670", VA = "0x181384A70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021A5C RID: 137820
			[Token(Token = "0x4021A5C")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacerInventoryDetailView m_closure;

			// Token: 0x04021A5D RID: 137821
			[Token(Token = "0x4021A5D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021A5E RID: 137822
			[Token(Token = "0x4021A5E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021A5F RID: 137823
			[Token(Token = "0x4021A5F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
