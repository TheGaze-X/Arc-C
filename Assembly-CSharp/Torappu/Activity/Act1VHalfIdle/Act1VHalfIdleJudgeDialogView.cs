using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200772C RID: 30508
	[Token(Token = "0x200772C")]
	public class Act1VHalfIdleJudgeDialogView : CustomJudgeDialogView
	{
		// Token: 0x0602ADCA RID: 175562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADCA")]
		[Address(RVA = "0x26A7620", Offset = "0x26A6220", VA = "0x1826A7620", Slot = "4")]
		protected override void OnRenderView(ValueBundle customVal)
		{
		}

		// Token: 0x0602ADCB RID: 175563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADCB")]
		[Address(RVA = "0x26A7760", Offset = "0x26A6360", VA = "0x1826A7760")]
		public Act1VHalfIdleJudgeDialogView()
		{
		}

		// Token: 0x0403DCB0 RID: 253104
		[Token(Token = "0x403DCB0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403DCB1 RID: 253105
		[Token(Token = "0x403DCB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderView;

		// Token: 0x0403DCB2 RID: 253106
		[Token(Token = "0x403DCB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
