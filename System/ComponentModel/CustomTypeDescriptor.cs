using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		// Token: 0x060009F6 RID: 2550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CustomTypeDescriptor()
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected CustomTypeDescriptor(ICustomTypeDescriptor parent)
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x5140EE0", Offset = "0x513FAE0", VA = "0x185140EE0", Slot = "16")]
		public virtual AttributeCollection GetAttributes()
		{
			return null;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x5140FE0", Offset = "0x513FBE0", VA = "0x185140FE0", Slot = "17")]
		public virtual string GetClassName()
		{
			return null;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x5141030", Offset = "0x513FC30", VA = "0x185141030", Slot = "18")]
		public virtual string GetComponentName()
		{
			return null;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x5141080", Offset = "0x513FC80", VA = "0x185141080", Slot = "19")]
		public virtual TypeConverter GetConverter()
		{
			return null;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x5141190", Offset = "0x513FD90", VA = "0x185141190", Slot = "20")]
		public virtual EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x5141270", Offset = "0x513FE70", VA = "0x185141270", Slot = "21")]
		public virtual PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x5141350", Offset = "0x513FF50", VA = "0x185141350", Slot = "22")]
		public virtual object GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x51413B0", Offset = "0x513FFB0", VA = "0x1851413B0", Slot = "23")]
		public virtual EventDescriptorCollection GetEvents()
		{
			return null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x51414C0", Offset = "0x51400C0", VA = "0x1851414C0", Slot = "24")]
		public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x5141700", Offset = "0x5140300", VA = "0x185141700", Slot = "25")]
		public virtual PropertyDescriptorCollection GetProperties()
		{
			return null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x51415E0", Offset = "0x51401E0", VA = "0x1851415E0", Slot = "26")]
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x5141810", Offset = "0x5140410", VA = "0x185141810", Slot = "27")]
		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x10")]
		private readonly ICustomTypeDescriptor _parent;
	}
}
