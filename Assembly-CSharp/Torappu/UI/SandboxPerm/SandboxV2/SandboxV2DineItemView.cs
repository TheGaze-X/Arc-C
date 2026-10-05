using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200413C RID: 16700
	[Token(Token = "0x200413C")]
	public class SandboxV2DineItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x06019C8A RID: 105610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019C8B RID: 105611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D70")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6019C8A")]
			[Address(RVA = "0x12AC0D0", Offset = "0x12AACD0", VA = "0x1812AC0D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019C8B")]
			[Address(RVA = "0x12AC130", Offset = "0x12AAD30", VA = "0x1812AC130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019C8C RID: 105612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C8C")]
		[Address(RVA = "0x12ABA50", Offset = "0x12AA650", VA = "0x1812ABA50")]
		public void OnItemSelectEvent()
		{
		}

		// Token: 0x06019C8D RID: 105613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C8D")]
		[Address(RVA = "0x12ABB30", Offset = "0x12AA730", VA = "0x1812ABB30")]
		public void Render(int index, SandboxV2DineItemModel model, bool initRender)
		{
		}

		// Token: 0x06019C8E RID: 105614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C8E")]
		[Address(RVA = "0x12ABDF0", Offset = "0x12AA9F0", VA = "0x1812ABDF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019C8F RID: 105615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C8F")]
		[Address(RVA = "0x12AC060", Offset = "0x12AAC60", VA = "0x1812AC060")]
		public SandboxV2DineItemView()
		{
		}

		// Token: 0x0402059C RID: 132508
		[Token(Token = "0x402059C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x0402059D RID: 132509
		[Token(Token = "0x402059D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardHolder;

		// Token: 0x0402059E RID: 132510
		[Token(Token = "0x402059E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402059F RID: 132511
		[Token(Token = "0x402059F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x040205A0 RID: 132512
		[Token(Token = "0x40205A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _durationText;

		// Token: 0x040205A1 RID: 132513
		[Token(Token = "0x40205A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x040205A2 RID: 132514
		[Token(Token = "0x40205A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _stockText;

		// Token: 0x040205A3 RID: 132515
		[Token(Token = "0x40205A3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _attributeContent;

		// Token: 0x040205A4 RID: 132516
		[Token(Token = "0x40205A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _isLastDinedPanel;

		// Token: 0x040205A5 RID: 132517
		[Token(Token = "0x40205A5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x040205A6 RID: 132518
		[Token(Token = "0x40205A6")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x040205A7 RID: 132519
		[Token(Token = "0x40205A7")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x040205A8 RID: 132520
		[Token(Token = "0x40205A8")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DineItemView.Adapter m_adapter;

		// Token: 0x040205A9 RID: 132521
		[Token(Token = "0x40205A9")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_selectTween;

		// Token: 0x040205AA RID: 132522
		[Token(Token = "0x40205AA")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedIndex;

		// Token: 0x040205AB RID: 132523
		[Token(Token = "0x40205AB")]
		[FieldOffset(Offset = "0x90")]
		private List<SandboxV2DineItemModel.AttributeInfo> m_cachedAttributes;

		// Token: 0x040205AD RID: 132525
		[Token(Token = "0x40205AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x040205AE RID: 132526
		[Token(Token = "0x40205AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x040205AF RID: 132527
		[Token(Token = "0x40205AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemSelectEvent;

		// Token: 0x040205B0 RID: 132528
		[Token(Token = "0x40205B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040205B1 RID: 132529
		[Token(Token = "0x40205B1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040205B2 RID: 132530
		[Token(Token = "0x40205B2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200413D RID: 16701
		[Token(Token = "0x200413D")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D71 RID: 15729
			// (get) Token: 0x06019C90 RID: 105616 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
			[Token(Token = "0x17003D71")]
			public override int count
			{
				[Token(Token = "0x6019C90")]
				[Address(RVA = "0x12A07B0", Offset = "0x129F3B0", VA = "0x1812A07B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019C91 RID: 105617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C91")]
			[Address(RVA = "0x12A0730", Offset = "0x129F330", VA = "0x1812A0730")]
			public Adapter(SandboxV2DineItemView closure)
			{
			}

			// Token: 0x06019C92 RID: 105618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019C92")]
			[Address(RVA = "0x12A0500", Offset = "0x129F100", VA = "0x1812A0500", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040205B3 RID: 132531
			[Token(Token = "0x40205B3")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DineItemView m_closure;

			// Token: 0x040205B4 RID: 132532
			[Token(Token = "0x40205B4")]
			[FieldOffset(Offset = "0x28")]
			private UIStateFinder m_finder;

			// Token: 0x040205B5 RID: 132533
			[Token(Token = "0x40205B5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040205B6 RID: 132534
			[Token(Token = "0x40205B6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040205B7 RID: 132535
			[Token(Token = "0x40205B7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
