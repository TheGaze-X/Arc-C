using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4E19E60", Offset = "0x4E18A60", VA = "0x184E19E60")]
		public ResponsiveButtonGroupAttribute(string group = "_DefaultResponsiveButtonGroup")
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4E19DA0", Offset = "0x4E189A0", VA = "0x184E19DA0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x38")]
		public ButtonSizes DefaultButtonSize;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x3C")]
		public bool UniformLayout;
	}
}
