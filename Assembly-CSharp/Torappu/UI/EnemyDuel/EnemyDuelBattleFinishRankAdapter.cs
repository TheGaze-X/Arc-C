using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F4B RID: 20299
	[Token(Token = "0x2004F4B")]
	public class EnemyDuelBattleFinishRankAdapter : LoopScrollAdapter<DuelRankItemHolder, SettlementRankItemModel>
	{
		// Token: 0x0601E399 RID: 123801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E399")]
		[Address(RVA = "0x17E11B0", Offset = "0x17DFDB0", VA = "0x1817E11B0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601E39A RID: 123802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E39A")]
		[Address(RVA = "0x17E1260", Offset = "0x17DFE60", VA = "0x1817E1260", Slot = "13")]
		public override void UpdateView(int position, GameObject view, DuelRankItemHolder holder, SettlementRankItemModel data)
		{
		}

		// Token: 0x0601E39B RID: 123803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E39B")]
		[Address(RVA = "0x17E1420", Offset = "0x17E0020", VA = "0x1817E1420")]
		public EnemyDuelBattleFinishRankAdapter()
		{
		}

		// Token: 0x040284AF RID: 165039
		[Token(Token = "0x40284AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x040284B0 RID: 165040
		[Token(Token = "0x40284B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040284B1 RID: 165041
		[Token(Token = "0x40284B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040284B2 RID: 165042
		[Token(Token = "0x40284B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
