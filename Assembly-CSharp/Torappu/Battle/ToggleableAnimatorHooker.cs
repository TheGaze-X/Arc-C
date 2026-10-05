using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002142 RID: 8514
	[Token(Token = "0x2002142")]
	public class ToggleableAnimatorHooker : UnitAnimatorHooker
	{
		// Token: 0x0600D166 RID: 53606 RVA: 0x0004B738 File Offset: 0x00049938
		[Token(Token = "0x600D166")]
		[Address(RVA = "0x353B3C0", Offset = "0x3539FC0", VA = "0x18353B3C0", Slot = "4")]
		public override bool TryHookAnimation(string animKey, out string newAnimKey)
		{
			return default(bool);
		}

		// Token: 0x0600D167 RID: 53607 RVA: 0x0004B750 File Offset: 0x00049950
		[Token(Token = "0x600D167")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		public override bool ValidateAnimSwitchable(string sourceAnimName, string targetAnimName)
		{
			return default(bool);
		}

		// Token: 0x0600D168 RID: 53608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D168")]
		[Address(RVA = "0x353B590", Offset = "0x353A190", VA = "0x18353B590")]
		public ToggleableAnimatorHooker()
		{
		}

		// Token: 0x0400DFD3 RID: 57299
		[Token(Token = "0x400DFD3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ToggleableAnimatorHooker.ToggleablePair> _checkerHookerPairs;

		// Token: 0x02002143 RID: 8515
		[Token(Token = "0x2002143")]
		[Serializable]
		public class ToggleablePair
		{
			// Token: 0x0600D169 RID: 53609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D169")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ToggleablePair()
			{
			}

			// Token: 0x0400DFD4 RID: 57300
			[Token(Token = "0x400DFD4")]
			[FieldOffset(Offset = "0x10")]
			public ToggleableHookerChecker toggleableHookerChecker;

			// Token: 0x0400DFD5 RID: 57301
			[Token(Token = "0x400DFD5")]
			[FieldOffset(Offset = "0x18")]
			public UnitAnimatorHooker hooker;
		}
	}
}
