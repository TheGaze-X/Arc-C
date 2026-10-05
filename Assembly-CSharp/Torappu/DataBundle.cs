using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	[Serializable]
	public class DataBundle : ILuaCallCSharp, IHotfixable
	{
		// Token: 0x06005A4C RID: 23116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0x1AED300", Offset = "0x1AEBF00", VA = "0x181AED300")]
		public void SetInt(string key, int value)
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x0002E908 File Offset: 0x0002CB08
		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0x1AECAD0", Offset = "0x1AEB6D0", VA = "0x181AECAD0")]
		public int GetInt(string key, int defValue = 0)
		{
			return 0;
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0x1AED3B0", Offset = "0x1AEBFB0", VA = "0x181AED3B0")]
		public void SetLong(string key, long value)
		{
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x0002E920 File Offset: 0x0002CB20
		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0x1AECB80", Offset = "0x1AEB780", VA = "0x181AECB80")]
		public long GetLong(string key, long defValue = 0L)
		{
			return 0L;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A50")]
		[Address(RVA = "0x1AED1A0", Offset = "0x1AEBDA0", VA = "0x181AED1A0")]
		public void SetFloat(string key, float value)
		{
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x0002E938 File Offset: 0x0002CB38
		[Token(Token = "0x6005A51")]
		[Address(RVA = "0x1AEC970", Offset = "0x1AEB570", VA = "0x181AEC970")]
		public float GetFloat(string key, float defValue = 0f)
		{
			return 0f;
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A52")]
		[Address(RVA = "0x1AECEE0", Offset = "0x1AEBAE0", VA = "0x181AECEE0")]
		public void SetBool(string key, bool value)
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x0002E950 File Offset: 0x0002CB50
		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x1AEC6B0", Offset = "0x1AEB2B0", VA = "0x181AEC6B0")]
		public bool GetBool(string key, bool defValue = false)
		{
			return default(bool);
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x1AED0F0", Offset = "0x1AEBCF0", VA = "0x181AED0F0")]
		public void SetDouble(string key, double value)
		{
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x0002E968 File Offset: 0x0002CB68
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0x1AEC8C0", Offset = "0x1AEB4C0", VA = "0x181AEC8C0")]
		public double GetDouble(string key, double defValue = 0.0)
		{
			return 0.0;
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x1AED510", Offset = "0x1AEC110", VA = "0x181AED510")]
		public void SetString(string key, string value)
		{
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A57")]
		[Address(RVA = "0x1AECCE0", Offset = "0x1AEB8E0", VA = "0x181AECCE0")]
		public string GetString(string key, [Optional] string defValue)
		{
			return null;
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A58")]
		[Address(RVA = "0x1AED040", Offset = "0x1AEBC40", VA = "0x181AED040")]
		public void SetDataBundle(string key, DataBundle value)
		{
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A59")]
		[Address(RVA = "0x1AEC810", Offset = "0x1AEB410", VA = "0x181AEC810")]
		public DataBundle GetDataBundle(string key, [Optional] DataBundle defValue)
		{
			return null;
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5A")]
		[Address(RVA = "0x1AECF90", Offset = "0x1AEBB90", VA = "0x181AECF90")]
		public void SetDataBundleList(string key, List<DataBundle> bundles)
		{
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0x1AEC760", Offset = "0x1AEB360", VA = "0x181AEC760")]
		public List<DataBundle> GetDataBundleList(string key, [Optional] List<DataBundle> defValue)
		{
			return null;
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0x1AED460", Offset = "0x1AEC060", VA = "0x181AED460")]
		public void SetStringList(string key, List<string> strs)
		{
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0x1AECC30", Offset = "0x1AEB830", VA = "0x181AECC30")]
		public List<string> GetStringList(string key, [Optional] List<string> defValue)
		{
			return null;
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0x1AED250", Offset = "0x1AEBE50", VA = "0x181AED250")]
		public void SetIntList(string key, List<int> ints)
		{
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0x1AECA20", Offset = "0x1AEB620", VA = "0x181AECA20")]
		public List<int> GetIntList(string key, [Optional] List<int> defValue)
		{
			return null;
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A60")]
		[Address(RVA = "0x1AED5C0", Offset = "0x1AEC1C0", VA = "0x181AED5C0")]
		public void SetTypeParam(string key, Type type)
		{
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A61")]
		[Address(RVA = "0x1AECD90", Offset = "0x1AEB990", VA = "0x181AECD90")]
		public Type GetTypeParam(string key, [Optional] Type defValue)
		{
			return null;
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x0002E980 File Offset: 0x0002CB80
		[Token(Token = "0x6005A62")]
		[Address(RVA = "0x1AECE40", Offset = "0x1AEBA40", VA = "0x181AECE40")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A63")]
		[Address(RVA = "0x1AEC620", Offset = "0x1AEB220", VA = "0x181AEC620")]
		public void Clear()
		{
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A64")]
		private void _Set<TValue>(string key, TValue value)
		{
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A65")]
		private TValue _Get<TValue>(string key, TValue defValue)
		{
			return null;
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A66")]
		[Address(RVA = "0x1AED670", Offset = "0x1AEC270", VA = "0x181AED670")]
		public DataBundle()
		{
		}

		// Token: 0x04002022 RID: 8226
		[Token(Token = "0x4002022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ListDict<string, object> m_storage;

		// Token: 0x04002023 RID: 8227
		[Token(Token = "0x4002023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInt;

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetInt;

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetLong;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLong;

		// Token: 0x04002027 RID: 8231
		[Token(Token = "0x4002027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetFloat;

		// Token: 0x04002028 RID: 8232
		[Token(Token = "0x4002028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFloat;

		// Token: 0x04002029 RID: 8233
		[Token(Token = "0x4002029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetBool;

		// Token: 0x0400202A RID: 8234
		[Token(Token = "0x400202A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBool;

		// Token: 0x0400202B RID: 8235
		[Token(Token = "0x400202B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetDouble;

		// Token: 0x0400202C RID: 8236
		[Token(Token = "0x400202C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetDouble;

		// Token: 0x0400202D RID: 8237
		[Token(Token = "0x400202D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetString;

		// Token: 0x0400202E RID: 8238
		[Token(Token = "0x400202E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetString;

		// Token: 0x0400202F RID: 8239
		[Token(Token = "0x400202F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetDataBundle;

		// Token: 0x04002030 RID: 8240
		[Token(Token = "0x4002030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetDataBundle;

		// Token: 0x04002031 RID: 8241
		[Token(Token = "0x4002031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetDataBundleList;

		// Token: 0x04002032 RID: 8242
		[Token(Token = "0x4002032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetDataBundleList;

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetStringList;

		// Token: 0x04002034 RID: 8244
		[Token(Token = "0x4002034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetStringList;

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetIntList;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetIntList;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetTypeParam;

		// Token: 0x04002038 RID: 8248
		[Token(Token = "0x4002038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetTypeParam;

		// Token: 0x04002039 RID: 8249
		[Token(Token = "0x4002039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Remove;

		// Token: 0x0400203A RID: 8250
		[Token(Token = "0x400203A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400203B RID: 8251
		[Token(Token = "0x400203B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__Set;

		// Token: 0x0400203C RID: 8252
		[Token(Token = "0x400203C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__Get;

		// Token: 0x0400203D RID: 8253
		[Token(Token = "0x400203D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
