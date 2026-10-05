using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053DB RID: 21467
	[Token(Token = "0x20053DB")]
	public class RoguelikeRewardEntryPopListAdapter : RecycleLoopScrollAdapter<RoguelikeRewardEntryPopItemHolder, RoguelikeRewardsPopInfo>
	{
		// Token: 0x0601F96B RID: 129387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F96B")]
		[Address(RVA = "0x193A760", Offset = "0x1939360", VA = "0x18193A760", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeRewardEntryPopItemHolder holder, RoguelikeRewardsPopInfo data)
		{
		}

		// Token: 0x0601F96C RID: 129388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F96C")]
		[Address(RVA = "0x193A880", Offset = "0x1939480", VA = "0x18193A880", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601F96D RID: 129389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F96D")]
		[Address(RVA = "0x193A930", Offset = "0x1939530", VA = "0x18193A930")]
		public RoguelikeRewardEntryPopListAdapter()
		{
		}

		// Token: 0x0402A885 RID: 174213
		[Token(Token = "0x402A885")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402A886 RID: 174214
		[Token(Token = "0x402A886")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402A887 RID: 174215
		[Token(Token = "0x402A887")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402A888 RID: 174216
		[Token(Token = "0x402A888")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
