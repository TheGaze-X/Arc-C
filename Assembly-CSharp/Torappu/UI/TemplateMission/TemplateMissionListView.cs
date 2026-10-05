using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D9E RID: 15774
	[Token(Token = "0x2003D9E")]
	public abstract class TemplateMissionListView : TemplateMissionBaseView
	{
		// Token: 0x0601887F RID: 100479
		[Token(Token = "0x601887F")]
		public abstract void BindPrefabToListView(AbstractTemplateMissionItemClaimAllView claimAllViewPrefab, AbstractTemplateMissionItemNormalView itemNormalViewPrefab, AbstractTemplateMissionRewardItemView rewardItemViewPrefab);

		// Token: 0x06018880 RID: 100480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018880")]
		[Address(RVA = "0x11146F0", Offset = "0x11132F0", VA = "0x1811146F0")]
		protected TemplateMissionListView()
		{
		}

		// Token: 0x0401E13B RID: 123195
		[Token(Token = "0x401E13B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
