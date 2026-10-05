using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	[Serializable]
	public class ExtraBattleLogDataKey
	{
		// Token: 0x06004CEC RID: 19692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExtraBattleLogDataKey()
		{
		}

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x40010F5")]
		[FieldOffset(Offset = "0x10")]
		public string description;

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x18")]
		public string sourceId;

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x20")]
		public string sourceMode;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x28")]
		public string enemyId;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x30")]
		public string enemyApplyWay;

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x38")]
		public string projectileName;

		// Token: 0x040010FB RID: 4347
		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x40")]
		public string abilityName;

		// Token: 0x040010FC RID: 4348
		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x48")]
		public string enemyLevelType;

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x50")]
		public List<string> enemyTag;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x58")]
		public string logAlias;
	}
}
