using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045D9 RID: 17881
	[Token(Token = "0x20045D9")]
	public class Rl03OuterBuffSummaryMergeGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B320 RID: 111392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B320")]
		[Address(RVA = "0x1468D00", Offset = "0x1467900", VA = "0x181468D00")]
		public void Render(string topicId, Rl03OuterBuffSummaryMergedItemModel leftModel, Rl03OuterBuffSummaryMergedItemModel rightModel, bool hasBack)
		{
		}

		// Token: 0x0601B321 RID: 111393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B321")]
		[Address(RVA = "0x1468E80", Offset = "0x1467A80", VA = "0x181468E80")]
		public Rl03OuterBuffSummaryMergeGroupView()
		{
		}

		// Token: 0x040230BB RID: 143547
		[Token(Token = "0x40230BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rl03OuterBuffSummaryMergeItemView _leftItem;

		// Token: 0x040230BC RID: 143548
		[Token(Token = "0x40230BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rl03OuterBuffSummaryMergeItemView _rightItem;

		// Token: 0x040230BD RID: 143549
		[Token(Token = "0x40230BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLeft;

		// Token: 0x040230BE RID: 143550
		[Token(Token = "0x40230BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRight;

		// Token: 0x040230BF RID: 143551
		[Token(Token = "0x40230BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _back;

		// Token: 0x040230C0 RID: 143552
		[Token(Token = "0x40230C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230C1 RID: 143553
		[Token(Token = "0x40230C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
