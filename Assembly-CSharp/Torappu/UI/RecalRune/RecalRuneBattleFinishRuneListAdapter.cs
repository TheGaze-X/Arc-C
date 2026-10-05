using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047A2 RID: 18338
	[Token(Token = "0x20047A2")]
	public class RecalRuneBattleFinishRuneListAdapter : LoopScrollAdapter<RecalRuneBattleFinishRuneViewHolder, RecalRuneBattleFinishView.RuneItem>
	{
		// Token: 0x0601BC66 RID: 113766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC66")]
		[Address(RVA = "0x152B650", Offset = "0x152A250", VA = "0x18152B650", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RecalRuneBattleFinishRuneViewHolder holder, RecalRuneBattleFinishView.RuneItem data)
		{
		}

		// Token: 0x0601BC67 RID: 113767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BC67")]
		[Address(RVA = "0x152B590", Offset = "0x152A190", VA = "0x18152B590", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601BC68 RID: 113768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC68")]
		[Address(RVA = "0x152B8D0", Offset = "0x152A4D0", VA = "0x18152B8D0")]
		public RecalRuneBattleFinishRuneListAdapter()
		{
		}

		// Token: 0x040241A0 RID: 147872
		[Token(Token = "0x40241A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RecalRuneBattleFinishRuneView _itemPrefab;

		// Token: 0x040241A1 RID: 147873
		[Token(Token = "0x40241A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040241A2 RID: 147874
		[Token(Token = "0x40241A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040241A3 RID: 147875
		[Token(Token = "0x40241A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
