using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064E3 RID: 25827
	[Token(Token = "0x20064E3")]
	public class AutoChessHUDBandInfoModel : IHotfixable
	{
		// Token: 0x060251B8 RID: 151992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B8")]
		[Address(RVA = "0x20248C0", Offset = "0x20234C0", VA = "0x1820248C0")]
		public void LoadData(AutoChessBattleUIViewModel viewModel, int targetViewIdx)
		{
		}

		// Token: 0x060251B9 RID: 151993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B9")]
		[Address(RVA = "0x2024AF0", Offset = "0x20236F0", VA = "0x182024AF0")]
		public AutoChessHUDBandInfoModel()
		{
		}

		// Token: 0x04034011 RID: 213009
		[Token(Token = "0x4034011")]
		[FieldOffset(Offset = "0x10")]
		public string modeName;

		// Token: 0x04034012 RID: 213010
		[Token(Token = "0x4034012")]
		[FieldOffset(Offset = "0x18")]
		public string modeIconId;

		// Token: 0x04034013 RID: 213011
		[Token(Token = "0x4034013")]
		[FieldOffset(Offset = "0x20")]
		public string modeColor;

		// Token: 0x04034014 RID: 213012
		[Token(Token = "0x4034014")]
		[FieldOffset(Offset = "0x28")]
		public string bandName;

		// Token: 0x04034015 RID: 213013
		[Token(Token = "0x4034015")]
		[FieldOffset(Offset = "0x30")]
		public string bandIconId;

		// Token: 0x04034016 RID: 213014
		[Token(Token = "0x4034016")]
		[FieldOffset(Offset = "0x38")]
		public string bandDesc;

		// Token: 0x04034017 RID: 213015
		[Token(Token = "0x4034017")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034018 RID: 213016
		[Token(Token = "0x4034018")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
