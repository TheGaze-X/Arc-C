using System;
using Il2CppDummyDll;
using Torappu.Audio;

namespace Torappu.UI
{
	// Token: 0x02003634 RID: 13876
	[Token(Token = "0x2003634")]
	public class UIPageControllerParam : ISceneParamWithMusic, ISceneParam
	{
		// Token: 0x0601617E RID: 90494 RVA: 0x0008F688 File Offset: 0x0008D888
		[Token(Token = "0x601617E")]
		[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0", Slot = "4")]
		public bool IsAutoMusicDisabled()
		{
			return default(bool);
		}

		// Token: 0x0601617F RID: 90495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601617F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UIPageControllerParam()
		{
		}

		// Token: 0x0401A940 RID: 108864
		[Token(Token = "0x401A940")]
		[FieldOffset(Offset = "0x10")]
		public UIPageStackParam stackParam;

		// Token: 0x0401A941 RID: 108865
		[Token(Token = "0x401A941")]
		[FieldOffset(Offset = "0x28")]
		public bool disableAutoSceneMusic;
	}
}
