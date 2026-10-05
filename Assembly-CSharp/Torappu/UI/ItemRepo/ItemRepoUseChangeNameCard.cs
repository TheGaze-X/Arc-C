using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EB7 RID: 24247
	[Token(Token = "0x2005EB7")]
	public class ItemRepoUseChangeNameCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x060231C5 RID: 143813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C5")]
		[Address(RVA = "0x1DA26F0", Offset = "0x1DA12F0", VA = "0x181DA26F0")]
		public void RenderChangeName(UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x060231C6 RID: 143814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C6")]
		[Address(RVA = "0x1DA2570", Offset = "0x1DA1170", VA = "0x181DA2570")]
		public void OnEndEditText(string text)
		{
		}

		// Token: 0x060231C7 RID: 143815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C7")]
		[Address(RVA = "0x1DA22C0", Offset = "0x1DA0EC0", VA = "0x181DA22C0")]
		public void OnClickConfirm()
		{
		}

		// Token: 0x060231C8 RID: 143816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C8")]
		[Address(RVA = "0x1DA2CF0", Offset = "0x1DA18F0", VA = "0x181DA2CF0")]
		private void _BindNickNameServiceSuccess(UseRenameCardResponse response)
		{
		}

		// Token: 0x060231C9 RID: 143817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C9")]
		[Address(RVA = "0x1DA2250", Offset = "0x1DA0E50", VA = "0x181DA2250")]
		public void Dismiss()
		{
		}

		// Token: 0x060231CA RID: 143818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231CA")]
		[Address(RVA = "0x1DA2DC0", Offset = "0x1DA19C0", VA = "0x181DA2DC0")]
		public ItemRepoUseChangeNameCard()
		{
		}

		// Token: 0x0403065D RID: 198237
		[Token(Token = "0x403065D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _currentNameText;

		// Token: 0x0403065E RID: 198238
		[Token(Token = "0x403065E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _changeNameText;

		// Token: 0x0403065F RID: 198239
		[Token(Token = "0x403065F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField _inputText;

		// Token: 0x04030660 RID: 198240
		[Token(Token = "0x4030660")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ChangeNameNotifyView _notifyView;

		// Token: 0x04030661 RID: 198241
		[Token(Token = "0x4030661")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _dismissAction;

		// Token: 0x04030662 RID: 198242
		[Token(Token = "0x4030662")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _title;

		// Token: 0x04030663 RID: 198243
		[Token(Token = "0x4030663")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _onTimePart;

		// Token: 0x04030664 RID: 198244
		[Token(Token = "0x4030664")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _onTimeText;

		// Token: 0x04030665 RID: 198245
		[Token(Token = "0x4030665")]
		[FieldOffset(Offset = "0x58")]
		private string m_changeName;

		// Token: 0x04030666 RID: 198246
		[Token(Token = "0x4030666")]
		[FieldOffset(Offset = "0x60")]
		private string m_itemId;

		// Token: 0x04030667 RID: 198247
		[Token(Token = "0x4030667")]
		[FieldOffset(Offset = "0x68")]
		private int m_instId;

		// Token: 0x04030668 RID: 198248
		[Token(Token = "0x4030668")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChangeName;

		// Token: 0x04030669 RID: 198249
		[Token(Token = "0x4030669")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEndEditText;

		// Token: 0x0403066A RID: 198250
		[Token(Token = "0x403066A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickConfirm;

		// Token: 0x0403066B RID: 198251
		[Token(Token = "0x403066B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__BindNickNameServiceSuccess;

		// Token: 0x0403066C RID: 198252
		[Token(Token = "0x403066C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x0403066D RID: 198253
		[Token(Token = "0x403066D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
