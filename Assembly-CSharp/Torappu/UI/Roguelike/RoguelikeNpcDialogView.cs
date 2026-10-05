using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054F4 RID: 21748
	[Token(Token = "0x20054F4")]
	public class RoguelikeNpcDialogView : DataBinder<RoguelikeGameShopDialogProp>
	{
		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x0601FFE2 RID: 131042 RVA: 0x000B4210 File Offset: 0x000B2410
		[Token(Token = "0x17004B03")]
		public bool isTweening
		{
			[Token(Token = "0x601FFE2")]
			[Address(RVA = "0x1A1F000", Offset = "0x1A1DC00", VA = "0x181A1F000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601FFE3 RID: 131043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFE3")]
		[Address(RVA = "0x1A1E990", Offset = "0x1A1D590", VA = "0x181A1E990", Slot = "7")]
		public override void OnValueChanged(RoguelikeGameShopDialogProp property)
		{
		}

		// Token: 0x0601FFE4 RID: 131044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFE4")]
		[Address(RVA = "0x1A1EE90", Offset = "0x1A1DA90", VA = "0x181A1EE90")]
		private void _RenderNpc(bool npcExist)
		{
		}

		// Token: 0x0601FFE5 RID: 131045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFE5")]
		[Address(RVA = "0x1A1ED10", Offset = "0x1A1D910", VA = "0x181A1ED10")]
		private void _PlayTextTween(string dialog)
		{
		}

		// Token: 0x0601FFE6 RID: 131046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFE6")]
		[Address(RVA = "0x1A1EF90", Offset = "0x1A1DB90", VA = "0x181A1EF90")]
		public RoguelikeNpcDialogView()
		{
		}

		// Token: 0x0402B2CD RID: 176845
		[Token(Token = "0x402B2CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402B2CE RID: 176846
		[Token(Token = "0x402B2CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDialog;

		// Token: 0x0402B2CF RID: 176847
		[Token(Token = "0x402B2CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _alphaTweenDelay;

		// Token: 0x0402B2D0 RID: 176848
		[Token(Token = "0x402B2D0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _alphaTweenDuration;

		// Token: 0x0402B2D1 RID: 176849
		[Token(Token = "0x402B2D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _textTweenDuration;

		// Token: 0x0402B2D2 RID: 176850
		[Token(Token = "0x402B2D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _npcPanel;

		// Token: 0x0402B2D3 RID: 176851
		[Token(Token = "0x402B2D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _npcGonePanel;

		// Token: 0x0402B2D4 RID: 176852
		[Token(Token = "0x402B2D4")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402B2D5 RID: 176853
		[Token(Token = "0x402B2D5")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_alphaTweener;

		// Token: 0x0402B2D6 RID: 176854
		[Token(Token = "0x402B2D6")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_textTweener;

		// Token: 0x0402B2D7 RID: 176855
		[Token(Token = "0x402B2D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTweening;

		// Token: 0x0402B2D8 RID: 176856
		[Token(Token = "0x402B2D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B2D9 RID: 176857
		[Token(Token = "0x402B2D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNpc;

		// Token: 0x0402B2DA RID: 176858
		[Token(Token = "0x402B2DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayTextTween;

		// Token: 0x0402B2DB RID: 176859
		[Token(Token = "0x402B2DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
