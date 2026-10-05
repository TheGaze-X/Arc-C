using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F59 RID: 28505
	[Token(Token = "0x2006F59")]
	public class ActMultiV3AlbumRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287AF RID: 165807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287AF")]
		[Address(RVA = "0x23BEF10", Offset = "0x23BDB10", VA = "0x1823BEF10")]
		public void Render(ItemBundle item, int position, bool hasRecieved)
		{
		}

		// Token: 0x060287B0 RID: 165808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B0")]
		[Address(RVA = "0x23BF150", Offset = "0x23BDD50", VA = "0x1823BF150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287B1 RID: 165809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B1")]
		[Address(RVA = "0x23BF060", Offset = "0x23BDC60", VA = "0x1823BF060")]
		private void _EventOnItemClicked(int index)
		{
		}

		// Token: 0x060287B2 RID: 165810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B2")]
		[Address(RVA = "0x23BF370", Offset = "0x23BDF70", VA = "0x1823BF370")]
		public ActMultiV3AlbumRewardItemView()
		{
		}

		// Token: 0x04039961 RID: 235873
		[Token(Token = "0x4039961")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04039962 RID: 235874
		[Token(Token = "0x4039962")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color _itemCardNormalColor;

		// Token: 0x04039963 RID: 235875
		[Token(Token = "0x4039963")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _itemCardRecievedColor;

		// Token: 0x04039964 RID: 235876
		[Token(Token = "0x4039964")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _itemCardRoot;

		// Token: 0x04039965 RID: 235877
		[Token(Token = "0x4039965")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _recievedMaskGo;

		// Token: 0x04039966 RID: 235878
		[Token(Token = "0x4039966")]
		[FieldOffset(Offset = "0x50")]
		private UIItemCard m_itemCard;

		// Token: 0x04039967 RID: 235879
		[Token(Token = "0x4039967")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04039968 RID: 235880
		[Token(Token = "0x4039968")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039969 RID: 235881
		[Token(Token = "0x4039969")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403996A RID: 235882
		[Token(Token = "0x403996A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x0403996B RID: 235883
		[Token(Token = "0x403996B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
