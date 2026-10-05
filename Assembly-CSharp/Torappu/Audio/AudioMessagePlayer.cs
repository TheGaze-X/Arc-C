using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FA4 RID: 8100
	[Token(Token = "0x2001FA4")]
	public class AudioMessagePlayer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C93C RID: 51516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C93C")]
		[Address(RVA = "0x349FDE0", Offset = "0x349E9E0", VA = "0x18349FDE0")]
		public void AudioUISignal(string combinedSignals)
		{
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C93D")]
		[Address(RVA = "0x349FD10", Offset = "0x349E910", VA = "0x18349FD10")]
		public void AudioSystemSignal(string combinedSignals)
		{
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x00049230 File Offset: 0x00047430
		[Token(Token = "0x600C93E")]
		[Address(RVA = "0x349FEB0", Offset = "0x349EAB0", VA = "0x18349FEB0")]
		private static bool _TryParseCombinedSignals(string combinedSignal, out string signal, out string subsignal)
		{
			return default(bool);
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C93F")]
		[Address(RVA = "0x34A0010", Offset = "0x349EC10", VA = "0x1834A0010")]
		public AudioMessagePlayer()
		{
		}

		// Token: 0x0400CFF6 RID: 53238
		[Token(Token = "0x400CFF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AudioUISignal;

		// Token: 0x0400CFF7 RID: 53239
		[Token(Token = "0x400CFF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AudioSystemSignal;

		// Token: 0x0400CFF8 RID: 53240
		[Token(Token = "0x400CFF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryParseCombinedSignals;

		// Token: 0x0400CFF9 RID: 53241
		[Token(Token = "0x400CFF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
