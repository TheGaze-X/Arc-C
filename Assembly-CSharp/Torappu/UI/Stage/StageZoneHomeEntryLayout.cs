using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067AB RID: 26539
	[Token(Token = "0x20067AB")]
	public class StageZoneHomeEntryLayout : UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>
	{
		// Token: 0x06026101 RID: 155905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026101")]
		[Address(RVA = "0x2121A20", Offset = "0x2120620", VA = "0x182121A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026102 RID: 155906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026102")]
		[Address(RVA = "0x2121930", Offset = "0x2120530", VA = "0x182121930")]
		public void Render(ZoneHomeEntryGroupModel groupModel, StageZoneHomeEntryLayout.RenderOptions options)
		{
		}

		// Token: 0x06026103 RID: 155907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026103")]
		[Address(RVA = "0x2121D10", Offset = "0x2120910", VA = "0x182121D10")]
		private void _OnEntryItemClicked(ZoneHomeEntryItemModel itemModel)
		{
		}

		// Token: 0x06026104 RID: 155908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026104")]
		[Address(RVA = "0x2121DA0", Offset = "0x21209A0", VA = "0x182121DA0")]
		public StageZoneHomeEntryLayout()
		{
		}

		// Token: 0x0403591C RID: 219420
		[Token(Token = "0x403591C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StageZoneHomeEntryItemBase _entryItemPrefab;

		// Token: 0x0403591D RID: 219421
		[Token(Token = "0x403591D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private StageZoneHomeEntryLayout.LayoutConfig _layoutConfig;

		// Token: 0x0403591E RID: 219422
		[Token(Token = "0x403591E")]
		[FieldOffset(Offset = "0x88")]
		private ZoneHomeEntryGroupModel m_groupModel;

		// Token: 0x0403591F RID: 219423
		[Token(Token = "0x403591F")]
		[FieldOffset(Offset = "0x90")]
		private StageZoneHomeEntryLayout.InnerLayouter m_layouter;

		// Token: 0x04035920 RID: 219424
		[Token(Token = "0x4035920")]
		[FieldOffset(Offset = "0x98")]
		private StageZoneHomeEntryLayout.InnerAdapter m_adapter;

		// Token: 0x04035921 RID: 219425
		[Token(Token = "0x4035921")]
		[FieldOffset(Offset = "0xA0")]
		private StageZoneHomeEntryLayout.RenderOptions m_options;

		// Token: 0x04035922 RID: 219426
		[Token(Token = "0x4035922")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x04035923 RID: 219427
		[Token(Token = "0x4035923")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035924 RID: 219428
		[Token(Token = "0x4035924")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035925 RID: 219429
		[Token(Token = "0x4035925")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnEntryItemClicked;

		// Token: 0x04035926 RID: 219430
		[Token(Token = "0x4035926")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067AC RID: 26540
		[Token(Token = "0x20067AC")]
		[Serializable]
		private class LayoutConfig
		{
			// Token: 0x06026105 RID: 155909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026105")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LayoutConfig()
			{
			}

			// Token: 0x04035927 RID: 219431
			[Token(Token = "0x4035927")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Used to fill entry items")]
			public List<StageZoneHomeEntryLayout.LayoutConfig.Slot> slots;

			// Token: 0x04035928 RID: 219432
			[Token(Token = "0x4035928")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Used to clip invalid slots. Set to null if non-clip required")]
			public RectTransform viewport;

			// Token: 0x020067AD RID: 26541
			[Token(Token = "0x20067AD")]
			[Serializable]
			public class Slot
			{
				// Token: 0x06026106 RID: 155910 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6026106")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Slot()
				{
				}

				// Token: 0x04035929 RID: 219433
				[Token(Token = "0x4035929")]
				[FieldOffset(Offset = "0x10")]
				public HomeEntryLayoutLevel level;

				// Token: 0x0403592A RID: 219434
				[Token(Token = "0x403592A")]
				[FieldOffset(Offset = "0x18")]
				public RectTransform rect;
			}
		}

		// Token: 0x020067AE RID: 26542
		[Token(Token = "0x20067AE")]
		public struct RenderOptions
		{
			// Token: 0x0403592B RID: 219435
			[Token(Token = "0x403592B")]
			[FieldOffset(Offset = "0x0")]
			public Action<ZoneHomeEntryItemModel> onEntryClicked;
		}

		// Token: 0x020067AF RID: 26543
		[Token(Token = "0x20067AF")]
		private class InnerLayouter : UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter
		{
			// Token: 0x06026107 RID: 155911 RVA: 0x000C9D68 File Offset: 0x000C7F68
			[Token(Token = "0x6026107")]
			[Address(RVA = "0x211AB60", Offset = "0x2119760", VA = "0x18211AB60")]
			private bool _TryGetMeta(string id, out StageZoneHomeEntryLayout.InnerLayouter.LayoutMeta meta)
			{
				return default(bool);
			}

			// Token: 0x06026108 RID: 155912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026108")]
			[Address(RVA = "0x211B390", Offset = "0x2119F90", VA = "0x18211B390")]
			public InnerLayouter(StageZoneHomeEntryLayout closure)
			{
			}

			// Token: 0x06026109 RID: 155913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026109")]
			[Address(RVA = "0x2118670", Offset = "0x2117270", VA = "0x182118670", Slot = "5")]
			protected override void LayoutImmediatelyInternal()
			{
			}

			// Token: 0x0602610A RID: 155914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602610A")]
			[Address(RVA = "0x21189F0", Offset = "0x21175F0", VA = "0x1821189F0", Slot = "4")]
			protected override void LayoutInternal()
			{
			}

			// Token: 0x0602610B RID: 155915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602610B")]
			[Address(RVA = "0x211ACB0", Offset = "0x21198B0", VA = "0x18211ACB0")]
			private void _UpdateAllElmentsMetaAndContentBound()
			{
			}

			// Token: 0x0602610C RID: 155916 RVA: 0x000C9D80 File Offset: 0x000C7F80
			[Token(Token = "0x602610C")]
			[Address(RVA = "0x2119410", Offset = "0x2118010", VA = "0x182119410")]
			private static int _CompareLayoutElement(UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter.LayoutElement lhs, UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter.LayoutElement rhs)
			{
				return 0;
			}

			// Token: 0x0602610D RID: 155917 RVA: 0x000C9D98 File Offset: 0x000C7F98
			[Token(Token = "0x602610D")]
			[Address(RVA = "0x2119120", Offset = "0x2117D20", VA = "0x182119120")]
			private static bool _CheckIfSlotValid(RectTransform viewport, RectTransform slot)
			{
				return default(bool);
			}

			// Token: 0x0602610E RID: 155918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602610E")]
			[Address(RVA = "0x2119560", Offset = "0x2118160", VA = "0x182119560")]
			private void _SetViewPropsAndRender(UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter.LayoutElement ele, StageZoneHomeEntryLayout.InnerLayouter.LayoutMeta meta)
			{
			}

			// Token: 0x0602610F RID: 155919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602610F")]
			[Address(RVA = "0x211A480", Offset = "0x2119080", VA = "0x18211A480")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter.LayoutElement ele, StageZoneHomeEntryLayout.InnerLayouter.LayoutMeta meta)
			{
			}

			// Token: 0x06026110 RID: 155920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026110")]
			[Address(RVA = "0x211A790", Offset = "0x2119390", VA = "0x18211A790")]
			private void _TransitionRemoved(UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x06026111 RID: 155921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026111")]
			[Address(RVA = "0x2119AE0", Offset = "0x21186E0", VA = "0x182119AE0")]
			private void _TransitionMove(UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Layouter.LayoutElement ele, StageZoneHomeEntryLayout.InnerLayouter.LayoutMeta meta)
			{
			}

			// Token: 0x0403592C RID: 219436
			[Token(Token = "0x403592C")]
			private const float FAST_TWEEN_DUR = 0.16f;

			// Token: 0x0403592D RID: 219437
			[Token(Token = "0x403592D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 ITEM_PIVOT;

			// Token: 0x0403592E RID: 219438
			[Token(Token = "0x403592E")]
			[FieldOffset(Offset = "0x48")]
			private StageZoneHomeEntryLayout m_closure;

			// Token: 0x0403592F RID: 219439
			[Token(Token = "0x403592F")]
			[FieldOffset(Offset = "0x50")]
			private Dictionary<string, StageZoneHomeEntryLayout.InnerLayouter.LayoutMeta> m_metaMap;

			// Token: 0x04035930 RID: 219440
			[Token(Token = "0x4035930")]
			[FieldOffset(Offset = "0x58")]
			private List<StageZoneHomeEntryLayout.LayoutConfig.Slot> m_validSlots;

			// Token: 0x04035931 RID: 219441
			[Token(Token = "0x4035931")]
			[FieldOffset(Offset = "0x60")]
			private StageZoneHomeEntryLayout.InnerLayouter.Options m_options;

			// Token: 0x04035932 RID: 219442
			[Token(Token = "0x4035932")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__TryGetMeta;

			// Token: 0x04035933 RID: 219443
			[Token(Token = "0x4035933")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035934 RID: 219444
			[Token(Token = "0x4035934")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyInternal;

			// Token: 0x04035935 RID: 219445
			[Token(Token = "0x4035935")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_LayoutInternal;

			// Token: 0x04035936 RID: 219446
			[Token(Token = "0x4035936")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__UpdateAllElmentsMetaAndContentBound;

			// Token: 0x04035937 RID: 219447
			[Token(Token = "0x4035937")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__CompareLayoutElement;

			// Token: 0x04035938 RID: 219448
			[Token(Token = "0x4035938")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__CheckIfSlotValid;

			// Token: 0x04035939 RID: 219449
			[Token(Token = "0x4035939")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__SetViewPropsAndRender;

			// Token: 0x0403593A RID: 219450
			[Token(Token = "0x403593A")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x0403593B RID: 219451
			[Token(Token = "0x403593B")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x0403593C RID: 219452
			[Token(Token = "0x403593C")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__TransitionMove;

			// Token: 0x020067B0 RID: 26544
			[Token(Token = "0x20067B0")]
			private struct LayoutMeta
			{
				// Token: 0x0403593D RID: 219453
				[Token(Token = "0x403593D")]
				[FieldOffset(Offset = "0x0")]
				public Vector2 size;

				// Token: 0x0403593E RID: 219454
				[Token(Token = "0x403593E")]
				[FieldOffset(Offset = "0x8")]
				public Vector2 center;

				// Token: 0x0403593F RID: 219455
				[Token(Token = "0x403593F")]
				[FieldOffset(Offset = "0x10")]
				public HomeEntryLayoutLevel layoutLevel;
			}

			// Token: 0x020067B1 RID: 26545
			[Token(Token = "0x20067B1")]
			public struct Options
			{
				// Token: 0x04035940 RID: 219456
				[Token(Token = "0x4035940")]
				[FieldOffset(Offset = "0x0")]
				public StageZoneHomeEntryLayout.LayoutConfig config;
			}
		}

		// Token: 0x020067B5 RID: 26549
		[Token(Token = "0x20067B5")]
		private class InnerAdapter : UICustomAdapterLayout<ZoneHomeEntryItemModel, StageZoneHomeEntryItemBase>.Adapter
		{
			// Token: 0x06026119 RID: 155929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026119")]
			[Address(RVA = "0x2118220", Offset = "0x2116E20", VA = "0x182118220")]
			public InnerAdapter(StageZoneHomeEntryLayout closure)
			{
			}

			// Token: 0x0602611A RID: 155930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602611A")]
			[Address(RVA = "0x2117C20", Offset = "0x2116820", VA = "0x182117C20", Slot = "6")]
			public override StageZoneHomeEntryItemBase CreateInst(ZoneHomeEntryItemModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0602611B RID: 155931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602611B")]
			[Address(RVA = "0x2117EA0", Offset = "0x2116AA0", VA = "0x182117EA0", Slot = "4")]
			public override IList<ZoneHomeEntryItemModel> GetData()
			{
				return null;
			}

			// Token: 0x0602611C RID: 155932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602611C")]
			[Address(RVA = "0x2117F20", Offset = "0x2116B20", VA = "0x182117F20", Slot = "5")]
			public override string GetId(ZoneHomeEntryItemModel data)
			{
				return null;
			}

			// Token: 0x0602611D RID: 155933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602611D")]
			[Address(RVA = "0x2118130", Offset = "0x2116D30", VA = "0x182118130", Slot = "7")]
			public override void UpdateView(StageZoneHomeEntryItemBase view, ZoneHomeEntryItemModel data)
			{
			}

			// Token: 0x04035948 RID: 219464
			[Token(Token = "0x4035948")]
			[FieldOffset(Offset = "0x20")]
			private StageZoneHomeEntryLayout m_closure;

			// Token: 0x04035949 RID: 219465
			[Token(Token = "0x4035949")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403594A RID: 219466
			[Token(Token = "0x403594A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0403594B RID: 219467
			[Token(Token = "0x403594B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x0403594C RID: 219468
			[Token(Token = "0x403594C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0403594D RID: 219469
			[Token(Token = "0x403594D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
