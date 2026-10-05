using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002590 RID: 9616
	[Token(Token = "0x2002590")]
	public class TargetRootTileValidator : TargetValidator
	{
		// Token: 0x0600F7E8 RID: 63464 RVA: 0x0005CD00 File Offset: 0x0005AF00
		[Token(Token = "0x600F7E8")]
		[Address(RVA = "0x7159A0", Offset = "0x7145A0", VA = "0x1807159A0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7E9 RID: 63465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E9")]
		[Address(RVA = "0x715B10", Offset = "0x714710", VA = "0x180715B10")]
		public TargetRootTileValidator()
		{
		}

		// Token: 0x0600F7EA RID: 63466 RVA: 0x0005CD18 File Offset: 0x0005AF18
		[Token(Token = "0x600F7EA")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011382 RID: 70530
		[Token(Token = "0x4011382")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Tile")]
		private TileSelector.Options _tileOptions;

		// Token: 0x04011383 RID: 70531
		[Token(Token = "0x4011383")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011384 RID: 70532
		[Token(Token = "0x4011384")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
