using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FB7 RID: 16311
	[Token(Token = "0x2003FB7")]
	public class SiracusaChatDialogComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x060194B2 RID: 103602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60194B2")]
		[Address(RVA = "0x12085E0", Offset = "0x12071E0", VA = "0x1812085E0")]
		private SiracusaChatDialogComp.PreferSizeCalculator _GetSizeCalculator()
		{
			return null;
		}

		// Token: 0x060194B3 RID: 103603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194B3")]
		[Address(RVA = "0x1208740", Offset = "0x1207340", VA = "0x181208740")]
		private void _Render(Sprite avatarSprite, string content)
		{
		}

		// Token: 0x060194B4 RID: 103604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194B4")]
		[Address(RVA = "0x1208810", Offset = "0x1207410", VA = "0x181208810")]
		private void _SetDisplay(bool isShow, bool useFastMode)
		{
		}

		// Token: 0x060194B5 RID: 103605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194B5")]
		[Address(RVA = "0x12089E0", Offset = "0x12075E0", VA = "0x1812089E0")]
		public SiracusaChatDialogComp()
		{
		}

		// Token: 0x0401F6AC RID: 128684
		[Token(Token = "0x401F6AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x0401F6AD RID: 128685
		[Token(Token = "0x401F6AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _dialog;

		// Token: 0x0401F6AE RID: 128686
		[Token(Token = "0x401F6AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _textPadding;

		// Token: 0x0401F6AF RID: 128687
		[Token(Token = "0x401F6AF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _avatarHeight;

		// Token: 0x0401F6B0 RID: 128688
		[Token(Token = "0x401F6B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("FadeIn")]
		private float _fadeInPos;

		// Token: 0x0401F6B1 RID: 128689
		[Token(Token = "0x401F6B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("FadeIn")]
		private CanvasGroup _fadeInAlpha;

		// Token: 0x0401F6B2 RID: 128690
		[Token(Token = "0x401F6B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("FadeIn")]
		private RectTransform _fadeInTrans;

		// Token: 0x0401F6B3 RID: 128691
		[Token(Token = "0x401F6B3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("FadeIn")]
		private float _fadeInDuration;

		// Token: 0x0401F6B4 RID: 128692
		[Token(Token = "0x401F6B4")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _postDelay;

		// Token: 0x0401F6B5 RID: 128693
		[Token(Token = "0x401F6B5")]
		[FieldOffset(Offset = "0x50")]
		private SiracusaChatDialogComp.PreferSizeCalculator m_sizeCalculator;

		// Token: 0x0401F6B6 RID: 128694
		[Token(Token = "0x401F6B6")]
		[FieldOffset(Offset = "0x58")]
		private FadeTranslationSwitchTween m_switchTween;

		// Token: 0x0401F6B7 RID: 128695
		[Token(Token = "0x401F6B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSizeCalculator;

		// Token: 0x0401F6B8 RID: 128696
		[Token(Token = "0x401F6B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401F6B9 RID: 128697
		[Token(Token = "0x401F6B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetDisplay;

		// Token: 0x0401F6BA RID: 128698
		[Token(Token = "0x401F6BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FB8 RID: 16312
		[Token(Token = "0x2003FB8")]
		public class ViewModel
		{
			// Token: 0x060194B6 RID: 103606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x0401F6BB RID: 128699
			[Token(Token = "0x401F6BB")]
			[FieldOffset(Offset = "0x10")]
			public SiracusaChatDialogComp prefab;

			// Token: 0x0401F6BC RID: 128700
			[Token(Token = "0x401F6BC")]
			[FieldOffset(Offset = "0x18")]
			public string avatarId;

			// Token: 0x0401F6BD RID: 128701
			[Token(Token = "0x401F6BD")]
			[FieldOffset(Offset = "0x20")]
			public string text;
		}

		// Token: 0x02003FB9 RID: 16313
		[Token(Token = "0x2003FB9")]
		public class VirtualView : AVGChatVirtualView<SiracusaChatDialogComp>
		{
			// Token: 0x060194B7 RID: 103607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194B7")]
			[Address(RVA = "0x12121F0", Offset = "0x1210DF0", VA = "0x1812121F0")]
			public VirtualView(SiracusaChatDialogComp.ViewModel model, Func<string, Sprite> avatarLoader)
			{
			}

			// Token: 0x060194B8 RID: 103608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194B8")]
			[Address(RVA = "0x120F980", Offset = "0x120E580", VA = "0x18120F980", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060194B9 RID: 103609 RVA: 0x0009D9F8 File Offset: 0x0009BBF8
			[Token(Token = "0x60194B9")]
			[Address(RVA = "0x120FDB0", Offset = "0x120E9B0", VA = "0x18120FDB0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060194BA RID: 103610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194BA")]
			[Address(RVA = "0x12106A0", Offset = "0x120F2A0", VA = "0x1812106A0", Slot = "22")]
			protected override void OnUpdateView(SiracusaChatDialogComp view)
			{
			}

			// Token: 0x060194BB RID: 103611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194BB")]
			[Address(RVA = "0x12104A0", Offset = "0x120F0A0", VA = "0x1812104A0", Slot = "20")]
			protected override void HideViewContent(SiracusaChatDialogComp view)
			{
			}

			// Token: 0x060194BC RID: 103612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194BC")]
			[Address(RVA = "0x12110F0", Offset = "0x120FCF0", VA = "0x1812110F0", Slot = "21")]
			protected override IEnumerator PlayViewContent(SiracusaChatDialogComp view)
			{
				return null;
			}

			// Token: 0x060194BD RID: 103613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194BD")]
			[Address(RVA = "0x1211420", Offset = "0x1210020", VA = "0x181211420", Slot = "23")]
			protected override void ShowAsLog(SiracusaChatDialogComp view)
			{
			}

			// Token: 0x060194BE RID: 103614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194BE")]
			[Address(RVA = "0x1211760", Offset = "0x1210360", VA = "0x181211760")]
			private void _InitIfNot()
			{
			}

			// Token: 0x060194BF RID: 103615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194BF")]
			[Address(RVA = "0x1211E50", Offset = "0x1210A50", VA = "0x181211E50")]
			private Sprite _LoadAvatarSprite(string avatarId)
			{
				return null;
			}

			// Token: 0x0401F6BE RID: 128702
			[Token(Token = "0x401F6BE")]
			[FieldOffset(Offset = "0x28")]
			private readonly SiracusaChatDialogComp.ViewModel m_model;

			// Token: 0x0401F6BF RID: 128703
			[Token(Token = "0x401F6BF")]
			[FieldOffset(Offset = "0x30")]
			private bool m_isInited;

			// Token: 0x0401F6C0 RID: 128704
			[Token(Token = "0x401F6C0")]
			[FieldOffset(Offset = "0x38")]
			private SiracusaChatDialogComp.PreferSizeCalculator m_sizeCalculator;

			// Token: 0x0401F6C1 RID: 128705
			[Token(Token = "0x401F6C1")]
			[FieldOffset(Offset = "0x40")]
			private string m_dialogContent;

			// Token: 0x0401F6C2 RID: 128706
			[Token(Token = "0x401F6C2")]
			[FieldOffset(Offset = "0x48")]
			private float m_cachedSize;

			// Token: 0x0401F6C3 RID: 128707
			[Token(Token = "0x401F6C3")]
			[FieldOffset(Offset = "0x50")]
			private Func<string, Sprite> m_avatarLoader;

			// Token: 0x0401F6C4 RID: 128708
			[Token(Token = "0x401F6C4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F6C5 RID: 128709
			[Token(Token = "0x401F6C5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401F6C6 RID: 128710
			[Token(Token = "0x401F6C6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401F6C7 RID: 128711
			[Token(Token = "0x401F6C7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401F6C8 RID: 128712
			[Token(Token = "0x401F6C8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401F6C9 RID: 128713
			[Token(Token = "0x401F6C9")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401F6CA RID: 128714
			[Token(Token = "0x401F6CA")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ShowAsLog;

			// Token: 0x0401F6CB RID: 128715
			[Token(Token = "0x401F6CB")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0401F6CC RID: 128716
			[Token(Token = "0x401F6CC")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__LoadAvatarSprite;
		}

		// Token: 0x02003FBB RID: 16315
		[Token(Token = "0x2003FBB")]
		private class PreferSizeCalculator : IHotfixable
		{
			// Token: 0x060194C6 RID: 103622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194C6")]
			[Address(RVA = "0x11FFC30", Offset = "0x11FE830", VA = "0x1811FFC30")]
			public PreferSizeCalculator(SiracusaChatDialogComp view)
			{
			}

			// Token: 0x060194C7 RID: 103623 RVA: 0x0009DA28 File Offset: 0x0009BC28
			[Token(Token = "0x60194C7")]
			[Address(RVA = "0x11FF7C0", Offset = "0x11FE3C0", VA = "0x1811FF7C0")]
			public float CalcSize(string text)
			{
				return 0f;
			}

			// Token: 0x0401F6D1 RID: 128721
			[Token(Token = "0x401F6D1")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0401F6D2 RID: 128722
			[Token(Token = "0x401F6D2")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0401F6D3 RID: 128723
			[Token(Token = "0x401F6D3")]
			[FieldOffset(Offset = "0x78")]
			private float m_textPadding;

			// Token: 0x0401F6D4 RID: 128724
			[Token(Token = "0x401F6D4")]
			[FieldOffset(Offset = "0x7C")]
			private float m_avatarSize;

			// Token: 0x0401F6D5 RID: 128725
			[Token(Token = "0x401F6D5")]
			[FieldOffset(Offset = "0x80")]
			private SiracusaChatDialogComp m_view;

			// Token: 0x0401F6D6 RID: 128726
			[Token(Token = "0x401F6D6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F6D7 RID: 128727
			[Token(Token = "0x401F6D7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
