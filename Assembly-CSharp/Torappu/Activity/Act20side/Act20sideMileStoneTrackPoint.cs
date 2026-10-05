using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x020076A5 RID: 30373
	[Token(Token = "0x20076A5")]
	public class Act20sideMileStoneTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602AB49 RID: 174921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB49")]
		[Address(RVA = "0x2676920", Offset = "0x2675520", VA = "0x182676920", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006457 RID: 25687
		// (get) Token: 0x0602AB4A RID: 174922 RVA: 0x000D97A0 File Offset: 0x000D79A0
		[Token(Token = "0x17006457")]
		public bool isShow
		{
			[Token(Token = "0x602AB4A")]
			[Address(RVA = "0x2676A70", Offset = "0x2675670", VA = "0x182676A70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB4B RID: 174923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB4B")]
		[Address(RVA = "0x2676A10", Offset = "0x2675610", VA = "0x182676A10")]
		public Act20sideMileStoneTrackPoint()
		{
		}

		// Token: 0x0403D8AA RID: 252074
		[Token(Token = "0x403D8AA")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D8AB RID: 252075
		[Token(Token = "0x403D8AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D8AC RID: 252076
		[Token(Token = "0x403D8AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D8AD RID: 252077
		[Token(Token = "0x403D8AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
