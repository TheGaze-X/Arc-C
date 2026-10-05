using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[Preserve]
	public class ReflectionValueProvider : IValueProvider
	{
		// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x4DDB0D0", Offset = "0x4DD9CD0", VA = "0x184DDB0D0")]
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x4DDAF70", Offset = "0x4DD9B70", VA = "0x184DDAF70", Slot = "4")]
		public void SetValue(object target, object value)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x4DDAE20", Offset = "0x4DD9A20", VA = "0x184DDAE20", Slot = "5")]
		public object GetValue(object target)
		{
			return null;
		}

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemberInfo _memberInfo;
	}
}
