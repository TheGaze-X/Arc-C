using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = true)]
	public class OdinRegisterAttributeAttribute : Attribute
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4E19090", Offset = "0x4E17C90", VA = "0x184E19090")]
		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4E19000", Offset = "0x4E17C00", VA = "0x184E19000")]
		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise, string url)
		{
		}

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x10")]
		public Type AttributeType;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x18")]
		public string Categories;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x20")]
		public string Description;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x28")]
		public string DocumentationUrl;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x30")]
		public bool IsEnterprise;
	}
}
