using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200340A RID: 13322
	[Token(Token = "0x200340A")]
	public class UICooperateBattleEmoticonPanelBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601549B RID: 87195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601549B")]
		[Address(RVA = "0xDB04E0", Offset = "0xDAF0E0", VA = "0x180DB04E0")]
		public void OnButtonClicked()
		{
		}

		// Token: 0x0601549C RID: 87196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601549C")]
		[Address(RVA = "0xDB0960", Offset = "0xDAF560", VA = "0x180DB0960")]
		public void Show(float predelay)
		{
		}

		// Token: 0x0601549D RID: 87197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601549D")]
		[Address(RVA = "0xDB0700", Offset = "0xDAF300", VA = "0x180DB0700")]
		public void RecoverFromCD()
		{
		}

		// Token: 0x0601549E RID: 87198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601549E")]
		[Address(RVA = "0xDB08B0", Offset = "0xDAF4B0", VA = "0x180DB08B0")]
		public void SetInCD()
		{
		}

		// Token: 0x0601549F RID: 87199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601549F")]
		[Address(RVA = "0xDB0B00", Offset = "0xDAF700", VA = "0x180DB0B00")]
		public UICooperateBattleEmoticonPanelBtn()
		{
		}

		// Token: 0x040196ED RID: 104173
		[Token(Token = "0x40196ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x040196EE RID: 104174
		[Token(Token = "0x40196EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _button;

		// Token: 0x040196EF RID: 104175
		[Token(Token = "0x40196EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _itemCanvasGroup;

		// Token: 0x040196F0 RID: 104176
		[Token(Token = "0x40196F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x040196F1 RID: 104177
		[Token(Token = "0x40196F1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _inactiveAlpha;

		// Token: 0x040196F2 RID: 104178
		[Token(Token = "0x40196F2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _activeAlpha;

		// Token: 0x040196F3 RID: 104179
		[Token(Token = "0x40196F3")]
		[FieldOffset(Offset = "0x48")]
		private CooperateUIPlugin m_plugin;

		// Token: 0x040196F4 RID: 104180
		[Token(Token = "0x40196F4")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_tween;

		// Token: 0x040196F5 RID: 104181
		[Token(Token = "0x40196F5")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tweenActive;

		// Token: 0x040196F6 RID: 104182
		[Token(Token = "0x40196F6")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isActive;

		// Token: 0x040196F7 RID: 104183
		[Token(Token = "0x40196F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnButtonClicked;

		// Token: 0x040196F8 RID: 104184
		[Token(Token = "0x40196F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040196F9 RID: 104185
		[Token(Token = "0x40196F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RecoverFromCD;

		// Token: 0x040196FA RID: 104186
		[Token(Token = "0x40196FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetInCD;

		// Token: 0x040196FB RID: 104187
		[Token(Token = "0x40196FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
