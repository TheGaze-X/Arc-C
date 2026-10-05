using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006919 RID: 26905
	[Token(Token = "0x2006919")]
	public class MultipleBattleSelectTimesDialog : UICompDialog<MultipleBattleSelectTimesDialog.Options>
	{
		// Token: 0x060268AE RID: 157870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268AE")]
		[Address(RVA = "0x2194790", Offset = "0x2193390", VA = "0x182194790", Slot = "18")]
		protected override void OnRender(MultipleBattleSelectTimesDialog.Options options)
		{
		}

		// Token: 0x060268AF RID: 157871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268AF")]
		[Address(RVA = "0x2194680", Offset = "0x2193280", VA = "0x182194680", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060268B0 RID: 157872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268B0")]
		[Address(RVA = "0x2194DB0", Offset = "0x21939B0", VA = "0x182194DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060268B1 RID: 157873 RVA: 0x000CB940 File Offset: 0x000C9B40
		[Token(Token = "0x60268B1")]
		[Address(RVA = "0x2194510", Offset = "0x2193110", VA = "0x182194510")]
		private MultipleBattleSelectTimesItemView.ApStatus CalculateApStatus(int times)
		{
			return MultipleBattleSelectTimesItemView.ApStatus.Enough;
		}

		// Token: 0x060268B2 RID: 157874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268B2")]
		[Address(RVA = "0x21945A0", Offset = "0x21931A0", VA = "0x1821945A0")]
		public void OnBackClick()
		{
		}

		// Token: 0x060268B3 RID: 157875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268B3")]
		[Address(RVA = "0x2194CC0", Offset = "0x21938C0", VA = "0x182194CC0")]
		public void OnSelectTimes(int times)
		{
		}

		// Token: 0x060268B4 RID: 157876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268B4")]
		[Address(RVA = "0x2194F90", Offset = "0x2193B90", VA = "0x182194F90")]
		public MultipleBattleSelectTimesDialog()
		{
		}

		// Token: 0x060268B5 RID: 157877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268B5")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040365A3 RID: 222627
		[Token(Token = "0x40365A3")]
		public const int NOT_SELECT_COUNT = -1;

		// Token: 0x040365A4 RID: 222628
		[Token(Token = "0x40365A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _aniEnter;

		// Token: 0x040365A5 RID: 222629
		[Token(Token = "0x40365A5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040365A6 RID: 222630
		[Token(Token = "0x40365A6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040365A7 RID: 222631
		[Token(Token = "0x40365A7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x040365A8 RID: 222632
		[Token(Token = "0x40365A8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x040365A9 RID: 222633
		[Token(Token = "0x40365A9")]
		[FieldOffset(Offset = "0xA0")]
		private List<MultipleBattleSelectTimesItemView.RenderOptions> m_itemList;

		// Token: 0x040365AA RID: 222634
		[Token(Token = "0x40365AA")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_enterSwitchTween;

		// Token: 0x040365AB RID: 222635
		[Token(Token = "0x40365AB")]
		[FieldOffset(Offset = "0xB0")]
		private MultipleBattleSelectTimesDialog.Adapter m_adapter;

		// Token: 0x040365AC RID: 222636
		[Token(Token = "0x40365AC")]
		[FieldOffset(Offset = "0xB8")]
		private int m_stageApCost;

		// Token: 0x040365AD RID: 222637
		[Token(Token = "0x40365AD")]
		[FieldOffset(Offset = "0xBC")]
		private int m_currentAp;

		// Token: 0x040365AE RID: 222638
		[Token(Token = "0x40365AE")]
		[FieldOffset(Offset = "0xC0")]
		private int m_apOwnedIncludingApItem;

		// Token: 0x040365AF RID: 222639
		[Token(Token = "0x40365AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040365B0 RID: 222640
		[Token(Token = "0x40365B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040365B1 RID: 222641
		[Token(Token = "0x40365B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040365B2 RID: 222642
		[Token(Token = "0x40365B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateApStatus;

		// Token: 0x040365B3 RID: 222643
		[Token(Token = "0x40365B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x040365B4 RID: 222644
		[Token(Token = "0x40365B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSelectTimes;

		// Token: 0x040365B5 RID: 222645
		[Token(Token = "0x40365B5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200691A RID: 26906
		[Token(Token = "0x200691A")]
		public class Options
		{
			// Token: 0x060268B6 RID: 157878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60268B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040365B6 RID: 222646
			[Token(Token = "0x40365B6")]
			[FieldOffset(Offset = "0x10")]
			public int stageApCost;

			// Token: 0x040365B7 RID: 222647
			[Token(Token = "0x40365B7")]
			[FieldOffset(Offset = "0x14")]
			public int currentAp;

			// Token: 0x040365B8 RID: 222648
			[Token(Token = "0x40365B8")]
			[FieldOffset(Offset = "0x18")]
			public int apOwnedIncludingApItem;

			// Token: 0x040365B9 RID: 222649
			[Token(Token = "0x40365B9")]
			[FieldOffset(Offset = "0x1C")]
			public int timesSelected;

			// Token: 0x040365BA RID: 222650
			[Token(Token = "0x40365BA")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 offset;
		}

		// Token: 0x0200691B RID: 26907
		[Token(Token = "0x200691B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060268B7 RID: 157879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60268B7")]
			[Address(RVA = "0x2190F70", Offset = "0x218FB70", VA = "0x182190F70")]
			public Adapter(MultipleBattleSelectTimesDialog closure)
			{
			}

			// Token: 0x17005AFE RID: 23294
			// (get) Token: 0x060268B8 RID: 157880 RVA: 0x000CB958 File Offset: 0x000C9B58
			[Token(Token = "0x17005AFE")]
			public override int count
			{
				[Token(Token = "0x60268B8")]
				[Address(RVA = "0x2191070", Offset = "0x218FC70", VA = "0x182191070", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060268B9 RID: 157881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60268B9")]
			[Address(RVA = "0x2190B00", Offset = "0x218F700", VA = "0x182190B00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040365BB RID: 222651
			[Token(Token = "0x40365BB")]
			[FieldOffset(Offset = "0x20")]
			private MultipleBattleSelectTimesDialog m_closure;

			// Token: 0x040365BC RID: 222652
			[Token(Token = "0x40365BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040365BD RID: 222653
			[Token(Token = "0x40365BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040365BE RID: 222654
			[Token(Token = "0x40365BE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
