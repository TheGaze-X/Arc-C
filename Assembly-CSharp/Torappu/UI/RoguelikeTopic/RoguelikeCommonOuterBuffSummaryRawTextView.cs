using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004514 RID: 17684
	[Token(Token = "0x2004514")]
	public class RoguelikeCommonOuterBuffSummaryRawTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF93 RID: 110483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF93")]
		[Address(RVA = "0x1422A40", Offset = "0x1421640", VA = "0x181422A40")]
		public void Render(string topicId, List<RoguelikeCommonOuterBuffSummaryRawTextGroupItemModel> viewModels, bool firstLineHasBack)
		{
		}

		// Token: 0x0601AF94 RID: 110484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF94")]
		[Address(RVA = "0x1422C80", Offset = "0x1421880", VA = "0x181422C80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF95 RID: 110485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF95")]
		[Address(RVA = "0x1422DD0", Offset = "0x14219D0", VA = "0x181422DD0")]
		public RoguelikeCommonOuterBuffSummaryRawTextView()
		{
		}

		// Token: 0x04022A0E RID: 141838
		[Token(Token = "0x4022A0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04022A0F RID: 141839
		[Token(Token = "0x4022A0F")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x04022A10 RID: 141840
		[Token(Token = "0x4022A10")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeCommonOuterBuffSummaryRawTextView.RawTextAdapter m_adapter;

		// Token: 0x04022A11 RID: 141841
		[Token(Token = "0x4022A11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022A12 RID: 141842
		[Token(Token = "0x4022A12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022A13 RID: 141843
		[Token(Token = "0x4022A13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004515 RID: 17685
		[Token(Token = "0x2004515")]
		private class RawTextAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004008 RID: 16392
			// (get) Token: 0x0601AF96 RID: 110486 RVA: 0x000A3C38 File Offset: 0x000A1E38
			[Token(Token = "0x17004008")]
			public override int count
			{
				[Token(Token = "0x601AF96")]
				[Address(RVA = "0x1418710", Offset = "0x1417310", VA = "0x181418710", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF97 RID: 110487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF97")]
			[Address(RVA = "0x1418440", Offset = "0x1417040", VA = "0x181418440", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF98 RID: 110488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF98")]
			[Address(RVA = "0x1418650", Offset = "0x1417250", VA = "0x181418650")]
			public RawTextAdapter()
			{
			}

			// Token: 0x04022A14 RID: 141844
			[Token(Token = "0x4022A14")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x04022A15 RID: 141845
			[Token(Token = "0x4022A15")]
			[FieldOffset(Offset = "0x28")]
			public bool firstLineHasBack;

			// Token: 0x04022A16 RID: 141846
			[Token(Token = "0x4022A16")]
			[FieldOffset(Offset = "0x30")]
			public List<RoguelikeCommonOuterBuffSummaryRawTextGroupItemModel> datas;

			// Token: 0x04022A17 RID: 141847
			[Token(Token = "0x4022A17")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022A18 RID: 141848
			[Token(Token = "0x4022A18")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04022A19 RID: 141849
			[Token(Token = "0x4022A19")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
