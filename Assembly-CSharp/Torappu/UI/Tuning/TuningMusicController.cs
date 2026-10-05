using System;
using Il2CppDummyDll;
using Torappu.Audio;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CC1 RID: 15553
	[Token(Token = "0x2003CC1")]
	public class TuningMusicController : PageSingleComponent
	{
		// Token: 0x06018402 RID: 99330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018402")]
		[Address(RVA = "0x10C26B0", Offset = "0x10C12B0", VA = "0x1810C26B0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06018403 RID: 99331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018403")]
		[Address(RVA = "0x10C2830", Offset = "0x10C1430", VA = "0x1810C2830", Slot = "9")]
		protected override void OnStop()
		{
		}

		// Token: 0x06018404 RID: 99332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018404")]
		[Address(RVA = "0x10C2740", Offset = "0x10C1340", VA = "0x1810C2740", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x06018405 RID: 99333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018405")]
		[Address(RVA = "0x10C28A0", Offset = "0x10C14A0", VA = "0x1810C28A0")]
		public void PlayMusic(TuningMusicController.TuningPlayMusicOption playOption)
		{
		}

		// Token: 0x06018406 RID: 99334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018406")]
		[Address(RVA = "0x10C2CB0", Offset = "0x10C18B0", VA = "0x1810C2CB0")]
		public void StopMusic()
		{
		}

		// Token: 0x06018407 RID: 99335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018407")]
		[Address(RVA = "0x10C2E00", Offset = "0x10C1A00", VA = "0x1810C2E00")]
		private void _PlayMainMusicWithDucking(string musicId, bool needInterrupt, string prevMusicId)
		{
		}

		// Token: 0x06018408 RID: 99336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018408")]
		[Address(RVA = "0x10C2FC0", Offset = "0x10C1BC0", VA = "0x1810C2FC0")]
		private void _PlaySubMusic(string musicId)
		{
		}

		// Token: 0x06018409 RID: 99337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018409")]
		[Address(RVA = "0x10C3110", Offset = "0x10C1D10", VA = "0x1810C3110")]
		private void _StopMainMusic()
		{
		}

		// Token: 0x0601840A RID: 99338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601840A")]
		[Address(RVA = "0x10C3290", Offset = "0x10C1E90", VA = "0x1810C3290")]
		private void _StopSubMusic()
		{
		}

		// Token: 0x0601840B RID: 99339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601840B")]
		[Address(RVA = "0x10C3180", Offset = "0x10C1D80", VA = "0x1810C3180")]
		private void _StopMusicWithoutClearCache()
		{
		}

		// Token: 0x0601840C RID: 99340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601840C")]
		[Address(RVA = "0x10C2D50", Offset = "0x10C1950", VA = "0x1810C2D50")]
		private void _PlayCachedMusic()
		{
		}

		// Token: 0x0601840D RID: 99341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601840D")]
		[Address(RVA = "0x10C3300", Offset = "0x10C1F00", VA = "0x1810C3300")]
		public TuningMusicController()
		{
		}

		// Token: 0x0601840E RID: 99342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601840E")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601840F RID: 99343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601840F")]
		[Address(RVA = "0xF53780", Offset = "0xF52380", VA = "0x180F53780")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x06018410 RID: 99344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018410")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0401D952 RID: 121170
		[Token(Token = "0x401D952")]
		[FieldOffset(Offset = "0x20")]
		private UIMusicDuckingHelper m_musicDuckingHelper;

		// Token: 0x0401D953 RID: 121171
		[Token(Token = "0x401D953")]
		[FieldOffset(Offset = "0x28")]
		private AudioMusicGroupHandler m_mainMusicGroupHandler;

		// Token: 0x0401D954 RID: 121172
		[Token(Token = "0x401D954")]
		[FieldOffset(Offset = "0x30")]
		private AudioMusicGroupHandler m_subMusicGroupHandler;

		// Token: 0x0401D955 RID: 121173
		[Token(Token = "0x401D955")]
		[FieldOffset(Offset = "0x38")]
		private TuningMusicController.TuningCachedMusicParam m_cachedMusicParam;

		// Token: 0x0401D956 RID: 121174
		[Token(Token = "0x401D956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401D957 RID: 121175
		[Token(Token = "0x401D957")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0401D958 RID: 121176
		[Token(Token = "0x401D958")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401D959 RID: 121177
		[Token(Token = "0x401D959")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayMusic;

		// Token: 0x0401D95A RID: 121178
		[Token(Token = "0x401D95A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopMusic;

		// Token: 0x0401D95B RID: 121179
		[Token(Token = "0x401D95B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayMainMusicWithDucking;

		// Token: 0x0401D95C RID: 121180
		[Token(Token = "0x401D95C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlaySubMusic;

		// Token: 0x0401D95D RID: 121181
		[Token(Token = "0x401D95D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StopMainMusic;

		// Token: 0x0401D95E RID: 121182
		[Token(Token = "0x401D95E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopSubMusic;

		// Token: 0x0401D95F RID: 121183
		[Token(Token = "0x401D95F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StopMusicWithoutClearCache;

		// Token: 0x0401D960 RID: 121184
		[Token(Token = "0x401D960")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayCachedMusic;

		// Token: 0x0401D961 RID: 121185
		[Token(Token = "0x401D961")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CC2 RID: 15554
		[Token(Token = "0x2003CC2")]
		private struct TuningCachedMusicParam : IHotfixable
		{
			// Token: 0x06018411 RID: 99345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018411")]
			[Address(RVA = "0x10BB910", Offset = "0x10BA510", VA = "0x1810BB910")]
			public void SetCachedMusic(string mainMusicId, string subMusicId)
			{
			}

			// Token: 0x0401D962 RID: 121186
			[Token(Token = "0x401D962")]
			[FieldOffset(Offset = "0x0")]
			public static TuningMusicController.TuningCachedMusicParam EMPTY;

			// Token: 0x0401D963 RID: 121187
			[Token(Token = "0x401D963")]
			[FieldOffset(Offset = "0x0")]
			public string cachedMainMusicId;

			// Token: 0x0401D964 RID: 121188
			[Token(Token = "0x401D964")]
			[FieldOffset(Offset = "0x8")]
			public string cachedSubMusicId;

			// Token: 0x0401D965 RID: 121189
			[Token(Token = "0x401D965")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetCachedMusic;
		}

		// Token: 0x02003CC3 RID: 15555
		[Token(Token = "0x2003CC3")]
		public struct TuningPlayMusicOption
		{
			// Token: 0x0401D966 RID: 121190
			[Token(Token = "0x401D966")]
			[FieldOffset(Offset = "0x0")]
			public string mainMusicId;

			// Token: 0x0401D967 RID: 121191
			[Token(Token = "0x401D967")]
			[FieldOffset(Offset = "0x8")]
			public string subMusicId;

			// Token: 0x0401D968 RID: 121192
			[Token(Token = "0x401D968")]
			[FieldOffset(Offset = "0x10")]
			public bool needInterrupt;
		}
	}
}
