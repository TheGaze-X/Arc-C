using System;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.Audio.Middleware.Data;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037AE RID: 14254
	[Token(Token = "0x20037AE")]
	public class UIMusicDuckingHelper : IDisposable, IHotfixable
	{
		// Token: 0x060169B3 RID: 92595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B3")]
		[Address(RVA = "0xEFF3B0", Offset = "0xEFDFB0", VA = "0x180EFF3B0")]
		public void SetMusicDuckingByMusicId(string musicId)
		{
		}

		// Token: 0x060169B4 RID: 92596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B4")]
		[Address(RVA = "0xEFF2A0", Offset = "0xEFDEA0", VA = "0x180EFF2A0")]
		public void SetMusicDuckingByBank(string bankName)
		{
		}

		// Token: 0x060169B5 RID: 92597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B5")]
		[Address(RVA = "0xEFEE80", Offset = "0xEFDA80", VA = "0x180EFEE80")]
		public void SetChannelDuckingByBank(string bankName, params string[] channels)
		{
		}

		// Token: 0x060169B6 RID: 92598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B6")]
		[Address(RVA = "0xEFEE10", Offset = "0xEFDA10", VA = "0x180EFEE10")]
		public void ReverseMusicDucking()
		{
		}

		// Token: 0x060169B7 RID: 92599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B7")]
		[Address(RVA = "0xEFF720", Offset = "0xEFE320", VA = "0x180EFF720")]
		private void _RemoveMusicDucking()
		{
		}

		// Token: 0x060169B8 RID: 92600 RVA: 0x00091F38 File Offset: 0x00090138
		[Token(Token = "0x60169B8")]
		[Address(RVA = "0xEFF560", Offset = "0xEFE160", VA = "0x180EFF560")]
		private AudioManager.AudioFadeParam _GeneDuckingFadeParam(DuckingData duckingData)
		{
			return default(AudioManager.AudioFadeParam);
		}

		// Token: 0x060169B9 RID: 92601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B9")]
		[Address(RVA = "0xEFED60", Offset = "0xEFD960", VA = "0x180EFED60", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060169BA RID: 92602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169BA")]
		[Address(RVA = "0xEFF7A0", Offset = "0xEFE3A0", VA = "0x180EFF7A0")]
		public UIMusicDuckingHelper()
		{
		}

		// Token: 0x0401B3FF RID: 111615
		[Token(Token = "0x401B3FF")]
		[FieldOffset(Offset = "0x10")]
		private AudioChannelEffect m_duckingEffect;

		// Token: 0x0401B400 RID: 111616
		[Token(Token = "0x401B400")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetMusicDuckingByMusicId;

		// Token: 0x0401B401 RID: 111617
		[Token(Token = "0x401B401")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetMusicDuckingByBank;

		// Token: 0x0401B402 RID: 111618
		[Token(Token = "0x401B402")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetChannelDuckingByBank;

		// Token: 0x0401B403 RID: 111619
		[Token(Token = "0x401B403")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReverseMusicDucking;

		// Token: 0x0401B404 RID: 111620
		[Token(Token = "0x401B404")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RemoveMusicDucking;

		// Token: 0x0401B405 RID: 111621
		[Token(Token = "0x401B405")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GeneDuckingFadeParam;

		// Token: 0x0401B406 RID: 111622
		[Token(Token = "0x401B406")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401B407 RID: 111623
		[Token(Token = "0x401B407")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
