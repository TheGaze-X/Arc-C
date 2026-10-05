using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200728A RID: 29322
	[Token(Token = "0x200728A")]
	public class Act4D0GetStoryStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06029871 RID: 170097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029871")]
		[Address(RVA = "0x24DC290", Offset = "0x24DAE90", VA = "0x1824DC290")]
		public Act4D0GetStoryStateBean()
		{
		}

		// Token: 0x0403B580 RID: 243072
		[Token(Token = "0x403B580")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Act4D0Data.StoryInfo storyInfo;

		// Token: 0x0403B581 RID: 243073
		[Token(Token = "0x403B581")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
