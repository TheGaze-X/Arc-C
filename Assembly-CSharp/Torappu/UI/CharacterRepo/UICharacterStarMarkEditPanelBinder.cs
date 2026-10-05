using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E3E RID: 24126
	[Token(Token = "0x2005E3E")]
	public class UICharacterStarMarkEditPanelBinder : DataBinder<CharacterRepoCardGroupViewProperty>, IHotfixable
	{
		// Token: 0x06022F52 RID: 143186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F52")]
		[Address(RVA = "0x1D8D430", Offset = "0x1D8C030", VA = "0x181D8D430", Slot = "7")]
		public override void OnValueChanged(CharacterRepoCardGroupViewProperty property)
		{
		}

		// Token: 0x06022F53 RID: 143187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F53")]
		[Address(RVA = "0x1D8DA40", Offset = "0x1D8C640", VA = "0x181D8DA40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022F54 RID: 143188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F54")]
		[Address(RVA = "0x1D8D9C0", Offset = "0x1D8C5C0", VA = "0x181D8D9C0")]
		private void _HideStarMarkBtn()
		{
		}

		// Token: 0x06022F55 RID: 143189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F55")]
		[Address(RVA = "0x1D8DD50", Offset = "0x1D8C950", VA = "0x181D8DD50")]
		private void _ShowStarMarkBtn()
		{
		}

		// Token: 0x06022F56 RID: 143190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F56")]
		[Address(RVA = "0x1D8DDD0", Offset = "0x1D8C9D0", VA = "0x181D8DDD0")]
		public UICharacterStarMarkEditPanelBinder()
		{
		}

		// Token: 0x040302A0 RID: 197280
		[Token(Token = "0x40302A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _editPanelContainer;

		// Token: 0x040302A1 RID: 197281
		[Token(Token = "0x40302A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterStarMarkEditPanel _editPanelPrefab;

		// Token: 0x040302A2 RID: 197282
		[Token(Token = "0x40302A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _eventOnStarMarkConfirm;

		// Token: 0x040302A3 RID: 197283
		[Token(Token = "0x40302A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _eventOnClearAllStarMark;

		// Token: 0x040302A4 RID: 197284
		[Token(Token = "0x40302A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent _eventOnExitStarMarkEdit;

		// Token: 0x040302A5 RID: 197285
		[Token(Token = "0x40302A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _starMarkTopShowAnmi;

		// Token: 0x040302A6 RID: 197286
		[Token(Token = "0x40302A6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _topbarBgScaleToShortAnim;

		// Token: 0x040302A7 RID: 197287
		[Token(Token = "0x40302A7")]
		[FieldOffset(Offset = "0x68")]
		private UICharacterStarMarkEditPanel m_starMarkEditPanel;

		// Token: 0x040302A8 RID: 197288
		[Token(Token = "0x40302A8")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x040302A9 RID: 197289
		[Token(Token = "0x40302A9")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_starMarkTopBtnShowSwitch;

		// Token: 0x040302AA RID: 197290
		[Token(Token = "0x40302AA")]
		[FieldOffset(Offset = "0x80")]
		private AnimationSwitchTween m_topbarBgScaleToShortSwitch;

		// Token: 0x040302AB RID: 197291
		[Token(Token = "0x40302AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040302AC RID: 197292
		[Token(Token = "0x40302AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040302AD RID: 197293
		[Token(Token = "0x40302AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HideStarMarkBtn;

		// Token: 0x040302AE RID: 197294
		[Token(Token = "0x40302AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowStarMarkBtn;

		// Token: 0x040302AF RID: 197295
		[Token(Token = "0x40302AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
