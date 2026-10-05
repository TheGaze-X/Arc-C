using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051C0 RID: 20928
	[Token(Token = "0x20051C0")]
	public class RoguelikeChoiceStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x0601EE94 RID: 126612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004822")]
		public RoguelikeChoiceScene scene
		{
			[Token(Token = "0x601EE94")]
			[Address(RVA = "0x18A5040", Offset = "0x18A3C40", VA = "0x1818A5040")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EE95 RID: 126613 RVA: 0x000B01A8 File Offset: 0x000AE3A8
		[Token(Token = "0x601EE95")]
		[Address(RVA = "0x18A4B10", Offset = "0x18A3710", VA = "0x1818A4B10")]
		public bool TryUpdateData(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601EE96 RID: 126614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE96")]
		[Address(RVA = "0x18A4D80", Offset = "0x18A3980", VA = "0x1818A4D80")]
		private PlayerRoguelikePendingEvent.SceneContent _GetPlayerChoiceScene(PlayerRoguelikeV2.CurrentData.PlayerStatus playerStatus)
		{
			return null;
		}

		// Token: 0x0601EE97 RID: 126615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE97")]
		[Address(RVA = "0x18A4E80", Offset = "0x18A3A80", VA = "0x1818A4E80")]
		public RoguelikeChoiceStateBean()
		{
		}

		// Token: 0x04029775 RID: 169845
		[Token(Token = "0x4029775")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeChoiceScene m_scene;

		// Token: 0x04029776 RID: 169846
		[Token(Token = "0x4029776")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scene;

		// Token: 0x04029777 RID: 169847
		[Token(Token = "0x4029777")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryUpdateData;

		// Token: 0x04029778 RID: 169848
		[Token(Token = "0x4029778")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPlayerChoiceScene;

		// Token: 0x04029779 RID: 169849
		[Token(Token = "0x4029779")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
