using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public struct JObjectWrapper : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x54FF410", Offset = "0x54FE010", VA = "0x1854FF410")]
		public JObjectWrapper(JObject obj)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005C")]
		public JObject rawObj
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x54FF4A0", Offset = "0x54FE0A0", VA = "0x1854FF4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x54FF270", Offset = "0x54FDE70", VA = "0x1854FF270")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x54FEFE0", Offset = "0x54FDBE0", VA = "0x1854FEFE0")]
		public long GetLong(string name)
		{
			return 0L;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000054A4 File Offset: 0x000036A4
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x54FEF10", Offset = "0x54FDB10", VA = "0x1854FEF10")]
		public int GetInt(string name, int defVal = 0)
		{
			return 0;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x54FEE40", Offset = "0x54FDA40", VA = "0x1854FEE40")]
		public float GetFloat(string name, float defVal = 0f)
		{
			return 0f;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x54FED70", Offset = "0x54FD970", VA = "0x1854FED70")]
		public double GetDouble(string name, double defVal = 0.0)
		{
			return 0.0;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x54FECC0", Offset = "0x54FD8C0", VA = "0x1854FECC0")]
		public bool GetBool(string name)
		{
			return default(bool);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x54FF1C0", Offset = "0x54FDDC0", VA = "0x1854FF1C0")]
		public string GetString(string name)
		{
			return null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x54FF090", Offset = "0x54FDC90", VA = "0x1854FF090")]
		public JObjectWrapper GetObject(string name)
		{
			return default(JObjectWrapper);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x54FEBA0", Offset = "0x54FD7A0", VA = "0x1854FEBA0")]
		public JArrayWrapper GetArray(string name)
		{
			return default(JArrayWrapper);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x54FF2F0", Offset = "0x54FDEF0", VA = "0x1854FF2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000499")]
		private T _GetValue<T>(string name, [Optional] T defVal)
		{
			return null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x54FF3C0", Offset = "0x54FDFC0", VA = "0x1854FF3C0")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static JObjectWrapper EMPTY;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private JObject m_obj;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate57 _c__Hotfix0_ctor;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate58 __Hotfix0_get_rawObj;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate59 __Hotfix0_IsEmpty;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate60 __Hotfix0_GetLong;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate61 __Hotfix0_GetInt;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate62 __Hotfix0_GetFloat;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate63 __Hotfix0_GetDouble;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate64 __Hotfix0_GetBool;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate65 __Hotfix0_GetString;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate66 __Hotfix0_GetObject;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate67 __Hotfix0_GetArray;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate68 __Hotfix0_ToString;
	}
}
