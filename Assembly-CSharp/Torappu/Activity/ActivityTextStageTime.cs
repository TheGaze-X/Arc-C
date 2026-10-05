using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D77 RID: 28023
	[Token(Token = "0x2006D77")]
	public class ActivityTextStageTime : AbstractStageTime
	{
		// Token: 0x06027EDA RID: 163546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EDA")]
		[Address(RVA = "0x233EE70", Offset = "0x233DA70", VA = "0x18233EE70", Slot = "5")]
		public override void SetRewardTimeActive(bool isActive)
		{
		}

		// Token: 0x06027EDB RID: 163547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EDB")]
		[Address(RVA = "0x233EF10", Offset = "0x233DB10", VA = "0x18233EF10", Slot = "4")]
		public override void SetStageTimeActive(bool isActive)
		{
		}

		// Token: 0x06027EDC RID: 163548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EDC")]
		[Address(RVA = "0x233EFB0", Offset = "0x233DBB0", VA = "0x18233EFB0")]
		public ActivityTextStageTime()
		{
		}

		// Token: 0x04038971 RID: 231793
		[Token(Token = "0x4038971")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04038972 RID: 231794
		[Token(Token = "0x4038972")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _rewardString;

		// Token: 0x04038973 RID: 231795
		[Token(Token = "0x4038973")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stageString;

		// Token: 0x04038974 RID: 231796
		[Token(Token = "0x4038974")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRewardTimeActive;

		// Token: 0x04038975 RID: 231797
		[Token(Token = "0x4038975")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetStageTimeActive;

		// Token: 0x04038976 RID: 231798
		[Token(Token = "0x4038976")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
