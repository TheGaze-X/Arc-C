using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC8 RID: 8136
	[Token(Token = "0x2001FC8")]
	public class DuckingData
	{
		// Token: 0x0600C9FF RID: 51711 RVA: 0x00049500 File Offset: 0x00047700
		[Token(Token = "0x600C9FF")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializefadeStyleId()
		{
			return default(bool);
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA00")]
		[Address(RVA = "0x34A7840", Offset = "0x34A6440", VA = "0x1834A7840")]
		public DuckingData()
		{
		}

		// Token: 0x0400D289 RID: 53897
		[Token(Token = "0x400D289")]
		[FieldOffset(Offset = "0x10")]
		public string bank;

		// Token: 0x0400D28A RID: 53898
		[Token(Token = "0x400D28A")]
		[FieldOffset(Offset = "0x18")]
		public float volume;

		// Token: 0x0400D28B RID: 53899
		[Token(Token = "0x400D28B")]
		[FieldOffset(Offset = "0x1C")]
		public float fadeTime;

		// Token: 0x0400D28C RID: 53900
		[Token(Token = "0x400D28C")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		// Token: 0x0400D28D RID: 53901
		[Token(Token = "0x400D28D")]
		[FieldOffset(Offset = "0x28")]
		public string fadeStyleId;
	}
}
