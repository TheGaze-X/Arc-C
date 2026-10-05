using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007287 RID: 29319
	[Token(Token = "0x2007287")]
	public class Act4D0MileStoneGridAdapter : RecycleLoopScrollAdapter<MileStoneItemHolder, Act4D0MileStoneViewModel>, IHotfixable
	{
		// Token: 0x06029864 RID: 170084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029864")]
		[Address(RVA = "0x24DCAA0", Offset = "0x24DB6A0", VA = "0x1824DCAA0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06029865 RID: 170085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029865")]
		[Address(RVA = "0x24DC870", Offset = "0x24DB470", VA = "0x1824DC870", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MileStoneItemHolder holder, Act4D0MileStoneViewModel data)
		{
		}

		// Token: 0x06029866 RID: 170086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029866")]
		[Address(RVA = "0x24DCBB0", Offset = "0x24DB7B0", VA = "0x1824DCBB0")]
		public Act4D0MileStoneGridAdapter()
		{
		}

		// Token: 0x0403B54A RID: 243018
		[Token(Token = "0x403B54A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _storyEvent;

		// Token: 0x0403B54B RID: 243019
		[Token(Token = "0x403B54B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _itemEvent;

		// Token: 0x0403B54C RID: 243020
		[Token(Token = "0x403B54C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _mileStoneItem;

		// Token: 0x0403B54D RID: 243021
		[Token(Token = "0x403B54D")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public string focusCharId;

		// Token: 0x0403B54E RID: 243022
		[Token(Token = "0x403B54E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403B54F RID: 243023
		[Token(Token = "0x403B54F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403B550 RID: 243024
		[Token(Token = "0x403B550")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
