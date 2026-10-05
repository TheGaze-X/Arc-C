using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002957 RID: 10583
	[Token(Token = "0x2002957")]
	public class CSpecificTargetAttributeCost : CRandomTargetAttribute
	{
		// Token: 0x0601189A RID: 71834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601189A")]
		[Address(RVA = "0x9515A0", Offset = "0x9501A0", VA = "0x1809515A0", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x0601189B RID: 71835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601189B")]
		[Address(RVA = "0x951AF0", Offset = "0x9506F0", VA = "0x180951AF0")]
		public CSpecificTargetAttributeCost()
		{
		}

		// Token: 0x0601189C RID: 71836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601189C")]
		[Address(RVA = "0x951AE0", Offset = "0x9506E0", VA = "0x180951AE0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040139A7 RID: 80295
		[Token(Token = "0x40139A7")]
		private const string FILTER_OPERATOR = "filter_operator";

		// Token: 0x040139A8 RID: 80296
		[Token(Token = "0x40139A8")]
		private const string MIN = "min";

		// Token: 0x040139A9 RID: 80297
		[Token(Token = "0x40139A9")]
		private const string MAX = "max";

		// Token: 0x040139AA RID: 80298
		[Token(Token = "0x40139AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040139AB RID: 80299
		[Token(Token = "0x40139AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002958 RID: 10584
		[Token(Token = "0x2002958")]
		private class DataPkg
		{
			// Token: 0x0601189D RID: 71837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601189D")]
			[Address(RVA = "0x952F90", Offset = "0x951B90", VA = "0x180952F90")]
			public DataPkg(int _index, ObscuredInt _value, ProfessionCategory _profession, string _key)
			{
			}

			// Token: 0x040139AC RID: 80300
			[Token(Token = "0x40139AC")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x040139AD RID: 80301
			[Token(Token = "0x40139AD")]
			[FieldOffset(Offset = "0x14")]
			public float value;

			// Token: 0x040139AE RID: 80302
			[Token(Token = "0x40139AE")]
			[FieldOffset(Offset = "0x18")]
			public ProfessionCategory profession;

			// Token: 0x040139AF RID: 80303
			[Token(Token = "0x40139AF")]
			[FieldOffset(Offset = "0x20")]
			public string key;
		}
	}
}
