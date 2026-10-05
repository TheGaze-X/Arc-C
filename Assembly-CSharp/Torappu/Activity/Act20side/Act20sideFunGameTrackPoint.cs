using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x020076A7 RID: 30375
	[Token(Token = "0x20076A7")]
	public class Act20sideFunGameTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602AB4F RID: 174927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB4F")]
		[Address(RVA = "0x26765A0", Offset = "0x26751A0", VA = "0x1826765A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006459 RID: 25689
		// (get) Token: 0x0602AB50 RID: 174928 RVA: 0x000D97D0 File Offset: 0x000D79D0
		[Token(Token = "0x17006459")]
		public bool isShow
		{
			[Token(Token = "0x602AB50")]
			[Address(RVA = "0x26766F0", Offset = "0x26752F0", VA = "0x1826766F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB51 RID: 174929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB51")]
		[Address(RVA = "0x2676690", Offset = "0x2675290", VA = "0x182676690")]
		public Act20sideFunGameTrackPoint()
		{
		}

		// Token: 0x0403D8B2 RID: 252082
		[Token(Token = "0x403D8B2")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D8B3 RID: 252083
		[Token(Token = "0x403D8B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D8B4 RID: 252084
		[Token(Token = "0x403D8B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D8B5 RID: 252085
		[Token(Token = "0x403D8B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
