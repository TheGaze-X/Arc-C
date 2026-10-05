using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FB0 RID: 28592
	[Token(Token = "0x2006FB0")]
	public class ActMultiV3CharSelectCustomInput : TemplateCharSelectController.TemplateCustomInput
	{
		// Token: 0x060289B4 RID: 166324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B4")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ActMultiV3CharSelectCustomInput()
		{
		}

		// Token: 0x04039D7F RID: 236927
		[Token(Token = "0x4039D7F")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3IdentityType idType;

		// Token: 0x04039D80 RID: 236928
		[Token(Token = "0x4039D80")]
		[FieldOffset(Offset = "0x18")]
		public string squadId;

		// Token: 0x04039D81 RID: 236929
		[Token(Token = "0x4039D81")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, string> charIdTypeDict;
	}
}
