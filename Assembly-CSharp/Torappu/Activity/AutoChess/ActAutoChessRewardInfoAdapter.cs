using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200712D RID: 28973
	[Token(Token = "0x200712D")]
	public class ActAutoChessRewardInfoAdapter : LoopScrollAdapter<ActAutoChessRewardInfoAdapter.ViewHolder, ActAutoChessSingleRoundRewardModel>, IHotfixable
	{
		// Token: 0x0602924B RID: 168523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602924B")]
		[Address(RVA = "0x248BF30", Offset = "0x248AB30", VA = "0x18248BF30", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602924C RID: 168524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602924C")]
		[Address(RVA = "0x248BFE0", Offset = "0x248ABE0", VA = "0x18248BFE0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActAutoChessRewardInfoAdapter.ViewHolder holder, ActAutoChessSingleRoundRewardModel data)
		{
		}

		// Token: 0x0602924D RID: 168525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602924D")]
		[Address(RVA = "0x248C250", Offset = "0x248AE50", VA = "0x18248C250")]
		public ActAutoChessRewardInfoAdapter()
		{
		}

		// Token: 0x0403AC21 RID: 240673
		[Token(Token = "0x403AC21")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0403AC22 RID: 240674
		[Token(Token = "0x403AC22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403AC23 RID: 240675
		[Token(Token = "0x403AC23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403AC24 RID: 240676
		[Token(Token = "0x403AC24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200712E RID: 28974
		[Token(Token = "0x200712E")]
		public class ViewHolder
		{
			// Token: 0x0602924E RID: 168526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602924E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403AC25 RID: 240677
			[Token(Token = "0x403AC25")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessRewardInfoItemView view;
		}
	}
}
