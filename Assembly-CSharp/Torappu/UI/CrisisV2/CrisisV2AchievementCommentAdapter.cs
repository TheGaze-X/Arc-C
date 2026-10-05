using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005989 RID: 22921
	[Token(Token = "0x2005989")]
	public class CrisisV2AchievementCommentAdapter : LoopScrollAdapter<CrisisV2AchievementCommentViewHolder, CrisisV2AchievementCommentViewModel>, IHotfixable
	{
		// Token: 0x060216B5 RID: 136885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B5")]
		[Address(RVA = "0x1BBBB90", Offset = "0x1BBA790", VA = "0x181BBBB90", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, CrisisV2AchievementCommentViewHolder holder, CrisisV2AchievementCommentViewModel data)
		{
		}

		// Token: 0x060216B6 RID: 136886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60216B6")]
		[Address(RVA = "0x1BBBAE0", Offset = "0x1BBA6E0", VA = "0x181BBBAE0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060216B7 RID: 136887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B7")]
		[Address(RVA = "0x1BBBD50", Offset = "0x1BBA950", VA = "0x181BBBD50")]
		public CrisisV2AchievementCommentAdapter()
		{
		}

		// Token: 0x0402D959 RID: 186713
		[Token(Token = "0x402D959")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402D95A RID: 186714
		[Token(Token = "0x402D95A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402D95B RID: 186715
		[Token(Token = "0x402D95B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402D95C RID: 186716
		[Token(Token = "0x402D95C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
