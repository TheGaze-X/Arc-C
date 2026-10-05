using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052D6 RID: 21206
	[Token(Token = "0x20052D6")]
	public abstract class RoguelikeExpeditionCharCardViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x0601F471 RID: 128113 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F472 RID: 128114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004963")]
		public Action<string> onCharClick
		{
			[Token(Token = "0x601F471")]
			[Address(RVA = "0x18FA490", Offset = "0x18F9090", VA = "0x1818FA490")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F472")]
			[Address(RVA = "0x18FA4F0", Offset = "0x18F90F0", VA = "0x1818FA4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F473 RID: 128115
		[Token(Token = "0x601F473")]
		protected abstract void RenderChar(RoguelikeExpeditionCharCardViewModel viewModel, string selectingCharId, bool fastMode);

		// Token: 0x0601F474 RID: 128116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F474")]
		[Address(RVA = "0x18FA2E0", Offset = "0x18F8EE0", VA = "0x1818FA2E0")]
		public void SetPluginContext(RoguelikeExpeditionPluginContext context)
		{
		}

		// Token: 0x0601F475 RID: 128117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F475")]
		[Address(RVA = "0x18F9FB0", Offset = "0x18F8BB0", VA = "0x1818F9FB0")]
		public void RenderCard(RoguelikeExpeditionCharCardViewModel viewModel, string selectingCharId, bool fastMode)
		{
		}

		// Token: 0x0601F476 RID: 128118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F476")]
		[Address(RVA = "0x18F9EA0", Offset = "0x18F8AA0", VA = "0x1818F9EA0")]
		public void OnClick()
		{
		}

		// Token: 0x0601F477 RID: 128119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F477")]
		[Address(RVA = "0x18FA360", Offset = "0x18F8F60", VA = "0x1818FA360")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F478 RID: 128120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F478")]
		[Address(RVA = "0x18FA430", Offset = "0x18F9030", VA = "0x1818FA430")]
		protected RoguelikeExpeditionCharCardViewBase()
		{
		}

		// Token: 0x0402A00E RID: 172046
		[Token(Token = "0x402A00E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x0402A00F RID: 172047
		[Token(Token = "0x402A00F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objUpgradeTag;

		// Token: 0x0402A010 RID: 172048
		[Token(Token = "0x402A010")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402A011 RID: 172049
		[Token(Token = "0x402A011")]
		[FieldOffset(Offset = "0x30")]
		private bool m_inited;

		// Token: 0x0402A012 RID: 172050
		[Token(Token = "0x402A012")]
		[FieldOffset(Offset = "0x38")]
		private UISwitchTween m_selectedTween;

		// Token: 0x0402A013 RID: 172051
		[Token(Token = "0x402A013")]
		[FieldOffset(Offset = "0x40")]
		private string m_charInstId;

		// Token: 0x0402A014 RID: 172052
		[Token(Token = "0x402A014")]
		[FieldOffset(Offset = "0x48")]
		protected RoguelikeExpeditionPluginContext pluginContext;

		// Token: 0x0402A016 RID: 172054
		[Token(Token = "0x402A016")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharClick;

		// Token: 0x0402A017 RID: 172055
		[Token(Token = "0x402A017")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharClick;

		// Token: 0x0402A018 RID: 172056
		[Token(Token = "0x402A018")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPluginContext;

		// Token: 0x0402A019 RID: 172057
		[Token(Token = "0x402A019")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0402A01A RID: 172058
		[Token(Token = "0x402A01A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A01B RID: 172059
		[Token(Token = "0x402A01B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A01C RID: 172060
		[Token(Token = "0x402A01C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
