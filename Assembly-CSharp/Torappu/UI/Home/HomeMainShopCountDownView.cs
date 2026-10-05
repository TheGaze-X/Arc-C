using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C10 RID: 19472
	[Token(Token = "0x2004C10")]
	public class HomeMainShopCountDownView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D419 RID: 119833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D419")]
		[Address(RVA = "0x16D55B0", Offset = "0x16D41B0", VA = "0x1816D55B0")]
		public void _InitIfNot()
		{
		}

		// Token: 0x0601D41A RID: 119834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D41A")]
		[Address(RVA = "0x16D5100", Offset = "0x16D3D00", VA = "0x1816D5100")]
		public void RefreshState()
		{
		}

		// Token: 0x0601D41B RID: 119835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D41B")]
		[Address(RVA = "0x16D56A0", Offset = "0x16D42A0", VA = "0x1816D56A0")]
		private void _OnTimeExceed()
		{
		}

		// Token: 0x0601D41C RID: 119836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D41C")]
		[Address(RVA = "0x16D5740", Offset = "0x16D4340", VA = "0x1816D5740")]
		public HomeMainShopCountDownView()
		{
		}

		// Token: 0x0402674C RID: 157516
		[Token(Token = "0x402674C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _onTimeContainer;

		// Token: 0x0402674D RID: 157517
		[Token(Token = "0x402674D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIItemTimeCountDown _countDown;

		// Token: 0x0402674E RID: 157518
		[Token(Token = "0x402674E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x0402674F RID: 157519
		[Token(Token = "0x402674F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _monthlySubWarning;

		// Token: 0x04026750 RID: 157520
		[Token(Token = "0x4026750")]
		[FieldOffset(Offset = "0x38")]
		private UIItemTimeCountDown m_countDown;

		// Token: 0x04026751 RID: 157521
		[Token(Token = "0x4026751")]
		[FieldOffset(Offset = "0x40")]
		private bool m_initFlag;

		// Token: 0x04026752 RID: 157522
		[Token(Token = "0x4026752")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026753 RID: 157523
		[Token(Token = "0x4026753")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x04026754 RID: 157524
		[Token(Token = "0x4026754")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTimeExceed;

		// Token: 0x04026755 RID: 157525
		[Token(Token = "0x4026755")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
