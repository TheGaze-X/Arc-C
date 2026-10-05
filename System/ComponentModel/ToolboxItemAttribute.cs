using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	[AttributeUsage(AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x5156090", Offset = "0x5154C90", VA = "0x185156090", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x5156310", Offset = "0x5154F10", VA = "0x185156310")]
		public ToolboxItemAttribute(bool defaultType)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x5156280", Offset = "0x5154E80", VA = "0x185156280")]
		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x5156370", Offset = "0x5154F70", VA = "0x185156370")]
		public ToolboxItemAttribute(Type toolboxItemType)
		{
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020A")]
		public Type ToolboxItemType
		{
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x5156440", Offset = "0x5155040", VA = "0x185156440")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020B")]
		public string ToolboxItemTypeName
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x51563F0", Offset = "0x5154FF0", VA = "0x1851563F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x5155F00", Offset = "0x5154B00", VA = "0x185155F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x5156040", Offset = "0x5154C40", VA = "0x185156040", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		[FieldOffset(Offset = "0x10")]
		private Type _toolboxItemType;

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[FieldOffset(Offset = "0x18")]
		private string _toolboxItemTypeName;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ToolboxItemAttribute Default;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ToolboxItemAttribute None;
	}
}
