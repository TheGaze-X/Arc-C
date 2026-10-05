using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200252F RID: 9519
	[Token(Token = "0x200252F")]
	public class AdvancedSelectorSortWithCausedDamage : AdvancedSelector
	{
		// Token: 0x0600F5A7 RID: 62887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5A7")]
		[Address(RVA = "0x6CF330", Offset = "0x6CDF30", VA = "0x1806CF330", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5A8 RID: 62888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F5A8")]
		[Address(RVA = "0x6CF8D0", Offset = "0x6CE4D0", VA = "0x1806CF8D0")]
		private string _GetSafeKey(Entity entity)
		{
			return null;
		}

		// Token: 0x0600F5A9 RID: 62889 RVA: 0x0005B4D0 File Offset: 0x000596D0
		[Token(Token = "0x600F5A9")]
		[Address(RVA = "0x6CF6D0", Offset = "0x6CE2D0", VA = "0x1806CF6D0")]
		private FP _CalculateDamageWeight(Entity entity, Buff recorderBuff)
		{
			return default(FP);
		}

		// Token: 0x0600F5AA RID: 62890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5AA")]
		[Address(RVA = "0x6CFA00", Offset = "0x6CE600", VA = "0x1806CFA00")]
		public AdvancedSelectorSortWithCausedDamage()
		{
		}

		// Token: 0x0600F5AB RID: 62891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5AB")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04011062 RID: 69730
		[Token(Token = "0x4011062")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Sort")]
		private string _damageRecorderBuffKey;

		// Token: 0x04011063 RID: 69731
		[Token(Token = "0x4011063")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Sort")]
		private int _maxTargetNum;

		// Token: 0x04011064 RID: 69732
		[Token(Token = "0x4011064")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[Group("Sort")]
		private bool _characterOnly;

		// Token: 0x04011065 RID: 69733
		[Token(Token = "0x4011065")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04011066 RID: 69734
		[Token(Token = "0x4011066")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetSafeKey;

		// Token: 0x04011067 RID: 69735
		[Token(Token = "0x4011067")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalculateDamageWeight;

		// Token: 0x04011068 RID: 69736
		[Token(Token = "0x4011068")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
