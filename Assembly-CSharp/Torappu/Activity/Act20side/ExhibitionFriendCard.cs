using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200763F RID: 30271
	[Token(Token = "0x200763F")]
	public class ExhibitionFriendCard : FriendCommonData
	{
		// Token: 0x0602A9A1 RID: 174497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A1")]
		[Address(RVA = "0x26645F0", Offset = "0x26631F0", VA = "0x1826645F0")]
		public ExhibitionFriendCard()
		{
		}

		// Token: 0x0403D56B RID: 251243
		[Token(Token = "0x403D56B")]
		[FieldOffset(Offset = "0x68")]
		public int assistSlotIndex;

		// Token: 0x0403D56C RID: 251244
		[Token(Token = "0x403D56C")]
		[FieldOffset(Offset = "0x70")]
		public string aliasName;

		// Token: 0x0403D56D RID: 251245
		[Token(Token = "0x403D56D")]
		[FieldOffset(Offset = "0x78")]
		public SharedCharData[] assistCharList;

		// Token: 0x0403D56E RID: 251246
		[Token(Token = "0x403D56E")]
		[FieldOffset(Offset = "0x80")]
		public bool isFriend;

		// Token: 0x0403D56F RID: 251247
		[Token(Token = "0x403D56F")]
		[FieldOffset(Offset = "0x81")]
		public bool canRequestFriend;

		// Token: 0x0403D570 RID: 251248
		[Token(Token = "0x403D570")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
