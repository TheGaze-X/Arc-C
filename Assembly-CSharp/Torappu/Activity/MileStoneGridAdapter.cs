using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D84 RID: 28036
	[Token(Token = "0x2006D84")]
	public class MileStoneGridAdapter : RecycleLoopScrollAdapter<MileStoneItemHolder, MileStoneViewModel>, IHotfixable
	{
		// Token: 0x06027EFE RID: 163582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EFE")]
		[Address(RVA = "0x23418F0", Offset = "0x23404F0", VA = "0x1823418F0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06027EFF RID: 163583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EFF")]
		[Address(RVA = "0x2341790", Offset = "0x2340390", VA = "0x182341790", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MileStoneItemHolder holder, MileStoneViewModel data)
		{
		}

		// Token: 0x06027F00 RID: 163584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F00")]
		[Address(RVA = "0x2341A00", Offset = "0x2340600", VA = "0x182341A00")]
		public MileStoneGridAdapter()
		{
		}

		// Token: 0x040389AF RID: 231855
		[Token(Token = "0x40389AF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _itemEvent;

		// Token: 0x040389B0 RID: 231856
		[Token(Token = "0x40389B0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _mileStoneItem;

		// Token: 0x040389B1 RID: 231857
		[Token(Token = "0x40389B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040389B2 RID: 231858
		[Token(Token = "0x40389B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040389B3 RID: 231859
		[Token(Token = "0x40389B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
