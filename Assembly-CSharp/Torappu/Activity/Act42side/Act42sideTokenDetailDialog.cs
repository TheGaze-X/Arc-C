using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007306 RID: 29446
	[Token(Token = "0x2007306")]
	public class Act42sideTokenDetailDialog : UICompDialog<Act42sideTokenDetailDialog.Input>
	{
		// Token: 0x06029A70 RID: 170608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A70")]
		[Address(RVA = "0x251B1B0", Offset = "0x2519DB0", VA = "0x18251B1B0", Slot = "18")]
		protected override void OnRender(Act42sideTokenDetailDialog.Input input)
		{
		}

		// Token: 0x06029A71 RID: 170609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A71")]
		[Address(RVA = "0x251B0F0", Offset = "0x2519CF0", VA = "0x18251B0F0")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x06029A72 RID: 170610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A72")]
		[Address(RVA = "0x251B2B0", Offset = "0x2519EB0", VA = "0x18251B2B0")]
		public Act42sideTokenDetailDialog()
		{
		}

		// Token: 0x0403B952 RID: 244050
		[Token(Token = "0x403B952")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _coffeeName;

		// Token: 0x0403B953 RID: 244051
		[Token(Token = "0x403B953")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _coffeeContent;

		// Token: 0x0403B954 RID: 244052
		[Token(Token = "0x403B954")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403B955 RID: 244053
		[Token(Token = "0x403B955")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0403B956 RID: 244054
		[Token(Token = "0x403B956")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007307 RID: 29447
		[Token(Token = "0x2007307")]
		public class Input
		{
			// Token: 0x06029A73 RID: 170611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B957 RID: 244055
			[Token(Token = "0x403B957")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
