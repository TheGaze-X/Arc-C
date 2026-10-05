using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007426 RID: 29734
	[Token(Token = "0x2007426")]
	public class Act3D0MileStoneStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06029F8C RID: 171916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F8C")]
		[Address(RVA = "0x258F6E0", Offset = "0x258E2E0", VA = "0x18258F6E0")]
		public void InitInfo()
		{
		}

		// Token: 0x06029F8D RID: 171917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F8D")]
		[Address(RVA = "0x258F9C0", Offset = "0x258E5C0", VA = "0x18258F9C0")]
		public Act3D0MileStoneStateBean()
		{
		}

		// Token: 0x0403C2D4 RID: 246484
		[Token(Token = "0x403C2D4")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<Act3D0MileStoneViewModel> viewModelList;

		// Token: 0x0403C2D5 RID: 246485
		[Token(Token = "0x403C2D5")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int currentStone;

		// Token: 0x0403C2D6 RID: 246486
		[Token(Token = "0x403C2D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403C2D7 RID: 246487
		[Token(Token = "0x403C2D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
