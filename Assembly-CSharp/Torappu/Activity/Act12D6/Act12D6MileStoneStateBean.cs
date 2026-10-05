using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B09 RID: 31497
	[Token(Token = "0x2007B09")]
	public class Act12D6MileStoneStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0602C19E RID: 180638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C19E")]
		[Address(RVA = "0x28103B0", Offset = "0x280EFB0", VA = "0x1828103B0")]
		public void InitInfo()
		{
		}

		// Token: 0x0602C19F RID: 180639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C19F")]
		[Address(RVA = "0x2810670", Offset = "0x280F270", VA = "0x182810670")]
		public Act12D6MileStoneStateBean()
		{
		}

		// Token: 0x0403FEF7 RID: 261879
		[Token(Token = "0x403FEF7")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<Act12D6MileStoneViewModel> viewModelList;

		// Token: 0x0403FEF8 RID: 261880
		[Token(Token = "0x403FEF8")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int currentStone;

		// Token: 0x0403FEF9 RID: 261881
		[Token(Token = "0x403FEF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403FEFA RID: 261882
		[Token(Token = "0x403FEFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
