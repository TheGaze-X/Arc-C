using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200598F RID: 22927
	[Token(Token = "0x200598F")]
	public class CrisisV2AchievementRuneAdapter : LoopScrollAdapter<CrisisV2AchievementRuneViewHolder, CrisisV2AchievementRuneViewModel>, IHotfixable
	{
		// Token: 0x060216C3 RID: 136899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216C3")]
		[Address(RVA = "0x1BBC410", Offset = "0x1BBB010", VA = "0x181BBC410", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, CrisisV2AchievementRuneViewHolder holder, CrisisV2AchievementRuneViewModel data)
		{
		}

		// Token: 0x060216C4 RID: 136900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60216C4")]
		[Address(RVA = "0x1BBC360", Offset = "0x1BBAF60", VA = "0x181BBC360", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060216C5 RID: 136901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216C5")]
		[Address(RVA = "0x1BBC640", Offset = "0x1BBB240", VA = "0x181BBC640")]
		public CrisisV2AchievementRuneAdapter()
		{
		}

		// Token: 0x0402D971 RID: 186737
		[Token(Token = "0x402D971")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402D972 RID: 186738
		[Token(Token = "0x402D972")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402D973 RID: 186739
		[Token(Token = "0x402D973")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402D974 RID: 186740
		[Token(Token = "0x402D974")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
