using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000ED7 RID: 3799
	[Token(Token = "0x2000ED7")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BlackboardExtension
	{
		// Token: 0x06006BEB RID: 27627 RVA: 0x00031668 File Offset: 0x0002F868
		[Token(Token = "0x6006BEB")]
		[Address(RVA = "0x2001B90", Offset = "0x2000790", VA = "0x182001B90")]
		public static bool GetBoolOrDefault(this IList<Blackboard.DataPair> dataPairs, string key, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x00031680 File Offset: 0x0002F880
		[Token(Token = "0x6006BEC")]
		[Address(RVA = "0x2001D50", Offset = "0x2000950", VA = "0x182001D50")]
		public static bool TryGetInt(this IList<Blackboard.DataPair> dataPairs, string key, out int value)
		{
			return default(bool);
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x00031698 File Offset: 0x0002F898
		[Token(Token = "0x6006BED")]
		[Address(RVA = "0x2001EF0", Offset = "0x2000AF0", VA = "0x182001EF0")]
		public static bool TryGetString(this IList<Blackboard.DataPair> dataPairs, string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x04005081 RID: 20609
		[Token(Token = "0x4005081")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBoolOrDefault;

		// Token: 0x04005082 RID: 20610
		[Token(Token = "0x4005082")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetInt;

		// Token: 0x04005083 RID: 20611
		[Token(Token = "0x4005083")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetString;
	}
}
