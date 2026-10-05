using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B99 RID: 19353
	[Token(Token = "0x2004B99")]
	public struct HomeThemeTrackPointData
	{
		// Token: 0x0601D1D3 RID: 119251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1D3")]
		[Address(RVA = "0x16AA490", Offset = "0x16A9090", VA = "0x1816AA490")]
		public void LoadData(string themeId)
		{
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x0601D1D4 RID: 119252 RVA: 0x000AA8C8 File Offset: 0x000A8AC8
		[Token(Token = "0x17004480")]
		public bool hasTrackPoint
		{
			[Token(Token = "0x601D1D4")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04026348 RID: 156488
		[Token(Token = "0x4026348")]
		[FieldOffset(Offset = "0x0")]
		private bool _hasNewThemeTag;
	}
}
