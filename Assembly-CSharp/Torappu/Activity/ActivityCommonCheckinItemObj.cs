using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DAE RID: 28078
	[Token(Token = "0x2006DAE")]
	public class ActivityCommonCheckinItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FCF RID: 163791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FCF")]
		[Address(RVA = "0x23382A0", Offset = "0x2336EA0", VA = "0x1823382A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027FD0 RID: 163792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD0")]
		[Address(RVA = "0x2338060", Offset = "0x2336C60", VA = "0x182338060")]
		public void Render(int index, UIItemViewModel itemViewModel, bool isReceived)
		{
		}

		// Token: 0x06027FD1 RID: 163793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD1")]
		[Address(RVA = "0x23384B0", Offset = "0x23370B0", VA = "0x1823384B0")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x06027FD2 RID: 163794 RVA: 0x000D0440 File Offset: 0x000CE640
		[Token(Token = "0x6027FD2")]
		[Address(RVA = "0x2337FB0", Offset = "0x2336BB0", VA = "0x182337FB0")]
		public static float GetHashString(string hashId)
		{
			return 0f;
		}

		// Token: 0x06027FD3 RID: 163795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD3")]
		[Address(RVA = "0x23385A0", Offset = "0x23371A0", VA = "0x1823385A0")]
		public ActivityCommonCheckinItemObj()
		{
		}

		// Token: 0x04038ADA RID: 232154
		[Token(Token = "0x4038ADA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04038ADB RID: 232155
		[Token(Token = "0x4038ADB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x04038ADC RID: 232156
		[Token(Token = "0x4038ADC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _receiveImg;

		// Token: 0x04038ADD RID: 232157
		[Token(Token = "0x4038ADD")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x04038ADE RID: 232158
		[Token(Token = "0x4038ADE")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04038ADF RID: 232159
		[Token(Token = "0x4038ADF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038AE0 RID: 232160
		[Token(Token = "0x4038AE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038AE1 RID: 232161
		[Token(Token = "0x4038AE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04038AE2 RID: 232162
		[Token(Token = "0x4038AE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetHashString;

		// Token: 0x04038AE3 RID: 232163
		[Token(Token = "0x4038AE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
