using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A9A RID: 19098
	[Token(Token = "0x2004A9A")]
	public class HotUpdateVoicePackItemViewModel : IHotfixable
	{
		// Token: 0x0601CB29 RID: 117545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB29")]
		[Address(RVA = "0x1625BF0", Offset = "0x16247F0", VA = "0x181625BF0")]
		public HotUpdateVoicePackItemViewModel()
		{
		}

		// Token: 0x04025ACC RID: 154316
		[Token(Token = "0x4025ACC")]
		[FieldOffset(Offset = "0x10")]
		public bool isPackValid;

		// Token: 0x04025ACD RID: 154317
		[Token(Token = "0x4025ACD")]
		[FieldOffset(Offset = "0x18")]
		public string voiceResType;

		// Token: 0x04025ACE RID: 154318
		[Token(Token = "0x4025ACE")]
		[FieldOffset(Offset = "0x20")]
		public bool isDependent;

		// Token: 0x04025ACF RID: 154319
		[Token(Token = "0x4025ACF")]
		[FieldOffset(Offset = "0x21")]
		public bool isSelected;

		// Token: 0x04025AD0 RID: 154320
		[Token(Token = "0x4025AD0")]
		[FieldOffset(Offset = "0x28")]
		public long size;

		// Token: 0x04025AD1 RID: 154321
		[Token(Token = "0x4025AD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
