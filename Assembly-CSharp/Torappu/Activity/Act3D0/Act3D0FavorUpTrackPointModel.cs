using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200742D RID: 29741
	[Token(Token = "0x200742D")]
	public class Act3D0FavorUpTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006318 RID: 25368
		// (get) Token: 0x06029F9C RID: 171932 RVA: 0x000D71C0 File Offset: 0x000D53C0
		[Token(Token = "0x17006318")]
		public bool isShow
		{
			[Token(Token = "0x6029F9C")]
			[Address(RVA = "0x25886E0", Offset = "0x25872E0", VA = "0x1825886E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029F9D RID: 171933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F9D")]
		[Address(RVA = "0x25884E0", Offset = "0x25870E0", VA = "0x1825884E0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029F9E RID: 171934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F9E")]
		[Address(RVA = "0x2588680", Offset = "0x2587280", VA = "0x182588680")]
		public Act3D0FavorUpTrackPointModel()
		{
		}

		// Token: 0x0403C2EC RID: 246508
		[Token(Token = "0x403C2EC")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNewUp;

		// Token: 0x0403C2ED RID: 246509
		[Token(Token = "0x403C2ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403C2EE RID: 246510
		[Token(Token = "0x403C2EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403C2EF RID: 246511
		[Token(Token = "0x403C2EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
