using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058A6 RID: 22694
	[Token(Token = "0x20058A6")]
	public class RoguelikeChatDialogComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021224 RID: 135716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021224")]
		[Address(RVA = "0x1B7C1C0", Offset = "0x1B7ADC0", VA = "0x181B7C1C0")]
		private RoguelikeChatDialogComp.PreferSizeCalculator _GetSizeCalculator()
		{
			return null;
		}

		// Token: 0x06021225 RID: 135717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021225")]
		[Address(RVA = "0x1B7C2D0", Offset = "0x1B7AED0", VA = "0x181B7C2D0")]
		private void _Render(string avatarId, string content)
		{
		}

		// Token: 0x06021226 RID: 135718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021226")]
		[Address(RVA = "0x1B7C3E0", Offset = "0x1B7AFE0", VA = "0x181B7C3E0")]
		private void _SetDisplay(bool isShow, bool useFastMode)
		{
		}

		// Token: 0x06021227 RID: 135719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021227")]
		[Address(RVA = "0x1B7C5B0", Offset = "0x1B7B1B0", VA = "0x181B7C5B0")]
		public RoguelikeChatDialogComp()
		{
		}

		// Token: 0x0402D1E1 RID: 184801
		[Token(Token = "0x402D1E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgAvater;

		// Token: 0x0402D1E2 RID: 184802
		[Token(Token = "0x402D1E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _dialog;

		// Token: 0x0402D1E3 RID: 184803
		[Token(Token = "0x402D1E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _textPadding;

		// Token: 0x0402D1E4 RID: 184804
		[Token(Token = "0x402D1E4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _avatarHeight;

		// Token: 0x0402D1E5 RID: 184805
		[Token(Token = "0x402D1E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("FadeIn")]
		private float _fadeInPos;

		// Token: 0x0402D1E6 RID: 184806
		[Token(Token = "0x402D1E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("FadeIn")]
		private CanvasGroup _fadeInAlpha;

		// Token: 0x0402D1E7 RID: 184807
		[Token(Token = "0x402D1E7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("FadeIn")]
		private RectTransform _fadeInTrans;

		// Token: 0x0402D1E8 RID: 184808
		[Token(Token = "0x402D1E8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("FadeIn")]
		private float _fadeInDuration;

		// Token: 0x0402D1E9 RID: 184809
		[Token(Token = "0x402D1E9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _postDelay;

		// Token: 0x0402D1EA RID: 184810
		[Token(Token = "0x402D1EA")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeChatDialogComp.PreferSizeCalculator m_sizeCalculator;

		// Token: 0x0402D1EB RID: 184811
		[Token(Token = "0x402D1EB")]
		[FieldOffset(Offset = "0x58")]
		private FadeTranslationSwitchTween m_switchTween;

		// Token: 0x0402D1EC RID: 184812
		[Token(Token = "0x402D1EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSizeCalculator;

		// Token: 0x0402D1ED RID: 184813
		[Token(Token = "0x402D1ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402D1EE RID: 184814
		[Token(Token = "0x402D1EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetDisplay;

		// Token: 0x0402D1EF RID: 184815
		[Token(Token = "0x402D1EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058A7 RID: 22695
		[Token(Token = "0x20058A7")]
		public struct VirtualOptions
		{
			// Token: 0x0402D1F0 RID: 184816
			[Token(Token = "0x402D1F0")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeChatDialogComp prefab;

			// Token: 0x0402D1F1 RID: 184817
			[Token(Token = "0x402D1F1")]
			[FieldOffset(Offset = "0x8")]
			public string avatarId;

			// Token: 0x0402D1F2 RID: 184818
			[Token(Token = "0x402D1F2")]
			[FieldOffset(Offset = "0x10")]
			public string text;
		}

		// Token: 0x020058A8 RID: 22696
		[Token(Token = "0x20058A8")]
		public class VirtualView : AVGChatVirtualView<RoguelikeChatDialogComp>
		{
			// Token: 0x06021228 RID: 135720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021228")]
			[Address(RVA = "0x1B87B30", Offset = "0x1B86730", VA = "0x181B87B30")]
			public VirtualView(RoguelikeChatDialogComp.VirtualOptions options)
			{
			}

			// Token: 0x06021229 RID: 135721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021229")]
			[Address(RVA = "0x1B86E20", Offset = "0x1B85A20", VA = "0x181B86E20", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602122A RID: 135722 RVA: 0x000B8AD0 File Offset: 0x000B6CD0
			[Token(Token = "0x602122A")]
			[Address(RVA = "0x1B87030", Offset = "0x1B85C30", VA = "0x181B87030", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602122B RID: 135723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602122B")]
			[Address(RVA = "0x1B875D0", Offset = "0x1B861D0", VA = "0x181B875D0", Slot = "22")]
			protected override void OnUpdateView(RoguelikeChatDialogComp view)
			{
			}

			// Token: 0x0602122C RID: 135724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602122C")]
			[Address(RVA = "0x1B87230", Offset = "0x1B85E30", VA = "0x181B87230", Slot = "20")]
			protected override void HideViewContent(RoguelikeChatDialogComp view)
			{
			}

			// Token: 0x0602122D RID: 135725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602122D")]
			[Address(RVA = "0x1B87870", Offset = "0x1B86470", VA = "0x181B87870", Slot = "21")]
			protected override IEnumerator PlayViewContent(RoguelikeChatDialogComp view)
			{
				return null;
			}

			// Token: 0x0602122E RID: 135726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602122E")]
			[Address(RVA = "0x1B87A20", Offset = "0x1B86620", VA = "0x181B87A20", Slot = "23")]
			protected override void ShowAsLog(RoguelikeChatDialogComp view)
			{
			}

			// Token: 0x0402D1F3 RID: 184819
			[Token(Token = "0x402D1F3")]
			[FieldOffset(Offset = "0x28")]
			private RoguelikeChatDialogComp.VirtualOptions m_options;

			// Token: 0x0402D1F4 RID: 184820
			[Token(Token = "0x402D1F4")]
			[FieldOffset(Offset = "0x40")]
			private RoguelikeChatDialogComp.PreferSizeCalculator m_sizeCalculator;

			// Token: 0x0402D1F5 RID: 184821
			[Token(Token = "0x402D1F5")]
			[FieldOffset(Offset = "0x48")]
			private float m_cachedSize;

			// Token: 0x0402D1F6 RID: 184822
			[Token(Token = "0x402D1F6")]
			[FieldOffset(Offset = "0x50")]
			private string m_dialogContent;

			// Token: 0x0402D1F7 RID: 184823
			[Token(Token = "0x402D1F7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402D1F8 RID: 184824
			[Token(Token = "0x402D1F8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402D1F9 RID: 184825
			[Token(Token = "0x402D1F9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402D1FA RID: 184826
			[Token(Token = "0x402D1FA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0402D1FB RID: 184827
			[Token(Token = "0x402D1FB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0402D1FC RID: 184828
			[Token(Token = "0x402D1FC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0402D1FD RID: 184829
			[Token(Token = "0x402D1FD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ShowAsLog;
		}

		// Token: 0x020058AA RID: 22698
		[Token(Token = "0x20058AA")]
		private class PreferSizeCalculator
		{
			// Token: 0x06021235 RID: 135733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021235")]
			[Address(RVA = "0x1B7A220", Offset = "0x1B78E20", VA = "0x181B7A220")]
			public PreferSizeCalculator(RoguelikeChatDialogComp view)
			{
			}

			// Token: 0x06021236 RID: 135734 RVA: 0x000B8B00 File Offset: 0x000B6D00
			[Token(Token = "0x6021236")]
			[Address(RVA = "0x1B7A0B0", Offset = "0x1B78CB0", VA = "0x181B7A0B0")]
			public float CalcSize(string text)
			{
				return 0f;
			}

			// Token: 0x0402D202 RID: 184834
			[Token(Token = "0x402D202")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0402D203 RID: 184835
			[Token(Token = "0x402D203")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0402D204 RID: 184836
			[Token(Token = "0x402D204")]
			[FieldOffset(Offset = "0x78")]
			private float m_textPadding;

			// Token: 0x0402D205 RID: 184837
			[Token(Token = "0x402D205")]
			[FieldOffset(Offset = "0x7C")]
			private float m_avatarSize;

			// Token: 0x0402D206 RID: 184838
			[Token(Token = "0x402D206")]
			[FieldOffset(Offset = "0x80")]
			private RoguelikeChatDialogComp m_view;
		}
	}
}
