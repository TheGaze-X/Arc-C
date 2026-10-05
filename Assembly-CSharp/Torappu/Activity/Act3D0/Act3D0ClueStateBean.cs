using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200741F RID: 29727
	[Token(Token = "0x200741F")]
	public class Act3D0ClueStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06029F81 RID: 171905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F81")]
		[Address(RVA = "0x25870D0", Offset = "0x2585CD0", VA = "0x1825870D0")]
		public void InitData()
		{
		}

		// Token: 0x06029F82 RID: 171906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F82")]
		[Address(RVA = "0x2587390", Offset = "0x2585F90", VA = "0x182587390")]
		public Act3D0ClueStateBean()
		{
		}

		// Token: 0x0403C2A9 RID: 246441
		[Token(Token = "0x403C2A9")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<Act3D0ClueInfo> clueList;

		// Token: 0x0403C2AA RID: 246442
		[Token(Token = "0x403C2AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403C2AB RID: 246443
		[Token(Token = "0x403C2AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
