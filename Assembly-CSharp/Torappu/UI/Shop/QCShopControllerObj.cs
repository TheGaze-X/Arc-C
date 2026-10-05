using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AFA RID: 23290
	[Token(Token = "0x2005AFA")]
	public class QCShopControllerObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x06021D89 RID: 138633 RVA: 0x000BB668 File Offset: 0x000B9868
		[Token(Token = "0x17004F34")]
		public QCShopDetailShopEnum shopState
		{
			[Token(Token = "0x6021D89")]
			[Address(RVA = "0x1C479A0", Offset = "0x1C465A0", VA = "0x181C479A0")]
			get
			{
				return QCShopDetailShopEnum.LOW;
			}
		}

		// Token: 0x06021D8A RID: 138634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D8A")]
		[Address(RVA = "0x1C478C0", Offset = "0x1C464C0", VA = "0x181C478C0")]
		public void OnClick()
		{
		}

		// Token: 0x06021D8B RID: 138635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D8B")]
		[Address(RVA = "0x1C47750", Offset = "0x1C46350", VA = "0x181C47750")]
		public void ApplyNewFlag(List<string> newFlagList)
		{
		}

		// Token: 0x06021D8C RID: 138636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D8C")]
		[Address(RVA = "0x1C47830", Offset = "0x1C46430", VA = "0x181C47830")]
		public void ApplyState(QCShopDetailShopEnum state)
		{
		}

		// Token: 0x06021D8D RID: 138637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D8D")]
		[Address(RVA = "0x1C47940", Offset = "0x1C46540", VA = "0x181C47940")]
		public QCShopControllerObj()
		{
		}

		// Token: 0x0402E5B1 RID: 189873
		[Token(Token = "0x402E5B1")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIQCShopEvent clickEvent;

		// Token: 0x0402E5B2 RID: 189874
		[Token(Token = "0x402E5B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _clickChange;

		// Token: 0x0402E5B3 RID: 189875
		[Token(Token = "0x402E5B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private QCShopDetailShopEnum _shopState;

		// Token: 0x0402E5B4 RID: 189876
		[Token(Token = "0x402E5B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newFlag;

		// Token: 0x0402E5B5 RID: 189877
		[Token(Token = "0x402E5B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shopState;

		// Token: 0x0402E5B6 RID: 189878
		[Token(Token = "0x402E5B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E5B7 RID: 189879
		[Token(Token = "0x402E5B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyNewFlag;

		// Token: 0x0402E5B8 RID: 189880
		[Token(Token = "0x402E5B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0402E5B9 RID: 189881
		[Token(Token = "0x402E5B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
