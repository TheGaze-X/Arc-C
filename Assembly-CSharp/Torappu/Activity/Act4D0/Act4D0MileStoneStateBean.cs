using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200728E RID: 29326
	[Token(Token = "0x200728E")]
	public class Act4D0MileStoneStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06029882 RID: 170114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029882")]
		[Address(RVA = "0x24DE5B0", Offset = "0x24DD1B0", VA = "0x1824DE5B0")]
		public void InitInfo()
		{
		}

		// Token: 0x06029883 RID: 170115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029883")]
		[Address(RVA = "0x24DE970", Offset = "0x24DD570", VA = "0x1824DE970")]
		public Act4D0MileStoneStateBean()
		{
		}

		// Token: 0x0403B594 RID: 243092
		[Token(Token = "0x403B594")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<Act4D0MileStoneViewModel> viewModelList;

		// Token: 0x0403B595 RID: 243093
		[Token(Token = "0x403B595")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int currentStone;

		// Token: 0x0403B596 RID: 243094
		[Token(Token = "0x403B596")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403B597 RID: 243095
		[Token(Token = "0x403B597")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
