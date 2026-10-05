using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002563 RID: 9571
	[Token(Token = "0x2002563")]
	[Obsolete]
	public class GainCardTrigger : TargetTrigger
	{
		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600F70B RID: 63243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002062")]
		public override Entity target
		{
			[Token(Token = "0x600F70B")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x0600F70C RID: 63244 RVA: 0x0005C2C8 File Offset: 0x0005A4C8
		[Token(Token = "0x17002063")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F70C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F70D RID: 63245 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		[Token(Token = "0x600F70D")]
		[Address(RVA = "0x70CCA0", Offset = "0x70B8A0", VA = "0x18070CCA0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F70E RID: 63246 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
		[Token(Token = "0x600F70E")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F70F RID: 63247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F70F")]
		[Address(RVA = "0x70CF40", Offset = "0x70BB40", VA = "0x18070CF40")]
		public GainCardTrigger()
		{
		}

		// Token: 0x0401126C RID: 70252
		[Token(Token = "0x401126C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _cardKey;

		// Token: 0x0401126D RID: 70253
		[Token(Token = "0x401126D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _releaseDiscardIfAllUsedUp;

		// Token: 0x0401126E RID: 70254
		[Token(Token = "0x401126E")]
		[FieldOffset(Offset = "0x30")]
		private GameModeFactory.LegionGameMode m_gameMode;
	}
}
