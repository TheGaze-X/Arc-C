using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D75 RID: 28021
	[Token(Token = "0x2006D75")]
	public class ActivitySpriteStageTime : AbstractStageTime
	{
		// Token: 0x06027ED5 RID: 163541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED5")]
		[Address(RVA = "0x233CEF0", Offset = "0x233BAF0", VA = "0x18233CEF0", Slot = "5")]
		public override void SetRewardTimeActive(bool isActive)
		{
		}

		// Token: 0x06027ED6 RID: 163542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED6")]
		[Address(RVA = "0x233CFB0", Offset = "0x233BBB0", VA = "0x18233CFB0", Slot = "4")]
		public override void SetStageTimeActive(bool isActive)
		{
		}

		// Token: 0x06027ED7 RID: 163543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED7")]
		[Address(RVA = "0x233D070", Offset = "0x233BC70", VA = "0x18233D070")]
		public ActivitySpriteStageTime()
		{
		}

		// Token: 0x04038969 RID: 231785
		[Token(Token = "0x4038969")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _rewardTimeImage;

		// Token: 0x0403896A RID: 231786
		[Token(Token = "0x403896A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _stageTimeImage;

		// Token: 0x0403896B RID: 231787
		[Token(Token = "0x403896B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRewardTimeActive;

		// Token: 0x0403896C RID: 231788
		[Token(Token = "0x403896C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetStageTimeActive;

		// Token: 0x0403896D RID: 231789
		[Token(Token = "0x403896D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
