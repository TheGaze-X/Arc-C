using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A99 RID: 23193
	[Token(Token = "0x2005A99")]
	public class ShopDetailChooseGpItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021BA3 RID: 138147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA3")]
		[Address(RVA = "0x1C1FB70", Offset = "0x1C1E770", VA = "0x181C1FB70")]
		public void InitData(int position, ChooseGiftPackageShopOption option)
		{
		}

		// Token: 0x06021BA4 RID: 138148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA4")]
		[Address(RVA = "0x1C1FDC0", Offset = "0x1C1E9C0", VA = "0x181C1FDC0")]
		public void SetPos(int selectPos)
		{
		}

		// Token: 0x06021BA5 RID: 138149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA5")]
		[Address(RVA = "0x1C1FCE0", Offset = "0x1C1E8E0", VA = "0x181C1FCE0")]
		public void OnClickDetail()
		{
		}

		// Token: 0x06021BA6 RID: 138150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA6")]
		[Address(RVA = "0x1C1FD50", Offset = "0x1C1E950", VA = "0x181C1FD50")]
		public void OnSelectClick()
		{
		}

		// Token: 0x06021BA7 RID: 138151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA7")]
		[Address(RVA = "0x1C1FE50", Offset = "0x1C1EA50", VA = "0x181C1FE50")]
		public ShopDetailChooseGpItem()
		{
		}

		// Token: 0x0402E22F RID: 188975
		[Token(Token = "0x402E22F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;

		// Token: 0x0402E230 RID: 188976
		[Token(Token = "0x402E230")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName1;

		// Token: 0x0402E231 RID: 188977
		[Token(Token = "0x402E231")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemName2;

		// Token: 0x0402E232 RID: 188978
		[Token(Token = "0x402E232")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<int> onDetailClick;

		// Token: 0x0402E233 RID: 188979
		[Token(Token = "0x402E233")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> onSelectClick;

		// Token: 0x0402E234 RID: 188980
		[Token(Token = "0x402E234")]
		[FieldOffset(Offset = "0x40")]
		private int m_position;

		// Token: 0x0402E235 RID: 188981
		[Token(Token = "0x402E235")]
		[FieldOffset(Offset = "0x48")]
		private ChooseGiftPackageShopOption m_cacheOption;

		// Token: 0x0402E236 RID: 188982
		[Token(Token = "0x402E236")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E237 RID: 188983
		[Token(Token = "0x402E237")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetPos;

		// Token: 0x0402E238 RID: 188984
		[Token(Token = "0x402E238")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickDetail;

		// Token: 0x0402E239 RID: 188985
		[Token(Token = "0x402E239")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelectClick;

		// Token: 0x0402E23A RID: 188986
		[Token(Token = "0x402E23A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
