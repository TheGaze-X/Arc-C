using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072FD RID: 29437
	[Token(Token = "0x20072FD")]
	public class Act42sideRewardDetailDialog : UICompDialog<Act42sideRewardDetailDialog.Input>
	{
		// Token: 0x06029A5D RID: 170589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A5D")]
		[Address(RVA = "0x251A160", Offset = "0x2518D60", VA = "0x18251A160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029A5E RID: 170590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A5E")]
		[Address(RVA = "0x251A020", Offset = "0x2518C20", VA = "0x18251A020", Slot = "18")]
		protected override void OnRender(Act42sideRewardDetailDialog.Input input)
		{
		}

		// Token: 0x06029A5F RID: 170591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A5F")]
		[Address(RVA = "0x2519F60", Offset = "0x2518B60", VA = "0x182519F60")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x06029A60 RID: 170592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A60")]
		[Address(RVA = "0x251A1F0", Offset = "0x2518DF0", VA = "0x18251A1F0")]
		public Act42sideRewardDetailDialog()
		{
		}

		// Token: 0x0403B928 RID: 244008
		[Token(Token = "0x403B928")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act42sideRewardDetailView _view;

		// Token: 0x0403B929 RID: 244009
		[Token(Token = "0x403B929")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403B92A RID: 244010
		[Token(Token = "0x403B92A")]
		[FieldOffset(Offset = "0x80")]
		private Act42sideRewardDetailProperty m_prop;

		// Token: 0x0403B92B RID: 244011
		[Token(Token = "0x403B92B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B92C RID: 244012
		[Token(Token = "0x403B92C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403B92D RID: 244013
		[Token(Token = "0x403B92D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0403B92E RID: 244014
		[Token(Token = "0x403B92E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072FE RID: 29438
		[Token(Token = "0x20072FE")]
		public class Input
		{
			// Token: 0x06029A61 RID: 170593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A61")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B92F RID: 244015
			[Token(Token = "0x403B92F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
