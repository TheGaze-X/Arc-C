using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A9B RID: 19099
	[Token(Token = "0x2004A9B")]
	public class HotUpdateVoicePackItemData : IHotfixable
	{
		// Token: 0x0601CB2A RID: 117546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB2A")]
		[Address(RVA = "0x1625B90", Offset = "0x1624790", VA = "0x181625B90")]
		public HotUpdateVoicePackItemData()
		{
		}

		// Token: 0x04025AD2 RID: 154322
		[Token(Token = "0x4025AD2")]
		[FieldOffset(Offset = "0x10")]
		public string voiceResType;

		// Token: 0x04025AD3 RID: 154323
		[Token(Token = "0x4025AD3")]
		[FieldOffset(Offset = "0x18")]
		public long size;

		// Token: 0x04025AD4 RID: 154324
		[Token(Token = "0x4025AD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
