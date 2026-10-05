using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024EE RID: 9454
	[Token(Token = "0x20024EE")]
	public class AdvancedSelectorWithinHpRatio : AdvancedSelector
	{
		// Token: 0x0600F391 RID: 62353 RVA: 0x00059D30 File Offset: 0x00057F30
		[Token(Token = "0x600F391")]
		[Address(RVA = "0x6A2170", Offset = "0x6A0D70", VA = "0x1806A2170", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F392 RID: 62354 RVA: 0x00059D48 File Offset: 0x00057F48
		[Token(Token = "0x600F392")]
		[Address(RVA = "0x6A2370", Offset = "0x6A0F70", VA = "0x1806A2370")]
		private bool _CheckHpRatio(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F393 RID: 62355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F393")]
		[Address(RVA = "0x6A2510", Offset = "0x6A1110", VA = "0x1806A2510")]
		public AdvancedSelectorWithinHpRatio()
		{
		}

		// Token: 0x0600F394 RID: 62356 RVA: 0x00059D60 File Offset: 0x00057F60
		[Token(Token = "0x600F394")]
		[Address(RVA = "0x60C700", Offset = "0x60B300", VA = "0x18060C700")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010D9E RID: 69022
		[Token(Token = "0x4010D9E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _filerMaxHp;

		// Token: 0x04010D9F RID: 69023
		[Token(Token = "0x4010D9F")]
		[FieldOffset(Offset = "0xF1")]
		[SerializeField]
		private bool _maxHpExcludeEqual;

		// Token: 0x04010DA0 RID: 69024
		[Token(Token = "0x4010DA0")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private float _maxHpRatio;

		// Token: 0x04010DA1 RID: 69025
		[Token(Token = "0x4010DA1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _filterMinHp;

		// Token: 0x04010DA2 RID: 69026
		[Token(Token = "0x4010DA2")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private float _minHpRatio;

		// Token: 0x04010DA3 RID: 69027
		[Token(Token = "0x4010DA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010DA4 RID: 69028
		[Token(Token = "0x4010DA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckHpRatio;

		// Token: 0x04010DA5 RID: 69029
		[Token(Token = "0x4010DA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
