using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF9 RID: 31481
	[Token(Token = "0x2007AF9")]
	public class Act12D6RelicHandBookGridAdapter : RecycleLoopScrollAdapter<RelicObjViewHolder, PlayerRelicHandBookData>, IHotfixable
	{
		// Token: 0x0602C151 RID: 180561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C151")]
		[Address(RVA = "0x27F5A10", Offset = "0x27F4610", VA = "0x1827F5A10", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RelicObjViewHolder holder, PlayerRelicHandBookData data)
		{
		}

		// Token: 0x0602C152 RID: 180562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C152")]
		[Address(RVA = "0x27F5B70", Offset = "0x27F4770", VA = "0x1827F5B70", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602C153 RID: 180563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C153")]
		[Address(RVA = "0x27F5C20", Offset = "0x27F4820", VA = "0x1827F5C20")]
		public Act12D6RelicHandBookGridAdapter()
		{
		}

		// Token: 0x0403FE25 RID: 261669
		[Token(Token = "0x403FE25")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _relickObj;

		// Token: 0x0403FE26 RID: 261670
		[Token(Token = "0x403FE26")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _onRelicClicked;

		// Token: 0x0403FE27 RID: 261671
		[Token(Token = "0x403FE27")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public string chosenRelic;

		// Token: 0x0403FE28 RID: 261672
		[Token(Token = "0x403FE28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403FE29 RID: 261673
		[Token(Token = "0x403FE29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403FE2A RID: 261674
		[Token(Token = "0x403FE2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
