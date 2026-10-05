using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F88 RID: 24456
	[Token(Token = "0x2005F88")]
	public class CharacterInfoPotentialIconLayout : UICustomAdapterLayout<int, CharacterInfoPotentialIconHolder>
	{
		// Token: 0x06023624 RID: 144932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023624")]
		[Address(RVA = "0x1E00DE0", Offset = "0x1DFF9E0", VA = "0x181E00DE0")]
		public void UpdateData(IList<int> potentialIconList)
		{
		}

		// Token: 0x06023625 RID: 144933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023625")]
		[Address(RVA = "0x1E01120", Offset = "0x1DFFD20", VA = "0x181E01120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023626 RID: 144934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023626")]
		[Address(RVA = "0x1E01380", Offset = "0x1DFFF80", VA = "0x181E01380")]
		public CharacterInfoPotentialIconLayout()
		{
		}

		// Token: 0x04030E0A RID: 200202
		[Token(Token = "0x4030E0A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tween")]
		private float _itemFadeDur;

		// Token: 0x04030E0B RID: 200203
		[Token(Token = "0x4030E0B")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Group("Tween")]
		private float _itemFadeMoveBias;

		// Token: 0x04030E0C RID: 200204
		[Token(Token = "0x4030E0C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CharacterInfoPotentialIconHolder _iconPrefab;

		// Token: 0x04030E0D RID: 200205
		[Token(Token = "0x4030E0D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 _gridSize;

		// Token: 0x04030E0E RID: 200206
		[Token(Token = "0x4030E0E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x04030E0F RID: 200207
		[Token(Token = "0x4030E0F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _spacing;

		// Token: 0x04030E10 RID: 200208
		[Token(Token = "0x4030E10")]
		[FieldOffset(Offset = "0xA8")]
		private List<int> m_iconRankList;

		// Token: 0x04030E11 RID: 200209
		[Token(Token = "0x4030E11")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<int, int> m_gridIndexMap;

		// Token: 0x04030E12 RID: 200210
		[Token(Token = "0x4030E12")]
		[FieldOffset(Offset = "0xB8")]
		private CharacterInfoPotentialIconLayout.InnerAdapter m_adapter;

		// Token: 0x04030E13 RID: 200211
		[Token(Token = "0x4030E13")]
		[FieldOffset(Offset = "0xC0")]
		private CharacterInfoPotentialIconLayout.InnerLayouter m_layouter;

		// Token: 0x04030E14 RID: 200212
		[Token(Token = "0x4030E14")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x04030E15 RID: 200213
		[Token(Token = "0x4030E15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04030E16 RID: 200214
		[Token(Token = "0x4030E16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030E17 RID: 200215
		[Token(Token = "0x4030E17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F89 RID: 24457
		[Token(Token = "0x2005F89")]
		private class InnerLayouter : UICustomGridLayouter<int, CharacterInfoPotentialIconHolder>
		{
			// Token: 0x06023627 RID: 144935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023627")]
			[Address(RVA = "0x1E100E0", Offset = "0x1E0ECE0", VA = "0x181E100E0")]
			public InnerLayouter(CharacterInfoPotentialIconLayout closure)
			{
			}

			// Token: 0x06023628 RID: 144936 RVA: 0x000C0B10 File Offset: 0x000BED10
			[Token(Token = "0x6023628")]
			[Address(RVA = "0x1E0F080", Offset = "0x1E0DC80", VA = "0x181E0F080", Slot = "6")]
			protected override GridPosition DataToOffset(int data)
			{
				return default(GridPosition);
			}

			// Token: 0x06023629 RID: 144937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023629")]
			[Address(RVA = "0x1E0F140", Offset = "0x1E0DD40", VA = "0x181E0F140", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x0602362A RID: 144938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602362A")]
			[Address(RVA = "0x1E0F3C0", Offset = "0x1E0DFC0", VA = "0x181E0F3C0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x0602362B RID: 144939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602362B")]
			[Address(RVA = "0x1E0FE20", Offset = "0x1E0EA20", VA = "0x181E0FE20")]
			private void _TransitionRemoved(UICustomAdapterLayout<int, CharacterInfoPotentialIconHolder>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0602362C RID: 144940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602362C")]
			[Address(RVA = "0x1E0F650", Offset = "0x1E0E250", VA = "0x181E0F650")]
			private void _SetViewTransformProp(UICustomAdapterLayout<int, CharacterInfoPotentialIconHolder>.Layouter.LayoutElement ele, UICustomGridLayouter<int, CharacterInfoPotentialIconHolder>.LayoutMeta meta)
			{
			}

			// Token: 0x0602362D RID: 144941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602362D")]
			[Address(RVA = "0x1E0FB80", Offset = "0x1E0E780", VA = "0x181E0FB80")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<int, CharacterInfoPotentialIconHolder>.Layouter.LayoutElement ele, UICustomGridLayouter<int, CharacterInfoPotentialIconHolder>.LayoutMeta meta)
			{
			}

			// Token: 0x0602362E RID: 144942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602362E")]
			[Address(RVA = "0x1E0F8C0", Offset = "0x1E0E4C0", VA = "0x181E0F8C0")]
			private void _TransitionMove(UICustomAdapterLayout<int, CharacterInfoPotentialIconHolder>.Layouter.LayoutElement ele, UICustomGridLayouter<int, CharacterInfoPotentialIconHolder>.LayoutMeta meta)
			{
			}

			// Token: 0x04030E18 RID: 200216
			[Token(Token = "0x4030E18")]
			[FieldOffset(Offset = "0x70")]
			private CharacterInfoPotentialIconLayout m_closure;

			// Token: 0x04030E19 RID: 200217
			[Token(Token = "0x4030E19")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030E1A RID: 200218
			[Token(Token = "0x4030E1A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x04030E1B RID: 200219
			[Token(Token = "0x4030E1B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x04030E1C RID: 200220
			[Token(Token = "0x4030E1C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x04030E1D RID: 200221
			[Token(Token = "0x4030E1D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x04030E1E RID: 200222
			[Token(Token = "0x4030E1E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetViewTransformProp;

			// Token: 0x04030E1F RID: 200223
			[Token(Token = "0x4030E1F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x04030E20 RID: 200224
			[Token(Token = "0x4030E20")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}

		// Token: 0x02005F8D RID: 24461
		[Token(Token = "0x2005F8D")]
		private class InnerAdapter : UICustomAdapterLayout<int, CharacterInfoPotentialIconHolder>.Adapter
		{
			// Token: 0x06023636 RID: 144950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023636")]
			[Address(RVA = "0x1E0EFA0", Offset = "0x1E0DBA0", VA = "0x181E0EFA0")]
			public InnerAdapter(CharacterInfoPotentialIconHolder prefab)
			{
			}

			// Token: 0x06023637 RID: 144951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023637")]
			[Address(RVA = "0x1E0ECA0", Offset = "0x1E0D8A0", VA = "0x181E0ECA0", Slot = "6")]
			public override CharacterInfoPotentialIconHolder CreateInst(int data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x06023638 RID: 144952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023638")]
			[Address(RVA = "0x1E0EDA0", Offset = "0x1E0D9A0", VA = "0x181E0EDA0", Slot = "4")]
			public override IList<int> GetData()
			{
				return null;
			}

			// Token: 0x06023639 RID: 144953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023639")]
			[Address(RVA = "0x1E0EE00", Offset = "0x1E0DA00", VA = "0x181E0EE00", Slot = "5")]
			public override string GetId(int data)
			{
				return null;
			}

			// Token: 0x0602363A RID: 144954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602363A")]
			[Address(RVA = "0x1E0EE70", Offset = "0x1E0DA70", VA = "0x181E0EE70", Slot = "7")]
			public override void UpdateView(CharacterInfoPotentialIconHolder view, int data)
			{
			}

			// Token: 0x04030E29 RID: 200233
			[Token(Token = "0x4030E29")]
			[FieldOffset(Offset = "0x20")]
			public List<int> potentialLevelList;

			// Token: 0x04030E2A RID: 200234
			[Token(Token = "0x4030E2A")]
			[FieldOffset(Offset = "0x28")]
			private CharacterInfoPotentialIconHolder m_prefab;

			// Token: 0x04030E2B RID: 200235
			[Token(Token = "0x4030E2B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030E2C RID: 200236
			[Token(Token = "0x4030E2C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x04030E2D RID: 200237
			[Token(Token = "0x4030E2D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x04030E2E RID: 200238
			[Token(Token = "0x4030E2E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x04030E2F RID: 200239
			[Token(Token = "0x4030E2F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
