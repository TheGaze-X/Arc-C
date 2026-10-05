using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200666E RID: 26222
	[Token(Token = "0x200666E")]
	public class HandBookMissionGroup : MonoBehaviour
	{
		// Token: 0x06025A6A RID: 154218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A6A")]
		[Address(RVA = "0x209A600", Offset = "0x2099200", VA = "0x18209A600")]
		public void OnClick()
		{
		}

		// Token: 0x06025A6B RID: 154219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A6B")]
		[Address(RVA = "0x209AFA0", Offset = "0x2099BA0", VA = "0x18209AFA0")]
		private void _OnClickButton(int index)
		{
		}

		// Token: 0x06025A6C RID: 154220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A6C")]
		[Address(RVA = "0x209A650", Offset = "0x2099250", VA = "0x18209A650")]
		public void Render(HandBookMissionViewModel viewModel)
		{
		}

		// Token: 0x06025A6D RID: 154221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A6D")]
		[Address(RVA = "0x209AFF0", Offset = "0x2099BF0", VA = "0x18209AFF0")]
		public HandBookMissionGroup()
		{
		}

		// Token: 0x04034E35 RID: 216629
		[Token(Token = "0x4034E35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookMissionItem _item;

		// Token: 0x04034E36 RID: 216630
		[Token(Token = "0x4034E36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04034E37 RID: 216631
		[Token(Token = "0x4034E37")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _teamImage;

		// Token: 0x04034E38 RID: 216632
		[Token(Token = "0x4034E38")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _favorPoint;

		// Token: 0x04034E39 RID: 216633
		[Token(Token = "0x4034E39")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _favorPercent;

		// Token: 0x04034E3A RID: 216634
		[Token(Token = "0x4034E3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _teamName;

		// Token: 0x04034E3B RID: 216635
		[Token(Token = "0x4034E3B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _cannotGet;

		// Token: 0x04034E3C RID: 216636
		[Token(Token = "0x4034E3C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _alreadyGet;

		// Token: 0x04034E3D RID: 216637
		[Token(Token = "0x4034E3D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _canGet;

		// Token: 0x04034E3E RID: 216638
		[Token(Token = "0x4034E3E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _itemContainerAlreadyGet;

		// Token: 0x04034E3F RID: 216639
		[Token(Token = "0x4034E3F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _itemContainerCanGet;

		// Token: 0x04034E40 RID: 216640
		[Token(Token = "0x4034E40")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _getTextGet;

		// Token: 0x04034E41 RID: 216641
		[Token(Token = "0x4034E41")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _ungetTextGet;

		// Token: 0x04034E42 RID: 216642
		[Token(Token = "0x4034E42")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04034E43 RID: 216643
		[Token(Token = "0x4034E43")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x04034E44 RID: 216644
		[Token(Token = "0x4034E44")]
		[FieldOffset(Offset = "0x90")]
		private string m_cacheId;

		// Token: 0x04034E45 RID: 216645
		[Token(Token = "0x4034E45")]
		[FieldOffset(Offset = "0x98")]
		private UIItemViewModel m_cacheViewModel;

		// Token: 0x04034E46 RID: 216646
		[Token(Token = "0x4034E46")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemCard m_itemCard;
	}
}
