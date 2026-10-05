using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024FB RID: 9467
	[Token(Token = "0x20024FB")]
	public class BlemshSleepingFirstSelector : BlockedOrAdvancedSelector
	{
		// Token: 0x0600F3D4 RID: 62420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3D4")]
		[Address(RVA = "0x6B3620", Offset = "0x6B2220", VA = "0x1806B3620", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F3D5 RID: 62421 RVA: 0x00059E98 File Offset: 0x00058098
		[Token(Token = "0x600F3D5")]
		[Address(RVA = "0x6B40E0", Offset = "0x6B2CE0", VA = "0x1806B40E0")]
		private bool _CheckEnemyHasAbnormalComboAndInBlockableRange(Entity entity, Entity source, out FP weight, out int volume)
		{
			return default(bool);
		}

		// Token: 0x0600F3D6 RID: 62422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3D6")]
		[Address(RVA = "0x6B4390", Offset = "0x6B2F90", VA = "0x1806B4390")]
		public BlemshSleepingFirstSelector()
		{
		}

		// Token: 0x0600F3D8 RID: 62424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3D8")]
		[Address(RVA = "0x6B40D0", Offset = "0x6B2CD0", VA = "0x1806B40D0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010E04 RID: 69124
		[Token(Token = "0x4010E04")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private AbnormalCombo _abnormalComboWithHighPriority;

		// Token: 0x04010E05 RID: 69125
		[Token(Token = "0x4010E05")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private bool _selectBlockRadiusSquareWithHighPrior;

		// Token: 0x04010E06 RID: 69126
		[Token(Token = "0x4010E06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E07 RID: 69127
		[Token(Token = "0x4010E07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckEnemyHasAbnormalComboAndInBlockableRange;

		// Token: 0x04010E08 RID: 69128
		[Token(Token = "0x4010E08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
