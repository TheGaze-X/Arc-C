using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x4E182C0", Offset = "0x4E16EC0", VA = "0x184E182C0")]
		internal DelegatingTypeDescriptionProvider(Type type)
		{
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		internal TypeDescriptionProvider Provider
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x5143610", Offset = "0x5142210", VA = "0x185143610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5143030", Offset = "0x5141C30", VA = "0x185143030", Slot = "4")]
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x51430F0", Offset = "0x5141CF0", VA = "0x1851430F0", Slot = "5")]
		public override IDictionary GetCache(object instance)
		{
			return null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x51432D0", Offset = "0x5141ED0", VA = "0x1851432D0", Slot = "8")]
		public override string GetFullComponentName(object component)
		{
			return null;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x5143190", Offset = "0x5141D90", VA = "0x185143190", Slot = "6")]
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x5143230", Offset = "0x5141E30", VA = "0x185143230", Slot = "7")]
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5143370", Offset = "0x5141F70", VA = "0x185143370", Slot = "9")]
		public override Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x5143420", Offset = "0x5142020", VA = "0x185143420", Slot = "10")]
		public override Type GetRuntimeType(Type objectType)
		{
			return null;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x51434C0", Offset = "0x51420C0", VA = "0x1851434C0", Slot = "11")]
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x5143570", Offset = "0x5142170", VA = "0x185143570", Slot = "12")]
		public override bool IsSupportedType(Type type)
		{
			return default(bool);
		}

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x20")]
		private readonly Type _type;
	}
}
