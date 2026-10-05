using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Preserve]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class JsonContainerAttribute : Attribute
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000D")]
		public string Id
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000E")]
		public string Title
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000F")]
		public string Description
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000010")]
		public Type ItemConverterType
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000011")]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000012")]
		public bool IsReference
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x4D60ED0", Offset = "0x4D5FAD0", VA = "0x184D60ED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x4D61010", Offset = "0x4D5FC10", VA = "0x184D61010")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000013")]
		public bool ItemIsReference
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x4D60F20", Offset = "0x4D5FB20", VA = "0x184D60F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x4D61070", Offset = "0x4D5FC70", VA = "0x184D61070")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000014")]
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x4D60F70", Offset = "0x4D5FB70", VA = "0x184D60F70")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x4D610D0", Offset = "0x4D5FCD0", VA = "0x184D610D0")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000015")]
		public TypeNameHandling ItemTypeNameHandling
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x4D60FC0", Offset = "0x4D5FBC0", VA = "0x184D60FC0")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x4D61130", Offset = "0x4D5FD30", VA = "0x184D61130")]
			set
			{
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected JsonContainerAttribute()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		protected JsonContainerAttribute(string id)
		{
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x38")]
		internal bool? _isReference;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x3A")]
		internal bool? _itemIsReference;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x3C")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x44")]
		internal TypeNameHandling? _itemTypeNameHandling;
	}
}
