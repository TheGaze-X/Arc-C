using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	internal sealed class ObjectMapInfo
	{
		// Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x4BB90C0", Offset = "0x4BB7CC0", VA = "0x184BB90C0")]
		internal ObjectMapInfo(int objectId, int numMembers, string[] memberNames, System.Type[] memberTypes)
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x4BB9120", Offset = "0x4BB7D20", VA = "0x184BB9120")]
		internal bool isCompatible(int numMembers, string[] memberNames, System.Type[] memberTypes)
		{
			return default(bool);
		}

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0x14")]
		private int numMembers;

		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		[FieldOffset(Offset = "0x18")]
		private string[] memberNames;

		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0x20")]
		private System.Type[] memberTypes;
	}
}
