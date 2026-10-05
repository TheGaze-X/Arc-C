using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003306 RID: 13062
	[Token(Token = "0x2003306")]
	public class UIBattleUnderframePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014BE2 RID: 84962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BE2")]
		[Address(RVA = "0xD23840", Offset = "0xD22440", VA = "0x180D23840")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06014BE3 RID: 84963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BE3")]
		[Address(RVA = "0xD23360", Offset = "0xD21F60", VA = "0x180D23360")]
		public void Render(UIBattleUnderframePanel.Param param)
		{
		}

		// Token: 0x06014BE4 RID: 84964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BE4")]
		[Address(RVA = "0xD23210", Offset = "0xD21E10", VA = "0x180D23210")]
		public void Hide()
		{
		}

		// Token: 0x06014BE5 RID: 84965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BE5")]
		[Address(RVA = "0xD23300", Offset = "0xD21F00", VA = "0x180D23300")]
		public void OnButtonClick()
		{
		}

		// Token: 0x06014BE6 RID: 84966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BE6")]
		[Address(RVA = "0xD238D0", Offset = "0xD224D0", VA = "0x180D238D0")]
		public UIBattleUnderframePanel()
		{
		}

		// Token: 0x04018A8B RID: 101003
		[Token(Token = "0x4018A8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04018A8C RID: 101004
		[Token(Token = "0x4018A8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _btnImage;

		// Token: 0x04018A8D RID: 101005
		[Token(Token = "0x4018A8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _btnShadowImage;

		// Token: 0x04018A8E RID: 101006
		[Token(Token = "0x4018A8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x04018A8F RID: 101007
		[Token(Token = "0x4018A8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _blocker;

		// Token: 0x04018A90 RID: 101008
		[Token(Token = "0x4018A90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _withdrawButton;

		// Token: 0x04018A91 RID: 101009
		[Token(Token = "0x4018A91")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessUnderFramePanelButton _underFramePanelBtn;

		// Token: 0x04018A92 RID: 101010
		[Token(Token = "0x4018A92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _underFramePanelBtnParamSellPos;

		// Token: 0x04018A93 RID: 101011
		[Token(Token = "0x4018A93")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Vector3 _underFramePanelBtnParamDestroyPos;

		// Token: 0x04018A94 RID: 101012
		[Token(Token = "0x4018A94")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AutoChessUnderFrameSkillButton _skillBtn;

		// Token: 0x04018A95 RID: 101013
		[Token(Token = "0x4018A95")]
		[FieldOffset(Offset = "0x70")]
		private Action onButtonClick;

		// Token: 0x04018A96 RID: 101014
		[Token(Token = "0x4018A96")]
		[FieldOffset(Offset = "0x78")]
		private Sprite m_defaultIcon;

		// Token: 0x04018A97 RID: 101015
		[Token(Token = "0x4018A97")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04018A98 RID: 101016
		[Token(Token = "0x4018A98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04018A99 RID: 101017
		[Token(Token = "0x4018A99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04018A9A RID: 101018
		[Token(Token = "0x4018A9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04018A9B RID: 101019
		[Token(Token = "0x4018A9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnButtonClick;

		// Token: 0x04018A9C RID: 101020
		[Token(Token = "0x4018A9C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003307 RID: 13063
		[Token(Token = "0x2003307")]
		public struct Param
		{
			// Token: 0x1700311C RID: 12572
			// (get) Token: 0x06014BE7 RID: 84967 RVA: 0x00088338 File Offset: 0x00086538
			[Token(Token = "0x1700311C")]
			public static UIBattleUnderframePanel.Param DEFAULT
			{
				[Token(Token = "0x6014BE7")]
				[Address(RVA = "0xD1AF80", Offset = "0xD19B80", VA = "0x180D1AF80")]
				get
				{
					return default(UIBattleUnderframePanel.Param);
				}
			}

			// Token: 0x04018A9D RID: 101021
			[Token(Token = "0x4018A9D")]
			[FieldOffset(Offset = "0x0")]
			public Sprite icon;

			// Token: 0x04018A9E RID: 101022
			[Token(Token = "0x4018A9E")]
			[FieldOffset(Offset = "0x8")]
			public bool showWithdrawOrDestory;

			// Token: 0x04018A9F RID: 101023
			[Token(Token = "0x4018A9F")]
			[FieldOffset(Offset = "0x9")]
			public bool dontBlockClick;

			// Token: 0x04018AA0 RID: 101024
			[Token(Token = "0x4018AA0")]
			[FieldOffset(Offset = "0x10")]
			public Action onButtonClick;

			// Token: 0x04018AA1 RID: 101025
			[Token(Token = "0x4018AA1")]
			[FieldOffset(Offset = "0x18")]
			public Transform mountPoint;

			// Token: 0x04018AA2 RID: 101026
			[Token(Token = "0x4018AA2")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 offset;

			// Token: 0x04018AA3 RID: 101027
			[Token(Token = "0x4018AA3")]
			[FieldOffset(Offset = "0x28")]
			public bool showUnderFramePanelBtn;

			// Token: 0x04018AA4 RID: 101028
			[Token(Token = "0x4018AA4")]
			[FieldOffset(Offset = "0x30")]
			public AutoChessUnderFramePanelButton.Param underFramePanelBtnParam;

			// Token: 0x04018AA5 RID: 101029
			[Token(Token = "0x4018AA5")]
			[FieldOffset(Offset = "0x60")]
			public bool showSkillBtn;

			// Token: 0x04018AA6 RID: 101030
			[Token(Token = "0x4018AA6")]
			[FieldOffset(Offset = "0x68")]
			public Character character;
		}
	}
}
