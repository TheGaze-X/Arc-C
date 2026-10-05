using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.Video;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A8D RID: 19085
	[Token(Token = "0x2004A8D")]
	public class HotUpdaterPreMainMediaView : AbstractHotUpdatePreMainFadeInView
	{
		// Token: 0x0601CAE1 RID: 117473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE1")]
		[Address(RVA = "0x162C500", Offset = "0x162B100", VA = "0x18162C500")]
		private void _EnsureMediaPlayer(ILoadAsset assetLoader)
		{
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x0601CAE2 RID: 117474 RVA: 0x000A90C8 File Offset: 0x000A72C8
		[Token(Token = "0x170043A8")]
		protected override PreMainState state
		{
			[Token(Token = "0x601CAE2")]
			[Address(RVA = "0x162CA00", Offset = "0x162B600", VA = "0x18162CA00", Slot = "4")]
			get
			{
				return PreMainState.NONE;
			}
		}

		// Token: 0x0601CAE3 RID: 117475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CAE3")]
		[Address(RVA = "0x162C600", Offset = "0x162B200", VA = "0x18162C600")]
		private AudioChannelEffect _GenerateMuteAudioChannelEffect()
		{
			return null;
		}

		// Token: 0x0601CAE4 RID: 117476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE4")]
		[Address(RVA = "0x162BCB0", Offset = "0x162A8B0", VA = "0x18162BCB0", Slot = "5")]
		public override void Render(HotUpdatePremainViewModel viewModel, ILoadAsset assets)
		{
		}

		// Token: 0x0601CAE5 RID: 117477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CAE5")]
		[Address(RVA = "0x162C290", Offset = "0x162AE90", VA = "0x18162C290", Slot = "8")]
		public override IEnumerator Show(PreMainState lastState)
		{
			return null;
		}

		// Token: 0x0601CAE6 RID: 117478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE6")]
		[Address(RVA = "0x162BA30", Offset = "0x162A630", VA = "0x18162BA30", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x0601CAE7 RID: 117479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE7")]
		[Address(RVA = "0x162C810", Offset = "0x162B410", VA = "0x18162C810")]
		private void _HandlePlayEvent(AbstractMediaPlayerHolder.Status evt)
		{
		}

		// Token: 0x0601CAE8 RID: 117480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE8")]
		[Address(RVA = "0x162BBF0", Offset = "0x162A7F0", VA = "0x18162BBF0")]
		public void OnPvPlayEnd()
		{
		}

		// Token: 0x0601CAE9 RID: 117481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE9")]
		[Address(RVA = "0x162C440", Offset = "0x162B040", VA = "0x18162C440")]
		private void _ApplyMusicSettings()
		{
		}

		// Token: 0x0601CAEA RID: 117482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAEA")]
		[Address(RVA = "0x162C960", Offset = "0x162B560", VA = "0x18162C960")]
		public HotUpdaterPreMainMediaView()
		{
		}

		// Token: 0x0601CAEB RID: 117483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAEB")]
		[Address(RVA = "0x162C360", Offset = "0x162AF60", VA = "0x18162C360")]
		private void <>xLuaBaseProxy_Render(HotUpdatePremainViewModel P0, ILoadAsset P1)
		{
		}

		// Token: 0x0601CAEC RID: 117484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CAEC")]
		[Address(RVA = "0x162C370", Offset = "0x162AF70", VA = "0x18162C370")]
		private IEnumerator <>xLuaBaseProxy_Show(PreMainState P0)
		{
			return null;
		}

		// Token: 0x0601CAED RID: 117485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAED")]
		[Address(RVA = "0x162C350", Offset = "0x162AF50", VA = "0x18162C350")]
		private void <>xLuaBaseProxy_Clear()
		{
		}

		// Token: 0x04025A55 RID: 154197
		[Token(Token = "0x4025A55")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _mediaPlayerContainer;

		// Token: 0x04025A56 RID: 154198
		[Token(Token = "0x4025A56")]
		[FieldOffset(Offset = "0x50")]
		private AbstractMediaPlayerHolder m_mediaPlayer;

		// Token: 0x04025A57 RID: 154199
		[Token(Token = "0x4025A57")]
		[FieldOffset(Offset = "0x58")]
		private bool m_alreadyPlay;

		// Token: 0x04025A58 RID: 154200
		[Token(Token = "0x4025A58")]
		[FieldOffset(Offset = "0x60")]
		private AudioChannelEffect m_audioChannelEffect;

		// Token: 0x04025A59 RID: 154201
		[Token(Token = "0x4025A59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureMediaPlayer;

		// Token: 0x04025A5A RID: 154202
		[Token(Token = "0x4025A5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04025A5B RID: 154203
		[Token(Token = "0x4025A5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenerateMuteAudioChannelEffect;

		// Token: 0x04025A5C RID: 154204
		[Token(Token = "0x4025A5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025A5D RID: 154205
		[Token(Token = "0x4025A5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04025A5E RID: 154206
		[Token(Token = "0x4025A5E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04025A5F RID: 154207
		[Token(Token = "0x4025A5F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandlePlayEvent;

		// Token: 0x04025A60 RID: 154208
		[Token(Token = "0x4025A60")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPvPlayEnd;

		// Token: 0x04025A61 RID: 154209
		[Token(Token = "0x4025A61")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ApplyMusicSettings;

		// Token: 0x04025A62 RID: 154210
		[Token(Token = "0x4025A62")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
