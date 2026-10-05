using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F31 RID: 24369
	[Token(Token = "0x2005F31")]
	public class CharacterInfoBattleInfoViewController : DataBinder<CharInfoGroupProperty>
	{
		// Token: 0x060234B4 RID: 144564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B4")]
		[Address(RVA = "0x1DD7210", Offset = "0x1DD5E10", VA = "0x181DD7210", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x060234B5 RID: 144565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B5")]
		[Address(RVA = "0x1DD72F0", Offset = "0x1DD5EF0", VA = "0x181DD72F0")]
		public CharacterInfoBattleInfoViewController()
		{
		}

		// Token: 0x04030AC5 RID: 199365
		[Token(Token = "0x4030AC5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x04030AC6 RID: 199366
		[Token(Token = "0x4030AC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030AC7 RID: 199367
		[Token(Token = "0x4030AC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
