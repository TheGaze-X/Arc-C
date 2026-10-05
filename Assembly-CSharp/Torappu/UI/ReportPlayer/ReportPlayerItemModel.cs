using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ReportPlayer
{
	// Token: 0x020046E9 RID: 18153
	[Token(Token = "0x20046E9")]
	public class ReportPlayerItemModel : IHotfixable
	{
		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x0601B847 RID: 112711 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B848 RID: 112712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700418A")]
		public string id
		{
			[Token(Token = "0x601B847")]
			[Address(RVA = "0x14EF5F0", Offset = "0x14EE1F0", VA = "0x1814EF5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B848")]
			[Address(RVA = "0x14EF790", Offset = "0x14EE390", VA = "0x1814EF790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x0601B849 RID: 112713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B84A RID: 112714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700418B")]
		public string name
		{
			[Token(Token = "0x601B849")]
			[Address(RVA = "0x14EF650", Offset = "0x14EE250", VA = "0x1814EF650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B84A")]
			[Address(RVA = "0x14EF810", Offset = "0x14EE410", VA = "0x1814EF810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x0601B84B RID: 112715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B84C RID: 112716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700418C")]
		public string desc
		{
			[Token(Token = "0x601B84B")]
			[Address(RVA = "0x14EF590", Offset = "0x14EE190", VA = "0x1814EF590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B84C")]
			[Address(RVA = "0x14EF710", Offset = "0x14EE310", VA = "0x1814EF710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x0601B84D RID: 112717 RVA: 0x000A56D8 File Offset: 0x000A38D8
		// (set) Token: 0x0601B84E RID: 112718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700418D")]
		public int sortId
		{
			[Token(Token = "0x601B84D")]
			[Address(RVA = "0x14EF6B0", Offset = "0x14EE2B0", VA = "0x1814EF6B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B84E")]
			[Address(RVA = "0x14EF890", Offset = "0x14EE490", VA = "0x1814EF890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B84F RID: 112719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B84F")]
		[Address(RVA = "0x14EF350", Offset = "0x14EDF50", VA = "0x1814EF350")]
		public void LoadData(CommonReportPlayerData reportItemData)
		{
		}

		// Token: 0x0601B850 RID: 112720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B850")]
		[Address(RVA = "0x14EF530", Offset = "0x14EE130", VA = "0x1814EF530")]
		public ReportPlayerItemModel()
		{
		}

		// Token: 0x04023A6A RID: 146026
		[Token(Token = "0x4023A6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x04023A6B RID: 146027
		[Token(Token = "0x4023A6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_id;

		// Token: 0x04023A6C RID: 146028
		[Token(Token = "0x4023A6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04023A6D RID: 146029
		[Token(Token = "0x4023A6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x04023A6E RID: 146030
		[Token(Token = "0x4023A6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x04023A6F RID: 146031
		[Token(Token = "0x4023A6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x04023A70 RID: 146032
		[Token(Token = "0x4023A70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04023A71 RID: 146033
		[Token(Token = "0x4023A71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04023A72 RID: 146034
		[Token(Token = "0x4023A72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023A73 RID: 146035
		[Token(Token = "0x4023A73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
