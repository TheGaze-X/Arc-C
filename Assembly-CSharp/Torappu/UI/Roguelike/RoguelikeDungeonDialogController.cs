using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200521E RID: 21022
	[Token(Token = "0x200521E")]
	public class RoguelikeDungeonDialogController : PageSingleComponent, IHotfixable
	{
		// Token: 0x0601F049 RID: 127049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F049")]
		[Address(RVA = "0x18B7090", Offset = "0x18B5C90", VA = "0x1818B7090", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601F04A RID: 127050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F04A")]
		[Address(RVA = "0x18B79C0", Offset = "0x18B65C0", VA = "0x1818B79C0")]
		public IEnumerator ShowDialogs(UICompDialogMgr compDialogMgr)
		{
			return null;
		}

		// Token: 0x0601F04B RID: 127051 RVA: 0x000B0850 File Offset: 0x000AEA50
		[Token(Token = "0x601F04B")]
		[Address(RVA = "0x18B6D80", Offset = "0x18B5980", VA = "0x1818B6D80")]
		public bool CheckNeedToShow()
		{
			return default(bool);
		}

		// Token: 0x0601F04C RID: 127052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F04C")]
		[Address(RVA = "0x18B7A90", Offset = "0x18B6690", VA = "0x1818B7A90")]
		public RoguelikeDungeonDialogController()
		{
		}

		// Token: 0x0601F04D RID: 127053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F04D")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x040299C0 RID: 170432
		[Token(Token = "0x40299C0")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, RoguelikeDialogMgr> m_dialogMgrs;

		// Token: 0x040299C1 RID: 170433
		[Token(Token = "0x40299C1")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeTopicDialogPlugin m_topicPlugin;

		// Token: 0x040299C2 RID: 170434
		[Token(Token = "0x40299C2")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_dialogs;

		// Token: 0x040299C3 RID: 170435
		[Token(Token = "0x40299C3")]
		[FieldOffset(Offset = "0x38")]
		private string m_topicId;

		// Token: 0x040299C4 RID: 170436
		[Token(Token = "0x40299C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040299C5 RID: 170437
		[Token(Token = "0x40299C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDialogs;

		// Token: 0x040299C6 RID: 170438
		[Token(Token = "0x40299C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckNeedToShow;

		// Token: 0x040299C7 RID: 170439
		[Token(Token = "0x40299C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
