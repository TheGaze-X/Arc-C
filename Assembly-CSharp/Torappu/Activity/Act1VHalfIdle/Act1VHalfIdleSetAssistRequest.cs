using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D9 RID: 30425
	[Token(Token = "0x20076D9")]
	public class Act1VHalfIdleSetAssistRequest : IHotfixable
	{
		// Token: 0x0602AC24 RID: 175140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC24")]
		[Address(RVA = "0x268A960", Offset = "0x2689560", VA = "0x18268A960")]
		public Act1VHalfIdleSetAssistRequest()
		{
		}

		// Token: 0x0403D9D5 RID: 252373
		[Token(Token = "0x403D9D5")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9D6 RID: 252374
		[Token(Token = "0x403D9D6")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x0403D9D7 RID: 252375
		[Token(Token = "0x403D9D7")]
		[FieldOffset(Offset = "0x20")]
		public SquadFriendData assistFriend;

		// Token: 0x0403D9D8 RID: 252376
		[Token(Token = "0x403D9D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
