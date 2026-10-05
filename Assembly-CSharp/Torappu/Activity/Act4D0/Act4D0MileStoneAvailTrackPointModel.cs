using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200728B RID: 29323
	[Token(Token = "0x200728B")]
	public class Act4D0MileStoneAvailTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x06029872 RID: 170098 RVA: 0x000D5D80 File Offset: 0x000D3F80
		[Token(Token = "0x17006241")]
		public bool isShow
		{
			[Token(Token = "0x6029872")]
			[Address(RVA = "0x24DC810", Offset = "0x24DB410", VA = "0x1824DC810", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029873 RID: 170099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029873")]
		[Address(RVA = "0x24DC570", Offset = "0x24DB170", VA = "0x1824DC570", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029874 RID: 170100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029874")]
		[Address(RVA = "0x24DC7B0", Offset = "0x24DB3B0", VA = "0x1824DC7B0")]
		public Act4D0MileStoneAvailTrackPointModel()
		{
		}

		// Token: 0x0403B582 RID: 243074
		[Token(Token = "0x403B582")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNew;

		// Token: 0x0403B583 RID: 243075
		[Token(Token = "0x403B583")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403B584 RID: 243076
		[Token(Token = "0x403B584")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403B585 RID: 243077
		[Token(Token = "0x403B585")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
