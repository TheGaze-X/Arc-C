using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B4B RID: 19275
	[Token(Token = "0x2004B4B")]
	public class HomeThemeMultiFormRawDataLoader : IHomeDisplayMultiFormRawDataLoader
	{
		// Token: 0x0601D07E RID: 118910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D07E")]
		[Address(RVA = "0x1679770", Offset = "0x1678370", VA = "0x181679770", Slot = "4")]
		public HomeDisplayMultiFormRawData Load(string tmId)
		{
			return null;
		}

		// Token: 0x0601D07F RID: 118911 RVA: 0x000AA118 File Offset: 0x000A8318
		[Token(Token = "0x601D07F")]
		[Address(RVA = "0x1679710", Offset = "0x1678310", VA = "0x181679710", Slot = "5")]
		public bool IsMultiForm(string tmId)
		{
			return default(bool);
		}

		// Token: 0x0601D080 RID: 118912 RVA: 0x000AA130 File Offset: 0x000A8330
		[Token(Token = "0x601D080")]
		[Address(RVA = "0x1679A30", Offset = "0x1678630", VA = "0x181679A30", Slot = "6")]
		public HomeMultiFormChangeRule QueryRule(string tmId)
		{
			return HomeMultiFormChangeRule.NONE;
		}

		// Token: 0x0601D081 RID: 118913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D081")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeMultiFormRawDataLoader()
		{
		}
	}
}
