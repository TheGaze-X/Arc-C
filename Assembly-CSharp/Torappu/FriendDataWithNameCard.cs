using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200141F RID: 5151
	[Token(Token = "0x200141F")]
	public class FriendDataWithNameCard : FriendData
	{
		// Token: 0x060076E0 RID: 30432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E0")]
		[Address(RVA = "0x241EB60", Offset = "0x241D760", VA = "0x18241EB60")]
		public FriendDataWithNameCard()
		{
		}

		// Token: 0x0400743B RID: 29755
		[Token(Token = "0x400743B")]
		[FieldOffset(Offset = "0xA0")]
		public DateTime registerTs;

		// Token: 0x0400743C RID: 29756
		[Token(Token = "0x400743C")]
		[FieldOffset(Offset = "0xA8")]
		public PlayerBirthday birthday;

		// Token: 0x0400743D RID: 29757
		[Token(Token = "0x400743D")]
		[FieldOffset(Offset = "0xB0")]
		public string mainStageProgress;

		// Token: 0x0400743E RID: 29758
		[Token(Token = "0x400743E")]
		[FieldOffset(Offset = "0xB8")]
		public int charCnt;

		// Token: 0x0400743F RID: 29759
		[Token(Token = "0x400743F")]
		[FieldOffset(Offset = "0xBC")]
		public int skinCnt;

		// Token: 0x04007440 RID: 29760
		[Token(Token = "0x4007440")]
		[FieldOffset(Offset = "0xC0")]
		public int furnCnt;

		// Token: 0x04007441 RID: 29761
		[Token(Token = "0x4007441")]
		[FieldOffset(Offset = "0xC8")]
		public string resume;

		// Token: 0x04007442 RID: 29762
		[Token(Token = "0x4007442")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<int, int> team;

		// Token: 0x04007443 RID: 29763
		[Token(Token = "0x4007443")]
		[FieldOffset(Offset = "0xD8")]
		public Dictionary<string, int> teamV2;

		// Token: 0x04007444 RID: 29764
		[Token(Token = "0x4007444")]
		[FieldOffset(Offset = "0xE0")]
		public FriendMedalBoard medalBoard;

		// Token: 0x04007445 RID: 29765
		[Token(Token = "0x4007445")]
		[FieldOffset(Offset = "0xE8")]
		public PlayerNameCardStyle nameCardStyle;

		// Token: 0x04007446 RID: 29766
		[Token(Token = "0x4007446")]
		[FieldOffset(Offset = "0xF0")]
		public BusinessCardEquipStatus equipStatus;

		// Token: 0x04007447 RID: 29767
		[Token(Token = "0x4007447")]
		[FieldOffset(Offset = "0xF8")]
		public List<FriendArtMagazineLeafData> magazineBoard;

		// Token: 0x04007448 RID: 29768
		[Token(Token = "0x4007448")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
