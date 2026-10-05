using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001120 RID: 4384
	[Token(Token = "0x2001120")]
	public class OpenServerData
	{
		// Token: 0x06006EE2 RID: 28386 RVA: 0x00032358 File Offset: 0x00030558
		[Token(Token = "0x6006EE2")]
		[Address(RVA = "0x2108D10", Offset = "0x2107910", VA = "0x182108D10")]
		public bool ShouldSerializetotalCheckinCharData()
		{
			return default(bool);
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x00032370 File Offset: 0x00030570
		[Token(Token = "0x6006EE3")]
		[Address(RVA = "0x2108CD0", Offset = "0x21078D0", VA = "0x182108CD0")]
		public bool ShouldSerializechainLoginCharData()
		{
			return default(bool);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE4")]
		[Address(RVA = "0x2108D50", Offset = "0x2107950", VA = "0x182108D50")]
		public OpenServerData()
		{
		}

		// Token: 0x04005DF1 RID: 24049
		[Token(Token = "0x4005DF1")]
		[FieldOffset(Offset = "0x10")]
		public MissionGroup openServerMissionGroup;

		// Token: 0x04005DF2 RID: 24050
		[Token(Token = "0x4005DF2")]
		[FieldOffset(Offset = "0x18")]
		public List<MissionData> openServerMissionData;

		// Token: 0x04005DF3 RID: 24051
		[Token(Token = "0x4005DF3")]
		[FieldOffset(Offset = "0x20")]
		public List<TotalCheckinData> checkInData;

		// Token: 0x04005DF4 RID: 24052
		[Token(Token = "0x4005DF4")]
		[FieldOffset(Offset = "0x28")]
		public List<ChainLoginData> chainLoginData;

		// Token: 0x04005DF5 RID: 24053
		[Token(Token = "0x4005DF5")]
		[FieldOffset(Offset = "0x30")]
		public List<string> totalCheckinCharData;

		// Token: 0x04005DF6 RID: 24054
		[Token(Token = "0x4005DF6")]
		[FieldOffset(Offset = "0x38")]
		public List<string> chainLoginCharData;
	}
}
