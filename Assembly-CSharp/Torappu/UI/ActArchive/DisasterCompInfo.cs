using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B6A RID: 27498
	[Token(Token = "0x2006B6A")]
	public class DisasterCompInfo : ActArchiveCompInfo, IHotfixable
	{
		// Token: 0x060274A2 RID: 160930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274A2")]
		[Address(RVA = "0x2287A00", Offset = "0x2286600", VA = "0x182287A00")]
		public DisasterCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060274A3 RID: 160931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274A3")]
		[Address(RVA = "0x2287860", Offset = "0x2286460", VA = "0x182287860")]
		public void SetSelectedDisasterId(string disasterTypeId)
		{
		}

		// Token: 0x060274A4 RID: 160932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274A4")]
		[Address(RVA = "0x2287940", Offset = "0x2286540", VA = "0x182287940")]
		public void SetShowSwitchAnim(bool show)
		{
		}

		// Token: 0x060274A5 RID: 160933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274A5")]
		[Address(RVA = "0x2287390", Offset = "0x2285F90", VA = "0x182287390", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060274A6 RID: 160934 RVA: 0x000CDF20 File Offset: 0x000CC120
		[Token(Token = "0x60274A6")]
		[Address(RVA = "0x2287590", Offset = "0x2286190", VA = "0x182287590", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060274A7 RID: 160935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274A7")]
		[Address(RVA = "0x2287610", Offset = "0x2286210", VA = "0x182287610", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060274A8 RID: 160936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274A8")]
		[Address(RVA = "0x22877B0", Offset = "0x22863B0", VA = "0x1822877B0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x060274A9 RID: 160937 RVA: 0x000CDF38 File Offset: 0x000CC138
		[Token(Token = "0x60274A9")]
		[Address(RVA = "0x22874E0", Offset = "0x22860E0", VA = "0x1822874E0", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060274AA RID: 160938 RVA: 0x000CDF50 File Offset: 0x000CC150
		[Token(Token = "0x60274AA")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037A15 RID: 227861
		[Token(Token = "0x4037A15")]
		[FieldOffset(Offset = "0x18")]
		public DisasterProperty disaster;

		// Token: 0x04037A16 RID: 227862
		[Token(Token = "0x4037A16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037A17 RID: 227863
		[Token(Token = "0x4037A17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedDisasterId;

		// Token: 0x04037A18 RID: 227864
		[Token(Token = "0x4037A18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetShowSwitchAnim;

		// Token: 0x04037A19 RID: 227865
		[Token(Token = "0x4037A19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037A1A RID: 227866
		[Token(Token = "0x4037A1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037A1B RID: 227867
		[Token(Token = "0x4037A1B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037A1C RID: 227868
		[Token(Token = "0x4037A1C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037A1D RID: 227869
		[Token(Token = "0x4037A1D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
