using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC1 RID: 8129
	[Token(Token = "0x2001FC1")]
	public class SnapshotAudioAtom : AudioAtom
	{
		// Token: 0x0600C9EE RID: 51694 RVA: 0x000494E8 File Offset: 0x000476E8
		[Token(Token = "0x600C9EE")]
		[Address(RVA = "0x34B1090", Offset = "0x34AFC90", VA = "0x1834B1090", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		// Token: 0x0600C9EF RID: 51695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9EF")]
		[Address(RVA = "0x34B0F30", Offset = "0x34AFB30", VA = "0x1834B0F30", Slot = "5")]
		public override void Stop(float fadetime)
		{
		}

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9F0")]
		[Address(RVA = "0x34B11A0", Offset = "0x34AFDA0", VA = "0x1834B11A0")]
		public SnapshotAudioAtom()
		{
		}

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9F1")]
		[Address(RVA = "0x349D5A0", Offset = "0x349C1A0", VA = "0x18349D5A0")]
		private void <>xLuaBaseProxy_Stop(float P0)
		{
		}

		// Token: 0x0400D264 RID: 53860
		[Token(Token = "0x400D264")]
		[FieldOffset(Offset = "0x20")]
		public SnapshotBank snapshotBank;

		// Token: 0x0400D265 RID: 53861
		[Token(Token = "0x400D265")]
		[FieldOffset(Offset = "0x28")]
		private bool m_listenBegin;

		// Token: 0x0400D266 RID: 53862
		[Token(Token = "0x400D266")]
		[FieldOffset(Offset = "0x29")]
		private bool m_poped;

		// Token: 0x0400D267 RID: 53863
		[Token(Token = "0x400D267")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D268 RID: 53864
		[Token(Token = "0x400D268")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D269 RID: 53865
		[Token(Token = "0x400D269")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
