using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A2 RID: 21922
	[Token(Token = "0x20055A2")]
	public class RL05FreezeCopperTitleView : DataBinder<RL05FreezeCopperProperty>, IHotfixable
	{
		// Token: 0x0602031E RID: 131870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602031E")]
		[Address(RVA = "0x1A54070", Offset = "0x1A52C70", VA = "0x181A54070", Slot = "7")]
		public override void OnValueChanged(RL05FreezeCopperProperty property)
		{
		}

		// Token: 0x0602031F RID: 131871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602031F")]
		[Address(RVA = "0x1A54400", Offset = "0x1A53000", VA = "0x181A54400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020320 RID: 131872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020320")]
		[Address(RVA = "0x1A53FE0", Offset = "0x1A52BE0", VA = "0x181A53FE0")]
		public void EventOnRefreshBtnClicked()
		{
		}

		// Token: 0x06020321 RID: 131873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020321")]
		[Address(RVA = "0x1A54510", Offset = "0x1A53110", VA = "0x181A54510")]
		public RL05FreezeCopperTitleView()
		{
		}

		// Token: 0x0402B862 RID: 178274
		[Token(Token = "0x402B862")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textFreezeItemCount;

		// Token: 0x0402B863 RID: 178275
		[Token(Token = "0x402B863")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRefreshItemCount;

		// Token: 0x0402B864 RID: 178276
		[Token(Token = "0x402B864")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textFreezeItemCost;

		// Token: 0x0402B865 RID: 178277
		[Token(Token = "0x402B865")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _textRefreshItemCost;

		// Token: 0x0402B866 RID: 178278
		[Token(Token = "0x402B866")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402B867 RID: 178279
		[Token(Token = "0x402B867")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animBtnSwitch;

		// Token: 0x0402B868 RID: 178280
		[Token(Token = "0x402B868")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0402B869 RID: 178281
		[Token(Token = "0x402B869")]
		[FieldOffset(Offset = "0x60")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402B86A RID: 178282
		[Token(Token = "0x402B86A")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_switchTween;

		// Token: 0x0402B86B RID: 178283
		[Token(Token = "0x402B86B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B86C RID: 178284
		[Token(Token = "0x402B86C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B86D RID: 178285
		[Token(Token = "0x402B86D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRefreshBtnClicked;

		// Token: 0x0402B86E RID: 178286
		[Token(Token = "0x402B86E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
