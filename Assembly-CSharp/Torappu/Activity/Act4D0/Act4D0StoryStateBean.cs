using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007296 RID: 29334
	[Token(Token = "0x2007296")]
	public class Act4D0StoryStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0602988C RID: 170124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602988C")]
		[Address(RVA = "0x24E2770", Offset = "0x24E1370", VA = "0x1824E2770")]
		public void InitInfo()
		{
		}

		// Token: 0x0602988D RID: 170125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602988D")]
		[Address(RVA = "0x24E2A50", Offset = "0x24E1650", VA = "0x1824E2A50")]
		public Act4D0StoryStateBean()
		{
		}

		// Token: 0x0403B5BF RID: 243135
		[Token(Token = "0x403B5BF")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<Act4D0StoryItemViewModel> viewModelList;

		// Token: 0x0403B5C0 RID: 243136
		[Token(Token = "0x403B5C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403B5C1 RID: 243137
		[Token(Token = "0x403B5C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
