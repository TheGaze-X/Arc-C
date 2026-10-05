using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200323A RID: 12858
	[Token(Token = "0x200323A")]
	[Obsolete("Because of |TryIgnoreEffect|, it is not recommended to tie audio to effects.")]
	public class OnPlayAudioPlayer : Effect.Behaviour, IHotfixable, IAudioSource
	{
		// Token: 0x06014656 RID: 83542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014656")]
		[Address(RVA = "0xCA5F40", Offset = "0xCA4B40", VA = "0x180CA5F40", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014657 RID: 83543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014657")]
		[Address(RVA = "0xCA5ED0", Offset = "0xCA4AD0", VA = "0x180CA5ED0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014658 RID: 83544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014658")]
		[Address(RVA = "0xCA6100", Offset = "0xCA4D00", VA = "0x180CA6100")]
		private void _OnPlayInternal()
		{
		}

		// Token: 0x06014659 RID: 83545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014659")]
		[Address(RVA = "0xCA5E60", Offset = "0xCA4A60", VA = "0x180CA5E60", Slot = "10")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x0601465A RID: 83546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601465A")]
		[Address(RVA = "0xCA61F0", Offset = "0xCA4DF0", VA = "0x180CA61F0")]
		public OnPlayAudioPlayer()
		{
		}

		// Token: 0x04018144 RID: 98628
		[Token(Token = "0x4018144")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _audioSignal;

		// Token: 0x04018145 RID: 98629
		[Token(Token = "0x4018145")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delayToEmit;

		// Token: 0x04018146 RID: 98630
		[Token(Token = "0x4018146")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _offset;

		// Token: 0x04018147 RID: 98631
		[Token(Token = "0x4018147")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine m_coroutine;
	}
}
