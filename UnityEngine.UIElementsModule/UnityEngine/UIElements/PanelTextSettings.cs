using System;
using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	public class PanelTextSettings : TextSettings
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000459")]
		internal static PanelTextSettings defaultPanelTextSettings
		{
			[Token(Token = "0x600112C")]
			[Address(RVA = "0x5B1F2D0", Offset = "0x5B1DED0", VA = "0x185B1F2D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x5B1ED60", Offset = "0x5B1D960", VA = "0x185B1ED60")]
		internal static void UpdateLocalizationFontAsset()
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x5B1ED50", Offset = "0x5B1D950", VA = "0x185B1ED50")]
		internal FontAsset GetCachedFontAsset(Font font)
		{
			return null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x5B1F2C0", Offset = "0x5B1DEC0", VA = "0x185B1F2C0")]
		public PanelTextSettings()
		{
		}

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x0")]
		private static PanelTextSettings s_DefaultPanelTextSettings;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x8")]
		internal static Func<string, Object> EditorGUIUtilityLoad;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x10")]
		internal static Func<SystemLanguage> GetCurrentLanguage;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string s_DefaultEditorPanelTextSettingPath;
	}
}
