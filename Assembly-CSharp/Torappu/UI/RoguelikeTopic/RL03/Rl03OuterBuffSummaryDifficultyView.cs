using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045D7 RID: 17879
	[Token(Token = "0x20045D7")]
	public class Rl03OuterBuffSummaryDifficultyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B31A RID: 111386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B31A")]
		[Address(RVA = "0x1468930", Offset = "0x1467530", VA = "0x181468930")]
		public void Render(string topicId, List<Rl03OuterBuffSummaryDifficultyItemModel> viewModels)
		{
		}

		// Token: 0x0601B31B RID: 111387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B31B")]
		[Address(RVA = "0x1468B50", Offset = "0x1467750", VA = "0x181468B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B31C RID: 111388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B31C")]
		[Address(RVA = "0x1468CA0", Offset = "0x14678A0", VA = "0x181468CA0")]
		public Rl03OuterBuffSummaryDifficultyView()
		{
		}

		// Token: 0x040230B0 RID: 143536
		[Token(Token = "0x40230B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040230B1 RID: 143537
		[Token(Token = "0x40230B1")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x040230B2 RID: 143538
		[Token(Token = "0x40230B2")]
		[FieldOffset(Offset = "0x28")]
		private Rl03OuterBuffSummaryDifficultyView.DifficultyAdapter m_adapter;

		// Token: 0x040230B3 RID: 143539
		[Token(Token = "0x40230B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230B4 RID: 143540
		[Token(Token = "0x40230B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040230B5 RID: 143541
		[Token(Token = "0x40230B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045D8 RID: 17880
		[Token(Token = "0x20045D8")]
		private class DifficultyAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040C6 RID: 16582
			// (get) Token: 0x0601B31D RID: 111389 RVA: 0x000A4958 File Offset: 0x000A2B58
			[Token(Token = "0x170040C6")]
			public override int count
			{
				[Token(Token = "0x601B31D")]
				[Address(RVA = "0x145ADC0", Offset = "0x14599C0", VA = "0x18145ADC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B31E RID: 111390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B31E")]
			[Address(RVA = "0x145ABC0", Offset = "0x14597C0", VA = "0x18145ABC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B31F RID: 111391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B31F")]
			[Address(RVA = "0x145AD60", Offset = "0x1459960", VA = "0x18145AD60")]
			public DifficultyAdapter()
			{
			}

			// Token: 0x040230B6 RID: 143542
			[Token(Token = "0x40230B6")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x040230B7 RID: 143543
			[Token(Token = "0x40230B7")]
			[FieldOffset(Offset = "0x28")]
			public List<Rl03OuterBuffSummaryDifficultyItemModel> datas;

			// Token: 0x040230B8 RID: 143544
			[Token(Token = "0x40230B8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040230B9 RID: 143545
			[Token(Token = "0x40230B9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040230BA RID: 143546
			[Token(Token = "0x40230BA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
