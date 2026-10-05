using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B4A RID: 19274
	[Token(Token = "0x2004B4A")]
	public class HomeBackgroundMultiFormRawDataLoader : IHomeDisplayMultiFormRawDataLoader
	{
		// Token: 0x0601D07A RID: 118906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D07A")]
		[Address(RVA = "0x1669BC0", Offset = "0x16687C0", VA = "0x181669BC0", Slot = "4")]
		public HomeDisplayMultiFormRawData Load(string bgId)
		{
			return null;
		}

		// Token: 0x0601D07B RID: 118907 RVA: 0x000AA0E8 File Offset: 0x000A82E8
		[Token(Token = "0x601D07B")]
		[Address(RVA = "0x1669B60", Offset = "0x1668760", VA = "0x181669B60", Slot = "5")]
		public bool IsMultiForm(string bgId)
		{
			return default(bool);
		}

		// Token: 0x0601D07C RID: 118908 RVA: 0x000AA100 File Offset: 0x000A8300
		[Token(Token = "0x601D07C")]
		[Address(RVA = "0x1669EE0", Offset = "0x1668AE0", VA = "0x181669EE0", Slot = "6")]
		public HomeMultiFormChangeRule QueryRule(string bgId)
		{
			return HomeMultiFormChangeRule.NONE;
		}

		// Token: 0x0601D07D RID: 118909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D07D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeBackgroundMultiFormRawDataLoader()
		{
		}
	}
}
