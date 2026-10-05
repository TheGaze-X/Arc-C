using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001948 RID: 6472
	[Token(Token = "0x2001948")]
	public class DIYShopGroupPanel : MonoBehaviour
	{
		// Token: 0x170012DF RID: 4831
		// (set) Token: 0x0600A2B9 RID: 41657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012DF")]
		public Action<DIYShopItemViewData> onFurnitureSelected
		{
			[Token(Token = "0x600A2B9")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BA")]
		[Address(RVA = "0x31C3760", Offset = "0x31C2360", VA = "0x1831C3760")]
		private void _OnFurnitureSelected(DIYShopItemViewData item)
		{
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BB")]
		[Address(RVA = "0x31C3780", Offset = "0x31C2380", VA = "0x1831C3780")]
		private void _RemoveAllGroupView()
		{
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2BC")]
		[Address(RVA = "0x31C4070", Offset = "0x31C2C70", VA = "0x1831C4070")]
		private IEnumerator _SwitchFadeCoroutine(string themeId, [Optional] Predicate<IDIYShopItem> filter, [Optional] Comparison<IDIYShopItem> sorter)
		{
			return null;
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BD")]
		[Address(RVA = "0x31C4140", Offset = "0x31C2D40", VA = "0x1831C4140")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BE")]
		[Address(RVA = "0x31C3AD0", Offset = "0x31C26D0", VA = "0x1831C3AD0")]
		private void _SetupView(string themeId, [Optional] Predicate<IDIYShopItem> filter, [Optional] Comparison<IDIYShopItem> sorter)
		{
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BF")]
		[Address(RVA = "0x31C3630", Offset = "0x31C2230", VA = "0x1831C3630")]
		public void Setup(string themeId, [Optional] Predicate<IDIYShopItem> filter, [Optional] Comparison<IDIYShopItem> sorter)
		{
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2C0")]
		[Address(RVA = "0x31C3260", Offset = "0x31C1E60", VA = "0x1831C3260")]
		public void Refresh()
		{
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2C1")]
		[Address(RVA = "0x31C4490", Offset = "0x31C3090", VA = "0x1831C4490")]
		public DIYShopGroupPanel()
		{
		}

		// Token: 0x04009929 RID: 39209
		[Token(Token = "0x4009929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x0400992A RID: 39210
		[Token(Token = "0x400992A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _positionHandler;

		// Token: 0x0400992B RID: 39211
		[Token(Token = "0x400992B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _groupViewProto;

		// Token: 0x0400992C RID: 39212
		[Token(Token = "0x400992C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400992D RID: 39213
		[Token(Token = "0x400992D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0400992E RID: 39214
		[Token(Token = "0x400992E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IFurnitureGroupDataProvider m_groupDataProvider;

		// Token: 0x0400992F RID: 39215
		[Token(Token = "0x400992F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine m_fadeCoroutine;

		// Token: 0x04009930 RID: 39216
		[Token(Token = "0x4009930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<DIYShopGroupItemView> m_groupViews;

		// Token: 0x04009931 RID: 39217
		[Token(Token = "0x4009931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<DIYShopItemViewData> m_onFurnitureSelected;
	}
}
