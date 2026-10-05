using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	public abstract class TypeDescriptionProvider
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TypeDescriptionProvider()
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected TypeDescriptionProvider(TypeDescriptionProvider parent)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x51752E0", Offset = "0x5173EE0", VA = "0x1851752E0", Slot = "4")]
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x5175410", Offset = "0x5174010", VA = "0x185175410", Slot = "5")]
		public virtual IDictionary GetCache(object instance)
		{
			return null;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x5175470", Offset = "0x5174070", VA = "0x185175470", Slot = "6")]
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x5175540", Offset = "0x5174140", VA = "0x185175540", Slot = "7")]
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x5175620", Offset = "0x5174220", VA = "0x185175620", Slot = "8")]
		public virtual string GetFullComponentName(object component)
		{
			return null;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x51757D0", Offset = "0x51743D0", VA = "0x1851757D0")]
		public Type GetReflectionType(Type objectType)
		{
			return null;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x5175820", Offset = "0x5174420", VA = "0x185175820")]
		public Type GetReflectionType(object instance)
		{
			return null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x5175760", Offset = "0x5174360", VA = "0x185175760", Slot = "9")]
		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x51758E0", Offset = "0x51744E0", VA = "0x1851758E0", Slot = "10")]
		public virtual Type GetRuntimeType(Type reflectionType)
		{
			return null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x5175C60", Offset = "0x5174860", VA = "0x185175C60")]
		public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			return null;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x5175BA0", Offset = "0x51747A0", VA = "0x185175BA0")]
		public ICustomTypeDescriptor GetTypeDescriptor(object instance)
		{
			return null;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x5175AD0", Offset = "0x51746D0", VA = "0x185175AD0", Slot = "11")]
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x5175CB0", Offset = "0x51748B0", VA = "0x185175CB0", Slot = "12")]
		public virtual bool IsSupportedType(Type type)
		{
			return default(bool);
		}

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x10")]
		private readonly TypeDescriptionProvider _parent;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x18")]
		private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

		// Token: 0x020001E8 RID: 488
		[Token(Token = "0x20001E8")]
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
			// Token: 0x06000D08 RID: 3336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public EmptyCustomTypeDescriptor()
			{
			}
		}
	}
}
