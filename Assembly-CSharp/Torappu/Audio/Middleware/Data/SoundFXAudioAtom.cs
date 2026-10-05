using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FBE RID: 8126
	[Token(Token = "0x2001FBE")]
	public class SoundFXAudioAtom : AudioAtom
	{
		// Token: 0x0600C9E0 RID: 51680 RVA: 0x000494A0 File Offset: 0x000476A0
		[Token(Token = "0x600C9E0")]
		[Address(RVA = "0x34B1D30", Offset = "0x34B0930", VA = "0x1834B1D30", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		// Token: 0x0600C9E1 RID: 51681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9E1")]
		[Address(RVA = "0x34B1C60", Offset = "0x34B0860", VA = "0x1834B1C60", Slot = "5")]
		public override void Stop(float fadetime)
		{
		}

		// Token: 0x0600C9E2 RID: 51682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9E2")]
		[Address(RVA = "0x34B1DF0", Offset = "0x34B09F0", VA = "0x1834B1DF0")]
		public SoundFXAudioAtom()
		{
		}

		// Token: 0x0600C9E3 RID: 51683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9E3")]
		[Address(RVA = "0x349D5A0", Offset = "0x349C1A0", VA = "0x18349D5A0")]
		private void <>xLuaBaseProxy_Stop(float P0)
		{
		}

		// Token: 0x0400D24E RID: 53838
		[Token(Token = "0x400D24E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D24F RID: 53839
		[Token(Token = "0x400D24F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D250 RID: 53840
		[Token(Token = "0x400D250")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
