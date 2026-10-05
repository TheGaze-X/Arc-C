using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FD8 RID: 16344
	[Token(Token = "0x2003FD8")]
	public class PCKeySettingSelectedDialog : UICompDialog<PCKeySettingSelectedDialog.Input>
	{
		// Token: 0x06019547 RID: 103751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019547")]
		[Address(RVA = "0x11FBA50", Offset = "0x11FA650", VA = "0x1811FBA50", Slot = "18")]
		protected override void OnRender(PCKeySettingSelectedDialog.Input input)
		{
		}

		// Token: 0x06019548 RID: 103752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019548")]
		[Address(RVA = "0x11FBE80", Offset = "0x11FAA80", VA = "0x1811FBE80")]
		public void OnSelectedDialogBgClicked()
		{
		}

		// Token: 0x06019549 RID: 103753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019549")]
		[Address(RVA = "0x11FC5A0", Offset = "0x11FB1A0", VA = "0x1811FC5A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601954A RID: 103754 RVA: 0x0009DBD8 File Offset: 0x0009BDD8
		[Token(Token = "0x601954A")]
		[Address(RVA = "0x11FC140", Offset = "0x11FAD40", VA = "0x1811FC140")]
		private float _GetRectWorldHeight(RectTransform rt)
		{
			return 0f;
		}

		// Token: 0x0601954B RID: 103755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601954B")]
		[Address(RVA = "0x11FC200", Offset = "0x11FAE00", VA = "0x1811FC200")]
		private void _HandleKeyInput(int result, string keyId)
		{
		}

		// Token: 0x0601954C RID: 103756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601954C")]
		[Address(RVA = "0x11FC650", Offset = "0x11FB250", VA = "0x1811FC650")]
		public PCKeySettingSelectedDialog()
		{
		}

		// Token: 0x0401F7CA RID: 128970
		[Token(Token = "0x401F7CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Graphic _passThroughPointerGraphic;

		// Token: 0x0401F7CB RID: 128971
		[Token(Token = "0x401F7CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _infoRect;

		// Token: 0x0401F7CC RID: 128972
		[Token(Token = "0x401F7CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _bgUp;

		// Token: 0x0401F7CD RID: 128973
		[Token(Token = "0x401F7CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _bgDown;

		// Token: 0x0401F7CE RID: 128974
		[Token(Token = "0x401F7CE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _infoPanelOffset;

		// Token: 0x0401F7CF RID: 128975
		[Token(Token = "0x401F7CF")]
		[FieldOffset(Offset = "0x98")]
		private Camera m_camera;

		// Token: 0x0401F7D0 RID: 128976
		[Token(Token = "0x401F7D0")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0401F7D1 RID: 128977
		[Token(Token = "0x401F7D1")]
		[FieldOffset(Offset = "0xA8")]
		private KeyBoardVirtualButtonConfig m_cachedSelectedInfo;

		// Token: 0x0401F7D2 RID: 128978
		[Token(Token = "0x401F7D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F7D3 RID: 128979
		[Token(Token = "0x401F7D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectedDialogBgClicked;

		// Token: 0x0401F7D4 RID: 128980
		[Token(Token = "0x401F7D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F7D5 RID: 128981
		[Token(Token = "0x401F7D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetRectWorldHeight;

		// Token: 0x0401F7D6 RID: 128982
		[Token(Token = "0x401F7D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleKeyInput;

		// Token: 0x0401F7D7 RID: 128983
		[Token(Token = "0x401F7D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FD9 RID: 16345
		[Token(Token = "0x2003FD9")]
		public class Input : IHotfixable
		{
			// Token: 0x0601954D RID: 103757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601954D")]
			[Address(RVA = "0x11F8060", Offset = "0x11F6C60", VA = "0x1811F8060")]
			public Input()
			{
			}

			// Token: 0x0401F7D8 RID: 128984
			[Token(Token = "0x401F7D8")]
			[FieldOffset(Offset = "0x10")]
			public KeyBoardVirtualButtonConfig selectedInfo;

			// Token: 0x0401F7D9 RID: 128985
			[Token(Token = "0x401F7D9")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform selectedItem;

			// Token: 0x0401F7DA RID: 128986
			[Token(Token = "0x401F7DA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003FDA RID: 16346
		[Token(Token = "0x2003FDA")]
		public class Output : IHotfixable
		{
			// Token: 0x0601954E RID: 103758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601954E")]
			[Address(RVA = "0x11F8380", Offset = "0x11F6F80", VA = "0x1811F8380")]
			public Output()
			{
			}

			// Token: 0x0401F7DB RID: 128987
			[Token(Token = "0x401F7DB")]
			[FieldOffset(Offset = "0x10")]
			public KeyBoardVirtualButtonConfig selectedInfo;

			// Token: 0x0401F7DC RID: 128988
			[Token(Token = "0x401F7DC")]
			[FieldOffset(Offset = "0x18")]
			public KeyBoardVirtualButtonConfig conflictInfo;

			// Token: 0x0401F7DD RID: 128989
			[Token(Token = "0x401F7DD")]
			[FieldOffset(Offset = "0x20")]
			public bool shouldTrySetKey;

			// Token: 0x0401F7DE RID: 128990
			[Token(Token = "0x401F7DE")]
			[FieldOffset(Offset = "0x28")]
			public string pressedKeyId;

			// Token: 0x0401F7DF RID: 128991
			[Token(Token = "0x401F7DF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
