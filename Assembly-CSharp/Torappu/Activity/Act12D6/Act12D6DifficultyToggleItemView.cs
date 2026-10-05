using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AE1 RID: 31457
	[Token(Token = "0x2007AE1")]
	public class Act12D6DifficultyToggleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700673C RID: 26428
		// (get) Token: 0x0602C0F1 RID: 180465 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C0F2 RID: 180466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700673C")]
		public string difficultyId
		{
			[Token(Token = "0x602C0F1")]
			[Address(RVA = "0x27ED290", Offset = "0x27EBE90", VA = "0x1827ED290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C0F2")]
			[Address(RVA = "0x27ED2F0", Offset = "0x27EBEF0", VA = "0x1827ED2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C0F3 RID: 180467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F3")]
		[Address(RVA = "0x27ECE20", Offset = "0x27EBA20", VA = "0x1827ECE20")]
		public void OnClick()
		{
		}

		// Token: 0x0602C0F4 RID: 180468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F4")]
		[Address(RVA = "0x27ECEA0", Offset = "0x27EBAA0", VA = "0x1827ECEA0")]
		public void Render(RoguelikeModeData modeData, bool locked = false)
		{
		}

		// Token: 0x0602C0F5 RID: 180469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F5")]
		[Address(RVA = "0x27ED0E0", Offset = "0x27EBCE0", VA = "0x1827ED0E0")]
		public void SwitchOnState(bool isOn)
		{
		}

		// Token: 0x0602C0F6 RID: 180470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F6")]
		[Address(RVA = "0x27ED230", Offset = "0x27EBE30", VA = "0x1827ED230")]
		public Act12D6DifficultyToggleItemView()
		{
		}

		// Token: 0x0403FD42 RID: 261442
		[Token(Token = "0x403FD42")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDifficulty;

		// Token: 0x0403FD43 RID: 261443
		[Token(Token = "0x403FD43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403FD44 RID: 261444
		[Token(Token = "0x403FD44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelDesc;

		// Token: 0x0403FD45 RID: 261445
		[Token(Token = "0x403FD45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0403FD46 RID: 261446
		[Token(Token = "0x403FD46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imageLocked;

		// Token: 0x0403FD47 RID: 261447
		[Token(Token = "0x403FD47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public UIStringEvent OnLockedToggleClicked;

		// Token: 0x0403FD48 RID: 261448
		[Token(Token = "0x403FD48")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedModeName;

		// Token: 0x0403FD4A RID: 261450
		[Token(Token = "0x403FD4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_difficultyId;

		// Token: 0x0403FD4B RID: 261451
		[Token(Token = "0x403FD4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_difficultyId;

		// Token: 0x0403FD4C RID: 261452
		[Token(Token = "0x403FD4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403FD4D RID: 261453
		[Token(Token = "0x403FD4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FD4E RID: 261454
		[Token(Token = "0x403FD4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchOnState;

		// Token: 0x0403FD4F RID: 261455
		[Token(Token = "0x403FD4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
