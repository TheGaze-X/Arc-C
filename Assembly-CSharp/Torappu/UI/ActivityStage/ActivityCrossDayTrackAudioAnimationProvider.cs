using System;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C76 RID: 27766
	[Token(Token = "0x2006C76")]
	public class ActivityCrossDayTrackAudioAnimationProvider : MonoBehaviour, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x06027A14 RID: 162324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A14")]
		[Address(RVA = "0x22BF7B0", Offset = "0x22BE3B0", VA = "0x1822BF7B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027A15 RID: 162325 RVA: 0x000CEEF8 File Offset: 0x000CD0F8
		[Token(Token = "0x6027A15")]
		[Address(RVA = "0x22BF5B0", Offset = "0x22BE1B0", VA = "0x1822BF5B0", Slot = "4")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x06027A16 RID: 162326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A16")]
		[Address(RVA = "0x22BF8B0", Offset = "0x22BE4B0", VA = "0x1822BF8B0")]
		public ActivityCrossDayTrackAudioAnimationProvider()
		{
		}

		// Token: 0x0403833F RID: 230207
		[Token(Token = "0x403833F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _entryAnimTrackId;

		// Token: 0x04038340 RID: 230208
		[Token(Token = "0x4038340")]
		[FieldOffset(Offset = "0x20")]
		private ActivityStageComponent m_component;

		// Token: 0x04038341 RID: 230209
		[Token(Token = "0x4038341")]
		[FieldOffset(Offset = "0x28")]
		private ActivityStageController m_controller;

		// Token: 0x04038342 RID: 230210
		[Token(Token = "0x4038342")]
		[FieldOffset(Offset = "0x30")]
		private bool m_inited;

		// Token: 0x04038343 RID: 230211
		[Token(Token = "0x4038343")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038344 RID: 230212
		[Token(Token = "0x4038344")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x04038345 RID: 230213
		[Token(Token = "0x4038345")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
