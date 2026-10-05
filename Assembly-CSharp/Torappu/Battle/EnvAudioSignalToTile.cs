using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002283 RID: 8835
	[Token(Token = "0x2002283")]
	public class EnvAudioSignalToTile : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DE49 RID: 56905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE49")]
		[Address(RVA = "0x36344F0", Offset = "0x36330F0", VA = "0x1836344F0", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE4A")]
		[Address(RVA = "0x36347A0", Offset = "0x36333A0", VA = "0x1836347A0")]
		public EnvAudioSignalToTile()
		{
		}

		// Token: 0x0600DE4B RID: 56907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE4B")]
		[Address(RVA = "0x36337D0", Offset = "0x36323D0", VA = "0x1836337D0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0400F112 RID: 61714
		[Token(Token = "0x400F112")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<EnvAudioSignalToTile.StatusSignalPair> _envStatus;

		// Token: 0x0400F113 RID: 61715
		[Token(Token = "0x400F113")]
		private const string AUDIO_SIGNAL_FORMAT = "{0}.{1}";

		// Token: 0x0400F114 RID: 61716
		[Token(Token = "0x400F114")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F115 RID: 61717
		[Token(Token = "0x400F115")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002284 RID: 8836
		[Token(Token = "0x2002284")]
		[Serializable]
		private class StatusSignalPair
		{
			// Token: 0x0600DE4C RID: 56908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DE4C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StatusSignalPair()
			{
			}

			// Token: 0x0400F116 RID: 61718
			[Token(Token = "0x400F116")]
			[FieldOffset(Offset = "0x10")]
			public string status;

			// Token: 0x0400F117 RID: 61719
			[Token(Token = "0x400F117")]
			[FieldOffset(Offset = "0x18")]
			public string audioSignal;
		}
	}
}
