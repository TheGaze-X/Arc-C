using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007319 RID: 29465
	[Token(Token = "0x2007319")]
	public class Act42SideGunTaskProgressStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17006277 RID: 25207
		// (get) Token: 0x06029AAC RID: 170668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029AAD RID: 170669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006277")]
		public string selectedTrustorId
		{
			[Token(Token = "0x6029AAC")]
			[Address(RVA = "0x250F680", Offset = "0x250E280", VA = "0x18250F680")]
			get
			{
				return null;
			}
			[Token(Token = "0x6029AAD")]
			[Address(RVA = "0x250F6E0", Offset = "0x250E2E0", VA = "0x18250F6E0")]
			set
			{
			}
		}

		// Token: 0x06029AAE RID: 170670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AAE")]
		[Address(RVA = "0x250F060", Offset = "0x250DC60", VA = "0x18250F060")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029AAF RID: 170671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AAF")]
		[Address(RVA = "0x250F4B0", Offset = "0x250E0B0", VA = "0x18250F4B0")]
		public void UpdateData(bool isEnter)
		{
		}

		// Token: 0x06029AB0 RID: 170672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AB0")]
		[Address(RVA = "0x250F280", Offset = "0x250DE80", VA = "0x18250F280")]
		public void OnSwitchTab(string trustorId)
		{
		}

		// Token: 0x06029AB1 RID: 170673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AB1")]
		[Address(RVA = "0x250F380", Offset = "0x250DF80", VA = "0x18250F380")]
		public void OnUpdateSelected(string selectedId)
		{
		}

		// Token: 0x06029AB2 RID: 170674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AB2")]
		[Address(RVA = "0x250F590", Offset = "0x250E190", VA = "0x18250F590")]
		public Act42SideGunTaskProgressStateBean()
		{
		}

		// Token: 0x0403B9B4 RID: 244148
		[Token(Token = "0x403B9B4")]
		[FieldOffset(Offset = "0x10")]
		public Act42SideGunTaskProgressProp prop;

		// Token: 0x0403B9B5 RID: 244149
		[Token(Token = "0x403B9B5")]
		[FieldOffset(Offset = "0x18")]
		private string m_selectedTrustorId;

		// Token: 0x0403B9B6 RID: 244150
		[Token(Token = "0x403B9B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTrustorId;

		// Token: 0x0403B9B7 RID: 244151
		[Token(Token = "0x403B9B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedTrustorId;

		// Token: 0x0403B9B8 RID: 244152
		[Token(Token = "0x403B9B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B9B9 RID: 244153
		[Token(Token = "0x403B9B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403B9BA RID: 244154
		[Token(Token = "0x403B9BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSwitchTab;

		// Token: 0x0403B9BB RID: 244155
		[Token(Token = "0x403B9BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnUpdateSelected;

		// Token: 0x0403B9BC RID: 244156
		[Token(Token = "0x403B9BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
