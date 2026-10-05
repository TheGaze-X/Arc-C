using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002585 RID: 9605
	[Token(Token = "0x2002585")]
	public class GridPosInFrontTargetValidator : TargetValidator
	{
		// Token: 0x0600F7BD RID: 63421 RVA: 0x0005CB08 File Offset: 0x0005AD08
		[Token(Token = "0x600F7BD")]
		[Address(RVA = "0x70CFE0", Offset = "0x70BBE0", VA = "0x18070CFE0", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7BE")]
		[Address(RVA = "0x70D2D0", Offset = "0x70BED0", VA = "0x18070D2D0")]
		public GridPosInFrontTargetValidator()
		{
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x0005CB20 File Offset: 0x0005AD20
		[Token(Token = "0x600F7BF")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401134B RID: 70475
		[Token(Token = "0x401134B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int _offset;

		// Token: 0x0401134C RID: 70476
		[Token(Token = "0x401134C")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _includeSameLine;

		// Token: 0x0401134D RID: 70477
		[Token(Token = "0x401134D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401134E RID: 70478
		[Token(Token = "0x401134E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
