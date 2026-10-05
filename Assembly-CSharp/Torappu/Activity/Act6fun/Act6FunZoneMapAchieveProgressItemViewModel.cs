using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B6 RID: 29110
	[Token(Token = "0x20071B6")]
	public class Act6FunZoneMapAchieveProgressItemViewModel : IHotfixable
	{
		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x060294F0 RID: 169200 RVA: 0x000D54B0 File Offset: 0x000D36B0
		// (set) Token: 0x060294F1 RID: 169201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C9")]
		public float progress
		{
			[Token(Token = "0x60294F0")]
			[Address(RVA = "0x24B16C0", Offset = "0x24B02C0", VA = "0x1824B16C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60294F1")]
			[Address(RVA = "0x24B1790", Offset = "0x24B0390", VA = "0x1824B1790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x060294F2 RID: 169202 RVA: 0x000D54C8 File Offset: 0x000D36C8
		// (set) Token: 0x060294F3 RID: 169203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061CA")]
		public int maxCount
		{
			[Token(Token = "0x60294F2")]
			[Address(RVA = "0x24B1660", Offset = "0x24B0260", VA = "0x1824B1660")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60294F3")]
			[Address(RVA = "0x24B1720", Offset = "0x24B0320", VA = "0x1824B1720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060294F4 RID: 169204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294F4")]
		[Address(RVA = "0x24B14A0", Offset = "0x24B00A0", VA = "0x1824B14A0")]
		public void LoadData(int maxCnt)
		{
		}

		// Token: 0x060294F5 RID: 169205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294F5")]
		[Address(RVA = "0x24B1540", Offset = "0x24B0140", VA = "0x1824B1540")]
		public void RefreshData(float itemProgress)
		{
		}

		// Token: 0x060294F6 RID: 169206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294F6")]
		[Address(RVA = "0x24B1600", Offset = "0x24B0200", VA = "0x1824B1600")]
		public Act6FunZoneMapAchieveProgressItemViewModel()
		{
		}

		// Token: 0x0403AFD4 RID: 241620
		[Token(Token = "0x403AFD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0403AFD5 RID: 241621
		[Token(Token = "0x403AFD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_progress;

		// Token: 0x0403AFD6 RID: 241622
		[Token(Token = "0x403AFD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxCount;

		// Token: 0x0403AFD7 RID: 241623
		[Token(Token = "0x403AFD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_maxCount;

		// Token: 0x0403AFD8 RID: 241624
		[Token(Token = "0x403AFD8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AFD9 RID: 241625
		[Token(Token = "0x403AFD9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403AFDA RID: 241626
		[Token(Token = "0x403AFDA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
