using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067BB RID: 26555
	[Token(Token = "0x20067BB")]
	public class ZoneHomeRoguelikeEntryItemModel : ZoneHomeEntryItemModel
	{
		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x0602614A RID: 155978 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602614B RID: 155979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A10")]
		public string topicId
		{
			[Token(Token = "0x602614A")]
			[Address(RVA = "0x212F440", Offset = "0x212E040", VA = "0x18212F440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602614B")]
			[Address(RVA = "0x212F4A0", Offset = "0x212E0A0", VA = "0x18212F4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602614C RID: 155980 RVA: 0x000C9EA0 File Offset: 0x000C80A0
		[Token(Token = "0x602614C")]
		[Address(RVA = "0x212F1D0", Offset = "0x212DDD0", VA = "0x18212F1D0", Slot = "5")]
		public override ZoneHomeEntryLockInfo GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x0602614D RID: 155981 RVA: 0x000C9EB8 File Offset: 0x000C80B8
		[Token(Token = "0x602614D")]
		[Address(RVA = "0x212F250", Offset = "0x212DE50", VA = "0x18212F250")]
		private static bool _CheckIfIsTopic(RoguelikeTopicBasicData topicBasicData, string displayId, long curTs)
		{
			return default(bool);
		}

		// Token: 0x0602614E RID: 155982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602614E")]
		[Address(RVA = "0x212EE90", Offset = "0x212DA90", VA = "0x18212EE90")]
		public static ZoneHomeRoguelikeEntryItemModel CreateEntryModel(StageStateBean stateBean, ActivityThemeData rogueTheme, long curTs)
		{
			return null;
		}

		// Token: 0x0602614F RID: 155983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602614F")]
		[Address(RVA = "0x212F390", Offset = "0x212DF90", VA = "0x18212F390")]
		public ZoneHomeRoguelikeEntryItemModel()
		{
		}

		// Token: 0x06026150 RID: 155984 RVA: 0x000C9ED0 File Offset: 0x000C80D0
		[Token(Token = "0x6026150")]
		[Address(RVA = "0x2128CE0", Offset = "0x21278E0", VA = "0x182128CE0")]
		private ZoneHomeEntryLockInfo <>xLuaBaseProxy_GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x04035993 RID: 219539
		[Token(Token = "0x4035993")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeEntryLockInfo m_lockInfo;

		// Token: 0x04035995 RID: 219541
		[Token(Token = "0x4035995")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04035996 RID: 219542
		[Token(Token = "0x4035996")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04035997 RID: 219543
		[Token(Token = "0x4035997")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetLockInfo;

		// Token: 0x04035998 RID: 219544
		[Token(Token = "0x4035998")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfIsTopic;

		// Token: 0x04035999 RID: 219545
		[Token(Token = "0x4035999")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateEntryModel;

		// Token: 0x0403599A RID: 219546
		[Token(Token = "0x403599A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
