using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045DB RID: 17883
	[Token(Token = "0x20045DB")]
	public class Rl03OuterBuffSummaryMergeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B324 RID: 111396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B324")]
		[Address(RVA = "0x14690F0", Offset = "0x1467CF0", VA = "0x1814690F0")]
		public void Render(string topicId, List<Rl03OuterBuffSummaryMergedItemModel> viewModels, bool firstLineHasBack)
		{
		}

		// Token: 0x0601B325 RID: 111397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B325")]
		[Address(RVA = "0x1469330", Offset = "0x1467F30", VA = "0x181469330")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B326 RID: 111398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B326")]
		[Address(RVA = "0x1469480", Offset = "0x1468080", VA = "0x181469480")]
		public Rl03OuterBuffSummaryMergeView()
		{
		}

		// Token: 0x040230CA RID: 143562
		[Token(Token = "0x40230CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040230CB RID: 143563
		[Token(Token = "0x40230CB")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040230CC RID: 143564
		[Token(Token = "0x40230CC")]
		[FieldOffset(Offset = "0x28")]
		private Rl03OuterBuffSummaryMergeView.MergeAdapter m_adapter;

		// Token: 0x040230CD RID: 143565
		[Token(Token = "0x40230CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230CE RID: 143566
		[Token(Token = "0x40230CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040230CF RID: 143567
		[Token(Token = "0x40230CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045DC RID: 17884
		[Token(Token = "0x20045DC")]
		private class MergeAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040C7 RID: 16583
			// (get) Token: 0x0601B327 RID: 111399 RVA: 0x000A4970 File Offset: 0x000A2B70
			[Token(Token = "0x170040C7")]
			public override int count
			{
				[Token(Token = "0x601B327")]
				[Address(RVA = "0x145CCE0", Offset = "0x145B8E0", VA = "0x18145CCE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B328 RID: 111400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B328")]
			[Address(RVA = "0x145C980", Offset = "0x145B580", VA = "0x18145C980", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B329 RID: 111401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B329")]
			[Address(RVA = "0x145CC80", Offset = "0x145B880", VA = "0x18145CC80")]
			public MergeAdapter()
			{
			}

			// Token: 0x040230D0 RID: 143568
			[Token(Token = "0x40230D0")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x040230D1 RID: 143569
			[Token(Token = "0x40230D1")]
			[FieldOffset(Offset = "0x28")]
			public bool firstLineHasBack;

			// Token: 0x040230D2 RID: 143570
			[Token(Token = "0x40230D2")]
			[FieldOffset(Offset = "0x30")]
			public List<Rl03OuterBuffSummaryMergedItemModel> datas;

			// Token: 0x040230D3 RID: 143571
			[Token(Token = "0x40230D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040230D4 RID: 143572
			[Token(Token = "0x40230D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040230D5 RID: 143573
			[Token(Token = "0x40230D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
