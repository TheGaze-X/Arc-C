using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004097 RID: 16535
	[Token(Token = "0x2004097")]
	public class SandboxV2AdminMainCookPanelModel : IHotfixable
	{
		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x06019953 RID: 104787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019954 RID: 104788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D0C")]
		public string topicId
		{
			[Token(Token = "0x6019953")]
			[Address(RVA = "0x1245530", Offset = "0x1244130", VA = "0x181245530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019954")]
			[Address(RVA = "0x12456F0", Offset = "0x12442F0", VA = "0x1812456F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x06019955 RID: 104789 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019956 RID: 104790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D0D")]
		public SandboxV2AdminMainCookInitParam initParam
		{
			[Token(Token = "0x6019955")]
			[Address(RVA = "0x1245470", Offset = "0x1244070", VA = "0x181245470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019956")]
			[Address(RVA = "0x1245600", Offset = "0x1244200", VA = "0x181245600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x06019957 RID: 104791 RVA: 0x0009EB68 File Offset: 0x0009CD68
		// (set) Token: 0x06019958 RID: 104792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D0E")]
		public SandboxV2AdminMainCookType currCookType
		{
			[Token(Token = "0x6019957")]
			[Address(RVA = "0x1245410", Offset = "0x1244010", VA = "0x181245410")]
			[CompilerGenerated]
			get
			{
				return SandboxV2AdminMainCookType.NONE;
			}
			[Token(Token = "0x6019958")]
			[Address(RVA = "0x1245590", Offset = "0x1244190", VA = "0x181245590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x06019959 RID: 104793 RVA: 0x0009EB80 File Offset: 0x0009CD80
		// (set) Token: 0x0601995A RID: 104794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D0F")]
		public bool initShow
		{
			[Token(Token = "0x6019959")]
			[Address(RVA = "0x12454D0", Offset = "0x12440D0", VA = "0x1812454D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601995A")]
			[Address(RVA = "0x1245680", Offset = "0x1244280", VA = "0x181245680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601995B RID: 104795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601995B")]
		[Address(RVA = "0x1244930", Offset = "0x1243530", VA = "0x181244930")]
		public void LoadData(string topicId, SandboxV2AdminMainCookInitParam initParam)
		{
		}

		// Token: 0x0601995C RID: 104796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601995C")]
		[Address(RVA = "0x1244C80", Offset = "0x1243880", VA = "0x181244C80")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601995D RID: 104797 RVA: 0x0009EB98 File Offset: 0x0009CD98
		[Token(Token = "0x601995D")]
		[Address(RVA = "0x1244880", Offset = "0x1243480", VA = "0x181244880")]
		public bool CheckTypeActive(SandboxV2AdminMainCookType type)
		{
			return default(bool);
		}

		// Token: 0x0601995E RID: 104798 RVA: 0x0009EBB0 File Offset: 0x0009CDB0
		[Token(Token = "0x601995E")]
		[Address(RVA = "0x1244F50", Offset = "0x1243B50", VA = "0x181244F50")]
		public bool SetCookType(SandboxV2AdminMainCookType cookType, bool init = false)
		{
			return default(bool);
		}

		// Token: 0x0601995F RID: 104799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601995F")]
		[Address(RVA = "0x12452F0", Offset = "0x1243EF0", VA = "0x1812452F0")]
		public SandboxV2AdminMainCookPanelModel()
		{
		}

		// Token: 0x0401FF08 RID: 130824
		[Token(Token = "0x401FF08")]
		[FieldOffset(Offset = "0x28")]
		public readonly SandboxV2CookDrinkModel drinkModel;

		// Token: 0x0401FF09 RID: 130825
		[Token(Token = "0x401FF09")]
		[FieldOffset(Offset = "0x30")]
		public readonly SandboxV2CookFoodListModel foodListModel;

		// Token: 0x0401FF0A RID: 130826
		[Token(Token = "0x401FF0A")]
		[FieldOffset(Offset = "0x38")]
		public readonly SandboxV2CookFreeCookModel freeCookModel;

		// Token: 0x0401FF0B RID: 130827
		[Token(Token = "0x401FF0B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_drinkActive;

		// Token: 0x0401FF0C RID: 130828
		[Token(Token = "0x401FF0C")]
		[FieldOffset(Offset = "0x41")]
		private bool m_drinkDirty;

		// Token: 0x0401FF0D RID: 130829
		[Token(Token = "0x401FF0D")]
		[FieldOffset(Offset = "0x42")]
		private bool m_foodListActive;

		// Token: 0x0401FF0E RID: 130830
		[Token(Token = "0x401FF0E")]
		[FieldOffset(Offset = "0x43")]
		private bool m_foodListDirty;

		// Token: 0x0401FF0F RID: 130831
		[Token(Token = "0x401FF0F")]
		[FieldOffset(Offset = "0x44")]
		private bool m_freeCookActive;

		// Token: 0x0401FF10 RID: 130832
		[Token(Token = "0x401FF10")]
		[FieldOffset(Offset = "0x45")]
		private bool m_freeCookDirty;

		// Token: 0x0401FF11 RID: 130833
		[Token(Token = "0x401FF11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401FF12 RID: 130834
		[Token(Token = "0x401FF12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0401FF13 RID: 130835
		[Token(Token = "0x401FF13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initParam;

		// Token: 0x0401FF14 RID: 130836
		[Token(Token = "0x401FF14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_initParam;

		// Token: 0x0401FF15 RID: 130837
		[Token(Token = "0x401FF15")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currCookType;

		// Token: 0x0401FF16 RID: 130838
		[Token(Token = "0x401FF16")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_currCookType;

		// Token: 0x0401FF17 RID: 130839
		[Token(Token = "0x401FF17")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_initShow;

		// Token: 0x0401FF18 RID: 130840
		[Token(Token = "0x401FF18")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_initShow;

		// Token: 0x0401FF19 RID: 130841
		[Token(Token = "0x401FF19")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401FF1A RID: 130842
		[Token(Token = "0x401FF1A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0401FF1B RID: 130843
		[Token(Token = "0x401FF1B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckTypeActive;

		// Token: 0x0401FF1C RID: 130844
		[Token(Token = "0x401FF1C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetCookType;

		// Token: 0x0401FF1D RID: 130845
		[Token(Token = "0x401FF1D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
