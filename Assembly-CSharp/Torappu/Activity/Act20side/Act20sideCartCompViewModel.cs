using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200768F RID: 30351
	[Token(Token = "0x200768F")]
	public class Act20sideCartCompViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602AB09 RID: 174857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB09")]
		[Address(RVA = "0x266FB30", Offset = "0x266E730", VA = "0x18266FB30")]
		public Act20sideCartCompViewModel(object param)
		{
		}

		// Token: 0x0403D817 RID: 251927
		[Token(Token = "0x403D817")]
		[FieldOffset(Offset = "0x20")]
		public bool isLocked;

		// Token: 0x0403D818 RID: 251928
		[Token(Token = "0x403D818")]
		[FieldOffset(Offset = "0x28")]
		public string lockedDesc;

		// Token: 0x0403D819 RID: 251929
		[Token(Token = "0x403D819")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007690 RID: 30352
		[Token(Token = "0x2007690")]
		public class Input
		{
			// Token: 0x0602AB0A RID: 174858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB0A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403D81A RID: 251930
			[Token(Token = "0x403D81A")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
