using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D1 RID: 17617
	[Token(Token = "0x20044D1")]
	public abstract class RoguelikeTopicCurrentDifficultyBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x0601AE68 RID: 110184 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE69 RID: 110185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FDF")]
		public Action onClick
		{
			[Token(Token = "0x601AE68")]
			[Address(RVA = "0x1408DF0", Offset = "0x14079F0", VA = "0x181408DF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AE69")]
			[Address(RVA = "0x1408E50", Offset = "0x1407A50", VA = "0x181408E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AE6A RID: 110186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE6A")]
		[Address(RVA = "0x14086A0", Offset = "0x14072A0", VA = "0x1814086A0")]
		public void Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601AE6B RID: 110187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE6B")]
		[Address(RVA = "0x1408530", Offset = "0x1407130", VA = "0x181408530")]
		public void RenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601AE6C RID: 110188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE6C")]
		[Address(RVA = "0x14089E0", Offset = "0x14075E0", VA = "0x1814089E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AE6D RID: 110189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE6D")]
		[Address(RVA = "0x1408470", Offset = "0x1407070", VA = "0x181408470", Slot = "4")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0601AE6E RID: 110190
		[Token(Token = "0x601AE6E")]
		protected abstract void OnRender(RoguelikeTopicModeViewModel model);

		// Token: 0x0601AE6F RID: 110191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE6F")]
		[Address(RVA = "0x14084D0", Offset = "0x14070D0", VA = "0x1814084D0", Slot = "6")]
		protected virtual void OnRenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601AE70 RID: 110192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE70")]
		[Address(RVA = "0x1408960", Offset = "0x1407560", VA = "0x181408960", Slot = "7")]
		protected virtual void SetVisible(bool v)
		{
		}

		// Token: 0x0601AE71 RID: 110193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE71")]
		[Address(RVA = "0x1408A70", Offset = "0x1407670", VA = "0x181408A70")]
		private void _SetColor(Color clr)
		{
		}

		// Token: 0x0601AE72 RID: 110194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE72")]
		[Address(RVA = "0x1408C20", Offset = "0x1407820", VA = "0x181408C20")]
		private void _SetName(string name)
		{
		}

		// Token: 0x0601AE73 RID: 110195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE73")]
		[Address(RVA = "0x1408360", Offset = "0x1406F60", VA = "0x181408360")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601AE74 RID: 110196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE74")]
		[Address(RVA = "0x1408D90", Offset = "0x1407990", VA = "0x181408D90")]
		protected RoguelikeTopicCurrentDifficultyBaseView()
		{
		}

		// Token: 0x04022785 RID: 141189
		[Token(Token = "0x4022785")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04022786 RID: 141190
		[Token(Token = "0x4022786")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _extNameLabels;

		// Token: 0x04022787 RID: 141191
		[Token(Token = "0x4022787")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic[] _diffColorTargets;

		// Token: 0x04022788 RID: 141192
		[Token(Token = "0x4022788")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInit;

		// Token: 0x0402278A RID: 141194
		[Token(Token = "0x402278A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0402278B RID: 141195
		[Token(Token = "0x402278B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0402278C RID: 141196
		[Token(Token = "0x402278C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402278D RID: 141197
		[Token(Token = "0x402278D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderDifficulty;

		// Token: 0x0402278E RID: 141198
		[Token(Token = "0x402278E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402278F RID: 141199
		[Token(Token = "0x402278F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04022790 RID: 141200
		[Token(Token = "0x4022790")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRenderDifficulty;

		// Token: 0x04022791 RID: 141201
		[Token(Token = "0x4022791")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04022792 RID: 141202
		[Token(Token = "0x4022792")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetColor;

		// Token: 0x04022793 RID: 141203
		[Token(Token = "0x4022793")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetName;

		// Token: 0x04022794 RID: 141204
		[Token(Token = "0x4022794")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04022795 RID: 141205
		[Token(Token = "0x4022795")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
