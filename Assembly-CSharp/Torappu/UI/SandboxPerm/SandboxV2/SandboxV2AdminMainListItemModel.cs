using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004071 RID: 16497
	[Token(Token = "0x2004071")]
	public class SandboxV2AdminMainListItemModel
	{
		// Token: 0x06019859 RID: 104537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019859")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AdminMainListItemModel()
		{
		}

		// Token: 0x0401FCED RID: 130285
		[Token(Token = "0x401FCED")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401FCEE RID: 130286
		[Token(Token = "0x401FCEE")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel itemModel;

		// Token: 0x0401FCEF RID: 130287
		[Token(Token = "0x401FCEF")]
		[FieldOffset(Offset = "0x20")]
		public List<SandboxV2AdminMainMaterialModel> materials;

		// Token: 0x0401FCF0 RID: 130288
		[Token(Token = "0x401FCF0")]
		[FieldOffset(Offset = "0x28")]
		public int stock;

		// Token: 0x0401FCF1 RID: 130289
		[Token(Token = "0x401FCF1")]
		[FieldOffset(Offset = "0x2C")]
		public bool isNew;
	}
}
