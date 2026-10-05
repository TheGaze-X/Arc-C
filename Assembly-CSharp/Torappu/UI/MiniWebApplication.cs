using System;
using Il2CppDummyDll;
using Torappu.Audio;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038A2 RID: 14498
	[Token(Token = "0x20038A2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MiniWebApplication
	{
		// Token: 0x06016F15 RID: 93973 RVA: 0x00094110 File Offset: 0x00092310
		[Token(Token = "0x6016F15")]
		[Address(RVA = "0xF5AB80", Offset = "0xF59780", VA = "0x180F5AB80")]
		public static bool IsBusy()
		{
			return default(bool);
		}

		// Token: 0x06016F16 RID: 93974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F16")]
		[Address(RVA = "0xF5AC80", Offset = "0xF59880", VA = "0x180F5AC80")]
		public static void Start(MiniWebApplication.Params input)
		{
		}

		// Token: 0x06016F17 RID: 93975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F17")]
		[Address(RVA = "0xF5B350", Offset = "0xF59F50", VA = "0x180F5B350")]
		private static AudioChannelEffect _GenerateMuteAudioChannelEffect()
		{
			return null;
		}

		// Token: 0x0401BB07 RID: 113415
		[Token(Token = "0x401BB07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsBusy;

		// Token: 0x0401BB08 RID: 113416
		[Token(Token = "0x401BB08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401BB09 RID: 113417
		[Token(Token = "0x401BB09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenerateMuteAudioChannelEffect;

		// Token: 0x020038A3 RID: 14499
		[Token(Token = "0x20038A3")]
		public struct Params : ILuaCallCSharp
		{
			// Token: 0x0401BB0A RID: 113418
			[Token(Token = "0x401BB0A")]
			[FieldOffset(Offset = "0x0")]
			public string url;

			// Token: 0x0401BB0B RID: 113419
			[Token(Token = "0x401BB0B")]
			[FieldOffset(Offset = "0x8")]
			public Action<UIWebWindow.MiniWebRet, int> callback;

			// Token: 0x0401BB0C RID: 113420
			[Token(Token = "0x401BB0C")]
			[FieldOffset(Offset = "0x10")]
			public UIWebWindow.MiniWebStyle style;

			// Token: 0x0401BB0D RID: 113421
			[Token(Token = "0x401BB0D")]
			[FieldOffset(Offset = "0x14")]
			public bool setAudioMute;

			// Token: 0x0401BB0E RID: 113422
			[Token(Token = "0x401BB0E")]
			[FieldOffset(Offset = "0x0")]
			public static MiniWebApplication.Params DEFAULT;
		}
	}
}
