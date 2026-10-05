using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002534 RID: 9524
	[Token(Token = "0x2002534")]
	public class AdvancedSelectorWithValidatorFilter : AdvancedSelector
	{
		// Token: 0x0600F5B9 RID: 62905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5B9")]
		[Address(RVA = "0x6D0AD0", Offset = "0x6CF6D0", VA = "0x1806D0AD0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F5BA RID: 62906 RVA: 0x0005B578 File Offset: 0x00059778
		[Token(Token = "0x600F5BA")]
		[Address(RVA = "0x6D0D70", Offset = "0x6CF970", VA = "0x1806D0D70", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F5BB RID: 62907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5BB")]
		[Address(RVA = "0x6D0F70", Offset = "0x6CFB70", VA = "0x1806D0F70")]
		public AdvancedSelectorWithValidatorFilter()
		{
		}

		// Token: 0x0600F5BC RID: 62908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5BC")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F5BD RID: 62909 RVA: 0x0005B590 File Offset: 0x00059790
		[Token(Token = "0x600F5BD")]
		[Address(RVA = "0x60C700", Offset = "0x60B300", VA = "0x18060C700")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401107E RID: 69758
		[Token(Token = "0x401107E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		public List<AdvancedSelectorWithValidatorFilter.ValidatorFilterSetting> _validatorFilterSettings;

		// Token: 0x0401107F RID: 69759
		[Token(Token = "0x401107F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011080 RID: 69760
		[Token(Token = "0x4011080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04011081 RID: 69761
		[Token(Token = "0x4011081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002535 RID: 9525
		[Token(Token = "0x2002535")]
		[Serializable]
		public class ValidatorFilterSetting
		{
			// Token: 0x0600F5BE RID: 62910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F5BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ValidatorFilterSetting()
			{
			}

			// Token: 0x04011082 RID: 69762
			[Token(Token = "0x4011082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TargetValidator validator;

			// Token: 0x04011083 RID: 69763
			[Token(Token = "0x4011083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isMatched;

			// Token: 0x04011084 RID: 69764
			[Token(Token = "0x4011084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool ignoreTargetSide;
		}
	}
}
