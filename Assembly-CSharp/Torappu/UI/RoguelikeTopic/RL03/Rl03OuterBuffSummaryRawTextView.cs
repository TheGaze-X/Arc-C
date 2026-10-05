using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E0 RID: 17888
	[Token(Token = "0x20045E0")]
	public class Rl03OuterBuffSummaryRawTextView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B332 RID: 111410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B332")]
		[Address(RVA = "0x1469ED0", Offset = "0x1468AD0", VA = "0x181469ED0")]
		public void Render(string topicId, List<Rl03OuterBuffSummaryRawTextGroupItemModel> viewModels, bool firstLineHasBack)
		{
		}

		// Token: 0x0601B333 RID: 111411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B333")]
		[Address(RVA = "0x146A110", Offset = "0x1468D10", VA = "0x18146A110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B334 RID: 111412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B334")]
		[Address(RVA = "0x146A260", Offset = "0x1468E60", VA = "0x18146A260")]
		public Rl03OuterBuffSummaryRawTextView()
		{
		}

		// Token: 0x040230E9 RID: 143593
		[Token(Token = "0x40230E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040230EA RID: 143594
		[Token(Token = "0x40230EA")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040230EB RID: 143595
		[Token(Token = "0x40230EB")]
		[FieldOffset(Offset = "0x28")]
		private Rl03OuterBuffSummaryRawTextView.RawTextAdapter m_adapter;

		// Token: 0x040230EC RID: 143596
		[Token(Token = "0x40230EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230ED RID: 143597
		[Token(Token = "0x40230ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040230EE RID: 143598
		[Token(Token = "0x40230EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045E1 RID: 17889
		[Token(Token = "0x20045E1")]
		private class RawTextAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040C9 RID: 16585
			// (get) Token: 0x0601B335 RID: 111413 RVA: 0x000A49A0 File Offset: 0x000A2BA0
			[Token(Token = "0x170040C9")]
			public override int count
			{
				[Token(Token = "0x601B335")]
				[Address(RVA = "0x14668F0", Offset = "0x14654F0", VA = "0x1814668F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B336 RID: 111414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B336")]
			[Address(RVA = "0x1466620", Offset = "0x1465220", VA = "0x181466620", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B337 RID: 111415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B337")]
			[Address(RVA = "0x1466890", Offset = "0x1465490", VA = "0x181466890")]
			public RawTextAdapter()
			{
			}

			// Token: 0x040230EF RID: 143599
			[Token(Token = "0x40230EF")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x040230F0 RID: 143600
			[Token(Token = "0x40230F0")]
			[FieldOffset(Offset = "0x28")]
			public bool firstLineHasBack;

			// Token: 0x040230F1 RID: 143601
			[Token(Token = "0x40230F1")]
			[FieldOffset(Offset = "0x30")]
			public List<Rl03OuterBuffSummaryRawTextGroupItemModel> datas;

			// Token: 0x040230F2 RID: 143602
			[Token(Token = "0x40230F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040230F3 RID: 143603
			[Token(Token = "0x40230F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040230F4 RID: 143604
			[Token(Token = "0x40230F4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
