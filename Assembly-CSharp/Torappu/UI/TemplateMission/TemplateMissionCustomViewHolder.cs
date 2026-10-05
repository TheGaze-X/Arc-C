using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA1 RID: 15777
	[Token(Token = "0x2003DA1")]
	public class TemplateMissionCustomViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018888 RID: 100488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018888")]
		[Address(RVA = "0x1112600", Offset = "0x1111200", VA = "0x181112600")]
		public TemplateMissionBigRewardView GetCustomBigRewardView()
		{
			return null;
		}

		// Token: 0x06018889 RID: 100489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018889")]
		[Address(RVA = "0x1112840", Offset = "0x1111440", VA = "0x181112840")]
		public TemplateMissionTitleView GetCustomTitleView()
		{
			return null;
		}

		// Token: 0x0601888A RID: 100490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601888A")]
		[Address(RVA = "0x11126C0", Offset = "0x11112C0", VA = "0x1811126C0")]
		public TemplateMissionCoinInfoView GetCustomCoinInfoView()
		{
			return null;
		}

		// Token: 0x0601888B RID: 100491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601888B")]
		[Address(RVA = "0x1112660", Offset = "0x1111260", VA = "0x181112660")]
		public AbstractTemplateMissionItemClaimAllView GetCustomClaimAllBtnView()
		{
			return null;
		}

		// Token: 0x0601888C RID: 100492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601888C")]
		[Address(RVA = "0x1112720", Offset = "0x1111320", VA = "0x181112720")]
		public AbstractTemplateMissionItemNormalView GetCustomListItemNormalView()
		{
			return null;
		}

		// Token: 0x0601888D RID: 100493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601888D")]
		[Address(RVA = "0x11127E0", Offset = "0x11113E0", VA = "0x1811127E0")]
		public AbstractTemplateMissionRewardItemView GetCustomRewardItemView()
		{
			return null;
		}

		// Token: 0x0601888E RID: 100494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601888E")]
		[Address(RVA = "0x1112780", Offset = "0x1111380", VA = "0x181112780")]
		public TemplateMissionListView GetCustomListView()
		{
			return null;
		}

		// Token: 0x0601888F RID: 100495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601888F")]
		[Address(RVA = "0x11128A0", Offset = "0x11114A0", VA = "0x1811128A0")]
		public TemplateMissionCustomViewHolder()
		{
		}

		// Token: 0x0401E148 RID: 123208
		[Token(Token = "0x401E148")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateMissionBigRewardView _customBigRewardView;

		// Token: 0x0401E149 RID: 123209
		[Token(Token = "0x401E149")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateMissionTitleView _customTitleView;

		// Token: 0x0401E14A RID: 123210
		[Token(Token = "0x401E14A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TemplateMissionCoinInfoView _customCoinInfoView;

		// Token: 0x0401E14B RID: 123211
		[Token(Token = "0x401E14B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AbstractTemplateMissionItemClaimAllView _customClaimAllBtnView;

		// Token: 0x0401E14C RID: 123212
		[Token(Token = "0x401E14C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AbstractTemplateMissionItemNormalView _customItemNormalView;

		// Token: 0x0401E14D RID: 123213
		[Token(Token = "0x401E14D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AbstractTemplateMissionRewardItemView _customRewardItemView;

		// Token: 0x0401E14E RID: 123214
		[Token(Token = "0x401E14E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TemplateMissionListView _customListView;

		// Token: 0x0401E14F RID: 123215
		[Token(Token = "0x401E14F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCustomBigRewardView;

		// Token: 0x0401E150 RID: 123216
		[Token(Token = "0x401E150")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCustomTitleView;

		// Token: 0x0401E151 RID: 123217
		[Token(Token = "0x401E151")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCustomCoinInfoView;

		// Token: 0x0401E152 RID: 123218
		[Token(Token = "0x401E152")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCustomClaimAllBtnView;

		// Token: 0x0401E153 RID: 123219
		[Token(Token = "0x401E153")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCustomListItemNormalView;

		// Token: 0x0401E154 RID: 123220
		[Token(Token = "0x401E154")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCustomRewardItemView;

		// Token: 0x0401E155 RID: 123221
		[Token(Token = "0x401E155")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCustomListView;

		// Token: 0x0401E156 RID: 123222
		[Token(Token = "0x401E156")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
