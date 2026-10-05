using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067FA RID: 26618
	[Token(Token = "0x20067FA")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class PermModeUtil
	{
		// Token: 0x0602625D RID: 156253 RVA: 0x000CA320 File Offset: 0x000C8520
		[Token(Token = "0x602625D")]
		[Address(RVA = "0x2131B30", Offset = "0x2130730", VA = "0x182131B30")]
		public static bool NeedPermModeTrack()
		{
			return default(bool);
		}

		// Token: 0x0602625E RID: 156254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602625E")]
		[Address(RVA = "0x21311C0", Offset = "0x212FDC0", VA = "0x1821311C0")]
		public static void ConsumePermModeTrack()
		{
		}

		// Token: 0x0602625F RID: 156255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602625F")]
		[Address(RVA = "0x2131C90", Offset = "0x2130890", VA = "0x182131C90")]
		private static void _ConsumeUnlockTrack()
		{
		}

		// Token: 0x06026260 RID: 156256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026260")]
		[Address(RVA = "0x2131C00", Offset = "0x2130800", VA = "0x182131C00")]
		private static void _ConsumeContentTrack()
		{
		}

		// Token: 0x06026261 RID: 156257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026261")]
		[Address(RVA = "0x21312A0", Offset = "0x212FEA0", VA = "0x1821312A0")]
		public static string GetCurrentRoguelikeTopicId(long currTs)
		{
			return null;
		}

		// Token: 0x06026262 RID: 156258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026262")]
		[Address(RVA = "0x21314C0", Offset = "0x21300C0", VA = "0x1821314C0")]
		public static string GetCurrentSandboxPermTopicId(long currTs)
		{
			return null;
		}

		// Token: 0x06026263 RID: 156259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026263")]
		[Address(RVA = "0x2130EC0", Offset = "0x212FAC0", VA = "0x182130EC0")]
		public static void ConsumeExpiredEntryTrackPoint()
		{
		}

		// Token: 0x06026264 RID: 156260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026264")]
		[Address(RVA = "0x21316D0", Offset = "0x21302D0", VA = "0x1821316D0")]
		public static RoguelikeTopicResHolder LoadRoguelikeResHolder(string topicId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06026265 RID: 156261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026265")]
		[Address(RVA = "0x2131900", Offset = "0x2130500", VA = "0x182131900")]
		public static SandboxPermTopicResHolder LoadSandboxPermResHolder(string topicId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x04035BA0 RID: 220064
		[Token(Token = "0x4035BA0")]
		public const string PERM_MODE_UNLOCK_TRACK_ID = "PERM_MODE_UNLOCKED";

		// Token: 0x04035BA1 RID: 220065
		[Token(Token = "0x4035BA1")]
		public const string PERM_ENTRY_TRACK_ID = "PERM_ENTRY";

		// Token: 0x04035BA2 RID: 220066
		[Token(Token = "0x4035BA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NeedPermModeTrack;

		// Token: 0x04035BA3 RID: 220067
		[Token(Token = "0x4035BA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConsumePermModeTrack;

		// Token: 0x04035BA4 RID: 220068
		[Token(Token = "0x4035BA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ConsumeUnlockTrack;

		// Token: 0x04035BA5 RID: 220069
		[Token(Token = "0x4035BA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConsumeContentTrack;

		// Token: 0x04035BA6 RID: 220070
		[Token(Token = "0x4035BA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurrentRoguelikeTopicId;

		// Token: 0x04035BA7 RID: 220071
		[Token(Token = "0x4035BA7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCurrentSandboxPermTopicId;

		// Token: 0x04035BA8 RID: 220072
		[Token(Token = "0x4035BA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConsumeExpiredEntryTrackPoint;

		// Token: 0x04035BA9 RID: 220073
		[Token(Token = "0x4035BA9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadRoguelikeResHolder;

		// Token: 0x04035BAA RID: 220074
		[Token(Token = "0x4035BAA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadSandboxPermResHolder;
	}
}
