using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200450F RID: 17679
	[Token(Token = "0x200450F")]
	public class RoguelikeCommonOuterBuffSummaryMergeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF85 RID: 110469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF85")]
		[Address(RVA = "0x1421C80", Offset = "0x1420880", VA = "0x181421C80")]
		public void Render(string topicId, List<RoguelikeCommonOuterBuffSummaryMergedItemModel> viewModels, bool firstLineHasBack)
		{
		}

		// Token: 0x0601AF86 RID: 110470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF86")]
		[Address(RVA = "0x1421EC0", Offset = "0x1420AC0", VA = "0x181421EC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF87 RID: 110471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF87")]
		[Address(RVA = "0x1422010", Offset = "0x1420C10", VA = "0x181422010")]
		public RoguelikeCommonOuterBuffSummaryMergeView()
		{
		}

		// Token: 0x040229EE RID: 141806
		[Token(Token = "0x40229EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040229EF RID: 141807
		[Token(Token = "0x40229EF")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040229F0 RID: 141808
		[Token(Token = "0x40229F0")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeCommonOuterBuffSummaryMergeView.MergeAdapter m_adapter;

		// Token: 0x040229F1 RID: 141809
		[Token(Token = "0x40229F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229F2 RID: 141810
		[Token(Token = "0x40229F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040229F3 RID: 141811
		[Token(Token = "0x40229F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004510 RID: 17680
		[Token(Token = "0x2004510")]
		private class MergeAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0601AF88 RID: 110472 RVA: 0x000A3C08 File Offset: 0x000A1E08
			[Token(Token = "0x17004006")]
			public override int count
			{
				[Token(Token = "0x601AF88")]
				[Address(RVA = "0x1417F20", Offset = "0x1416B20", VA = "0x181417F20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF89 RID: 110473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF89")]
			[Address(RVA = "0x1417BC0", Offset = "0x14167C0", VA = "0x181417BC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF8A RID: 110474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF8A")]
			[Address(RVA = "0x1417EC0", Offset = "0x1416AC0", VA = "0x181417EC0")]
			public MergeAdapter()
			{
			}

			// Token: 0x040229F4 RID: 141812
			[Token(Token = "0x40229F4")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x040229F5 RID: 141813
			[Token(Token = "0x40229F5")]
			[FieldOffset(Offset = "0x28")]
			public bool firstLineHasBack;

			// Token: 0x040229F6 RID: 141814
			[Token(Token = "0x40229F6")]
			[FieldOffset(Offset = "0x30")]
			public List<RoguelikeCommonOuterBuffSummaryMergedItemModel> datas;

			// Token: 0x040229F7 RID: 141815
			[Token(Token = "0x40229F7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040229F8 RID: 141816
			[Token(Token = "0x40229F8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040229F9 RID: 141817
			[Token(Token = "0x40229F9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
