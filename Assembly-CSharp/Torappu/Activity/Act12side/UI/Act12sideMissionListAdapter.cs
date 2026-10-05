using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB7 RID: 31415
	[Token(Token = "0x2007AB7")]
	public class Act12sideMissionListAdapter : RecycleLoopScrollAdapter<Act12sideMissionItemHolder, Act12sideMissionItemViewModel>
	{
		// Token: 0x0602C00F RID: 180239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C00F")]
		[Address(RVA = "0x27DFF40", Offset = "0x27DEB40", VA = "0x1827DFF40", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act12sideMissionItemHolder holder, Act12sideMissionItemViewModel data)
		{
		}

		// Token: 0x0602C010 RID: 180240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C010")]
		[Address(RVA = "0x27E0060", Offset = "0x27DEC60", VA = "0x1827E0060", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602C011 RID: 180241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C011")]
		[Address(RVA = "0x27E0110", Offset = "0x27DED10", VA = "0x1827E0110")]
		public Act12sideMissionListAdapter()
		{
		}

		// Token: 0x0403FC22 RID: 261154
		[Token(Token = "0x403FC22")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x0403FC23 RID: 261155
		[Token(Token = "0x403FC23")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0403FC24 RID: 261156
		[Token(Token = "0x403FC24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403FC25 RID: 261157
		[Token(Token = "0x403FC25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403FC26 RID: 261158
		[Token(Token = "0x403FC26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
