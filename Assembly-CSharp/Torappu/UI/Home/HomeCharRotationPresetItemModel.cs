using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B5E RID: 19294
	[Token(Token = "0x2004B5E")]
	public class HomeCharRotationPresetItemModel : IHotfixable
	{
		// Token: 0x0601D0C9 RID: 118985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0C9")]
		[Address(RVA = "0x1669F40", Offset = "0x1668B40", VA = "0x181669F40")]
		public void LoadDataByPlayerPreset(PlayerCharRotationPreset preset, string instId)
		{
		}

		// Token: 0x0601D0CA RID: 118986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0CA")]
		[Address(RVA = "0x166A480", Offset = "0x1669080", VA = "0x18166A480")]
		public void RefreshProfileSkinId()
		{
		}

		// Token: 0x0601D0CB RID: 118987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0CB")]
		[Address(RVA = "0x166A680", Offset = "0x1669280", VA = "0x18166A680")]
		public HomeCharRotationPresetItemModel()
		{
		}

		// Token: 0x040261A2 RID: 156066
		[Token(Token = "0x40261A2")]
		[FieldOffset(Offset = "0x10")]
		public string presetInstId;

		// Token: 0x040261A3 RID: 156067
		[Token(Token = "0x40261A3")]
		[FieldOffset(Offset = "0x18")]
		public string presetName;

		// Token: 0x040261A4 RID: 156068
		[Token(Token = "0x40261A4")]
		[FieldOffset(Offset = "0x20")]
		public string profileSkinTag;

		// Token: 0x040261A5 RID: 156069
		[Token(Token = "0x40261A5")]
		[FieldOffset(Offset = "0x28")]
		public string nowPreviewingSkinTag;

		// Token: 0x040261A6 RID: 156070
		[Token(Token = "0x40261A6")]
		[FieldOffset(Offset = "0x30")]
		public string backgroundId;

		// Token: 0x040261A7 RID: 156071
		[Token(Token = "0x40261A7")]
		[FieldOffset(Offset = "0x38")]
		public string themeId;

		// Token: 0x040261A8 RID: 156072
		[Token(Token = "0x40261A8")]
		[FieldOffset(Offset = "0x40")]
		public ListDict<string, HomeCharRotationPresetSkinItemViewModel> presetSkins;

		// Token: 0x040261A9 RID: 156073
		[Token(Token = "0x40261A9")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, int> m_charSkinCount;

		// Token: 0x040261AA RID: 156074
		[Token(Token = "0x40261AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadDataByPlayerPreset;

		// Token: 0x040261AB RID: 156075
		[Token(Token = "0x40261AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshProfileSkinId;

		// Token: 0x040261AC RID: 156076
		[Token(Token = "0x40261AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
