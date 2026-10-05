using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FBB RID: 8123
	[Token(Token = "0x2001FBB")]
	public class BGMAudioAtom : AudioAtom
	{
		// Token: 0x0600C9C7 RID: 51655 RVA: 0x000493C8 File Offset: 0x000475C8
		[Token(Token = "0x600C9C7")]
		[Address(RVA = "0x34A5560", Offset = "0x34A4160", VA = "0x1834A5560", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9C8")]
		[Address(RVA = "0x34A54F0", Offset = "0x34A40F0", VA = "0x1834A54F0", Slot = "5")]
		public override void Stop(float fadetime)
		{
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9C9")]
		[Address(RVA = "0x34A5620", Offset = "0x34A4220", VA = "0x1834A5620")]
		public BGMAudioAtom()
		{
		}

		// Token: 0x0600C9CA RID: 51658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9CA")]
		[Address(RVA = "0x349D5A0", Offset = "0x349C1A0", VA = "0x18349D5A0")]
		private void <>xLuaBaseProxy_Stop(float P0)
		{
		}

		// Token: 0x0400D231 RID: 53809
		[Token(Token = "0x400D231")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D232 RID: 53810
		[Token(Token = "0x400D232")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D233 RID: 53811
		[Token(Token = "0x400D233")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
