using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF2 RID: 31474
	[Token(Token = "0x2007AF2")]
	public class Act12D6MileStoneGridAdapter : RecycleLoopScrollAdapter<MileStoneItemHolder, Act12D6MileStoneViewModel>, IHotfixable
	{
		// Token: 0x0602C136 RID: 180534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C136")]
		[Address(RVA = "0x27F2AC0", Offset = "0x27F16C0", VA = "0x1827F2AC0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602C137 RID: 180535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C137")]
		[Address(RVA = "0x27F2980", Offset = "0x27F1580", VA = "0x1827F2980", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MileStoneItemHolder holder, Act12D6MileStoneViewModel data)
		{
		}

		// Token: 0x0602C138 RID: 180536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C138")]
		[Address(RVA = "0x27F2BD0", Offset = "0x27F17D0", VA = "0x1827F2BD0")]
		public Act12D6MileStoneGridAdapter()
		{
		}

		// Token: 0x0403FDE9 RID: 261609
		[Token(Token = "0x403FDE9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _itemEvent;

		// Token: 0x0403FDEA RID: 261610
		[Token(Token = "0x403FDEA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _mileStoneItem;

		// Token: 0x0403FDEB RID: 261611
		[Token(Token = "0x403FDEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403FDEC RID: 261612
		[Token(Token = "0x403FDEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403FDED RID: 261613
		[Token(Token = "0x403FDED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
