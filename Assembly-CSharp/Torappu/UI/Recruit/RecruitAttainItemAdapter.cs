using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200473B RID: 18235
	[Token(Token = "0x200473B")]
	public class RecruitAttainItemAdapter : RecycleLoopScrollAdapter<RecruitAttainItemViewHolder, string>
	{
		// Token: 0x0601BA22 RID: 113186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BA22")]
		[Address(RVA = "0x14F4EC0", Offset = "0x14F3AC0", VA = "0x1814F4EC0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601BA23 RID: 113187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA23")]
		[Address(RVA = "0x14F4D70", Offset = "0x14F3970", VA = "0x1814F4D70", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RecruitAttainItemViewHolder holder, string data)
		{
		}

		// Token: 0x0601BA24 RID: 113188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA24")]
		[Address(RVA = "0x14F4F80", Offset = "0x14F3B80", VA = "0x1814F4F80")]
		public RecruitAttainItemAdapter()
		{
		}

		// Token: 0x04023D6C RID: 146796
		[Token(Token = "0x4023D6C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RecruitUpCharDetailPortraitObj _objView;

		// Token: 0x04023D6D RID: 146797
		[Token(Token = "0x4023D6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04023D6E RID: 146798
		[Token(Token = "0x4023D6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04023D6F RID: 146799
		[Token(Token = "0x4023D6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
