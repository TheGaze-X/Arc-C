using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel.Design.Serialization
{
	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x51879B0", Offset = "0x51865B0", VA = "0x1851879B0")]
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000316")]
		public string SerializerBaseTypeName
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000317")]
		public override object TypeId
		{
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x5187A10", Offset = "0x5186610", VA = "0x185187A10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x10")]
		private string _typeId;
	}
}
