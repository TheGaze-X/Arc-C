using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000442 RID: 1090
	[Token(Token = "0x2000442")]
	internal sealed class SerObjectInfoCache
	{
		// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002156")]
		[Address(RVA = "0x4AE4B20", Offset = "0x4AE3720", VA = "0x184AE4B20")]
		internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
		{
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002157")]
		[Address(RVA = "0x4BC54C0", Offset = "0x4BC40C0", VA = "0x184BC54C0")]
		internal SerObjectInfoCache(System.Type type)
		{
		}

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x10")]
		internal string fullTypeName;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x18")]
		internal string assemblyString;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0x20")]
		internal bool hasTypeForwardedFrom;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0x28")]
		internal System.Reflection.MemberInfo[] memberInfos;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0x30")]
		internal string[] memberNames;

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0x38")]
		internal System.Type[] memberTypes;
	}
}
