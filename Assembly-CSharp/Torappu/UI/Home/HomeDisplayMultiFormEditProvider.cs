using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B52 RID: 19282
	[Token(Token = "0x2004B52")]
	public class HomeDisplayMultiFormEditProvider : HomeDisplayMultiFormProvider
	{
		// Token: 0x1700444A RID: 17482
		// (set) Token: 0x0601D099 RID: 118937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700444A")]
		public string overrideFormId
		{
			[Token(Token = "0x601D099")]
			[Address(RVA = "0x166FCF0", Offset = "0x166E8F0", VA = "0x18166FCF0")]
			set
			{
			}
		}

		// Token: 0x0601D09A RID: 118938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D09A")]
		[Address(RVA = "0x166FB30", Offset = "0x166E730", VA = "0x18166FB30", Slot = "4")]
		protected override void _RefreshActiveForm()
		{
		}

		// Token: 0x0601D09B RID: 118939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D09B")]
		[Address(RVA = "0x166FC90", Offset = "0x166E890", VA = "0x18166FC90")]
		public HomeDisplayMultiFormEditProvider()
		{
		}

		// Token: 0x04026164 RID: 156004
		[Token(Token = "0x4026164")]
		[FieldOffset(Offset = "0x58")]
		private string m_overrideFormId;

		// Token: 0x04026165 RID: 156005
		[Token(Token = "0x4026165")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_overrideFormId;

		// Token: 0x04026166 RID: 156006
		[Token(Token = "0x4026166")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshActiveForm;

		// Token: 0x04026167 RID: 156007
		[Token(Token = "0x4026167")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
