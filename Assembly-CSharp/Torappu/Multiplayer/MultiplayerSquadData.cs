using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;

namespace Torappu.Multiplayer
{
	// Token: 0x02001551 RID: 5457
	[Token(Token = "0x2001551")]
	public class MultiplayerSquadData
	{
		// Token: 0x06007CB6 RID: 31926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CB6")]
		[Address(RVA = "0x284A180", Offset = "0x2848D80", VA = "0x18284A180")]
		public static MultiplayerSquadData operator +(MultiplayerSquadData a, MultiplayerSquadData b)
		{
			return null;
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB7")]
		[Address(RVA = "0x284A0F0", Offset = "0x2848CF0", VA = "0x18284A0F0")]
		public MultiplayerSquadData()
		{
		}

		// Token: 0x04007D60 RID: 32096
		[Token(Token = "0x4007D60")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSide playerSide;

		// Token: 0x04007D61 RID: 32097
		[Token(Token = "0x4007D61")]
		[FieldOffset(Offset = "0x18")]
		public List<AdvancedCharacterInst> squad;

		// Token: 0x04007D62 RID: 32098
		[Token(Token = "0x4007D62")]
		[FieldOffset(Offset = "0x20")]
		public string buffId;

		// Token: 0x04007D63 RID: 32099
		[Token(Token = "0x4007D63")]
		[FieldOffset(Offset = "0x28")]
		public string uid;

		// Token: 0x04007D64 RID: 32100
		[Token(Token = "0x4007D64")]
		[FieldOffset(Offset = "0x30")]
		public TeamProtocol.Squad squadRawData;
	}
}
