using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B8C RID: 19340
	[Token(Token = "0x2004B8C")]
	public class FriendStarEditPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x0601D19D RID: 119197 RVA: 0x000AA718 File Offset: 0x000A8918
		[Token(Token = "0x17004472")]
		public bool isShow
		{
			[Token(Token = "0x601D19D")]
			[Address(RVA = "0x169AC00", Offset = "0x1699800", VA = "0x18169AC00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D19E RID: 119198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D19E")]
		[Address(RVA = "0x169AB30", Offset = "0x1699730", VA = "0x18169AB30", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D19F RID: 119199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D19F")]
		[Address(RVA = "0x169ABA0", Offset = "0x16997A0", VA = "0x18169ABA0")]
		public FriendStarEditPointModel()
		{
		}

		// Token: 0x04026312 RID: 156434
		[Token(Token = "0x4026312")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04026313 RID: 156435
		[Token(Token = "0x4026313")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026314 RID: 156436
		[Token(Token = "0x4026314")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026315 RID: 156437
		[Token(Token = "0x4026315")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
