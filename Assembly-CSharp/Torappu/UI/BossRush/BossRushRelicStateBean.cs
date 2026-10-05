using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200618B RID: 24971
	[Token(Token = "0x200618B")]
	public class BossRushRelicStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x06024053 RID: 147539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024054 RID: 147540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005502")]
		public string actId
		{
			[Token(Token = "0x6024053")]
			[Address(RVA = "0x1EA6150", Offset = "0x1EA4D50", VA = "0x181EA6150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024054")]
			[Address(RVA = "0x1EA62E0", Offset = "0x1EA4EE0", VA = "0x181EA62E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x06024055 RID: 147541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005503")]
		public string tokenName
		{
			[Token(Token = "0x6024055")]
			[Address(RVA = "0x1EA6240", Offset = "0x1EA4E40", VA = "0x181EA6240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x06024056 RID: 147542 RVA: 0x000C2C88 File Offset: 0x000C0E88
		[Token(Token = "0x17005504")]
		public int tokenCurCount
		{
			[Token(Token = "0x6024056")]
			[Address(RVA = "0x1EA61B0", Offset = "0x1EA4DB0", VA = "0x181EA61B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06024057 RID: 147543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024057")]
		[Address(RVA = "0x1EA5BF0", Offset = "0x1EA47F0", VA = "0x181EA5BF0")]
		public void LoadData(string aId)
		{
		}

		// Token: 0x06024058 RID: 147544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024058")]
		[Address(RVA = "0x1EA5F30", Offset = "0x1EA4B30", VA = "0x181EA5F30")]
		public void UpdateChange(bool refreshSelect)
		{
		}

		// Token: 0x06024059 RID: 147545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024059")]
		[Address(RVA = "0x1EA5D40", Offset = "0x1EA4940", VA = "0x181EA5D40")]
		public void SwitchRelic(string relicId)
		{
		}

		// Token: 0x0602405A RID: 147546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602405A")]
		[Address(RVA = "0x1EA5B60", Offset = "0x1EA4760", VA = "0x181EA5B60")]
		public BossRushRelicNodeModel GetSelectingRelicNodeModel()
		{
			return null;
		}

		// Token: 0x0602405B RID: 147547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602405B")]
		[Address(RVA = "0x1EA5A70", Offset = "0x1EA4670", VA = "0x181EA5A70")]
		public string GetSelectingRelicId()
		{
			return null;
		}

		// Token: 0x0602405C RID: 147548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602405C")]
		[Address(RVA = "0x1EA6060", Offset = "0x1EA4C60", VA = "0x181EA6060")]
		public BossRushRelicStateBean()
		{
		}

		// Token: 0x040320B2 RID: 204978
		[Token(Token = "0x40320B2")]
		[FieldOffset(Offset = "0x10")]
		public BossRushRelicViewProperty viewProperty;

		// Token: 0x040320B4 RID: 204980
		[Token(Token = "0x40320B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040320B5 RID: 204981
		[Token(Token = "0x40320B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x040320B6 RID: 204982
		[Token(Token = "0x40320B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tokenName;

		// Token: 0x040320B7 RID: 204983
		[Token(Token = "0x40320B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_tokenCurCount;

		// Token: 0x040320B8 RID: 204984
		[Token(Token = "0x40320B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040320B9 RID: 204985
		[Token(Token = "0x40320B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateChange;

		// Token: 0x040320BA RID: 204986
		[Token(Token = "0x40320BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SwitchRelic;

		// Token: 0x040320BB RID: 204987
		[Token(Token = "0x40320BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSelectingRelicNodeModel;

		// Token: 0x040320BC RID: 204988
		[Token(Token = "0x40320BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetSelectingRelicId;

		// Token: 0x040320BD RID: 204989
		[Token(Token = "0x40320BD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
