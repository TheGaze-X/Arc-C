using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	[Preserve]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x4DA3100", Offset = "0x4DA1D00", VA = "0x184DA3100")]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x4DA3600", Offset = "0x4DA2200", VA = "0x184DA3600", Slot = "4")]
		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x4DA3490", Offset = "0x4DA2090", VA = "0x184DA3490", Slot = "5")]
		public string GetReference(object context, object value)
		{
			return null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4DA3080", Offset = "0x4DA1C80", VA = "0x184DA3080", Slot = "7")]
		public void AddReference(object context, string reference, object value)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4DA3580", Offset = "0x4DA2180", VA = "0x184DA3580", Slot = "6")]
		public bool IsReferenced(object context, object value)
		{
			return default(bool);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultReferenceResolver()
		{
		}

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x10")]
		private int _referenceCount;
	}
}
