using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D74 RID: 28020
	[Token(Token = "0x2006D74")]
	public class ActivityDefaultTextStageTime : AbstractStageTime
	{
		// Token: 0x06027ED2 RID: 163538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED2")]
		[Address(RVA = "0x233BEA0", Offset = "0x233AAA0", VA = "0x18233BEA0", Slot = "5")]
		public override void SetRewardTimeActive(bool isActive)
		{
		}

		// Token: 0x06027ED3 RID: 163539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED3")]
		[Address(RVA = "0x233BF70", Offset = "0x233AB70", VA = "0x18233BF70", Slot = "4")]
		public override void SetStageTimeActive(bool isActive)
		{
		}

		// Token: 0x06027ED4 RID: 163540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED4")]
		[Address(RVA = "0x233C040", Offset = "0x233AC40", VA = "0x18233C040")]
		public ActivityDefaultTextStageTime()
		{
		}

		// Token: 0x04038965 RID: 231781
		[Token(Token = "0x4038965")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04038966 RID: 231782
		[Token(Token = "0x4038966")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRewardTimeActive;

		// Token: 0x04038967 RID: 231783
		[Token(Token = "0x4038967")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetStageTimeActive;

		// Token: 0x04038968 RID: 231784
		[Token(Token = "0x4038968")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
