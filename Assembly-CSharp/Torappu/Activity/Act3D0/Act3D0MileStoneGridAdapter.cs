using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007407 RID: 29703
	[Token(Token = "0x2007407")]
	public class Act3D0MileStoneGridAdapter : RecycleLoopScrollAdapter<MileStoneItemHolder, Act3D0MileStoneViewModel>, IHotfixable
	{
		// Token: 0x06029F29 RID: 171817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029F29")]
		[Address(RVA = "0x258E2F0", Offset = "0x258CEF0", VA = "0x18258E2F0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06029F2A RID: 171818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F2A")]
		[Address(RVA = "0x258E1B0", Offset = "0x258CDB0", VA = "0x18258E1B0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MileStoneItemHolder holder, Act3D0MileStoneViewModel data)
		{
		}

		// Token: 0x06029F2B RID: 171819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F2B")]
		[Address(RVA = "0x258E400", Offset = "0x258D000", VA = "0x18258E400")]
		public Act3D0MileStoneGridAdapter()
		{
		}

		// Token: 0x0403C1F1 RID: 246257
		[Token(Token = "0x403C1F1")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x0403C1F2 RID: 246258
		[Token(Token = "0x403C1F2")]
		[FieldOffset(Offset = "0x70")]
		public GameObject _mileStoneItem;

		// Token: 0x0403C1F3 RID: 246259
		[Token(Token = "0x403C1F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403C1F4 RID: 246260
		[Token(Token = "0x403C1F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403C1F5 RID: 246261
		[Token(Token = "0x403C1F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
