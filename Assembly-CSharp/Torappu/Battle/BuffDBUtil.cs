using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002656 RID: 9814
	[Token(Token = "0x2002656")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BuffDBUtil
	{
		// Token: 0x060100BB RID: 65723 RVA: 0x00061E60 File Offset: 0x00060060
		[Token(Token = "0x60100BB")]
		[Address(RVA = "0x7C1D20", Offset = "0x7C0920", VA = "0x1807C1D20")]
		public static bool TryGetBuff(string key, out BuffConfig result, [Optional] List<Blackboard.DataPair> externalBlackboard)
		{
			return default(bool);
		}

		// Token: 0x060100BC RID: 65724 RVA: 0x00061E78 File Offset: 0x00060078
		[Token(Token = "0x60100BC")]
		[Address(RVA = "0x7C1F30", Offset = "0x7C0B30", VA = "0x1807C1F30")]
		public static bool TryGetBuff(BuffData data, out BuffConfig result)
		{
			return default(bool);
		}

		// Token: 0x060100BD RID: 65725 RVA: 0x00061E90 File Offset: 0x00060090
		[Token(Token = "0x60100BD")]
		[Address(RVA = "0x7C1C50", Offset = "0x7C0850", VA = "0x1807C1C50")]
		public static bool TryGetBuffData(string key, out BuffData data)
		{
			return default(bool);
		}

		// Token: 0x060100BE RID: 65726 RVA: 0x00061EA8 File Offset: 0x000600A8
		[Token(Token = "0x60100BE")]
		[Address(RVA = "0x7C2050", Offset = "0x7C0C50", VA = "0x1807C2050")]
		public static bool TryGetTemplate(string key, out BuffTemplate template)
		{
			return default(bool);
		}

		// Token: 0x060100BF RID: 65727 RVA: 0x00061EC0 File Offset: 0x000600C0
		[Token(Token = "0x60100BF")]
		[Address(RVA = "0x7C22E0", Offset = "0x7C0EE0", VA = "0x1807C22E0")]
		private static bool _TryGetBuffTemplateFromBuffDB(string key, out BuffTemplate template)
		{
			return default(bool);
		}

		// Token: 0x060100C0 RID: 65728 RVA: 0x00061ED8 File Offset: 0x000600D8
		[Token(Token = "0x60100C0")]
		[Address(RVA = "0x7C2500", Offset = "0x7C1100", VA = "0x1807C2500")]
		private static bool _TryGetBuffTemplateFromTemplateDB(string key, out BuffTemplate templateData)
		{
			return default(bool);
		}

		// Token: 0x060100C1 RID: 65729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100C1")]
		[Address(RVA = "0x7C1830", Offset = "0x7C0430", VA = "0x1807C1830")]
		public static void LoadBuffTemplateDirectly(ref Dictionary<string, BuffTemplate> buffTemplate)
		{
		}

		// Token: 0x060100C2 RID: 65730 RVA: 0x00061EF0 File Offset: 0x000600F0
		[Token(Token = "0x60100C2")]
		public static bool CheckEqualE<T>(T data, T data2)
		{
			return default(bool);
		}

		// Token: 0x04011D98 RID: 73112
		[Token(Token = "0x4011D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetBuff;

		// Token: 0x04011D99 RID: 73113
		[Token(Token = "0x4011D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_TryGetBuff;

		// Token: 0x04011D9A RID: 73114
		[Token(Token = "0x4011D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetBuffData;

		// Token: 0x04011D9B RID: 73115
		[Token(Token = "0x4011D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetTemplate;

		// Token: 0x04011D9C RID: 73116
		[Token(Token = "0x4011D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGetBuffTemplateFromBuffDB;

		// Token: 0x04011D9D RID: 73117
		[Token(Token = "0x4011D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetBuffTemplateFromTemplateDB;

		// Token: 0x04011D9E RID: 73118
		[Token(Token = "0x4011D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadBuffTemplateDirectly;

		// Token: 0x04011D9F RID: 73119
		[Token(Token = "0x4011D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckEqualE;
	}
}
