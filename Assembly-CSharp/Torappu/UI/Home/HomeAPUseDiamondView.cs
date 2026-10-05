using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BD9 RID: 19417
	[Token(Token = "0x2004BD9")]
	public class HomeAPUseDiamondView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D2F1 RID: 119537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F1")]
		[Address(RVA = "0x16BBF60", Offset = "0x16BAB60", VA = "0x1816BBF60")]
		private void _InitItemIfNot()
		{
		}

		// Token: 0x0601D2F2 RID: 119538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F2")]
		[Address(RVA = "0x16BBB90", Offset = "0x16BA790", VA = "0x1816BBB90")]
		public void InitData()
		{
		}

		// Token: 0x0601D2F3 RID: 119539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F3")]
		[Address(RVA = "0x16BC160", Offset = "0x16BAD60", VA = "0x1816BC160")]
		public HomeAPUseDiamondView()
		{
		}

		// Token: 0x040264E0 RID: 156896
		[Token(Token = "0x40264E0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _restoreAP;

		// Token: 0x040264E1 RID: 156897
		[Token(Token = "0x40264E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x040264E2 RID: 156898
		[Token(Token = "0x40264E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _remainText;

		// Token: 0x040264E3 RID: 156899
		[Token(Token = "0x40264E3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _upPart;

		// Token: 0x040264E4 RID: 156900
		[Token(Token = "0x40264E4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _downPart;

		// Token: 0x040264E5 RID: 156901
		[Token(Token = "0x40264E5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x040264E6 RID: 156902
		[Token(Token = "0x40264E6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x040264E7 RID: 156903
		[Token(Token = "0x40264E7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _hasLimitObj;

		// Token: 0x040264E8 RID: 156904
		[Token(Token = "0x40264E8")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_itemCard;

		// Token: 0x040264E9 RID: 156905
		[Token(Token = "0x40264E9")]
		[FieldOffset(Offset = "0x60")]
		private UIItemViewModel m_itemModel;

		// Token: 0x040264EA RID: 156906
		[Token(Token = "0x40264EA")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x040264EB RID: 156907
		[Token(Token = "0x40264EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitItemIfNot;

		// Token: 0x040264EC RID: 156908
		[Token(Token = "0x40264EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040264ED RID: 156909
		[Token(Token = "0x40264ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
