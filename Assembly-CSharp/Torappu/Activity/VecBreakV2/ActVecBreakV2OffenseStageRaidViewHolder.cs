using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E5F RID: 28255
	[Token(Token = "0x2006E5F")]
	public class ActVecBreakV2OffenseStageRaidViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028360 RID: 164704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028360")]
		[Address(RVA = "0x2378D70", Offset = "0x2377970", VA = "0x182378D70")]
		public void Render(List<VecBreakV2OffenseRaidStageModel> stageList, int selectedIdx)
		{
		}

		// Token: 0x06028361 RID: 164705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028361")]
		[Address(RVA = "0x2379150", Offset = "0x2377D50", VA = "0x182379150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028362 RID: 164706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028362")]
		[Address(RVA = "0x2379050", Offset = "0x2377C50", VA = "0x182379050")]
		private VecBreakV2OffenseRaidStageModel _FindStageModel(List<VecBreakV2OffenseRaidStageModel> stageList, out int stageIdx)
		{
			return null;
		}

		// Token: 0x06028363 RID: 164707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028363")]
		[Address(RVA = "0x2379220", Offset = "0x2377E20", VA = "0x182379220")]
		public ActVecBreakV2OffenseStageRaidViewHolder()
		{
		}

		// Token: 0x04039236 RID: 234038
		[Token(Token = "0x4039236")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActVecBreakV2StageOrderType _orderType;

		// Token: 0x04039237 RID: 234039
		[Token(Token = "0x4039237")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _stageRaidViewRoot;

		// Token: 0x04039238 RID: 234040
		[Token(Token = "0x4039238")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActVecBreakV2OffenseStageRaidView _stageRaidPrefab;

		// Token: 0x04039239 RID: 234041
		[Token(Token = "0x4039239")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completedPart;

		// Token: 0x0403923A RID: 234042
		[Token(Token = "0x403923A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _inProgressPart;

		// Token: 0x0403923B RID: 234043
		[Token(Token = "0x403923B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0403923C RID: 234044
		[Token(Token = "0x403923C")]
		[FieldOffset(Offset = "0x48")]
		private ActVecBreakV2OffenseStageRaidView m_stageRaidView;

		// Token: 0x0403923D RID: 234045
		[Token(Token = "0x403923D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403923E RID: 234046
		[Token(Token = "0x403923E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403923F RID: 234047
		[Token(Token = "0x403923F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FindStageModel;

		// Token: 0x04039240 RID: 234048
		[Token(Token = "0x4039240")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
