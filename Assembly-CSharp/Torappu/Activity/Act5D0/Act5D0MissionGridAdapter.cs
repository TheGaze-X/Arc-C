using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071F5 RID: 29173
	[Token(Token = "0x20071F5")]
	public class Act5D0MissionGridAdapter : RecycleLoopScrollAdapter<MissionItemHolder, Act5D0MissionViewModel>, IHotfixable
	{
		// Token: 0x06029611 RID: 169489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029611")]
		[Address(RVA = "0x24C24B0", Offset = "0x24C10B0", VA = "0x1824C24B0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06029612 RID: 169490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029612")]
		[Address(RVA = "0x24C2320", Offset = "0x24C0F20", VA = "0x1824C2320", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MissionItemHolder holder, Act5D0MissionViewModel data)
		{
		}

		// Token: 0x06029613 RID: 169491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029613")]
		[Address(RVA = "0x24C25C0", Offset = "0x24C11C0", VA = "0x1824C25C0")]
		public Act5D0MissionGridAdapter()
		{
		}

		// Token: 0x0403B19A RID: 242074
		[Token(Token = "0x403B19A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _itemEvent;

		// Token: 0x0403B19B RID: 242075
		[Token(Token = "0x403B19B")]
		[FieldOffset(Offset = "0x70")]
		public GameObject _missionItem;

		// Token: 0x0403B19C RID: 242076
		[Token(Token = "0x403B19C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403B19D RID: 242077
		[Token(Token = "0x403B19D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403B19E RID: 242078
		[Token(Token = "0x403B19E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
