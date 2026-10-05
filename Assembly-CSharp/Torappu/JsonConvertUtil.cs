using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu
{
	// Token: 0x020013D0 RID: 5072
	[Token(Token = "0x20013D0")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class JsonConvertUtil
	{
		// Token: 0x060073CB RID: 29643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CB")]
		[Address(RVA = "0x2207000", Offset = "0x2205C00", VA = "0x182207000")]
		public static void PopulateJson(JObject patch, JObject target)
		{
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CC")]
		[Address(RVA = "0x2206810", Offset = "0x2205410", VA = "0x182206810")]
		public static void DeleteFromJson(object deletePatch, JObject target)
		{
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073CD")]
		[Address(RVA = "0x2206CA0", Offset = "0x22058A0", VA = "0x182206CA0")]
		public static JsonSerializerSettings GenerateJsonSettingsForCustomDBRules()
		{
			return null;
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073CE")]
		[Address(RVA = "0x2207530", Offset = "0x2206130", VA = "0x182207530")]
		public static LuaTable PopulateLuaTable(JObject json, LuaEnv env, IList<LuaTable> instedLuaTables)
		{
			return null;
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CF")]
		[Address(RVA = "0x2206E20", Offset = "0x2205A20", VA = "0x182206E20")]
		public static void PopulateJObjectToLuaTable(JObject json, LuaTable table, LuaEnv env, IList<LuaTable> instedLuaTables)
		{
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073D0")]
		[Address(RVA = "0x2207330", Offset = "0x2205F30", VA = "0x182207330")]
		public static LuaTable PopulateLuaTable(JArray jarray, LuaEnv env, IList<LuaTable> instedLuaTables)
		{
			return null;
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073D1")]
		private static void _SetValueToLuaTable<KeyType>(KeyType name, JToken valueToken, LuaTable luaTable, LuaEnv env, IList<LuaTable> instedLuaTables)
		{
		}

		// Token: 0x040070C2 RID: 28866
		[Token(Token = "0x40070C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PopulateJson;

		// Token: 0x040070C3 RID: 28867
		[Token(Token = "0x40070C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DeleteFromJson;

		// Token: 0x040070C4 RID: 28868
		[Token(Token = "0x40070C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateJsonSettingsForCustomDBRules;

		// Token: 0x040070C5 RID: 28869
		[Token(Token = "0x40070C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PopulateLuaTable;

		// Token: 0x040070C6 RID: 28870
		[Token(Token = "0x40070C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PopulateJObjectToLuaTable;

		// Token: 0x040070C7 RID: 28871
		[Token(Token = "0x40070C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_PopulateLuaTable;

		// Token: 0x040070C8 RID: 28872
		[Token(Token = "0x40070C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetValueToLuaTable;
	}
}
