using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D76 RID: 28022
	[Token(Token = "0x2006D76")]
	public class ActivityTextRemainTime : AbstractRemainTime
	{
		// Token: 0x06027ED8 RID: 163544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED8")]
		[Address(RVA = "0x233EC80", Offset = "0x233D880", VA = "0x18233EC80", Slot = "4")]
		public override void SetRemainTime(TimeSpan time)
		{
		}

		// Token: 0x06027ED9 RID: 163545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED9")]
		[Address(RVA = "0x233EDD0", Offset = "0x233D9D0", VA = "0x18233EDD0")]
		public ActivityTextRemainTime()
		{
		}

		// Token: 0x0403896E RID: 231790
		[Token(Token = "0x403896E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0403896F RID: 231791
		[Token(Token = "0x403896F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRemainTime;

		// Token: 0x04038970 RID: 231792
		[Token(Token = "0x4038970")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
