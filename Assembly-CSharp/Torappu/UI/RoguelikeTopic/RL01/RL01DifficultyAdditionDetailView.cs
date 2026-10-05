using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004634 RID: 17972
	[Token(Token = "0x2004634")]
	public class RL01DifficultyAdditionDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B4BE RID: 111806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4BE")]
		[Address(RVA = "0x1499D40", Offset = "0x1498940", VA = "0x181499D40")]
		public void Render(RoguelikeTopicDifficultyViewModel difficulty)
		{
		}

		// Token: 0x0601B4BF RID: 111807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4BF")]
		[Address(RVA = "0x1499F00", Offset = "0x1498B00", VA = "0x181499F00")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0601B4C0 RID: 111808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C0")]
		[Address(RVA = "0x1499CE0", Offset = "0x14988E0", VA = "0x181499CE0")]
		public void EventOnClose()
		{
		}

		// Token: 0x0601B4C1 RID: 111809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C1")]
		[Address(RVA = "0x1499F80", Offset = "0x1498B80", VA = "0x181499F80")]
		public RL01DifficultyAdditionDetailView()
		{
		}

		// Token: 0x040233F0 RID: 144368
		[Token(Token = "0x40233F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x040233F1 RID: 144369
		[Token(Token = "0x40233F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _addDesc;

		// Token: 0x040233F2 RID: 144370
		[Token(Token = "0x40233F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040233F3 RID: 144371
		[Token(Token = "0x40233F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x040233F4 RID: 144372
		[Token(Token = "0x40233F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x040233F5 RID: 144373
		[Token(Token = "0x40233F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
