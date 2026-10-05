using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003247 RID: 12871
	[Token(Token = "0x2003247")]
	public class PauseEffectIfRacingEnemy : PauseEffectIf
	{
		// Token: 0x0601469F RID: 83615 RVA: 0x00086D18 File Offset: 0x00084F18
		[Token(Token = "0x601469F")]
		[Address(RVA = "0xCA83A0", Offset = "0xCA6FA0", VA = "0x180CA83A0", Slot = "10")]
		protected override bool? GetCheckResult()
		{
			return null;
		}

		// Token: 0x060146A0 RID: 83616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A0")]
		[Address(RVA = "0xCA85F0", Offset = "0xCA71F0", VA = "0x180CA85F0")]
		public PauseEffectIfRacingEnemy()
		{
		}

		// Token: 0x060146A1 RID: 83617 RVA: 0x00086D30 File Offset: 0x00084F30
		[Token(Token = "0x60146A1")]
		[Address(RVA = "0xCA85E0", Offset = "0xCA71E0", VA = "0x180CA85E0")]
		private bool? <>xLuaBaseProxy_GetCheckResult()
		{
			return null;
		}

		// Token: 0x040181BC RID: 98748
		[Token(Token = "0x40181BC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Racing Enemy")]
		private CompareType _compareType;

		// Token: 0x040181BD RID: 98749
		[Token(Token = "0x40181BD")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Group("Racing Enemy")]
		private int _pauseRacingMoveSpeed;

		// Token: 0x040181BE RID: 98750
		[Token(Token = "0x40181BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCheckResult;

		// Token: 0x040181BF RID: 98751
		[Token(Token = "0x40181BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
