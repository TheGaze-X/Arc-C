using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C1 RID: 17601
	[Token(Token = "0x20044C1")]
	public class RoguelikeTopicDifficultyItemModel : IHotfixable
	{
		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x0601AE15 RID: 110101 RVA: 0x000A38F0 File Offset: 0x000A1AF0
		[Token(Token = "0x17003FD0")]
		public int sortId
		{
			[Token(Token = "0x601AE15")]
			[Address(RVA = "0x1409EB0", Offset = "0x1408AB0", VA = "0x181409EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x0601AE16 RID: 110102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FD1")]
		public Sprite relicIcon
		{
			[Token(Token = "0x601AE16")]
			[Address(RVA = "0x1409E50", Offset = "0x1408A50", VA = "0x181409E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0601AE17 RID: 110103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FD2")]
		public RoguelikeTopicDifficulty difficultyData
		{
			[Token(Token = "0x601AE17")]
			[Address(RVA = "0x1409DF0", Offset = "0x14089F0", VA = "0x181409DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AE18 RID: 110104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE18")]
		[Address(RVA = "0x1409C20", Offset = "0x1408820", VA = "0x181409C20")]
		public void Load(RoguelikeTopicDifficulty difficultyData, RoguelikeTopicNormalModelStyle normalModeStyle)
		{
		}

		// Token: 0x0601AE19 RID: 110105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE19")]
		[Address(RVA = "0x1409D90", Offset = "0x1408990", VA = "0x181409D90")]
		public RoguelikeTopicDifficultyItemModel()
		{
		}

		// Token: 0x04022723 RID: 141091
		[Token(Token = "0x4022723")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeTopicDifficulty m_diffData;

		// Token: 0x04022724 RID: 141092
		[Token(Token = "0x4022724")]
		[FieldOffset(Offset = "0x18")]
		private Sprite m_relicIcon;

		// Token: 0x04022725 RID: 141093
		[Token(Token = "0x4022725")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04022726 RID: 141094
		[Token(Token = "0x4022726")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_relicIcon;

		// Token: 0x04022727 RID: 141095
		[Token(Token = "0x4022727")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_difficultyData;

		// Token: 0x04022728 RID: 141096
		[Token(Token = "0x4022728")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04022729 RID: 141097
		[Token(Token = "0x4022729")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
