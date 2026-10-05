using System;
using Il2CppDummyDll;
using Torappu.UI.Mission;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F80 RID: 28544
	[Token(Token = "0x2006F80")]
	public class ActMultiV3MissionViewModel : IHotfixable
	{
		// Token: 0x06028837 RID: 165943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028837")]
		[Address(RVA = "0x23DB740", Offset = "0x23DA340", VA = "0x1823DB740")]
		public ActMultiV3MissionViewModel()
		{
		}

		// Token: 0x04039AEC RID: 236268
		[Token(Token = "0x4039AEC")]
		[FieldOffset(Offset = "0x10")]
		public MissionViewModel missionViewModel;

		// Token: 0x04039AED RID: 236269
		[Token(Token = "0x4039AED")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3TitleViewModel titleViewModel;

		// Token: 0x04039AEE RID: 236270
		[Token(Token = "0x4039AEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
