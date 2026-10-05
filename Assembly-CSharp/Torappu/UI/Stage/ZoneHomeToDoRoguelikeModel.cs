using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F7 RID: 26615
	[Token(Token = "0x20067F7")]
	public class ZoneHomeToDoRoguelikeModel : ZoneHomeToDoItemModel
	{
		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x06026251 RID: 156241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A2D")]
		public ZoneHomeToDoRoguelikeModel.TopicModel topicModel
		{
			[Token(Token = "0x6026251")]
			[Address(RVA = "0x2146F50", Offset = "0x2145B50", VA = "0x182146F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026252 RID: 156242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026252")]
		[Address(RVA = "0x2146B70", Offset = "0x2145770", VA = "0x182146B70")]
		public static ZoneHomeToDoRoguelikeModel LoadData()
		{
			return null;
		}

		// Token: 0x06026253 RID: 156243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026253")]
		[Address(RVA = "0x2146EA0", Offset = "0x2145AA0", VA = "0x182146EA0")]
		public ZoneHomeToDoRoguelikeModel()
		{
		}

		// Token: 0x04035B92 RID: 220050
		[Token(Token = "0x4035B92")]
		[FieldOffset(Offset = "0x38")]
		private ZoneHomeToDoRoguelikeModel.TopicModel m_topicModel;

		// Token: 0x04035B93 RID: 220051
		[Token(Token = "0x4035B93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicModel;

		// Token: 0x04035B94 RID: 220052
		[Token(Token = "0x4035B94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035B95 RID: 220053
		[Token(Token = "0x4035B95")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067F8 RID: 26616
		[Token(Token = "0x20067F8")]
		public class TopicModel
		{
			// Token: 0x06026254 RID: 156244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026254")]
			[Address(RVA = "0x2142A50", Offset = "0x2141650", VA = "0x182142A50")]
			public TopicModel(string topicId, bool isOnBattle, bool isPinned)
			{
			}

			// Token: 0x17005A2E RID: 23086
			// (get) Token: 0x06026255 RID: 156245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005A2E")]
			public string displayId
			{
				[Token(Token = "0x6026255")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005A2F RID: 23087
			// (get) Token: 0x06026256 RID: 156246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005A2F")]
			public string topicId
			{
				[Token(Token = "0x6026256")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005A30 RID: 23088
			// (get) Token: 0x06026257 RID: 156247 RVA: 0x000CA2F0 File Offset: 0x000C84F0
			[Token(Token = "0x17005A30")]
			public bool isOnBattle
			{
				[Token(Token = "0x6026257")]
				[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005A31 RID: 23089
			// (get) Token: 0x06026258 RID: 156248 RVA: 0x000CA308 File Offset: 0x000C8508
			[Token(Token = "0x17005A31")]
			public bool isPinned
			{
				[Token(Token = "0x6026258")]
				[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005A32 RID: 23090
			// (get) Token: 0x06026259 RID: 156249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005A32")]
			public RoguelikeTopicBasicData basicData
			{
				[Token(Token = "0x6026259")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
			}

			// Token: 0x04035B96 RID: 220054
			[Token(Token = "0x4035B96")]
			[FieldOffset(Offset = "0x10")]
			private string m_displayId;

			// Token: 0x04035B97 RID: 220055
			[Token(Token = "0x4035B97")]
			[FieldOffset(Offset = "0x18")]
			private string m_topicId;

			// Token: 0x04035B98 RID: 220056
			[Token(Token = "0x4035B98")]
			[FieldOffset(Offset = "0x20")]
			private bool m_isOnBattle;

			// Token: 0x04035B99 RID: 220057
			[Token(Token = "0x4035B99")]
			[FieldOffset(Offset = "0x21")]
			private bool m_isPinned;

			// Token: 0x04035B9A RID: 220058
			[Token(Token = "0x4035B9A")]
			[FieldOffset(Offset = "0x28")]
			private RoguelikeTopicBasicData m_basicData;
		}
	}
}
