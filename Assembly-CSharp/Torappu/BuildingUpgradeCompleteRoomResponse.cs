using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000629 RID: 1577
	[Token(Token = "0x2000629")]
	public class BuildingUpgradeCompleteRoomResponse : PlayerDeltaResponse, IAlertResponse
	{
		// Token: 0x06006258 RID: 25176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006258")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006259")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingUpgradeCompleteRoomResponse()
		{
		}

		// Token: 0x04002DB5 RID: 11701
		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x30")]
		public List<ServiceAlertStruct> alert;
	}
}
