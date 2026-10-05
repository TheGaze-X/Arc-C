using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AF5 RID: 19189
	[Token(Token = "0x2004AF5")]
	public class HomeCharRotationPresetItemViewModel : IHotfixable
	{
		// Token: 0x0601CD2A RID: 118058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD2A")]
		[Address(RVA = "0x16407D0", Offset = "0x163F3D0", VA = "0x1816407D0")]
		public void LoadData(string instId, PlayerCharRotationPreset playerData)
		{
		}

		// Token: 0x0601CD2B RID: 118059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD2B")]
		[Address(RVA = "0x1641000", Offset = "0x163FC00", VA = "0x181641000")]
		public HomeCharRotationPresetItemViewModel()
		{
		}

		// Token: 0x04025D29 RID: 154921
		[Token(Token = "0x4025D29")]
		private const int SHOW_SKIN_NUM = 13;

		// Token: 0x04025D2A RID: 154922
		[Token(Token = "0x4025D2A")]
		[FieldOffset(Offset = "0x10")]
		public string presetInstId;

		// Token: 0x04025D2B RID: 154923
		[Token(Token = "0x4025D2B")]
		[FieldOffset(Offset = "0x18")]
		public string presetName;

		// Token: 0x04025D2C RID: 154924
		[Token(Token = "0x4025D2C")]
		[FieldOffset(Offset = "0x20")]
		public string presetThemeId;

		// Token: 0x04025D2D RID: 154925
		[Token(Token = "0x4025D2D")]
		[FieldOffset(Offset = "0x28")]
		public string presetThemeName;

		// Token: 0x04025D2E RID: 154926
		[Token(Token = "0x4025D2E")]
		[FieldOffset(Offset = "0x30")]
		public bool isTmMultiForm;

		// Token: 0x04025D2F RID: 154927
		[Token(Token = "0x4025D2F")]
		[FieldOffset(Offset = "0x38")]
		public string presetThemeFormId;

		// Token: 0x04025D30 RID: 154928
		[Token(Token = "0x4025D30")]
		[FieldOffset(Offset = "0x40")]
		public string presetBackgroundId;

		// Token: 0x04025D31 RID: 154929
		[Token(Token = "0x4025D31")]
		[FieldOffset(Offset = "0x48")]
		public string presetBackgroundName;

		// Token: 0x04025D32 RID: 154930
		[Token(Token = "0x4025D32")]
		[FieldOffset(Offset = "0x50")]
		public bool isBgMultiForm;

		// Token: 0x04025D33 RID: 154931
		[Token(Token = "0x4025D33")]
		[FieldOffset(Offset = "0x58")]
		public string presetBackgroundFormId;

		// Token: 0x04025D34 RID: 154932
		[Token(Token = "0x4025D34")]
		[FieldOffset(Offset = "0x60")]
		public int skinCount;

		// Token: 0x04025D35 RID: 154933
		[Token(Token = "0x4025D35")]
		[FieldOffset(Offset = "0x64")]
		public bool skinExceeded;

		// Token: 0x04025D36 RID: 154934
		[Token(Token = "0x4025D36")]
		[FieldOffset(Offset = "0x68")]
		public List<HomeCharRotationPresetSkinItemViewModel> presetSkins;

		// Token: 0x04025D37 RID: 154935
		[Token(Token = "0x4025D37")]
		[FieldOffset(Offset = "0x70")]
		public CharUISkinStruct profileSkin;

		// Token: 0x04025D38 RID: 154936
		[Token(Token = "0x4025D38")]
		[FieldOffset(Offset = "0x88")]
		public string profileSkinTag;

		// Token: 0x04025D39 RID: 154937
		[Token(Token = "0x4025D39")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<string, int> m_charSkinCount;

		// Token: 0x04025D3A RID: 154938
		[Token(Token = "0x4025D3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025D3B RID: 154939
		[Token(Token = "0x4025D3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
