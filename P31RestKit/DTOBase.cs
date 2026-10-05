using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class DTOBase
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007D")]
		public static List<T> listFromJson<T>(string json) where T : DTOBase
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4E049B0", Offset = "0x4E035B0", VA = "0x184E049B0")]
		public void setDataFromJson(string json)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4E047B0", Offset = "0x4E033B0", VA = "0x184E047B0")]
		public void setDataFromDictionary(Dictionary<string, object> dict)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4E04A70", Offset = "0x4E03670", VA = "0x184E04A70")]
		private bool shouldIncludeTypeWithSetters(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4E04320", Offset = "0x4E02F20", VA = "0x184E04320")]
		protected Dictionary<string, Action<object>> getMembersWithSetters()
		{
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4E04080", Offset = "0x4E02C80", VA = "0x184E04080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DTOBase()
		{
		}
	}
}
