using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000526")]
	public static class CustomAttributeExtensions
	{
		// Token: 0x060025F3 RID: 9715 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x4BD1540", Offset = "0x4BD0140", VA = "0x184BD1540")]
		public static System.Attribute GetCustomAttribute(this Assembly element, System.Type attributeType)
		{
			return null;
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x4BD1550", Offset = "0x4BD0150", VA = "0x184BD1550")]
		public static System.Attribute GetCustomAttribute(this MemberInfo element, System.Type attributeType)
		{
			return null;
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F5")]
		public static T GetCustomAttribute<T>(this Assembly element) where T : System.Attribute
		{
			return null;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F6")]
		public static T GetCustomAttribute<T>(this MemberInfo element) where T : System.Attribute
		{
			return null;
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x4BD1560", Offset = "0x4BD0160", VA = "0x184BD1560")]
		public static System.Attribute GetCustomAttribute(this MemberInfo element, System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F8")]
		public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : System.Attribute
		{
			return null;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x4BD1580", Offset = "0x4BD0180", VA = "0x184BD1580")]
		public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this MemberInfo element, System.Type attributeType)
		{
			return null;
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025FA")]
		public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : System.Attribute
		{
			return null;
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x4BD1570", Offset = "0x4BD0170", VA = "0x184BD1570")]
		public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this MemberInfo element, System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025FC")]
		public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : System.Attribute
		{
			return null;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x4BD1590", Offset = "0x4BD0190", VA = "0x184BD1590")]
		public static bool IsDefined(this MemberInfo element, System.Type attributeType)
		{
			return default(bool);
		}
	}
}
