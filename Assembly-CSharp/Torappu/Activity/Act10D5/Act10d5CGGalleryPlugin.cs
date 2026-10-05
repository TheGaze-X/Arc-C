using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B14 RID: 31508
	[Token(Token = "0x2007B14")]
	public class Act10d5CGGalleryPlugin : ActivityStageSingleComponent
	{
		// Token: 0x0602C1BD RID: 180669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1BD")]
		[Address(RVA = "0x280F740", Offset = "0x280E340", VA = "0x18280F740")]
		public void Refresh(TemplateActivityCGGalleryViewModel model)
		{
		}

		// Token: 0x0602C1BE RID: 180670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1BE")]
		[Address(RVA = "0x280F810", Offset = "0x280E410", VA = "0x18280F810")]
		public Act10d5CGGalleryPlugin()
		{
		}

		// Token: 0x0403FF3A RID: 261946
		[Token(Token = "0x403FF3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateActivityEntryCGGalleryPlugin _cgGalleryPlugin;

		// Token: 0x0403FF3B RID: 261947
		[Token(Token = "0x403FF3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403FF3C RID: 261948
		[Token(Token = "0x403FF3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
