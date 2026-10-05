using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	[Conditional("FALSE")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class DesignerAttribute : Attribute
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x515B260", Offset = "0x5159E60", VA = "0x18515B260")]
		public DesignerAttribute(string designerTypeName)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x515B370", Offset = "0x5159F70", VA = "0x18515B370")]
		public DesignerAttribute(Type designerType)
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x515B520", Offset = "0x515A120", VA = "0x18515B520")]
		public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x515B190", Offset = "0x5159D90", VA = "0x18515B190")]
		public DesignerAttribute(string designerTypeName, Type designerBaseType)
		{
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x515B470", Offset = "0x515A070", VA = "0x18515B470")]
		public DesignerAttribute(Type designerType, Type designerBaseType)
		{
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DA")]
		public string DesignerBaseTypeName
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DB")]
		public string DesignerTypeName
		{
			[Token(Token = "0x6000DA7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DC")]
		public override object TypeId
		{
			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x515B5C0", Offset = "0x515A1C0", VA = "0x18515B5C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x515B050", Offset = "0x5159C50", VA = "0x18515B050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x515B100", Offset = "0x5159D00", VA = "0x18515B100", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x10")]
		private readonly string designerTypeName;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x18")]
		private readonly string designerBaseTypeName;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x20")]
		private string typeId;
	}
}
