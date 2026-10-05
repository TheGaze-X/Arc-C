using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004898 RID: 18584
	[Token(Token = "0x2004898")]
	public class MainMissionTaskAdapter : RecycleLoopScrollAdapter<MainMissionTaskHolder, MainMissionTaskDataWrapper>
	{
		// Token: 0x0601C0C1 RID: 114881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0C1")]
		[Address(RVA = "0x1566D40", Offset = "0x1565940", VA = "0x181566D40", Slot = "13")]
		public override void UpdateView(int position, GameObject gameObj, MainMissionTaskHolder holder, MainMissionTaskDataWrapper data)
		{
		}

		// Token: 0x0601C0C2 RID: 114882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C0C2")]
		[Address(RVA = "0x1566E90", Offset = "0x1565A90", VA = "0x181566E90", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601C0C3 RID: 114883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0C3")]
		[Address(RVA = "0x1566FB0", Offset = "0x1565BB0", VA = "0x181566FB0")]
		public MainMissionTaskAdapter()
		{
		}

		// Token: 0x040249E9 RID: 149993
		[Token(Token = "0x40249E9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MainMissionTask _taskPrefab;

		// Token: 0x040249EA RID: 149994
		[Token(Token = "0x40249EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040249EB RID: 149995
		[Token(Token = "0x40249EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040249EC RID: 149996
		[Token(Token = "0x40249EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
