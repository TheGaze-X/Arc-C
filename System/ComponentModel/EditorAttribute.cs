using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x5143DF0", Offset = "0x51429F0", VA = "0x185143DF0")]
		public EditorAttribute()
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x5143D50", Offset = "0x5142950", VA = "0x185143D50")]
		public EditorAttribute(string typeName, string baseTypeName)
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x5143C80", Offset = "0x5142880", VA = "0x185143C80")]
		public EditorAttribute(string typeName, Type baseType)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x5143BD0", Offset = "0x51427D0", VA = "0x185143BD0")]
		public EditorAttribute(Type type, Type baseType)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020F")]
		public string EditorBaseTypeName
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000210")]
		public string EditorTypeName
		{
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000211")]
		public override object TypeId
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x5143E60", Offset = "0x5142A60", VA = "0x185143E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x5143B20", Offset = "0x5142720", VA = "0x185143B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x10")]
		private string _typeId;
	}
}
