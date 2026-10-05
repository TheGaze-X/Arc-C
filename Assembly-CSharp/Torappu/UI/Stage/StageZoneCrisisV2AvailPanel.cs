using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200693B RID: 26939
	[Token(Token = "0x200693B")]
	public class StageZoneCrisisV2AvailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026939 RID: 158009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026939")]
		[Address(RVA = "0x21B8370", Offset = "0x21B6F70", VA = "0x1821B8370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602693A RID: 158010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602693A")]
		[Address(RVA = "0x21B7CE0", Offset = "0x21B68E0", VA = "0x1821B7CE0")]
		public void RenderSeason(CrisisV2ZoneEntryModel viewModel)
		{
		}

		// Token: 0x0602693B RID: 158011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602693B")]
		[Address(RVA = "0x21B8450", Offset = "0x21B7050", VA = "0x1821B8450")]
		public StageZoneCrisisV2AvailPanel()
		{
		}

		// Token: 0x040366A2 RID: 222882
		[Token(Token = "0x40366A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _backImg;

		// Token: 0x040366A3 RID: 222883
		[Token(Token = "0x40366A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _titleImg;

		// Token: 0x040366A4 RID: 222884
		[Token(Token = "0x40366A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _medalBackImg;

		// Token: 0x040366A5 RID: 222885
		[Token(Token = "0x40366A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040366A6 RID: 222886
		[Token(Token = "0x40366A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x040366A7 RID: 222887
		[Token(Token = "0x40366A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _seasonName;

		// Token: 0x040366A8 RID: 222888
		[Token(Token = "0x40366A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x040366A9 RID: 222889
		[Token(Token = "0x40366A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _availMedalPart;

		// Token: 0x040366AA RID: 222890
		[Token(Token = "0x40366AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _unavailMedalPart;

		// Token: 0x040366AB RID: 222891
		[Token(Token = "0x40366AB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _medalIcon;

		// Token: 0x040366AC RID: 222892
		[Token(Token = "0x40366AC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Graphic[] _themeColorGraphicList;

		// Token: 0x040366AD RID: 222893
		[Token(Token = "0x40366AD")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_finder;

		// Token: 0x040366AE RID: 222894
		[Token(Token = "0x40366AE")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsInited;

		// Token: 0x040366AF RID: 222895
		[Token(Token = "0x40366AF")]
		[FieldOffset(Offset = "0x88")]
		private StageZoneCrisisV2AvailPanel.Adapter m_adapter;

		// Token: 0x040366B0 RID: 222896
		[Token(Token = "0x40366B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040366B1 RID: 222897
		[Token(Token = "0x40366B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderSeason;

		// Token: 0x040366B2 RID: 222898
		[Token(Token = "0x40366B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200693C RID: 26940
		[Token(Token = "0x200693C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005B18 RID: 23320
			// (get) Token: 0x0602693C RID: 158012 RVA: 0x000CBBE0 File Offset: 0x000C9DE0
			[Token(Token = "0x17005B18")]
			public override int count
			{
				[Token(Token = "0x602693C")]
				[Address(RVA = "0x21A5E70", Offset = "0x21A4A70", VA = "0x1821A5E70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602693D RID: 158013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602693D")]
			[Address(RVA = "0x21A5990", Offset = "0x21A4590", VA = "0x1821A5990", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602693E RID: 158014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602693E")]
			[Address(RVA = "0x21A5E10", Offset = "0x21A4A10", VA = "0x1821A5E10")]
			public Adapter()
			{
			}

			// Token: 0x040366B3 RID: 222899
			[Token(Token = "0x40366B3")]
			[FieldOffset(Offset = "0x20")]
			public List<CrisisV2ZoneEntryModel.Temp> tempList;

			// Token: 0x040366B4 RID: 222900
			[Token(Token = "0x40366B4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040366B5 RID: 222901
			[Token(Token = "0x40366B5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040366B6 RID: 222902
			[Token(Token = "0x40366B6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
