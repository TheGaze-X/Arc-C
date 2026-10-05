using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200255E RID: 9566
	[Token(Token = "0x200255E")]
	[Obsolete]
	public class CardWithProperCountTrigger : TargetTrigger
	{
		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x0600F6E8 RID: 63208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700205C")]
		public override Entity target
		{
			[Token(Token = "0x600F6E8")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x0600F6E9 RID: 63209 RVA: 0x0005C118 File Offset: 0x0005A318
		[Token(Token = "0x1700205D")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F6E9")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F6EA RID: 63210 RVA: 0x0005C130 File Offset: 0x0005A330
		[Token(Token = "0x600F6EA")]
		[Address(RVA = "0x6F3690", Offset = "0x6F2290", VA = "0x1806F3690", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F6EB RID: 63211 RVA: 0x0005C148 File Offset: 0x0005A348
		[Token(Token = "0x600F6EB")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F6EC RID: 63212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6EC")]
		[Address(RVA = "0x6F3930", Offset = "0x6F2530", VA = "0x1806F3930")]
		public CardWithProperCountTrigger()
		{
		}

		// Token: 0x04011242 RID: 70210
		[Token(Token = "0x4011242")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _cardKey;

		// Token: 0x04011243 RID: 70211
		[Token(Token = "0x4011243")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _minCardCount;

		// Token: 0x04011244 RID: 70212
		[Token(Token = "0x4011244")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _maxCardCount;
	}
}
