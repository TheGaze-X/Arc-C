using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E58 RID: 28248
	[Token(Token = "0x2006E58")]
	public class ActVecBreakV2OffenseTowerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602833E RID: 164670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602833E")]
		[Address(RVA = "0x2381460", Offset = "0x2380060", VA = "0x182381460")]
		public void Render(VecBreakV2OffenseStageModel model, ActVecBreakV2OffenseTowerItemView.Param param)
		{
		}

		// Token: 0x0602833F RID: 164671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602833F")]
		[Address(RVA = "0x23818E0", Offset = "0x23804E0", VA = "0x1823818E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028340 RID: 164672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028340")]
		[Address(RVA = "0x2381F20", Offset = "0x2380B20", VA = "0x182381F20")]
		private void _RenderTowerBase(VecBreakV2OffenseStageModel model, ActVecBreakV2ResCollector seasonLoader)
		{
		}

		// Token: 0x06028341 RID: 164673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028341")]
		[Address(RVA = "0x2381A80", Offset = "0x2380680", VA = "0x182381A80")]
		private void _RenderDecoItem(VecBreakV2OffenseStageModel model, ILoadAsset assetLoader, bool isSelected, bool showDeco, bool beforeCollapse)
		{
		}

		// Token: 0x06028342 RID: 164674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028342")]
		[Address(RVA = "0x2381DB0", Offset = "0x23809B0", VA = "0x182381DB0")]
		private void _RenderSeasonPart(VecBreakV2OffenseStageModel model, ActVecBreakV2ResCollector seasonLoader)
		{
		}

		// Token: 0x06028343 RID: 164675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028343")]
		[Address(RVA = "0x23819B0", Offset = "0x23805B0", VA = "0x1823819B0")]
		private void _PlaySelectTween(bool isFirstRender, bool isSelected)
		{
		}

		// Token: 0x06028344 RID: 164676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028344")]
		[Address(RVA = "0x23821F0", Offset = "0x2380DF0", VA = "0x1823821F0")]
		private void _SetLayoutPreferredHeight(bool isSelected, bool beforeClose)
		{
		}

		// Token: 0x06028345 RID: 164677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028345")]
		[Address(RVA = "0x23822E0", Offset = "0x2380EE0", VA = "0x1823822E0")]
		public ActVecBreakV2OffenseTowerItemView()
		{
		}

		// Token: 0x040391D5 RID: 233941
		[Token(Token = "0x40391D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalTowerBase;

		// Token: 0x040391D6 RID: 233942
		[Token(Token = "0x40391D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bossTowerBase;

		// Token: 0x040391D7 RID: 233943
		[Token(Token = "0x40391D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _customTowerBase;

		// Token: 0x040391D8 RID: 233944
		[Token(Token = "0x40391D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _customTowerBaseImage;

		// Token: 0x040391D9 RID: 233945
		[Token(Token = "0x40391D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _itemHolder;

		// Token: 0x040391DA RID: 233946
		[Token(Token = "0x40391DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _numImage;

		// Token: 0x040391DB RID: 233947
		[Token(Token = "0x40391DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _numNormalColor;

		// Token: 0x040391DC RID: 233948
		[Token(Token = "0x40391DC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _numBossColor;

		// Token: 0x040391DD RID: 233949
		[Token(Token = "0x40391DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _completedPart;

		// Token: 0x040391DE RID: 233950
		[Token(Token = "0x40391DE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _topHolderPart;

		// Token: 0x040391DF RID: 233951
		[Token(Token = "0x40391DF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _topIconPart;

		// Token: 0x040391E0 RID: 233952
		[Token(Token = "0x40391E0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _selectArrowImage;

		// Token: 0x040391E1 RID: 233953
		[Token(Token = "0x40391E1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _selectAnimLocation;

		// Token: 0x040391E2 RID: 233954
		[Token(Token = "0x40391E2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private LayoutElement _layout;

		// Token: 0x040391E3 RID: 233955
		[Token(Token = "0x40391E3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _normalHeight;

		// Token: 0x040391E4 RID: 233956
		[Token(Token = "0x40391E4")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _selectHeight;

		// Token: 0x040391E5 RID: 233957
		[Token(Token = "0x40391E5")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x040391E6 RID: 233958
		[Token(Token = "0x40391E6")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040391E7 RID: 233959
		[Token(Token = "0x40391E7")]
		[FieldOffset(Offset = "0xC0")]
		private string m_actId;

		// Token: 0x040391E8 RID: 233960
		[Token(Token = "0x40391E8")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cachedLevel;

		// Token: 0x040391E9 RID: 233961
		[Token(Token = "0x40391E9")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x040391EA RID: 233962
		[Token(Token = "0x40391EA")]
		[FieldOffset(Offset = "0xD8")]
		private ActVecBreakV2OffenseTowerItemDecoView m_stageDecoItem;

		// Token: 0x040391EB RID: 233963
		[Token(Token = "0x40391EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040391EC RID: 233964
		[Token(Token = "0x40391EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040391ED RID: 233965
		[Token(Token = "0x40391ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTowerBase;

		// Token: 0x040391EE RID: 233966
		[Token(Token = "0x40391EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDecoItem;

		// Token: 0x040391EF RID: 233967
		[Token(Token = "0x40391EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSeasonPart;

		// Token: 0x040391F0 RID: 233968
		[Token(Token = "0x40391F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlaySelectTween;

		// Token: 0x040391F1 RID: 233969
		[Token(Token = "0x40391F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetLayoutPreferredHeight;

		// Token: 0x040391F2 RID: 233970
		[Token(Token = "0x40391F2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E59 RID: 28249
		[Token(Token = "0x2006E59")]
		public struct Param
		{
			// Token: 0x040391F3 RID: 233971
			[Token(Token = "0x40391F3")]
			[FieldOffset(Offset = "0x0")]
			public bool isSelected;

			// Token: 0x040391F4 RID: 233972
			[Token(Token = "0x40391F4")]
			[FieldOffset(Offset = "0x1")]
			public bool isFirstRender;

			// Token: 0x040391F5 RID: 233973
			[Token(Token = "0x40391F5")]
			[FieldOffset(Offset = "0x2")]
			public bool beforeClose;

			// Token: 0x040391F6 RID: 233974
			[Token(Token = "0x40391F6")]
			[FieldOffset(Offset = "0x3")]
			public bool showDeco;
		}
	}
}
