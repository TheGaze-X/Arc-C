using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	public class BuildingAssignCharRequest : BuildingRequest
	{
		// Token: 0x06006272 RID: 25202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006272")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingAssignCharRequest()
		{
		}

		// Token: 0x04002DFC RID: 11772
		[Token(Token = "0x4002DFC")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x4002DFD")]
		[FieldOffset(Offset = "0x18")]
		public List<int> charInstIdList;
	}
}
