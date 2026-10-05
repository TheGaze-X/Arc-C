using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	[AttributeUsage(AttributeTargets.All)]
	public class PropertyTabAttribute : Attribute
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x5154DB0", Offset = "0x51539B0", VA = "0x185154DB0")]
		public PropertyTabAttribute()
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x51552C0", Offset = "0x5153EC0", VA = "0x1851552C0")]
		public PropertyTabAttribute(Type tabClass)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x51551C0", Offset = "0x5153DC0", VA = "0x1851551C0")]
		public PropertyTabAttribute(string tabClassName)
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x5155020", Offset = "0x5153C20", VA = "0x185155020")]
		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5154E80", Offset = "0x5153A80", VA = "0x185154E80")]
		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000207")]
		public Type[] TabClasses
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x5155440", Offset = "0x5154040", VA = "0x185155440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000208")]
		protected string[] TabClassNames
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x51553C0", Offset = "0x5153FC0", VA = "0x1851553C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000209")]
		public PropertyTabScope[] TabScopes
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x5154690", Offset = "0x5153290", VA = "0x185154690", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x51547B0", Offset = "0x51533B0", VA = "0x1851547B0")]
		public bool Equals(PropertyTabAttribute other)
		{
			return default(bool);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x5154D90", Offset = "0x5153990", VA = "0x185154D90")]
		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x5154960", Offset = "0x5153560", VA = "0x185154960")]
		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x5154980", Offset = "0x5153580", VA = "0x185154980")]
		private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x10")]
		private Type[] _tabClasses;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x18")]
		private string[] _tabClassNames;
	}
}
