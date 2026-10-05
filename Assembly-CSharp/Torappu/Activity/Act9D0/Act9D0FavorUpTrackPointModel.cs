using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200717F RID: 29055
	[Token(Token = "0x200717F")]
	public class Act9D0FavorUpTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x060293EB RID: 168939 RVA: 0x000D4D18 File Offset: 0x000D2F18
		[Token(Token = "0x1700619C")]
		public bool isShow
		{
			[Token(Token = "0x60293EB")]
			[Address(RVA = "0x24963C0", Offset = "0x2494FC0", VA = "0x1824963C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060293EC RID: 168940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293EC")]
		[Address(RVA = "0x24961C0", Offset = "0x2494DC0", VA = "0x1824961C0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060293ED RID: 168941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293ED")]
		[Address(RVA = "0x2496360", Offset = "0x2494F60", VA = "0x182496360")]
		public Act9D0FavorUpTrackPointModel()
		{
		}

		// Token: 0x0403AE83 RID: 241283
		[Token(Token = "0x403AE83")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNewUp;

		// Token: 0x0403AE84 RID: 241284
		[Token(Token = "0x403AE84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403AE85 RID: 241285
		[Token(Token = "0x403AE85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403AE86 RID: 241286
		[Token(Token = "0x403AE86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
