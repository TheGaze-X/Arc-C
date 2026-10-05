using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[Preserve]
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BB")]
		internal JsonContract ItemContract
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x4D897F0", Offset = "0x4D883F0", VA = "0x184D897F0")]
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		internal JsonContract FinalItemContract
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BD")]
		public JsonConverter ItemConverter
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00003C60 File Offset: 0x00001E60
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BE")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x4D897C0", Offset = "0x4D883C0", VA = "0x184D897C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x4D89890", Offset = "0x4D88490", VA = "0x184D89890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BF")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x4D897D0", Offset = "0x4D883D0", VA = "0x184D897D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x4D898A0", Offset = "0x4D884A0", VA = "0x184D898A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00003C90 File Offset: 0x00001E90
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C0")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x4D897E0", Offset = "0x4D883E0", VA = "0x184D897E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x4D898B0", Offset = "0x4D884B0", VA = "0x184D898B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x4D896C0", Offset = "0x4D882C0", VA = "0x184D896C0")]
		internal JsonContainerContract(Type underlyingType)
		{
		}

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x90")]
		private JsonContract _itemContract;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x98")]
		private JsonContract _finalItemContract;
	}
}
