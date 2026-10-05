using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000627 RID: 1575
	[Token(Token = "0x2000627")]
	public class BuildingBuildRoomResponse : PlayerDeltaResponse, IAlertResponse
	{
		// Token: 0x06006255 RID: 25173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006255")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006256")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingBuildRoomResponse()
		{
		}

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x30")]
		public List<ServiceAlertStruct> alert;
	}
}
