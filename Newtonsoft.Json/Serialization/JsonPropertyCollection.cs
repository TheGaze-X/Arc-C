using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[Preserve]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x4DA9390", Offset = "0x4DA7F90", VA = "0x184DA9390")]
		public JsonPropertyCollection(Type type)
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x4DA9070", Offset = "0x4DA7C70", VA = "0x184DA9070", Slot = "39")]
		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x4DA8DE0", Offset = "0x4DA79E0", VA = "0x184DA8DE0")]
		public void AddProperty(JsonProperty property)
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4DA9030", Offset = "0x4DA7C30", VA = "0x184DA9030")]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x4DA9260", Offset = "0x4DA7E60", VA = "0x184DA9260")]
		private new bool TryGetValue(string key, out JsonProperty item)
		{
			return default(bool);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x4DA9090", Offset = "0x4DA7C90", VA = "0x184DA9090")]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x30")]
		private readonly Type _type;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<JsonProperty> _list;
	}
}
