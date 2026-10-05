using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B0 RID: 6576
	[Token(Token = "0x20019B0")]
	public class DIYViewListGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A52E RID: 42286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52E")]
		[Address(RVA = "0x31FB9B0", Offset = "0x31FA5B0", VA = "0x1831FB9B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52F")]
		[Address(RVA = "0x31FB8B0", Offset = "0x31FA4B0", VA = "0x1831FB8B0")]
		public void Setup(bool isThemeListView)
		{
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A530")]
		[Address(RVA = "0x31FB800", Offset = "0x31FA400", VA = "0x1831FB800")]
		public void SavePos()
		{
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A531")]
		[Address(RVA = "0x31FB480", Offset = "0x31FA080", VA = "0x1831FB480")]
		public void Render(DIYViewListModel viewListModel, int themeStateChangeDirection)
		{
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A532")]
		[Address(RVA = "0x31FBA30", Offset = "0x31FA630", VA = "0x1831FBA30")]
		public DIYViewListGroup()
		{
		}

		// Token: 0x04009C94 RID: 40084
		[Token(Token = "0x4009C94")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYListView _verticalView;

		// Token: 0x04009C95 RID: 40085
		[Token(Token = "0x4009C95")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYListView _horizontalView;

		// Token: 0x04009C96 RID: 40086
		[Token(Token = "0x4009C96")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlListview;

		// Token: 0x04009C97 RID: 40087
		[Token(Token = "0x4009C97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlEmpty;

		// Token: 0x04009C98 RID: 40088
		[Token(Token = "0x4009C98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEmpty;

		// Token: 0x04009C99 RID: 40089
		[Token(Token = "0x4009C99")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> onButtonPressed;

		// Token: 0x04009C9A RID: 40090
		[Token(Token = "0x4009C9A")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> onInfoPressed;

		// Token: 0x04009C9B RID: 40091
		[Token(Token = "0x4009C9B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInit;

		// Token: 0x04009C9C RID: 40092
		[Token(Token = "0x4009C9C")]
		[FieldOffset(Offset = "0x54")]
		private float m_cachedPos;

		// Token: 0x04009C9D RID: 40093
		[Token(Token = "0x4009C9D")]
		[FieldOffset(Offset = "0x58")]
		private DIYViewListModel.UIExpandListState m_cachedExpandedState;

		// Token: 0x04009C9E RID: 40094
		[Token(Token = "0x4009C9E")]
		[FieldOffset(Offset = "0x60")]
		private DIYListView m_cachedListView;

		// Token: 0x04009C9F RID: 40095
		[Token(Token = "0x4009C9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009CA0 RID: 40096
		[Token(Token = "0x4009CA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009CA1 RID: 40097
		[Token(Token = "0x4009CA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SavePos;

		// Token: 0x04009CA2 RID: 40098
		[Token(Token = "0x4009CA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04009CA3 RID: 40099
		[Token(Token = "0x4009CA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
