using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FB8 RID: 4024
	[Token(Token = "0x2000FB8")]
	public class CrisisV2SeasonInfo
	{
		// Token: 0x06006CFF RID: 27903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SeasonInfo()
		{
		}

		// Token: 0x04005552 RID: 21842
		[Token(Token = "0x4005552")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x04005553 RID: 21843
		[Token(Token = "0x4005553")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005554 RID: 21844
		[Token(Token = "0x4005554")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04005555 RID: 21845
		[Token(Token = "0x4005555")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;

		// Token: 0x04005556 RID: 21846
		[Token(Token = "0x4005556")]
		[FieldOffset(Offset = "0x30")]
		public string medalGroupId;

		// Token: 0x04005557 RID: 21847
		[Token(Token = "0x4005557")]
		[FieldOffset(Offset = "0x38")]
		public string medalId;

		// Token: 0x04005558 RID: 21848
		[Token(Token = "0x4005558")]
		[FieldOffset(Offset = "0x40")]
		public string themeColor1;

		// Token: 0x04005559 RID: 21849
		[Token(Token = "0x4005559")]
		[FieldOffset(Offset = "0x48")]
		public string themeColor2;

		// Token: 0x0400555A RID: 21850
		[Token(Token = "0x400555A")]
		[FieldOffset(Offset = "0x50")]
		public string themeColor3;

		// Token: 0x0400555B RID: 21851
		[Token(Token = "0x400555B")]
		[FieldOffset(Offset = "0x58")]
		public string seasonBgm;

		// Token: 0x0400555C RID: 21852
		[Token(Token = "0x400555C")]
		[FieldOffset(Offset = "0x60")]
		public string seasonBgmChallenge;

		// Token: 0x0400555D RID: 21853
		[Token(Token = "0x400555D")]
		[FieldOffset(Offset = "0x68")]
		public string crisisV2SeasonCode;
	}
}
