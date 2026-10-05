using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E2E RID: 28206
	[Token(Token = "0x2006E2E")]
	public class ActVecBreakV2EntryHardStageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602824A RID: 164426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602824A")]
		[Address(RVA = "0x236ED50", Offset = "0x236D950", VA = "0x18236ED50")]
		public void RenderView(ActVecBreakV2ZoneStageViewModel stageModel)
		{
		}

		// Token: 0x0602824B RID: 164427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602824B")]
		[Address(RVA = "0x236EE80", Offset = "0x236DA80", VA = "0x18236EE80")]
		public ActVecBreakV2EntryHardStageItemView()
		{
		}

		// Token: 0x0403901F RID: 233503
		[Token(Token = "0x403901F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04039020 RID: 233504
		[Token(Token = "0x4039020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _completePartGO;

		// Token: 0x04039021 RID: 233505
		[Token(Token = "0x4039021")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04039022 RID: 233506
		[Token(Token = "0x4039022")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
