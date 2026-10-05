using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE5 RID: 23525
	[Token(Token = "0x2005BE5")]
	public abstract class TemplateCharSelectShuffleViewModel : IHotfixable
	{
		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x060221B5 RID: 139701
		[Token(Token = "0x17004FD5")]
		public abstract CharacterSortType sortType { [Token(Token = "0x60221B5")] get; }

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x060221B6 RID: 139702
		[Token(Token = "0x17004FD6")]
		public abstract CharacterProfessionFilterViewModel profFilter { [Token(Token = "0x60221B6")] get; }

		// Token: 0x060221B7 RID: 139703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221B7")]
		[Address(RVA = "0x1C9EBE0", Offset = "0x1C9D7E0", VA = "0x181C9EBE0")]
		public void Reset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x060221B8 RID: 139704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221B8")]
		[Address(RVA = "0x1C9ECB0", Offset = "0x1C9D8B0", VA = "0x181C9ECB0", Slot = "6")]
		public virtual void Resume()
		{
		}

		// Token: 0x060221B9 RID: 139705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221B9")]
		[Address(RVA = "0x1C9EB60", Offset = "0x1C9D760", VA = "0x181C9EB60", Slot = "7")]
		public virtual void OnReset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x060221BA RID: 139706 RVA: 0x000BC580 File Offset: 0x000BA780
		[Token(Token = "0x60221BA")]
		[Address(RVA = "0x1C9EAF0", Offset = "0x1C9D6F0", VA = "0x181C9EAF0", Slot = "8")]
		public virtual bool FilterChar(TemplateCharSelectCardViewModel charViewModel)
		{
			return default(bool);
		}

		// Token: 0x060221BB RID: 139707 RVA: 0x000BC598 File Offset: 0x000BA798
		[Token(Token = "0x60221BB")]
		[Address(RVA = "0x1C9ED10", Offset = "0x1C9D910", VA = "0x181C9ED10", Slot = "9")]
		public virtual int SortChar(TemplateCharSelectCardViewModel a, TemplateCharSelectCardViewModel b)
		{
			return 0;
		}

		// Token: 0x060221BC RID: 139708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221BC")]
		[Address(RVA = "0x1C9EDA0", Offset = "0x1C9D9A0", VA = "0x181C9EDA0")]
		protected TemplateCharSelectShuffleViewModel()
		{
		}

		// Token: 0x0402EC6D RID: 191597
		[Token(Token = "0x402EC6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402EC6E RID: 191598
		[Token(Token = "0x402EC6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Resume;

		// Token: 0x0402EC6F RID: 191599
		[Token(Token = "0x402EC6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0402EC70 RID: 191600
		[Token(Token = "0x402EC70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FilterChar;

		// Token: 0x0402EC71 RID: 191601
		[Token(Token = "0x402EC71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SortChar;

		// Token: 0x0402EC72 RID: 191602
		[Token(Token = "0x402EC72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
