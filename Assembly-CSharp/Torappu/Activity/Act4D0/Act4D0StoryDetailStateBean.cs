using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007293 RID: 29331
	[Token(Token = "0x2007293")]
	public class Act4D0StoryDetailStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06029889 RID: 170121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029889")]
		[Address(RVA = "0x24E1B30", Offset = "0x24E0730", VA = "0x1824E1B30")]
		public void SetData(Act4D0StoryItemViewModel model)
		{
		}

		// Token: 0x0602988A RID: 170122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602988A")]
		[Address(RVA = "0x24E1C00", Offset = "0x24E0800", VA = "0x1824E1C00")]
		public Act4D0StoryDetailStateBean()
		{
		}

		// Token: 0x0403B5AA RID: 243114
		[Token(Token = "0x403B5AA")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string stageTitle;

		// Token: 0x0403B5AB RID: 243115
		[Token(Token = "0x403B5AB")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string stageDesc;

		// Token: 0x0403B5AC RID: 243116
		[Token(Token = "0x403B5AC")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public string storyKey;

		// Token: 0x0403B5AD RID: 243117
		[Token(Token = "0x403B5AD")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public string storyId;

		// Token: 0x0403B5AE RID: 243118
		[Token(Token = "0x403B5AE")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public string storySort;

		// Token: 0x0403B5AF RID: 243119
		[Token(Token = "0x403B5AF")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public bool isNewStory;

		// Token: 0x0403B5B0 RID: 243120
		[Token(Token = "0x403B5B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0403B5B1 RID: 243121
		[Token(Token = "0x403B5B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
