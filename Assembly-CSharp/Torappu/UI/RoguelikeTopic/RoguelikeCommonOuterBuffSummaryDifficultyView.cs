using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200450B RID: 17675
	[Token(Token = "0x200450B")]
	public class RoguelikeCommonOuterBuffSummaryDifficultyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF7B RID: 110459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF7B")]
		[Address(RVA = "0x14214B0", Offset = "0x14200B0", VA = "0x1814214B0")]
		public void Render(string topicId, List<RoguelikeCommonOuterBuffSummaryDifficultyItemModel> viewModels)
		{
		}

		// Token: 0x0601AF7C RID: 110460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF7C")]
		[Address(RVA = "0x14216D0", Offset = "0x14202D0", VA = "0x1814216D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF7D RID: 110461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF7D")]
		[Address(RVA = "0x1421820", Offset = "0x1420420", VA = "0x181421820")]
		public RoguelikeCommonOuterBuffSummaryDifficultyView()
		{
		}

		// Token: 0x040229D3 RID: 141779
		[Token(Token = "0x40229D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040229D4 RID: 141780
		[Token(Token = "0x40229D4")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040229D5 RID: 141781
		[Token(Token = "0x40229D5")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeCommonOuterBuffSummaryDifficultyView.DifficultyAdapter m_adapter;

		// Token: 0x040229D6 RID: 141782
		[Token(Token = "0x40229D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229D7 RID: 141783
		[Token(Token = "0x40229D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040229D8 RID: 141784
		[Token(Token = "0x40229D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200450C RID: 17676
		[Token(Token = "0x200450C")]
		private class DifficultyAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0601AF7E RID: 110462 RVA: 0x000A3BF0 File Offset: 0x000A1DF0
			[Token(Token = "0x17004005")]
			public override int count
			{
				[Token(Token = "0x601AF7E")]
				[Address(RVA = "0x1416F30", Offset = "0x1415B30", VA = "0x181416F30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF7F RID: 110463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF7F")]
			[Address(RVA = "0x1416D30", Offset = "0x1415930", VA = "0x181416D30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF80 RID: 110464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF80")]
			[Address(RVA = "0x1416ED0", Offset = "0x1415AD0", VA = "0x181416ED0")]
			public DifficultyAdapter()
			{
			}

			// Token: 0x040229D9 RID: 141785
			[Token(Token = "0x40229D9")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x040229DA RID: 141786
			[Token(Token = "0x40229DA")]
			[FieldOffset(Offset = "0x28")]
			public List<RoguelikeCommonOuterBuffSummaryDifficultyItemModel> datas;

			// Token: 0x040229DB RID: 141787
			[Token(Token = "0x40229DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040229DC RID: 141788
			[Token(Token = "0x40229DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040229DD RID: 141789
			[Token(Token = "0x40229DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
