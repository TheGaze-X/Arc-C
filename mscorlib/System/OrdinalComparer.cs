using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	[System.Serializable]
	public class OrdinalComparer : System.StringComparer
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x4CF66F0", Offset = "0x4CF52F0", VA = "0x184CF66F0")]
		internal OrdinalComparer(bool ignoreCase)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x4CF6470", Offset = "0x4CF5070", VA = "0x184CF6470", Slot = "10")]
		public override int Compare(string x, string y)
		{
			return 0;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x4CF64C0", Offset = "0x4CF50C0", VA = "0x184CF64C0", Slot = "11")]
		public override bool Equals(string x, string y)
		{
			return default(bool);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x4CF65D0", Offset = "0x4CF51D0", VA = "0x184CF65D0", Slot = "12")]
		public override int GetHashCode(string obj)
		{
			return 0;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x4CF6530", Offset = "0x4CF5130", VA = "0x184CF6530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x4CF6670", Offset = "0x4CF5270", VA = "0x184CF6670", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool _ignoreCase;
	}
}
