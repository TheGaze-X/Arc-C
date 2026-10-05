using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public struct JArrayWrapper : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x54FEAD0", Offset = "0x54FD6D0", VA = "0x1854FEAD0")]
		public JArrayWrapper(JArray obj)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005D")]
		public JArray rawObj
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x54FEB40", Offset = "0x54FD740", VA = "0x1854FEB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x54FE970", Offset = "0x54FD570", VA = "0x1854FE970")]
		public bool IsNull()
		{
			return default(bool);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000554C File Offset: 0x0000374C
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x54FE740", Offset = "0x54FD340", VA = "0x1854FE740")]
		public long GetLong(int index)
		{
			return 0L;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00005564 File Offset: 0x00003764
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x54FE6B0", Offset = "0x54FD2B0", VA = "0x1854FE6B0")]
		public int GetInt(int index)
		{
			return 0;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x54FE620", Offset = "0x54FD220", VA = "0x1854FE620")]
		public float GetFloat(int index)
		{
			return 0f;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x54FE590", Offset = "0x54FD190", VA = "0x1854FE590")]
		public double GetDouble(int index)
		{
			return 0.0;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x54FE490", Offset = "0x54FD090", VA = "0x1854FE490")]
		public bool GetBool(int index)
		{
			return default(bool);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x54FE8E0", Offset = "0x54FD4E0", VA = "0x1854FE8E0")]
		public string GetString(int index)
		{
			return null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x54FE7D0", Offset = "0x54FD3D0", VA = "0x1854FE7D0")]
		public JObjectWrapper GetObject(int index)
		{
			return default(JObjectWrapper);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x54FE3A0", Offset = "0x54FCFA0", VA = "0x1854FE3A0")]
		public JArrayWrapper GetArray(int index)
		{
			return default(JArrayWrapper);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x54FE520", Offset = "0x54FD120", VA = "0x1854FE520")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x54FE9D0", Offset = "0x54FD5D0", VA = "0x1854FE9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A9")]
		private T _GetValue<T>(int index)
		{
			return null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x54FEA80", Offset = "0x54FD680", VA = "0x1854FEA80")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x0")]
		private JArray m_obj;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate69 _c__Hotfix0_ctor;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate70 __Hotfix0_get_rawObj;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate71 __Hotfix0_IsNull;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate72 __Hotfix0_GetLong;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate73 __Hotfix0_GetInt;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate74 __Hotfix0_GetFloat;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate75 __Hotfix0_GetDouble;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate76 __Hotfix0_GetBool;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate77 __Hotfix0_GetString;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate78 __Hotfix0_GetObject;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate79 __Hotfix0_GetArray;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate80 __Hotfix0_GetCount;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate81 __Hotfix0_ToString;
	}
}
