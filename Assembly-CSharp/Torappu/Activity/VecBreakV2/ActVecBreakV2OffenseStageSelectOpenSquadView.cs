using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E53 RID: 28243
	[Token(Token = "0x2006E53")]
	public class ActVecBreakV2OffenseStageSelectOpenSquadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028321 RID: 164641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028321")]
		[Address(RVA = "0x2379FF0", Offset = "0x2378BF0", VA = "0x182379FF0")]
		public void Render(VecBreakV2OffenseStageModelBase stageModel)
		{
		}

		// Token: 0x06028322 RID: 164642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028322")]
		[Address(RVA = "0x237A1C0", Offset = "0x2378DC0", VA = "0x18237A1C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028323 RID: 164643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028323")]
		[Address(RVA = "0x237A290", Offset = "0x2378E90", VA = "0x18237A290")]
		public ActVecBreakV2OffenseStageSelectOpenSquadView()
		{
		}

		// Token: 0x04039181 RID: 233857
		[Token(Token = "0x4039181")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rewardHintRoot;

		// Token: 0x04039182 RID: 233858
		[Token(Token = "0x4039182")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActVecBreakV2RewardHintView _rewardHintPrefab;

		// Token: 0x04039183 RID: 233859
		[Token(Token = "0x4039183")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x04039184 RID: 233860
		[Token(Token = "0x4039184")]
		[FieldOffset(Offset = "0x30")]
		private ActVecBreakV2RewardHintView m_rewardHintView;

		// Token: 0x04039185 RID: 233861
		[Token(Token = "0x4039185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039186 RID: 233862
		[Token(Token = "0x4039186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039187 RID: 233863
		[Token(Token = "0x4039187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
