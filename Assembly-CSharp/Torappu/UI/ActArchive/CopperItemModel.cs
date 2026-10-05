using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B59 RID: 27481
	[Token(Token = "0x2006B59")]
	public class CopperItemModel
	{
		// Token: 0x06027454 RID: 160852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027454")]
		[Address(RVA = "0x2277A40", Offset = "0x2276640", VA = "0x182277A40")]
		public void ConsumeNewMark(string trackType)
		{
		}

		// Token: 0x06027455 RID: 160853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027455")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CopperItemModel()
		{
		}

		// Token: 0x04037980 RID: 227712
		[Token(Token = "0x4037980")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04037981 RID: 227713
		[Token(Token = "0x4037981")]
		[FieldOffset(Offset = "0x18")]
		public string archiveId;

		// Token: 0x04037982 RID: 227714
		[Token(Token = "0x4037982")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04037983 RID: 227715
		[Token(Token = "0x4037983")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04037984 RID: 227716
		[Token(Token = "0x4037984")]
		[FieldOffset(Offset = "0x30")]
		public string copperTypeName;

		// Token: 0x04037985 RID: 227717
		[Token(Token = "0x4037985")]
		[FieldOffset(Offset = "0x38")]
		public string descFirst;

		// Token: 0x04037986 RID: 227718
		[Token(Token = "0x4037986")]
		[FieldOffset(Offset = "0x40")]
		public string descSec;

		// Token: 0x04037987 RID: 227719
		[Token(Token = "0x4037987")]
		[FieldOffset(Offset = "0x48")]
		public bool hasNew;

		// Token: 0x04037988 RID: 227720
		[Token(Token = "0x4037988")]
		[FieldOffset(Offset = "0x49")]
		public bool isSelected;

		// Token: 0x04037989 RID: 227721
		[Token(Token = "0x4037989")]
		[FieldOffset(Offset = "0x50")]
		public List<string> poems;

		// Token: 0x0403798A RID: 227722
		[Token(Token = "0x403798A")]
		[FieldOffset(Offset = "0x58")]
		public List<string> coppersInGroup;

		// Token: 0x0403798B RID: 227723
		[Token(Token = "0x403798B")]
		[FieldOffset(Offset = "0x60")]
		public ActArchiveCopperType archiveType;

		// Token: 0x0403798C RID: 227724
		[Token(Token = "0x403798C")]
		[FieldOffset(Offset = "0x64")]
		public RoguelikeCopperType copperType;

		// Token: 0x0403798D RID: 227725
		[Token(Token = "0x403798D")]
		[FieldOffset(Offset = "0x68")]
		public RoguelikeCopperLuckyLevel luckyLevel;

		// Token: 0x0403798E RID: 227726
		[Token(Token = "0x403798E")]
		[FieldOffset(Offset = "0x6C")]
		public RoguelikeArchiveItemUnlockStatus status;
	}
}
