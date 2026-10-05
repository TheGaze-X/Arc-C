using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	public class BuildingGetRecentVisitorsResponse
	{
		// Token: 0x060062BA RID: 25274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingGetRecentVisitorsResponse()
		{
		}

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x10")]
		public List<BuildingGetRecentVisitorsResponse.Visitor> visitors;

		// Token: 0x0200068A RID: 1674
		[Token(Token = "0x200068A")]
		public class Visitor
		{
			// Token: 0x060062BB RID: 25275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062BB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Visitor()
			{
			}

			// Token: 0x04002E52 RID: 11858
			[Token(Token = "0x4002E52")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04002E53 RID: 11859
			[Token(Token = "0x4002E53")]
			[FieldOffset(Offset = "0x18")]
			public string nickName;

			// Token: 0x04002E54 RID: 11860
			[Token(Token = "0x4002E54")]
			[FieldOffset(Offset = "0x20")]
			public string nickNumber;

			// Token: 0x04002E55 RID: 11861
			[Token(Token = "0x4002E55")]
			[FieldOffset(Offset = "0x28")]
			public string secretary;

			// Token: 0x04002E56 RID: 11862
			[Token(Token = "0x4002E56")]
			[FieldOffset(Offset = "0x30")]
			public string secretarySkinId;

			// Token: 0x04002E57 RID: 11863
			[Token(Token = "0x4002E57")]
			[FieldOffset(Offset = "0x38")]
			public int level;

			// Token: 0x04002E58 RID: 11864
			[Token(Token = "0x4002E58")]
			[FieldOffset(Offset = "0x40")]
			public long ts;
		}
	}
}
