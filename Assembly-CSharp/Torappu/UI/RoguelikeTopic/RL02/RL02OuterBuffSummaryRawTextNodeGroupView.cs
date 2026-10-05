using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200461F RID: 17951
	[Token(Token = "0x200461F")]
	public class RL02OuterBuffSummaryRawTextNodeGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x0601B489 RID: 111753 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B48A RID: 111754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004106")]
		public UIPage page
		{
			[Token(Token = "0x601B489")]
			[Address(RVA = "0x14A1420", Offset = "0x14A0020", VA = "0x1814A1420")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B48A")]
			[Address(RVA = "0x14A1480", Offset = "0x14A0080", VA = "0x1814A1480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B48B RID: 111755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B48B")]
		[Address(RVA = "0x14A10D0", Offset = "0x149FCD0", VA = "0x1814A10D0")]
		public void Render(RL02OuterBuffListModel viewModel)
		{
		}

		// Token: 0x0601B48C RID: 111756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B48C")]
		[Address(RVA = "0x14A12A0", Offset = "0x149FEA0", VA = "0x1814A12A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B48D RID: 111757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B48D")]
		[Address(RVA = "0x14A13C0", Offset = "0x149FFC0", VA = "0x1814A13C0")]
		public RL02OuterBuffSummaryRawTextNodeGroupView()
		{
		}

		// Token: 0x04023373 RID: 144243
		[Token(Token = "0x4023373")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _groupContent;

		// Token: 0x04023375 RID: 144245
		[Token(Token = "0x4023375")]
		[FieldOffset(Offset = "0x28")]
		private List<RL02OuterBuffListRawTextGroupItemModel> m_groupModelList;

		// Token: 0x04023376 RID: 144246
		[Token(Token = "0x4023376")]
		[FieldOffset(Offset = "0x30")]
		private string m_topicId;

		// Token: 0x04023377 RID: 144247
		[Token(Token = "0x4023377")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04023378 RID: 144248
		[Token(Token = "0x4023378")]
		[FieldOffset(Offset = "0x40")]
		private RL02OuterBuffSummaryRawTextNodeGroupView.Adapter m_adapter;

		// Token: 0x04023379 RID: 144249
		[Token(Token = "0x4023379")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402337A RID: 144250
		[Token(Token = "0x402337A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402337B RID: 144251
		[Token(Token = "0x402337B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402337C RID: 144252
		[Token(Token = "0x402337C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402337D RID: 144253
		[Token(Token = "0x402337D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004620 RID: 17952
		[Token(Token = "0x2004620")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B48E RID: 111758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B48E")]
			[Address(RVA = "0x14958E0", Offset = "0x14944E0", VA = "0x1814958E0")]
			public Adapter(RL02OuterBuffSummaryRawTextNodeGroupView closure)
			{
			}

			// Token: 0x17004107 RID: 16647
			// (get) Token: 0x0601B48F RID: 111759 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
			[Token(Token = "0x17004107")]
			public override int count
			{
				[Token(Token = "0x601B48F")]
				[Address(RVA = "0x1495D50", Offset = "0x1494950", VA = "0x181495D50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B490 RID: 111760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B490")]
			[Address(RVA = "0x1494F10", Offset = "0x1493B10", VA = "0x181494F10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402337E RID: 144254
			[Token(Token = "0x402337E")]
			[FieldOffset(Offset = "0x20")]
			private RL02OuterBuffSummaryRawTextNodeGroupView m_closure;

			// Token: 0x0402337F RID: 144255
			[Token(Token = "0x402337F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023380 RID: 144256
			[Token(Token = "0x4023380")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023381 RID: 144257
			[Token(Token = "0x4023381")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
