using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.UniEquip;
using UnityEngine;
using XLua;

namespace Torappu.Scripts.UI.UniEquip
{
	// Token: 0x02001799 RID: 6041
	[Token(Token = "0x2001799")]
	public class UniEquipShowPage : UIPage
	{
		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060098BF RID: 39103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001069")]
		public UniEquipShowView showView
		{
			[Token(Token = "0x60098BF")]
			[Address(RVA = "0x314DDC0", Offset = "0x314C9C0", VA = "0x18314DDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C0")]
		[Address(RVA = "0x314DBD0", Offset = "0x314C7D0", VA = "0x18314DBD0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098C1")]
		[Address(RVA = "0x314DCA0", Offset = "0x314C8A0", VA = "0x18314DCA0", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098C2")]
		[Address(RVA = "0x314DA30", Offset = "0x314C630", VA = "0x18314DA30", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C3")]
		[Address(RVA = "0x314DB70", Offset = "0x314C770", VA = "0x18314DB70")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C4")]
		[Address(RVA = "0x314DB10", Offset = "0x314C710", VA = "0x18314DB10")]
		public void OnBlankClick()
		{
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C5")]
		[Address(RVA = "0x314DD60", Offset = "0x314C960", VA = "0x18314DD60")]
		public UniEquipShowPage()
		{
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C6")]
		[Address(RVA = "0xE98780", Offset = "0xE97380", VA = "0x180E98780")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098C7")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098C8")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04008EC2 RID: 36546
		[Token(Token = "0x4008EC2")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UniEquipShowView _showViewPrefab;

		// Token: 0x04008EC3 RID: 36547
		[Token(Token = "0x4008EC3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x04008EC4 RID: 36548
		[Token(Token = "0x4008EC4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private EffectLightInstHolder _effectLightInstHolder;

		// Token: 0x04008EC5 RID: 36549
		[Token(Token = "0x4008EC5")]
		[FieldOffset(Offset = "0xF0")]
		private UniEquipShowView m_uniEquipShowView;

		// Token: 0x04008EC6 RID: 36550
		[Token(Token = "0x4008EC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showView;

		// Token: 0x04008EC7 RID: 36551
		[Token(Token = "0x4008EC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04008EC8 RID: 36552
		[Token(Token = "0x4008EC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04008EC9 RID: 36553
		[Token(Token = "0x4008EC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04008ECA RID: 36554
		[Token(Token = "0x4008ECA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x04008ECB RID: 36555
		[Token(Token = "0x4008ECB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBlankClick;

		// Token: 0x04008ECC RID: 36556
		[Token(Token = "0x4008ECC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200179A RID: 6042
		[Token(Token = "0x200179A")]
		public struct Params
		{
			// Token: 0x04008ECD RID: 36557
			[Token(Token = "0x4008ECD")]
			[FieldOffset(Offset = "0x0")]
			public UniEquipData uniEquipData;

			// Token: 0x04008ECE RID: 36558
			[Token(Token = "0x4008ECE")]
			[FieldOffset(Offset = "0x8")]
			public string subProfessionId;
		}
	}
}
