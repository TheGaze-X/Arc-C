using System;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	internal class KnownHttpVerb
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x505A800", Offset = "0x5059400", VA = "0x18505A800")]
		internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse)
		{
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x505A220", Offset = "0x5058E20", VA = "0x18505A220")]
		public static KnownHttpVerb Parse(string name)
		{
			return null;
		}

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[FieldOffset(Offset = "0x10")]
		internal string Name;

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x18")]
		internal bool RequireContentBody;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x19")]
		internal bool ContentBodyNotAllowed;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x1A")]
		internal bool ConnectRequest;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x1B")]
		internal bool ExpectNoContentResponse;

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x0")]
		private static ListDictionary NamedHeaders;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x8")]
		internal static KnownHttpVerb Get;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x10")]
		internal static KnownHttpVerb Connect;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x18")]
		internal static KnownHttpVerb Head;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x20")]
		internal static KnownHttpVerb Put;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x28")]
		internal static KnownHttpVerb Post;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x30")]
		internal static KnownHttpVerb MkCol;
	}
}
