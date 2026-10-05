using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D0 RID: 17616
	[Token(Token = "0x20044D0")]
	public abstract class RoguelikeTopicEndingPageViewModelBase : IHotfixable
	{
		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x0601AE61 RID: 110177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE62 RID: 110178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FDD")]
		public string topicId
		{
			[Token(Token = "0x601AE61")]
			[Address(RVA = "0x140C8E0", Offset = "0x140B4E0", VA = "0x18140C8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AE62")]
			[Address(RVA = "0x140C9C0", Offset = "0x140B5C0", VA = "0x18140C9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x0601AE63 RID: 110179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE64 RID: 110180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FDE")]
		public RoguelikeTopicPage.SettleInfo settleInfo
		{
			[Token(Token = "0x601AE63")]
			[Address(RVA = "0x140C880", Offset = "0x140B480", VA = "0x18140C880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AE64")]
			[Address(RVA = "0x140C940", Offset = "0x140B540", VA = "0x18140C940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601AE65 RID: 110181 RVA: 0x000A3980 File Offset: 0x000A1B80
		[Token(Token = "0x601AE65")]
		[Address(RVA = "0x140C6C0", Offset = "0x140B2C0", VA = "0x18140C6C0")]
		public bool LoadData(string topicId, RoguelikeTopicPage.SettleInfo settleInfo)
		{
			return default(bool);
		}

		// Token: 0x0601AE66 RID: 110182
		[Token(Token = "0x601AE66")]
		protected abstract void OnDataLoad(out bool isDataValid);

		// Token: 0x0601AE67 RID: 110183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE67")]
		[Address(RVA = "0x140C820", Offset = "0x140B420", VA = "0x18140C820")]
		protected RoguelikeTopicEndingPageViewModelBase()
		{
		}

		// Token: 0x0402277F RID: 141183
		[Token(Token = "0x402277F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04022780 RID: 141184
		[Token(Token = "0x4022780")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04022781 RID: 141185
		[Token(Token = "0x4022781")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_settleInfo;

		// Token: 0x04022782 RID: 141186
		[Token(Token = "0x4022782")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_settleInfo;

		// Token: 0x04022783 RID: 141187
		[Token(Token = "0x4022783")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022784 RID: 141188
		[Token(Token = "0x4022784")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
