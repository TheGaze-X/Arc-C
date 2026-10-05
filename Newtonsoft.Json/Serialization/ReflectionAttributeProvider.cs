using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	[Preserve]
	public class ReflectionAttributeProvider : IAttributeProvider
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x4D91160", Offset = "0x4D8FD60", VA = "0x184D91160")]
		public ReflectionAttributeProvider(object attributeProvider)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x4D91100", Offset = "0x4D8FD00", VA = "0x184D91100", Slot = "4")]
		public IList<Attribute> GetAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x4D91090", Offset = "0x4D8FC90", VA = "0x184D91090", Slot = "5")]
		public IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _attributeProvider;
	}
}
