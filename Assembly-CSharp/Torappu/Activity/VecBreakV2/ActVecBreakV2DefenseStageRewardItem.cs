using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E1B RID: 28187
	[Token(Token = "0x2006E1B")]
	public class ActVecBreakV2DefenseStageRewardItem : ActVecBreakV2DefenseStageBaseItem
	{
		// Token: 0x06028205 RID: 164357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028205")]
		[Address(RVA = "0x236B4D0", Offset = "0x236A0D0", VA = "0x18236B4D0", Slot = "4")]
		public override void Render(ActVecBreakV2DefenseStageBaseItem.InputParam inputParam)
		{
		}

		// Token: 0x06028206 RID: 164358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028206")]
		[Address(RVA = "0x236B6A0", Offset = "0x236A2A0", VA = "0x18236B6A0")]
		public ActVecBreakV2DefenseStageRewardItem()
		{
		}

		// Token: 0x04038F7A RID: 233338
		[Token(Token = "0x4038F7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _timeLimitRewardPanel;

		// Token: 0x04038F7B RID: 233339
		[Token(Token = "0x4038F7B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalRewardPanel;

		// Token: 0x04038F7C RID: 233340
		[Token(Token = "0x4038F7C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _timeLimitRewardRemainTime;

		// Token: 0x04038F7D RID: 233341
		[Token(Token = "0x4038F7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038F7E RID: 233342
		[Token(Token = "0x4038F7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
