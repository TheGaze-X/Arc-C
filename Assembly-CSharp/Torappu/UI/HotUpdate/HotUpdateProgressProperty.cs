using System;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A54 RID: 19028
	[Token(Token = "0x2004A54")]
	public class HotUpdateProgressProperty : DynamicBindProperty<HotUpdateProgressProperty, HotUpdateProgressModel>
	{
		// Token: 0x0601C99C RID: 117148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C99C")]
		[Address(RVA = "0x160D440", Offset = "0x160C040", VA = "0x18160D440")]
		public void DisplayHintOnly(string hint)
		{
		}

		// Token: 0x0601C99D RID: 117149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C99D")]
		[Address(RVA = "0x160D4E0", Offset = "0x160C0E0", VA = "0x18160D4E0")]
		public void DisplayProgressOnly(HotUpdateProgressModel.Progress progress)
		{
		}

		// Token: 0x0601C99E RID: 117150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C99E")]
		[Address(RVA = "0x160D5A0", Offset = "0x160C1A0", VA = "0x18160D5A0")]
		public HotUpdateProgressProperty()
		{
		}
	}
}
