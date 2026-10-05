using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200768D RID: 30349
	[Token(Token = "0x200768D")]
	public class Act20sideSquadHomeCartPluginView : SquadHomePluginView
	{
		// Token: 0x0602AAFC RID: 174844 RVA: 0x000D9638 File Offset: 0x000D7838
		[Token(Token = "0x602AAFC")]
		[Address(RVA = "0x267B150", Offset = "0x2679D50", VA = "0x18267B150", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602AAFD RID: 174845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAFD")]
		[Address(RVA = "0x267B0B0", Offset = "0x2679CB0", VA = "0x18267B0B0", Slot = "9")]
		protected override void OnSquadGroupChanged(SquadGroupViewModel groupModel)
		{
		}

		// Token: 0x0602AAFE RID: 174846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAFE")]
		[Address(RVA = "0x267B1B0", Offset = "0x2679DB0", VA = "0x18267B1B0", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0602AAFF RID: 174847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAFF")]
		[Address(RVA = "0x267AD70", Offset = "0x2679970", VA = "0x18267AD70")]
		public void EventOnCartBtnClick()
		{
		}

		// Token: 0x0602AB00 RID: 174848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB00")]
		[Address(RVA = "0x267AEF0", Offset = "0x2679AF0", VA = "0x18267AEF0")]
		public void EventOnCartPresentationBtnClick()
		{
		}

		// Token: 0x0602AB01 RID: 174849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB01")]
		[Address(RVA = "0x267C0A0", Offset = "0x267ACA0", VA = "0x18267C0A0")]
		private void _TryUpdateLeftArrowStatus(SquadGroupViewModel squadGroupModel, string stageId, bool canUseCart)
		{
		}

		// Token: 0x0602AB02 RID: 174850 RVA: 0x000D9650 File Offset: 0x000D7850
		[Token(Token = "0x602AB02")]
		[Address(RVA = "0x267BF20", Offset = "0x267AB20", VA = "0x18267BF20")]
		private static bool _TryGetCartCompSprite(Dictionary<CartComponents.CartAccessoryPos, string> cartComponentsDict, CartComponents.CartAccessoryPos accessoryPos, out Sprite compIcon)
		{
			return default(bool);
		}

		// Token: 0x0602AB03 RID: 174851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB03")]
		[Address(RVA = "0x267C1A0", Offset = "0x267ADA0", VA = "0x18267C1A0")]
		public Act20sideSquadHomeCartPluginView()
		{
		}

		// Token: 0x0602AB04 RID: 174852 RVA: 0x000D9668 File Offset: 0x000D7868
		[Token(Token = "0x602AB04")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602AB05 RID: 174853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB05")]
		[Address(RVA = "0x1EB7190", Offset = "0x1EB5D90", VA = "0x181EB7190")]
		private void <>xLuaBaseProxy_OnSquadGroupChanged(SquadGroupViewModel P0)
		{
		}

		// Token: 0x0403D7FE RID: 251902
		[Token(Token = "0x403D7FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgPartRoof;

		// Token: 0x0403D7FF RID: 251903
		[Token(Token = "0x403D7FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgPartFront;

		// Token: 0x0403D800 RID: 251904
		[Token(Token = "0x403D800")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgPartTrunk1;

		// Token: 0x0403D801 RID: 251905
		[Token(Token = "0x403D801")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgPartTrunk2;

		// Token: 0x0403D802 RID: 251906
		[Token(Token = "0x403D802")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgPartOS1;

		// Token: 0x0403D803 RID: 251907
		[Token(Token = "0x403D803")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgPartOS2;

		// Token: 0x0403D804 RID: 251908
		[Token(Token = "0x403D804")]
		[FieldOffset(Offset = "0x60")]
		private bool m_canEdit;

		// Token: 0x0403D805 RID: 251909
		[Token(Token = "0x403D805")]
		[FieldOffset(Offset = "0x68")]
		private string m_stageId;

		// Token: 0x0403D806 RID: 251910
		[Token(Token = "0x403D806")]
		[FieldOffset(Offset = "0x70")]
		private bool m_canUseCart;

		// Token: 0x0403D807 RID: 251911
		[Token(Token = "0x403D807")]
		[FieldOffset(Offset = "0x71")]
		private bool m_isRetro;

		// Token: 0x0403D808 RID: 251912
		[Token(Token = "0x403D808")]
		[FieldOffset(Offset = "0x78")]
		private string m_groupId;

		// Token: 0x0403D809 RID: 251913
		[Token(Token = "0x403D809")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<CartComponents.CartAccessoryPos, string> m_cartDict;

		// Token: 0x0403D80A RID: 251914
		[Token(Token = "0x403D80A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403D80B RID: 251915
		[Token(Token = "0x403D80B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSquadGroupChanged;

		// Token: 0x0403D80C RID: 251916
		[Token(Token = "0x403D80C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403D80D RID: 251917
		[Token(Token = "0x403D80D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCartBtnClick;

		// Token: 0x0403D80E RID: 251918
		[Token(Token = "0x403D80E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCartPresentationBtnClick;

		// Token: 0x0403D80F RID: 251919
		[Token(Token = "0x403D80F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryUpdateLeftArrowStatus;

		// Token: 0x0403D810 RID: 251920
		[Token(Token = "0x403D810")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryGetCartCompSprite;

		// Token: 0x0403D811 RID: 251921
		[Token(Token = "0x403D811")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
