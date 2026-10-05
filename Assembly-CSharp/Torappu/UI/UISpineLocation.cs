using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036E7 RID: 14055
	[Token(Token = "0x20036E7")]
	[Serializable]
	public struct UISpineLocation
	{
		// Token: 0x06016523 RID: 91427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016523")]
		[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
		public UISpineLocation(UISpineWrapper pSpineWrapper, string pSpineName)
		{
		}

		// Token: 0x06016524 RID: 91428 RVA: 0x000908A0 File Offset: 0x0008EAA0
		[Token(Token = "0x6016524")]
		[Address(RVA = "0xED4B10", Offset = "0xED3710", VA = "0x180ED4B10")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0401AD8A RID: 109962
		[Token(Token = "0x401AD8A")]
		[FieldOffset(Offset = "0x0")]
		public UISpineWrapper spineWrapper;

		// Token: 0x0401AD8B RID: 109963
		[Token(Token = "0x401AD8B")]
		[FieldOffset(Offset = "0x8")]
		public string spineName;
	}
}
