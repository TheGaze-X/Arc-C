using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D4 RID: 5076
	[Token(Token = "0x20013D4")]
	public class ListDictConverter : JsonConverter
	{
		// Token: 0x060073DA RID: 29658 RVA: 0x000337F8 File Offset: 0x000319F8
		[Token(Token = "0x60073DA")]
		[Address(RVA = "0x2208440", Offset = "0x2207040", VA = "0x182208440")]
		private ListDictConverter.GenericContext _GetGenericContext(Type genericType)
		{
			return default(ListDictConverter.GenericContext);
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00033810 File Offset: 0x00031A10
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x2207AC0", Offset = "0x22066C0", VA = "0x182207AC0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DC")]
		[Address(RVA = "0x2207C10", Offset = "0x2206810", VA = "0x182207C10", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0x22080F0", Offset = "0x2206CF0", VA = "0x1822080F0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0x2208600", Offset = "0x2207200", VA = "0x182208600")]
		public ListDictConverter()
		{
		}

		// Token: 0x040070C9 RID: 28873
		[Token(Token = "0x40070C9")]
		private const string KEY_NAME = "Key";

		// Token: 0x040070CA RID: 28874
		[Token(Token = "0x40070CA")]
		private const string VALUE_NAME = "Value";

		// Token: 0x040070CB RID: 28875
		[Token(Token = "0x40070CB")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, ListDictConverter.GenericContext> m_genericMap;

		// Token: 0x040070CC RID: 28876
		[Token(Token = "0x40070CC")]
		[FieldOffset(Offset = "0x18")]
		private object m_lock;

		// Token: 0x020013D5 RID: 5077
		[Token(Token = "0x20013D5")]
		private struct GenericContext
		{
			// Token: 0x060073DF RID: 29663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60073DF")]
			[Address(RVA = "0x2205ED0", Offset = "0x2204AD0", VA = "0x182205ED0")]
			public GenericContext(Type genericType)
			{
			}

			// Token: 0x040070CD RID: 28877
			[Token(Token = "0x40070CD")]
			[FieldOffset(Offset = "0x0")]
			public Type dictCls;

			// Token: 0x040070CE RID: 28878
			[Token(Token = "0x40070CE")]
			[FieldOffset(Offset = "0x8")]
			public Type listDictCls;

			// Token: 0x040070CF RID: 28879
			[Token(Token = "0x40070CF")]
			[FieldOffset(Offset = "0x10")]
			public Type keyValueCls;

			// Token: 0x040070D0 RID: 28880
			[Token(Token = "0x40070D0")]
			[FieldOffset(Offset = "0x18")]
			public PropertyInfo keyProp;

			// Token: 0x040070D1 RID: 28881
			[Token(Token = "0x40070D1")]
			[FieldOffset(Offset = "0x20")]
			public PropertyInfo valueProp;
		}
	}
}
