using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FE5 RID: 16357
	[Token(Token = "0x2003FE5")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class PCSettingUtil
	{
		// Token: 0x0601956E RID: 103790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601956E")]
		[Address(RVA = "0x11FEE50", Offset = "0x11FDA50", VA = "0x1811FEE50")]
		public static HashSet<string> FindValidActType()
		{
			return null;
		}

		// Token: 0x0601956F RID: 103791 RVA: 0x0009DC50 File Offset: 0x0009BE50
		[Token(Token = "0x601956F")]
		[Address(RVA = "0x11FED00", Offset = "0x11FD900", VA = "0x1811FED00")]
		public static bool CheckIfActGroupValid(KeySettingGroupData group, HashSet<string> validActType)
		{
			return default(bool);
		}

		// Token: 0x06019570 RID: 103792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019570")]
		[Address(RVA = "0x11FF230", Offset = "0x11FDE30", VA = "0x1811FF230")]
		public static PCKeyCard GetKeyCardPrefab()
		{
			return null;
		}

		// Token: 0x06019571 RID: 103793 RVA: 0x0009DC68 File Offset: 0x0009BE68
		[Token(Token = "0x6019571")]
		[Address(RVA = "0x11FEDD0", Offset = "0x11FD9D0", VA = "0x1811FEDD0")]
		public static bool CheckSettingAvail(SettingPlatform platform)
		{
			return default(bool);
		}

		// Token: 0x06019572 RID: 103794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019572")]
		[Address(RVA = "0x11FF160", Offset = "0x11FDD60", VA = "0x1811FF160")]
		public static KeyItem GetCurrKeySetting(KeyBoardVirtualButtonConfig group)
		{
			return null;
		}

		// Token: 0x0401F832 RID: 129074
		[Token(Token = "0x401F832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindValidActType;

		// Token: 0x0401F833 RID: 129075
		[Token(Token = "0x401F833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfActGroupValid;

		// Token: 0x0401F834 RID: 129076
		[Token(Token = "0x401F834")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetKeyCardPrefab;

		// Token: 0x0401F835 RID: 129077
		[Token(Token = "0x401F835")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckSettingAvail;

		// Token: 0x0401F836 RID: 129078
		[Token(Token = "0x401F836")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurrKeySetting;
	}
}
