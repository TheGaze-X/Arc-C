using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F39 RID: 28473
	[Token(Token = "0x2006F39")]
	public class ActMultiV3MilestoneMainRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060286FC RID: 165628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286FC")]
		[Address(RVA = "0x23BA2C0", Offset = "0x23B8EC0", VA = "0x1823BA2C0")]
		public void Render(string itemId, string itemDesc)
		{
		}

		// Token: 0x060286FD RID: 165629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286FD")]
		[Address(RVA = "0x23BA6E0", Offset = "0x23B92E0", VA = "0x1823BA6E0")]
		private void _RenderSkin(string itemId)
		{
		}

		// Token: 0x060286FE RID: 165630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286FE")]
		[Address(RVA = "0x23BA600", Offset = "0x23B9200", VA = "0x1823BA600")]
		private void _RenderNormalItem(string itemId)
		{
		}

		// Token: 0x060286FF RID: 165631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286FF")]
		[Address(RVA = "0x23BA1E0", Offset = "0x23B8DE0", VA = "0x1823BA1E0")]
		public void OnCheckSkin()
		{
		}

		// Token: 0x06028700 RID: 165632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028700")]
		[Address(RVA = "0x23BA8C0", Offset = "0x23B94C0", VA = "0x1823BA8C0")]
		public ActMultiV3MilestoneMainRewardItemView()
		{
		}

		// Token: 0x0403985B RID: 235611
		[Token(Token = "0x403985B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ItemType _itemType;

		// Token: 0x0403985C RID: 235612
		[Token(Token = "0x403985C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403985D RID: 235613
		[Token(Token = "0x403985D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemTypeName;

		// Token: 0x0403985E RID: 235614
		[Token(Token = "0x403985E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemDesc;

		// Token: 0x0403985F RID: 235615
		[Token(Token = "0x403985F")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedItemId;

		// Token: 0x04039860 RID: 235616
		[Token(Token = "0x4039860")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039861 RID: 235617
		[Token(Token = "0x4039861")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039862 RID: 235618
		[Token(Token = "0x4039862")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSkin;

		// Token: 0x04039863 RID: 235619
		[Token(Token = "0x4039863")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNormalItem;

		// Token: 0x04039864 RID: 235620
		[Token(Token = "0x4039864")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCheckSkin;

		// Token: 0x04039865 RID: 235621
		[Token(Token = "0x4039865")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
