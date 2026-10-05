using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006111 RID: 24849
	[Token(Token = "0x2006111")]
	public class CampaignWorldSwitchTweenObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x06023E68 RID: 147048 RVA: 0x000C2538 File Offset: 0x000C0738
		// (set) Token: 0x06023E69 RID: 147049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054CE")]
		public bool isShow
		{
			[Token(Token = "0x6023E68")]
			[Address(RVA = "0x1E8F120", Offset = "0x1E8DD20", VA = "0x181E8F120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6023E69")]
			[Address(RVA = "0x1E8F190", Offset = "0x1E8DD90", VA = "0x181E8F190")]
			set
			{
			}
		}

		// Token: 0x06023E6A RID: 147050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E6A")]
		[Address(RVA = "0x1E8EF50", Offset = "0x1E8DB50", VA = "0x181E8EF50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023E6B RID: 147051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E6B")]
		[Address(RVA = "0x1E8EED0", Offset = "0x1E8DAD0", VA = "0x181E8EED0")]
		public void Start()
		{
		}

		// Token: 0x06023E6C RID: 147052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E6C")]
		[Address(RVA = "0x1E8F0B0", Offset = "0x1E8DCB0", VA = "0x181E8F0B0")]
		public CampaignWorldSwitchTweenObj()
		{
		}

		// Token: 0x04031D0E RID: 204046
		[Token(Token = "0x4031D0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04031D0F RID: 204047
		[Token(Token = "0x4031D0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rectTrans;

		// Token: 0x04031D10 RID: 204048
		[Token(Token = "0x4031D10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x04031D11 RID: 204049
		[Token(Token = "0x4031D11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x04031D12 RID: 204050
		[Token(Token = "0x4031D12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _isShowOnStart;

		// Token: 0x04031D13 RID: 204051
		[Token(Token = "0x4031D13")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float duration;

		// Token: 0x04031D14 RID: 204052
		[Token(Token = "0x4031D14")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x04031D15 RID: 204053
		[Token(Token = "0x4031D15")]
		[FieldOffset(Offset = "0x48")]
		private FadeTranslationSwitchTween m_switchTween;

		// Token: 0x04031D16 RID: 204054
		[Token(Token = "0x4031D16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04031D17 RID: 204055
		[Token(Token = "0x4031D17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04031D18 RID: 204056
		[Token(Token = "0x4031D18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031D19 RID: 204057
		[Token(Token = "0x4031D19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04031D1A RID: 204058
		[Token(Token = "0x4031D1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
