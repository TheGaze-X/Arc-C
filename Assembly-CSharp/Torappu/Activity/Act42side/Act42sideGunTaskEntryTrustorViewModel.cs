using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007314 RID: 29460
	[Token(Token = "0x2007314")]
	public class Act42sideGunTaskEntryTrustorViewModel : IHotfixable
	{
		// Token: 0x06029AA4 RID: 170660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AA4")]
		[Address(RVA = "0x25167C0", Offset = "0x25153C0", VA = "0x1825167C0")]
		public Act42sideGunTaskEntryTrustorViewModel()
		{
		}

		// Token: 0x0403B99C RID: 244124
		[Token(Token = "0x403B99C")]
		[FieldOffset(Offset = "0x10")]
		public string trustorId;

		// Token: 0x0403B99D RID: 244125
		[Token(Token = "0x403B99D")]
		[FieldOffset(Offset = "0x18")]
		public Act42sideGunTaskEntryTrustorState state;

		// Token: 0x0403B99E RID: 244126
		[Token(Token = "0x403B99E")]
		[FieldOffset(Offset = "0x1C")]
		public int completeCount;

		// Token: 0x0403B99F RID: 244127
		[Token(Token = "0x403B99F")]
		[FieldOffset(Offset = "0x20")]
		public int totalCount;

		// Token: 0x0403B9A0 RID: 244128
		[Token(Token = "0x403B9A0")]
		[FieldOffset(Offset = "0x28")]
		public string trustorName;

		// Token: 0x0403B9A1 RID: 244129
		[Token(Token = "0x403B9A1")]
		[FieldOffset(Offset = "0x30")]
		public string trustorAvatar;

		// Token: 0x0403B9A2 RID: 244130
		[Token(Token = "0x403B9A2")]
		[FieldOffset(Offset = "0x38")]
		public string trustorWeapon;

		// Token: 0x0403B9A3 RID: 244131
		[Token(Token = "0x403B9A3")]
		[FieldOffset(Offset = "0x40")]
		public string trustorWeaponComplete;

		// Token: 0x0403B9A4 RID: 244132
		[Token(Token = "0x403B9A4")]
		[FieldOffset(Offset = "0x48")]
		public bool showTrack;

		// Token: 0x0403B9A5 RID: 244133
		[Token(Token = "0x403B9A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
