using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EFE RID: 20222
	[Token(Token = "0x2004EFE")]
	public class FifthAnnivExploreMissionGroupAdapter : RecycleLoopScrollAdapter<MissionObjViewHolder, FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel>, IHotfixable
	{
		// Token: 0x0601E269 RID: 123497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E269")]
		[Address(RVA = "0x17D4F70", Offset = "0x17D3B70", VA = "0x1817D4F70", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601E26A RID: 123498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E26A")]
		[Address(RVA = "0x17D4C20", Offset = "0x17D3820", VA = "0x1817D4C20", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MissionObjViewHolder holder, FifthAnnivExploreMissionViewModel.MissionObjHolderViewModel data)
		{
		}

		// Token: 0x0601E26B RID: 123499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E26B")]
		[Address(RVA = "0x17D5020", Offset = "0x17D3C20", VA = "0x1817D5020")]
		public FifthAnnivExploreMissionGroupAdapter()
		{
		}

		// Token: 0x0402822C RID: 164396
		[Token(Token = "0x402822C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _missionObjHolderPrefab;

		// Token: 0x0402822D RID: 164397
		[Token(Token = "0x402822D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _onMissionObjClicked;

		// Token: 0x0402822E RID: 164398
		[Token(Token = "0x402822E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStringEvent _onCollectAllBtnClicked;

		// Token: 0x0402822F RID: 164399
		[Token(Token = "0x402822F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04028230 RID: 164400
		[Token(Token = "0x4028230")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04028231 RID: 164401
		[Token(Token = "0x4028231")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
