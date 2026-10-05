using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006032 RID: 24626
	[Token(Token = "0x2006032")]
	public class CarvingMainBoardModel : IHotfixable
	{
		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x060239C6 RID: 145862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060239C7 RID: 145863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005414")]
		public CarvingInputMaterialModel inputMaterialModel
		{
			[Token(Token = "0x60239C6")]
			[Address(RVA = "0x1E46750", Offset = "0x1E45350", VA = "0x181E46750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60239C7")]
			[Address(RVA = "0x1E46870", Offset = "0x1E45470", VA = "0x181E46870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x060239C8 RID: 145864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060239C9 RID: 145865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005415")]
		public CarvingMainBoardOutputMaterialModel outputMaterialModel
		{
			[Token(Token = "0x60239C8")]
			[Address(RVA = "0x1E467B0", Offset = "0x1E453B0", VA = "0x181E467B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60239C9")]
			[Address(RVA = "0x1E468F0", Offset = "0x1E454F0", VA = "0x181E468F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x060239CA RID: 145866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060239CB RID: 145867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005416")]
		public CarvingTopInfoViewModel topInfoModel
		{
			[Token(Token = "0x60239CA")]
			[Address(RVA = "0x1E46810", Offset = "0x1E45410", VA = "0x181E46810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60239CB")]
			[Address(RVA = "0x1E46970", Offset = "0x1E45570", VA = "0x181E46970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060239CC RID: 145868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239CC")]
		[Address(RVA = "0x1E460D0", Offset = "0x1E44CD0", VA = "0x181E460D0")]
		public void LoadData(string actId, Act35SideData actData)
		{
		}

		// Token: 0x060239CD RID: 145869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239CD")]
		[Address(RVA = "0x1E46170", Offset = "0x1E44D70", VA = "0x181E46170")]
		public void UpdateData()
		{
		}

		// Token: 0x060239CE RID: 145870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239CE")]
		[Address(RVA = "0x1E46400", Offset = "0x1E45000", VA = "0x181E46400")]
		public void UpdateOutputMaterialData(ListDict<string, CarvingMainCardViewModel> slotCardList)
		{
		}

		// Token: 0x060239CF RID: 145871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239CF")]
		[Address(RVA = "0x1E466F0", Offset = "0x1E452F0", VA = "0x181E466F0")]
		public CarvingMainBoardModel()
		{
		}

		// Token: 0x040314DB RID: 201947
		[Token(Token = "0x40314DB")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x040314DC RID: 201948
		[Token(Token = "0x40314DC")]
		[FieldOffset(Offset = "0x30")]
		private Act35SideData m_actData;

		// Token: 0x040314DD RID: 201949
		[Token(Token = "0x40314DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inputMaterialModel;

		// Token: 0x040314DE RID: 201950
		[Token(Token = "0x40314DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_inputMaterialModel;

		// Token: 0x040314DF RID: 201951
		[Token(Token = "0x40314DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_outputMaterialModel;

		// Token: 0x040314E0 RID: 201952
		[Token(Token = "0x40314E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_outputMaterialModel;

		// Token: 0x040314E1 RID: 201953
		[Token(Token = "0x40314E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_topInfoModel;

		// Token: 0x040314E2 RID: 201954
		[Token(Token = "0x40314E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_topInfoModel;

		// Token: 0x040314E3 RID: 201955
		[Token(Token = "0x40314E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040314E4 RID: 201956
		[Token(Token = "0x40314E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040314E5 RID: 201957
		[Token(Token = "0x40314E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateOutputMaterialData;

		// Token: 0x040314E6 RID: 201958
		[Token(Token = "0x40314E6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
