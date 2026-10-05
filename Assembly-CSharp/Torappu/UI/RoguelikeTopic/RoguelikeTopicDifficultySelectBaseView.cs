using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D5 RID: 17621
	[Token(Token = "0x20044D5")]
	public abstract class RoguelikeTopicDifficultySelectBaseView : RoguelikeTopicSubView
	{
		// Token: 0x0601AE77 RID: 110199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE77")]
		[Address(RVA = "0x140AAA0", Offset = "0x14096A0", VA = "0x18140AAA0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601AE78 RID: 110200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE78")]
		[Address(RVA = "0x140ABE0", Offset = "0x14097E0", VA = "0x18140ABE0", Slot = "10")]
		protected virtual void SetVisible(bool v, bool immediately)
		{
		}

		// Token: 0x0601AE79 RID: 110201
		[Token(Token = "0x601AE79")]
		protected abstract void OnRefresh(RoguelikeTopicModeViewProperty property);

		// Token: 0x0601AE7A RID: 110202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE7A")]
		[Address(RVA = "0x140AC80", Offset = "0x1409880", VA = "0x18140AC80")]
		protected void _SelectDifficulty(RoguelikeTopicMode difficulty, int grade)
		{
		}

		// Token: 0x0601AE7B RID: 110203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE7B")]
		[Address(RVA = "0x140AE40", Offset = "0x1409A40", VA = "0x18140AE40")]
		protected void _SelectDifficulty(RoguelikeTopicDifficultyID difficulty)
		{
		}

		// Token: 0x0601AE7C RID: 110204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE7C")]
		[Address(RVA = "0x140AF70", Offset = "0x1409B70", VA = "0x18140AF70")]
		protected RoguelikeTopicDifficultySelectBaseView()
		{
		}

		// Token: 0x0601AE7D RID: 110205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE7D")]
		[Address(RVA = "0x1406270", Offset = "0x1404E70", VA = "0x181406270")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x0402279F RID: 141215
		[Token(Token = "0x402279F")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x040227A0 RID: 141216
		[Token(Token = "0x40227A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040227A1 RID: 141217
		[Token(Token = "0x40227A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x040227A2 RID: 141218
		[Token(Token = "0x40227A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SelectDifficulty;

		// Token: 0x040227A3 RID: 141219
		[Token(Token = "0x40227A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1__SelectDifficulty;

		// Token: 0x040227A4 RID: 141220
		[Token(Token = "0x40227A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
