using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	internal sealed class ValueTypeFixupInfo
	{
		// Token: 0x06001FAC RID: 8108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x4BB0F30", Offset = "0x4BAFB30", VA = "0x184BB0F30")]
		public ValueTypeFixupInfo(long containerID, System.Reflection.FieldInfo member, int[] parentIndex)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x17000424")]
		public long ContainerID
		{
			[Token(Token = "0x6001FAD")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000425")]
		public System.Reflection.FieldInfo ParentField
		{
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000426")]
		public int[] ParentIndex
		{
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x10")]
		private readonly long _containerID;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x18")]
		private readonly System.Reflection.FieldInfo _parentField;

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] _parentIndex;
	}
}
