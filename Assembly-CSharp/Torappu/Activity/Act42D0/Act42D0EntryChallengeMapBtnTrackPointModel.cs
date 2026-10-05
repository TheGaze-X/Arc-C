using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007388 RID: 29576
	[Token(Token = "0x2007388")]
	public class Act42D0EntryChallengeMapBtnTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x06029CFD RID: 171261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CFD")]
		[Address(RVA = "0x255DC20", Offset = "0x255C820", VA = "0x18255DC20", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x06029CFE RID: 171262 RVA: 0x000D6AA0 File Offset: 0x000D4CA0
		// (set) Token: 0x06029CFF RID: 171263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170062C1")]
		public bool isShow
		{
			[Token(Token = "0x6029CFE")]
			[Address(RVA = "0x255DDA0", Offset = "0x255C9A0", VA = "0x18255DDA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6029CFF")]
			[Address(RVA = "0x255DE00", Offset = "0x255CA00", VA = "0x18255DE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029D00 RID: 171264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D00")]
		[Address(RVA = "0x255DD40", Offset = "0x255C940", VA = "0x18255DD40")]
		public Act42D0EntryChallengeMapBtnTrackPointModel()
		{
		}

		// Token: 0x0403BDFF RID: 245247
		[Token(Token = "0x403BDFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403BE00 RID: 245248
		[Token(Token = "0x403BE00")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403BE01 RID: 245249
		[Token(Token = "0x403BE01")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0403BE02 RID: 245250
		[Token(Token = "0x403BE02")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007389 RID: 29577
		[Token(Token = "0x2007389")]
		public class Input
		{
			// Token: 0x06029D01 RID: 171265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029D01")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403BE03 RID: 245251
			[Token(Token = "0x403BE03")]
			[FieldOffset(Offset = "0x10")]
			public bool hasNewSign;
		}
	}
}
