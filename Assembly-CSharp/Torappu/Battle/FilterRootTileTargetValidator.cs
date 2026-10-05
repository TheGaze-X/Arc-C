using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002581 RID: 9601
	[Token(Token = "0x2002581")]
	public class FilterRootTileTargetValidator : TargetValidator
	{
		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600F7B0 RID: 63408 RVA: 0x0005CA30 File Offset: 0x0005AC30
		[Token(Token = "0x17002083")]
		private bool filterHeightType
		{
			[Token(Token = "0x600F7B0")]
			[Address(RVA = "0x70BE10", Offset = "0x70AA10", VA = "0x18070BE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F7B1 RID: 63409 RVA: 0x0005CA48 File Offset: 0x0005AC48
		[Token(Token = "0x600F7B1")]
		[Address(RVA = "0x70BC00", Offset = "0x70A800", VA = "0x18070BC00", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7B2 RID: 63410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7B2")]
		[Address(RVA = "0x70BD70", Offset = "0x70A970", VA = "0x18070BD70")]
		public FilterRootTileTargetValidator()
		{
		}

		// Token: 0x0600F7B3 RID: 63411 RVA: 0x0005CA60 File Offset: 0x0005AC60
		[Token(Token = "0x600F7B3")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401133D RID: 70461
		[Token(Token = "0x401133D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _filterHeightType;

		// Token: 0x0401133E RID: 70462
		[Token(Token = "0x401133E")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Inspect("filterHeightType")]
		private TileData.HeightType _tileHeightType;

		// Token: 0x0401133F RID: 70463
		[Token(Token = "0x401133F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterHeightType;

		// Token: 0x04011340 RID: 70464
		[Token(Token = "0x4011340")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011341 RID: 70465
		[Token(Token = "0x4011341")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
