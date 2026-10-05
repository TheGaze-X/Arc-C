using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using Torappu.UI.Mission;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200716E RID: 29038
	[Token(Token = "0x200716E")]
	public class Act9D0MissionGroupAdapter : RecycleLoopScrollAdapter<MissionObjViewHolder, MissionViewModel>, IHotfixable
	{
		// Token: 0x06029397 RID: 168855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029397")]
		[Address(RVA = "0x2498370", Offset = "0x2496F70", VA = "0x182498370", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06029398 RID: 168856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029398")]
		[Address(RVA = "0x24981E0", Offset = "0x2496DE0", VA = "0x1824981E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MissionObjViewHolder holder, MissionViewModel data)
		{
		}

		// Token: 0x06029399 RID: 168857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029399")]
		[Address(RVA = "0x2498420", Offset = "0x2497020", VA = "0x182498420")]
		public Act9D0MissionGroupAdapter()
		{
		}

		// Token: 0x0403ADD6 RID: 241110
		[Token(Token = "0x403ADD6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _missionObjPrefab;

		// Token: 0x0403ADD7 RID: 241111
		[Token(Token = "0x403ADD7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _onMissionObjClicked;

		// Token: 0x0403ADD8 RID: 241112
		[Token(Token = "0x403ADD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403ADD9 RID: 241113
		[Token(Token = "0x403ADD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403ADDA RID: 241114
		[Token(Token = "0x403ADDA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
