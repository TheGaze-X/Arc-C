using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000DFD")]
	public class ActivityEnemyDuelModeData
	{
		// Token: 0x06006ACE RID: 27342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelModeData()
		{
		}

		// Token: 0x04004A44 RID: 19012
		[Token(Token = "0x4004A44")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x04004A45 RID: 19013
		[Token(Token = "0x4004A45")]
		[FieldOffset(Offset = "0x18")]
		public bool isMultiPlayer;

		// Token: 0x04004A46 RID: 19014
		[Token(Token = "0x4004A46")]
		[FieldOffset(Offset = "0x19")]
		public bool isRoom;

		// Token: 0x04004A47 RID: 19015
		[Token(Token = "0x4004A47")]
		[FieldOffset(Offset = "0x1C")]
		public EnemyDuelModeType modeType;

		// Token: 0x04004A48 RID: 19016
		[Token(Token = "0x4004A48")]
		[FieldOffset(Offset = "0x20")]
		public List<string> stageIds;

		// Token: 0x04004A49 RID: 19017
		[Token(Token = "0x4004A49")]
		[FieldOffset(Offset = "0x28")]
		public int pageId;

		// Token: 0x04004A4A RID: 19018
		[Token(Token = "0x4004A4A")]
		[FieldOffset(Offset = "0x2C")]
		public int innerSortId;

		// Token: 0x04004A4B RID: 19019
		[Token(Token = "0x4004A4B")]
		[FieldOffset(Offset = "0x30")]
		public string modeName;

		// Token: 0x04004A4C RID: 19020
		[Token(Token = "0x4004A4C")]
		[FieldOffset(Offset = "0x38")]
		public string modeShortName;

		// Token: 0x04004A4D RID: 19021
		[Token(Token = "0x4004A4D")]
		[FieldOffset(Offset = "0x40")]
		public string modeEnName;

		// Token: 0x04004A4E RID: 19022
		[Token(Token = "0x4004A4E")]
		[FieldOffset(Offset = "0x48")]
		public int maxPlayer;

		// Token: 0x04004A4F RID: 19023
		[Token(Token = "0x4004A4F")]
		[FieldOffset(Offset = "0x50")]
		public string preposedMode;

		// Token: 0x04004A50 RID: 19024
		[Token(Token = "0x4004A50")]
		[FieldOffset(Offset = "0x58")]
		public long startTs;

		// Token: 0x04004A51 RID: 19025
		[Token(Token = "0x4004A51")]
		[FieldOffset(Offset = "0x60")]
		public long endTs;

		// Token: 0x04004A52 RID: 19026
		[Token(Token = "0x4004A52")]
		[FieldOffset(Offset = "0x68")]
		public string entryPicId;

		// Token: 0x04004A53 RID: 19027
		[Token(Token = "0x4004A53")]
		[FieldOffset(Offset = "0x70")]
		public List<string> titlePics;

		// Token: 0x04004A54 RID: 19028
		[Token(Token = "0x4004A54")]
		[FieldOffset(Offset = "0x78")]
		public string modeTarget;

		// Token: 0x04004A55 RID: 19029
		[Token(Token = "0x4004A55")]
		[FieldOffset(Offset = "0x80")]
		public string modeDesc;

		// Token: 0x04004A56 RID: 19030
		[Token(Token = "0x4004A56")]
		[FieldOffset(Offset = "0x88")]
		public string modeRecordDesc;

		// Token: 0x04004A57 RID: 19031
		[Token(Token = "0x4004A57")]
		[FieldOffset(Offset = "0x90")]
		public bool extraTag;

		// Token: 0x04004A58 RID: 19032
		[Token(Token = "0x4004A58")]
		[FieldOffset(Offset = "0x98")]
		public string modeAvatarPicId;

		// Token: 0x04004A59 RID: 19033
		[Token(Token = "0x4004A59")]
		[FieldOffset(Offset = "0xA0")]
		public string modeAvatarName;

		// Token: 0x04004A5A RID: 19034
		[Token(Token = "0x4004A5A")]
		[FieldOffset(Offset = "0xA8")]
		public string modeAvatarText;

		// Token: 0x04004A5B RID: 19035
		[Token(Token = "0x4004A5B")]
		[FieldOffset(Offset = "0xB0")]
		public bool hasUnlockToast;
	}
}
