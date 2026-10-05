using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D55 RID: 7509
	[Token(Token = "0x2001D55")]
	public class BuildingMusicPlayerView : DataBinder<MusicPlayerProperty>, IHotfixable
	{
		// Token: 0x0600B94E RID: 47438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94E")]
		[Address(RVA = "0x3364620", Offset = "0x3363220", VA = "0x183364620", Slot = "7")]
		public override void OnValueChanged(MusicPlayerProperty property)
		{
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94F")]
		[Address(RVA = "0x3364590", Offset = "0x3363190", VA = "0x183364590")]
		public void OnSetMusicBtnClicked()
		{
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B950")]
		[Address(RVA = "0x3364520", Offset = "0x3363120", VA = "0x183364520")]
		public void OnChangeSortOrderClicked()
		{
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B951")]
		[Address(RVA = "0x33644B0", Offset = "0x33630B0", VA = "0x1833644B0")]
		public void OnBkgClicked()
		{
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B952")]
		[Address(RVA = "0x3364910", Offset = "0x3363510", VA = "0x183364910")]
		private IEnumerator _TryEnableAutoSlide()
		{
			return null;
		}

		// Token: 0x0600B953 RID: 47443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B953")]
		[Address(RVA = "0x33649C0", Offset = "0x33635C0", VA = "0x1833649C0")]
		public BuildingMusicPlayerView()
		{
		}

		// Token: 0x0400B7B6 RID: 47030
		[Token(Token = "0x400B7B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelDefault;

		// Token: 0x0400B7B7 RID: 47031
		[Token(Token = "0x400B7B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelVisit;

		// Token: 0x0400B7B8 RID: 47032
		[Token(Token = "0x400B7B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingMusicPlayerListAdapter _adapter;

		// Token: 0x0400B7B9 RID: 47033
		[Token(Token = "0x400B7B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _ascending;

		// Token: 0x0400B7BA RID: 47034
		[Token(Token = "0x400B7BA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _descending;

		// Token: 0x0400B7BB RID: 47035
		[Token(Token = "0x400B7BB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _name;

		// Token: 0x0400B7BC RID: 47036
		[Token(Token = "0x400B7BC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _unlockDesc;

		// Token: 0x0400B7BD RID: 47037
		[Token(Token = "0x400B7BD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _bottomLockIcon;

		// Token: 0x0400B7BE RID: 47038
		[Token(Token = "0x400B7BE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnCanSet;

		// Token: 0x0400B7BF RID: 47039
		[Token(Token = "0x400B7BF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnCanNotSet;

		// Token: 0x0400B7C0 RID: 47040
		[Token(Token = "0x400B7C0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _visitName;

		// Token: 0x0400B7C1 RID: 47041
		[Token(Token = "0x400B7C1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _visitDesc;

		// Token: 0x0400B7C2 RID: 47042
		[Token(Token = "0x400B7C2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAutoSlideRect _visitNameSlideRect;

		// Token: 0x0400B7C3 RID: 47043
		[Token(Token = "0x400B7C3")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action onChangeSortOrder;

		// Token: 0x0400B7C4 RID: 47044
		[Token(Token = "0x400B7C4")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onBkgClicked;

		// Token: 0x0400B7C5 RID: 47045
		[Token(Token = "0x400B7C5")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400B7C6 RID: 47046
		[Token(Token = "0x400B7C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B7C7 RID: 47047
		[Token(Token = "0x400B7C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetMusicBtnClicked;

		// Token: 0x0400B7C8 RID: 47048
		[Token(Token = "0x400B7C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnChangeSortOrderClicked;

		// Token: 0x0400B7C9 RID: 47049
		[Token(Token = "0x400B7C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBkgClicked;

		// Token: 0x0400B7CA RID: 47050
		[Token(Token = "0x400B7CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryEnableAutoSlide;

		// Token: 0x0400B7CB RID: 47051
		[Token(Token = "0x400B7CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
