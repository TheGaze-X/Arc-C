using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public class RuntimeReflectionUtils : IHotfixable
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x5500C20", Offset = "0x54FF820", VA = "0x185500C20")]
		public static void InheritFindFields(Type type, BindingFlags flags, List<FieldInfo> outFields, [Optional] Func<Type, bool> typeFilter)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x5500A30", Offset = "0x54FF630", VA = "0x185500A30")]
		public static bool CheckIfTorappuBasedClass(Type type)
		{
			return default(bool);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E7")]
		public static T CreateInstanceByType<T>(T reusableInst, Type type, params object[] args) where T : class
		{
			return null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x5500D90", Offset = "0x54FF990", VA = "0x185500D90")]
		public RuntimeReflectionUtils()
		{
		}

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		private const string TORAPPU_BASE_NS = "Torappu";

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate82 __Hotfix0_InheritFindFields;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckIfTorappuBasedClass;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
