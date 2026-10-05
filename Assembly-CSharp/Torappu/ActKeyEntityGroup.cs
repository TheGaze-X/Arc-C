using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	public class ActKeyEntityGroup : KeyEntityGroupBase
	{
		// Token: 0x06004FAD RID: 20397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x1AE9990", Offset = "0x1AE8590", VA = "0x181AE9990", Slot = "5")]
		protected override void LoadGroupData(KeySettingGroupData groupData)
		{
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x1AE97F0", Offset = "0x1AE83F0", VA = "0x181AE97F0", Slot = "4")]
		protected override bool CheckIfUseGroup()
		{
			return default(bool);
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x1AE9A10", Offset = "0x1AE8610", VA = "0x181AE9A10")]
		public ActKeyEntityGroup()
		{
		}

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x30")]
		private string m_gameModeTag;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadGroupData;

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfUseGroup;

		// Token: 0x0400143A RID: 5178
		[Token(Token = "0x400143A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
