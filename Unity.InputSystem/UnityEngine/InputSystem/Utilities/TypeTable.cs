using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	internal struct TypeTable
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005EA")]
		public IEnumerable<string> names
		{
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x56188F0", Offset = "0x56174F0", VA = "0x1856188F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005EB")]
		public IEnumerable<InternedString> internedNames
		{
			[Token(Token = "0x600161C")]
			[Address(RVA = "0x56188A0", Offset = "0x56174A0", VA = "0x1856188A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x5618700", Offset = "0x5617300", VA = "0x185618700")]
		public void Initialize()
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x56184D0", Offset = "0x56170D0", VA = "0x1856184D0")]
		public InternedString FindNameForType(Type type)
		{
			return default(InternedString);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x5618340", Offset = "0x5616F40", VA = "0x185618340")]
		public void AddTypeRegistration(string name, Type type)
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x5618780", Offset = "0x5617380", VA = "0x185618780")]
		public Type LookupTypeRegistration(string name)
		{
			return null;
		}

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x0")]
		public Dictionary<InternedString, Type> table;
	}
}
