using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007385 RID: 29573
	[Token(Token = "0x2007385")]
	public class Act42D0EntryChallengeMapBtnViewModel : TemplateActivityViewModel
	{
		// Token: 0x170062BE RID: 25278
		// (get) Token: 0x06029CF0 RID: 171248 RVA: 0x000D6A58 File Offset: 0x000D4C58
		// (set) Token: 0x06029CF1 RID: 171249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170062BE")]
		public bool hasNewSign
		{
			[Token(Token = "0x6029CF0")]
			[Address(RVA = "0x255E730", Offset = "0x255D330", VA = "0x18255E730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6029CF1")]
			[Address(RVA = "0x255E860", Offset = "0x255D460", VA = "0x18255E860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x06029CF2 RID: 171250 RVA: 0x000D6A70 File Offset: 0x000D4C70
		// (set) Token: 0x06029CF3 RID: 171251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170062BF")]
		public bool allClear
		{
			[Token(Token = "0x6029CF2")]
			[Address(RVA = "0x255E6D0", Offset = "0x255D2D0", VA = "0x18255E6D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6029CF3")]
			[Address(RVA = "0x255E7F0", Offset = "0x255D3F0", VA = "0x18255E7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x06029CF4 RID: 171252 RVA: 0x000D6A88 File Offset: 0x000D4C88
		// (set) Token: 0x06029CF5 RID: 171253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170062C0")]
		public bool isTimeOut
		{
			[Token(Token = "0x6029CF4")]
			[Address(RVA = "0x255E790", Offset = "0x255D390", VA = "0x18255E790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6029CF5")]
			[Address(RVA = "0x255E8D0", Offset = "0x255D4D0", VA = "0x18255E8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029CF6 RID: 171254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CF6")]
		[Address(RVA = "0x255E520", Offset = "0x255D120", VA = "0x18255E520")]
		public Act42D0EntryChallengeMapBtnViewModel(object param)
		{
		}

		// Token: 0x06029CF7 RID: 171255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CF7")]
		[Address(RVA = "0x255DE70", Offset = "0x255CA70", VA = "0x18255DE70")]
		public void LoadData(ActivityBasicInfo basicInfo)
		{
		}

		// Token: 0x0403BDEC RID: 245228
		[Token(Token = "0x403BDEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasNewSign;

		// Token: 0x0403BDED RID: 245229
		[Token(Token = "0x403BDED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasNewSign;

		// Token: 0x0403BDEE RID: 245230
		[Token(Token = "0x403BDEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allClear;

		// Token: 0x0403BDEF RID: 245231
		[Token(Token = "0x403BDEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_allClear;

		// Token: 0x0403BDF0 RID: 245232
		[Token(Token = "0x403BDF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isTimeOut;

		// Token: 0x0403BDF1 RID: 245233
		[Token(Token = "0x403BDF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isTimeOut;

		// Token: 0x0403BDF2 RID: 245234
		[Token(Token = "0x403BDF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403BDF3 RID: 245235
		[Token(Token = "0x403BDF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x02007386 RID: 29574
		[Token(Token = "0x2007386")]
		public class Input
		{
			// Token: 0x06029CF8 RID: 171256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CF8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403BDF4 RID: 245236
			[Token(Token = "0x403BDF4")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo basicInfo;
		}
	}
}
