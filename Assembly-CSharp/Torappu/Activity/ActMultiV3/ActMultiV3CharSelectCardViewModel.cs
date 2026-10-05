using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect.Common;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FB2 RID: 28594
	[Token(Token = "0x2006FB2")]
	public class ActMultiV3CharSelectCardViewModel : CommonCharSelectCardDefaultViewModel
	{
		// Token: 0x060289B6 RID: 166326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B6")]
		[Address(RVA = "0x23EC340", Offset = "0x23EAF40", VA = "0x1823EC340")]
		public ActMultiV3CharSelectCardViewModel()
		{
		}

		// Token: 0x04039D83 RID: 236931
		[Token(Token = "0x4039D83")]
		[FieldOffset(Offset = "0x40")]
		public string actId;

		// Token: 0x04039D84 RID: 236932
		[Token(Token = "0x4039D84")]
		[FieldOffset(Offset = "0x48")]
		public ActMultiV3IdentityType idType;

		// Token: 0x04039D85 RID: 236933
		[Token(Token = "0x4039D85")]
		[FieldOffset(Offset = "0x4C")]
		public ActMultiV3IdentityType editingType;

		// Token: 0x04039D86 RID: 236934
		[Token(Token = "0x4039D86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
