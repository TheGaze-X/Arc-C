using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BDA RID: 11226
	[Token(Token = "0x2002BDA")]
	[Obsolete("Use BuffDuringCastingFixed instead")]
	public class BuffDuringCasting : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06012F4C RID: 77644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F4C")]
		[Address(RVA = "0xADC070", Offset = "0xADAC70", VA = "0x180ADC070", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012F4D RID: 77645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F4D")]
		[Address(RVA = "0xADC050", Offset = "0xADAC50", VA = "0x180ADC050", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012F4E RID: 77646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F4E")]
		[Address(RVA = "0xADC030", Offset = "0xADAC30", VA = "0x180ADC030", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F4F RID: 77647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F4F")]
		[Address(RVA = "0xADBFD0", Offset = "0xADABD0", VA = "0x180ADBFD0", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F50 RID: 77648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F50")]
		[Address(RVA = "0xADC1A0", Offset = "0xADADA0", VA = "0x180ADC1A0")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x06012F51 RID: 77649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F51")]
		[Address(RVA = "0xADC250", Offset = "0xADAE50", VA = "0x180ADC250")]
		public BuffDuringCasting()
		{
		}

		// Token: 0x04015658 RID: 87640
		[Token(Token = "0x4015658")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04015659 RID: 87641
		[Token(Token = "0x4015659")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_buffUid;
	}
}
