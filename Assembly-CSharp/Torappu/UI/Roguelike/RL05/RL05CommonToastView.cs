using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200563B RID: 22075
	[Token(Token = "0x200563B")]
	public class RL05CommonToastView : UINotifyView<RL05CommonToastView.Param>
	{
		// Token: 0x06020641 RID: 132673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020641")]
		[Address(RVA = "0x1A74940", Offset = "0x1A73540", VA = "0x181A74940", Slot = "9")]
		protected override void Render(RL05CommonToastView.Param param)
		{
		}

		// Token: 0x06020642 RID: 132674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020642")]
		[Address(RVA = "0x1A74AF0", Offset = "0x1A736F0", VA = "0x181A74AF0")]
		public RL05CommonToastView()
		{
		}

		// Token: 0x0402BD8D RID: 179597
		[Token(Token = "0x402BD8D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _toastText;

		// Token: 0x0402BD8E RID: 179598
		[Token(Token = "0x402BD8E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<RL05CommonToastView.ToastIconGroup> _toastIconGroups;

		// Token: 0x0402BD8F RID: 179599
		[Token(Token = "0x402BD8F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402BD90 RID: 179600
		[Token(Token = "0x402BD90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BD91 RID: 179601
		[Token(Token = "0x402BD91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200563C RID: 22076
		[Token(Token = "0x200563C")]
		public enum ToastType
		{
			// Token: 0x0402BD93 RID: 179603
			[Token(Token = "0x402BD93")]
			NONE,
			// Token: 0x0402BD94 RID: 179604
			[Token(Token = "0x402BD94")]
			SKY,
			// Token: 0x0402BD95 RID: 179605
			[Token(Token = "0x402BD95")]
			GOLD,
			// Token: 0x0402BD96 RID: 179606
			[Token(Token = "0x402BD96")]
			WRATH,
			// Token: 0x0402BD97 RID: 179607
			[Token(Token = "0x402BD97")]
			EVIL_TEMPLE,
			// Token: 0x0402BD98 RID: 179608
			[Token(Token = "0x402BD98")]
			COPPER_CONVERT
		}

		// Token: 0x0200563D RID: 22077
		[Token(Token = "0x200563D")]
		[Serializable]
		public class ToastIconGroup
		{
			// Token: 0x06020643 RID: 132675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020643")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ToastIconGroup()
			{
			}

			// Token: 0x0402BD99 RID: 179609
			[Token(Token = "0x402BD99")]
			[FieldOffset(Offset = "0x10")]
			public RL05CommonToastView.ToastType type;

			// Token: 0x0402BD9A RID: 179610
			[Token(Token = "0x402BD9A")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;
		}

		// Token: 0x0200563E RID: 22078
		[Token(Token = "0x200563E")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020644 RID: 132676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020644")]
			[Address(RVA = "0x1A74560", Offset = "0x1A73160", VA = "0x181A74560", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x06020645 RID: 132677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020645")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402BD9B RID: 179611
			[Token(Token = "0x402BD9B")]
			[FieldOffset(Offset = "0x10")]
			public RL05CommonToastView.ToastType toastType;

			// Token: 0x0402BD9C RID: 179612
			[Token(Token = "0x402BD9C")]
			[FieldOffset(Offset = "0x18")]
			public string text;
		}
	}
}
