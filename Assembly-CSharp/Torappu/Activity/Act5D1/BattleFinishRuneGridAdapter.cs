using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200722A RID: 29226
	[Token(Token = "0x200722A")]
	public class BattleFinishRuneGridAdapter : RecycleLoopScrollAdapter<BattleFinishRuneItemHolder, RuneTable.PackedRuneData>, IHotfixable
	{
		// Token: 0x060296BC RID: 169660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60296BC")]
		[Address(RVA = "0x24D41E0", Offset = "0x24D2DE0", VA = "0x1824D41E0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x060296BD RID: 169661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296BD")]
		[Address(RVA = "0x24D3F90", Offset = "0x24D2B90", VA = "0x1824D3F90", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BattleFinishRuneItemHolder holder, RuneTable.PackedRuneData data)
		{
		}

		// Token: 0x060296BE RID: 169662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296BE")]
		[Address(RVA = "0x24D42F0", Offset = "0x24D2EF0", VA = "0x1824D42F0")]
		public BattleFinishRuneGridAdapter()
		{
		}

		// Token: 0x0403B28E RID: 242318
		[Token(Token = "0x403B28E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _itemEvent;

		// Token: 0x0403B28F RID: 242319
		[Token(Token = "0x403B28F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _item;

		// Token: 0x0403B290 RID: 242320
		[Token(Token = "0x403B290")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403B291 RID: 242321
		[Token(Token = "0x403B291")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403B292 RID: 242322
		[Token(Token = "0x403B292")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
