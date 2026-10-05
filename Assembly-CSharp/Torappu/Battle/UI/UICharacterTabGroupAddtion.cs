using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032D1 RID: 13009
	[Token(Token = "0x20032D1")]
	public class UICharacterTabGroupAddtion : MonoBehaviour, IHotfixable
	{
		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06014AEF RID: 84719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030FA")]
		public EasyInstancePool tabItemInstancePool
		{
			[Token(Token = "0x6014AEF")]
			[Address(RVA = "0xD27B10", Offset = "0xD26710", VA = "0x180D27B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06014AF0 RID: 84720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030FB")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014AF0")]
			[Address(RVA = "0xD27A90", Offset = "0xD26690", VA = "0x180D27A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014AF1 RID: 84721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AF1")]
		[Address(RVA = "0xD275C0", Offset = "0xD261C0", VA = "0x180D275C0")]
		public void OnInit(UIController uiController)
		{
		}

		// Token: 0x06014AF2 RID: 84722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AF2")]
		[Address(RVA = "0xD27420", Offset = "0xD26020", VA = "0x180D27420")]
		public void EnableTab(bool isActive)
		{
		}

		// Token: 0x06014AF3 RID: 84723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AF3")]
		[Address(RVA = "0xD27A30", Offset = "0xD26630", VA = "0x180D27A30")]
		public UICharacterTabGroupAddtion()
		{
		}

		// Token: 0x040188A3 RID: 100515
		[Token(Token = "0x40188A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharacterTabSwitchButton _additionInfoTab;

		// Token: 0x040188A4 RID: 100516
		[Token(Token = "0x40188A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _additionInfoTabDetailPanel;

		// Token: 0x040188A5 RID: 100517
		[Token(Token = "0x40188A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _moveToFirst;

		// Token: 0x040188A6 RID: 100518
		[Token(Token = "0x40188A6")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _refreshTransform;

		// Token: 0x040188A7 RID: 100519
		[Token(Token = "0x40188A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EasyInstancePool _tabItemInstancePool;

		// Token: 0x040188A8 RID: 100520
		[Token(Token = "0x40188A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tabItemInstancePool;

		// Token: 0x040188A9 RID: 100521
		[Token(Token = "0x40188A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x040188AA RID: 100522
		[Token(Token = "0x40188AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040188AB RID: 100523
		[Token(Token = "0x40188AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EnableTab;

		// Token: 0x040188AC RID: 100524
		[Token(Token = "0x40188AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
