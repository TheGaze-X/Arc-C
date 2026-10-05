using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A36 RID: 23094
	[Token(Token = "0x2005A36")]
	public class UIChooseCharGroupCharItemView : CommonChooseCharCardView, IHotfixable
	{
		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x06021A01 RID: 137729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021A02 RID: 137730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EF0")]
		public Action<string> onClickEvent
		{
			[Token(Token = "0x6021A01")]
			[Address(RVA = "0x1C13ED0", Offset = "0x1C12AD0", VA = "0x181C13ED0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021A02")]
			[Address(RVA = "0x1C13F30", Offset = "0x1C12B30", VA = "0x181C13F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021A03 RID: 137731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A03")]
		[Address(RVA = "0x1C13DB0", Offset = "0x1C129B0", VA = "0x181C13DB0", Slot = "4")]
		public override void SetClickCallback(Action<string> action)
		{
		}

		// Token: 0x06021A04 RID: 137732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A04")]
		[Address(RVA = "0x1C139A0", Offset = "0x1C125A0", VA = "0x181C139A0", Slot = "5")]
		public override void Render(ICommonChooseCharCardViewModel viewModel)
		{
		}

		// Token: 0x06021A05 RID: 137733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A05")]
		[Address(RVA = "0x1C13930", Offset = "0x1C12530", VA = "0x181C13930", Slot = "6")]
		public override void OnItemClick()
		{
		}

		// Token: 0x06021A06 RID: 137734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A06")]
		[Address(RVA = "0x1C13E30", Offset = "0x1C12A30", VA = "0x181C13E30")]
		public UIChooseCharGroupCharItemView()
		{
		}

		// Token: 0x0402DFAD RID: 188333
		[Token(Token = "0x402DFAD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x0402DFAE RID: 188334
		[Token(Token = "0x402DFAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgCharRarity;

		// Token: 0x0402DFAF RID: 188335
		[Token(Token = "0x402DFAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCharProfession;

		// Token: 0x0402DFB0 RID: 188336
		[Token(Token = "0x402DFB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtCharName;

		// Token: 0x0402DFB1 RID: 188337
		[Token(Token = "0x402DFB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x0402DFB2 RID: 188338
		[Token(Token = "0x402DFB2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelPotential;

		// Token: 0x0402DFB3 RID: 188339
		[Token(Token = "0x402DFB3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0402DFB5 RID: 188341
		[Token(Token = "0x402DFB5")]
		[FieldOffset(Offset = "0x58")]
		private string m_cacheCharId;

		// Token: 0x0402DFB6 RID: 188342
		[Token(Token = "0x402DFB6")]
		[FieldOffset(Offset = "0x60")]
		private Action<string> m_cacheAction;

		// Token: 0x0402DFB7 RID: 188343
		[Token(Token = "0x402DFB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402DFB8 RID: 188344
		[Token(Token = "0x402DFB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402DFB9 RID: 188345
		[Token(Token = "0x402DFB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetClickCallback;

		// Token: 0x0402DFBA RID: 188346
		[Token(Token = "0x402DFBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DFBB RID: 188347
		[Token(Token = "0x402DFBB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0402DFBC RID: 188348
		[Token(Token = "0x402DFBC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
