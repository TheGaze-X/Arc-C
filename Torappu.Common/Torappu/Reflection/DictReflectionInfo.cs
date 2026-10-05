using System;
using System.Reflection;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Reflection
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	public class DictReflectionInfo : IHotfixable
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x5513E40", Offset = "0x5512A40", VA = "0x185513E40")]
		private DictReflectionInfo()
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000067F4 File Offset: 0x000049F4
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x5513590", Offset = "0x5512190", VA = "0x185513590")]
		public static bool TryCreateInfo(Type dictType, out DictReflectionInfo dictInfo)
		{
			return default(bool);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x5513210", Offset = "0x5511E10", VA = "0x185513210")]
		public object CreateInstance()
		{
			return null;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0000680C File Offset: 0x00004A0C
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x5513B90", Offset = "0x5512790", VA = "0x185513B90")]
		public bool TryGetValue(object dict, object key, object[] objects2, out object value)
		{
			return default(bool);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00006824 File Offset: 0x00004A24
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x5513350", Offset = "0x5511F50", VA = "0x185513350")]
		public bool TryAdd(object dict, object[] objects2, object key, object value)
		{
			return default(bool);
		}

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x10")]
		public Type dictType;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x18")]
		public Type keyType;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x20")]
		public Type valueType;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x28")]
		public MethodInfo methodAdd;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x30")]
		public MethodInfo methodTryGetValue;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x38")]
		public PropertyInfo keyProp;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x40")]
		public PropertyInfo valueProp;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate131 __Hotfix0_TryCreateInfo;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate132 __Hotfix0_CreateInstance;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate133 __Hotfix0_TryGetValue;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate134 __Hotfix0_TryAdd;
	}
}
