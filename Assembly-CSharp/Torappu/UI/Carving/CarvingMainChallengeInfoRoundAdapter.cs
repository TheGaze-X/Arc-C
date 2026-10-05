using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200606C RID: 24684
	[Token(Token = "0x200606C")]
	public class CarvingMainChallengeInfoRoundAdapter : LoopScrollAdapter<CarvingMainChallengeInfoRoundAdapter.ViewHolder, CarvingMainChallengeInfoRoundItemViewModel>
	{
		// Token: 0x06023B1B RID: 146203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B1B")]
		[Address(RVA = "0x1E573C0", Offset = "0x1E55FC0", VA = "0x181E573C0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06023B1C RID: 146204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B1C")]
		[Address(RVA = "0x1E57470", Offset = "0x1E56070", VA = "0x181E57470", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CarvingMainChallengeInfoRoundAdapter.ViewHolder holder, CarvingMainChallengeInfoRoundItemViewModel data)
		{
		}

		// Token: 0x06023B1D RID: 146205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B1D")]
		[Address(RVA = "0x1E575D0", Offset = "0x1E561D0", VA = "0x181E575D0")]
		public CarvingMainChallengeInfoRoundAdapter()
		{
		}

		// Token: 0x04031777 RID: 202615
		[Token(Token = "0x4031777")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _roundObjPrefab;

		// Token: 0x04031778 RID: 202616
		[Token(Token = "0x4031778")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04031779 RID: 202617
		[Token(Token = "0x4031779")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403177A RID: 202618
		[Token(Token = "0x403177A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200606D RID: 24685
		[Token(Token = "0x200606D")]
		public class ViewHolder
		{
			// Token: 0x06023B1E RID: 146206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023B1E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403177B RID: 202619
			[Token(Token = "0x403177B")]
			[FieldOffset(Offset = "0x10")]
			public CarvingMainChallengeInfoRoundItemView view;
		}
	}
}
