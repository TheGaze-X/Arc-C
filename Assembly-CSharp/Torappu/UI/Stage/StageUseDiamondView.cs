using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068FD RID: 26877
	[Token(Token = "0x20068FD")]
	public class StageUseDiamondView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026807 RID: 157703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026807")]
		[Address(RVA = "0x21A33B0", Offset = "0x21A1FB0", VA = "0x1821A33B0")]
		private void _InitItemIfNot()
		{
		}

		// Token: 0x06026808 RID: 157704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026808")]
		[Address(RVA = "0x21A2FA0", Offset = "0x21A1BA0", VA = "0x1821A2FA0")]
		public void InitData()
		{
		}

		// Token: 0x06026809 RID: 157705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026809")]
		[Address(RVA = "0x21A35B0", Offset = "0x21A21B0", VA = "0x1821A35B0")]
		public StageUseDiamondView()
		{
		}

		// Token: 0x0403640A RID: 222218
		[Token(Token = "0x403640A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _restoreAP;

		// Token: 0x0403640B RID: 222219
		[Token(Token = "0x403640B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _remainDiamond;

		// Token: 0x0403640C RID: 222220
		[Token(Token = "0x403640C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403640D RID: 222221
		[Token(Token = "0x403640D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainText;

		// Token: 0x0403640E RID: 222222
		[Token(Token = "0x403640E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _upPart;

		// Token: 0x0403640F RID: 222223
		[Token(Token = "0x403640F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _downPart;

		// Token: 0x04036410 RID: 222224
		[Token(Token = "0x4036410")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04036411 RID: 222225
		[Token(Token = "0x4036411")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04036412 RID: 222226
		[Token(Token = "0x4036412")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _hasLimitObj;

		// Token: 0x04036413 RID: 222227
		[Token(Token = "0x4036413")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x04036414 RID: 222228
		[Token(Token = "0x4036414")]
		[FieldOffset(Offset = "0x68")]
		private UIItemViewModel m_itemModel;

		// Token: 0x04036415 RID: 222229
		[Token(Token = "0x4036415")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04036416 RID: 222230
		[Token(Token = "0x4036416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitItemIfNot;

		// Token: 0x04036417 RID: 222231
		[Token(Token = "0x4036417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04036418 RID: 222232
		[Token(Token = "0x4036418")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
