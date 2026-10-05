using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067BC RID: 26556
	[Token(Token = "0x20067BC")]
	public class ZoneHomeSandboxPermItemModel : ZoneHomeEntryItemModel, IHotfixable
	{
		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x06026151 RID: 155985 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026152 RID: 155986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A11")]
		public string topicId
		{
			[Token(Token = "0x6026151")]
			[Address(RVA = "0x212FAC0", Offset = "0x212E6C0", VA = "0x18212FAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026152")]
			[Address(RVA = "0x212FB20", Offset = "0x212E720", VA = "0x18212FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026153 RID: 155987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026153")]
		[Address(RVA = "0x212F520", Offset = "0x212E120", VA = "0x18212F520")]
		public static ZoneHomeSandboxPermItemModel CreateEntryModel(ActivityThemeData sandboxTheme, long currTs)
		{
			return null;
		}

		// Token: 0x06026154 RID: 155988 RVA: 0x000C9EE8 File Offset: 0x000C80E8
		[Token(Token = "0x6026154")]
		[Address(RVA = "0x212F830", Offset = "0x212E430", VA = "0x18212F830", Slot = "5")]
		public override ZoneHomeEntryLockInfo GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x06026155 RID: 155989 RVA: 0x000C9F00 File Offset: 0x000C8100
		[Token(Token = "0x6026155")]
		[Address(RVA = "0x212F8B0", Offset = "0x212E4B0", VA = "0x18212F8B0")]
		private static bool _CheckIfIsTopic(SandboxPermBasicData basicData, string displayId, long currTs)
		{
			return default(bool);
		}

		// Token: 0x06026156 RID: 155990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026156")]
		[Address(RVA = "0x212FA10", Offset = "0x212E610", VA = "0x18212FA10")]
		public ZoneHomeSandboxPermItemModel()
		{
		}

		// Token: 0x06026157 RID: 155991 RVA: 0x000C9F18 File Offset: 0x000C8118
		[Token(Token = "0x6026157")]
		[Address(RVA = "0x2128CE0", Offset = "0x21278E0", VA = "0x182128CE0")]
		private ZoneHomeEntryLockInfo <>xLuaBaseProxy_GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x0403599B RID: 219547
		[Token(Token = "0x403599B")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeEntryLockInfo m_lockInfo;

		// Token: 0x0403599D RID: 219549
		[Token(Token = "0x403599D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0403599E RID: 219550
		[Token(Token = "0x403599E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0403599F RID: 219551
		[Token(Token = "0x403599F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateEntryModel;

		// Token: 0x040359A0 RID: 219552
		[Token(Token = "0x40359A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLockInfo;

		// Token: 0x040359A1 RID: 219553
		[Token(Token = "0x40359A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfIsTopic;

		// Token: 0x040359A2 RID: 219554
		[Token(Token = "0x40359A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
