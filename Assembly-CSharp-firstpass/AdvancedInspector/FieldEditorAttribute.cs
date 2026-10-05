using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class FieldEditorAttribute : Attribute, IListAttribute
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002C")]
		public string Type
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4EEBE0", Offset = "0x4ED7E0", VA = "0x1804EEBE0")]
		public FieldEditorAttribute(string type)
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x10")]
		private string type;
	}
}
