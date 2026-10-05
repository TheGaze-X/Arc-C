using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Preserve]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003B")]
		public Type ItemConverterType
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003C")]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003D")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x4D669A0", Offset = "0x4D655A0", VA = "0x184D669A0")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4D66D60", Offset = "0x4D65960", VA = "0x184D66D60")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003E")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x4D66810", Offset = "0x4D65410", VA = "0x184D66810")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x4D66B80", Offset = "0x4D65780", VA = "0x184D66B80")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003F")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x4D66A90", Offset = "0x4D65690", VA = "0x184D66A90")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4D66E80", Offset = "0x4D65A80", VA = "0x184D66E80")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000040")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4D669F0", Offset = "0x4D655F0", VA = "0x184D669F0")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4D66DC0", Offset = "0x4D659C0", VA = "0x184D66DC0")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000041")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x4D66B30", Offset = "0x4D65730", VA = "0x184D66B30")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4D66F40", Offset = "0x4D65B40", VA = "0x184D66F40")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000042")]
		public bool IsReference
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x4D66860", Offset = "0x4D65460", VA = "0x184D66860")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x4D66BE0", Offset = "0x4D657E0", VA = "0x184D66BE0")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000043")]
		public int Order
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x4D66A40", Offset = "0x4D65640", VA = "0x184D66A40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x4D66E20", Offset = "0x4D65A20", VA = "0x184D66E20")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000044")]
		public Required Required
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x4D66AE0", Offset = "0x4D656E0", VA = "0x184D66AE0")]
			get
			{
				return Required.Default;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x4D66EE0", Offset = "0x4D65AE0", VA = "0x184D66EE0")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000045")]
		public string PropertyName
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000046")]
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x4D66900", Offset = "0x4D65500", VA = "0x184D66900")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x4D66CA0", Offset = "0x4D658A0", VA = "0x184D66CA0")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000047")]
		public TypeNameHandling ItemTypeNameHandling
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4D66950", Offset = "0x4D65550", VA = "0x184D66950")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x4D66D00", Offset = "0x4D65900", VA = "0x184D66D00")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000048")]
		public bool ItemIsReference
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x4D668B0", Offset = "0x4D654B0", VA = "0x184D668B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x4D66C40", Offset = "0x4D65840", VA = "0x184D66C40")]
			set
			{
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public JsonPropertyAttribute()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4D667E0", Offset = "0x4D653E0", VA = "0x184D667E0")]
		public JsonPropertyAttribute(string propertyName)
		{
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x18")]
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x20")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x28")]
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x30")]
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x38")]
		internal bool? _isReference;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x3C")]
		internal int? _order;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x44")]
		internal Required? _required;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x4C")]
		internal bool? _itemIsReference;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x50")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x58")]
		internal TypeNameHandling? _itemTypeNameHandling;
	}
}
