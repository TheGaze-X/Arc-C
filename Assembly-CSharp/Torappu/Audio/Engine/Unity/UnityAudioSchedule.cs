using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio.Engine.Unity
{
	// Token: 0x02001FD3 RID: 8147
	[Token(Token = "0x2001FD3")]
	public class UnityAudioSchedule : IHotfixable
	{
		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x0600CA4C RID: 51788 RVA: 0x00049680 File Offset: 0x00047880
		[Token(Token = "0x170017F3")]
		public bool isScheduling
		{
			[Token(Token = "0x600CA4C")]
			[Address(RVA = "0x34BA4D0", Offset = "0x34B90D0", VA = "0x1834BA4D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA4D")]
		[Address(RVA = "0x34BA180", Offset = "0x34B8D80", VA = "0x1834BA180")]
		public void StartAudioSchedule(UnityAudioPlayback.ChannelAudioSource[] sources, int count, float delay = 0f)
		{
		}

		// Token: 0x0600CA4E RID: 51790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA4E")]
		[Address(RVA = "0x34BA2F0", Offset = "0x34B8EF0", VA = "0x1834BA2F0")]
		public void StopAudioSchedule()
		{
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA4F")]
		[Address(RVA = "0x34BA370", Offset = "0x34B8F70", VA = "0x1834BA370")]
		private IEnumerator _AudioScheduleCoroutine(UnityAudioPlayback.ChannelAudioSource[] sources, int count, float delay = 0f)
		{
			return null;
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA50")]
		[Address(RVA = "0x34BA470", Offset = "0x34B9070", VA = "0x1834BA470")]
		public UnityAudioSchedule()
		{
		}

		// Token: 0x0400D2E6 RID: 53990
		[Token(Token = "0x400D2E6")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator m_scheduleRoutine;

		// Token: 0x0400D2E7 RID: 53991
		[Token(Token = "0x400D2E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isScheduling;

		// Token: 0x0400D2E8 RID: 53992
		[Token(Token = "0x400D2E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartAudioSchedule;

		// Token: 0x0400D2E9 RID: 53993
		[Token(Token = "0x400D2E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StopAudioSchedule;

		// Token: 0x0400D2EA RID: 53994
		[Token(Token = "0x400D2EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AudioScheduleCoroutine;

		// Token: 0x0400D2EB RID: 53995
		[Token(Token = "0x400D2EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
