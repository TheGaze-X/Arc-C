using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B8E RID: 15246
	[Token(Token = "0x2003B8E")]
	public class VoucherSkinItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017E4B RID: 97867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E4B")]
		[Address(RVA = "0x1026BD0", Offset = "0x10257D0", VA = "0x181026BD0")]
		public void Render(VoucherSkinItemViewModel viewModel)
		{
		}

		// Token: 0x06017E4C RID: 97868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E4C")]
		[Address(RVA = "0x1026AF0", Offset = "0x10256F0", VA = "0x181026AF0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06017E4D RID: 97869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E4D")]
		[Address(RVA = "0x1026F00", Offset = "0x1025B00", VA = "0x181026F00")]
		public VoucherSkinItemView()
		{
		}

		// Token: 0x0401CE2E RID: 118318
		[Token(Token = "0x401CE2E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textSkinName;

		// Token: 0x0401CE2F RID: 118319
		[Token(Token = "0x401CE2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x0401CE30 RID: 118320
		[Token(Token = "0x401CE30")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _checkObj;

		// Token: 0x0401CE31 RID: 118321
		[Token(Token = "0x401CE31")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objHasGot;

		// Token: 0x0401CE32 RID: 118322
		[Token(Token = "0x401CE32")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _notRedeem;

		// Token: 0x0401CE33 RID: 118323
		[Token(Token = "0x401CE33")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgPortrait;

		// Token: 0x0401CE34 RID: 118324
		[Token(Token = "0x401CE34")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgLogo;

		// Token: 0x0401CE35 RID: 118325
		[Token(Token = "0x401CE35")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _buttonPart;

		// Token: 0x0401CE36 RID: 118326
		[Token(Token = "0x401CE36")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedSkinId;

		// Token: 0x0401CE37 RID: 118327
		[Token(Token = "0x401CE37")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401CE38 RID: 118328
		[Token(Token = "0x401CE38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CE39 RID: 118329
		[Token(Token = "0x401CE39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401CE3A RID: 118330
		[Token(Token = "0x401CE3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
