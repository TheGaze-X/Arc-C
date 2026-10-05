using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004157 RID: 16727
	[Token(Token = "0x2004157")]
	public class SandboxV2BasementUpgradeViewModel : IHotfixable
	{
		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x06019D40 RID: 105792 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019D41 RID: 105793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D90")]
		public string topicId
		{
			[Token(Token = "0x6019D40")]
			[Address(RVA = "0x12A7450", Offset = "0x12A6050", VA = "0x1812A7450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019D41")]
			[Address(RVA = "0x12A74B0", Offset = "0x12A60B0", VA = "0x1812A74B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x06019D42 RID: 105794 RVA: 0x0009F6F0 File Offset: 0x0009D8F0
		[Token(Token = "0x17003D91")]
		public int currentLevel
		{
			[Token(Token = "0x6019D42")]
			[Address(RVA = "0x12A7330", Offset = "0x12A5F30", VA = "0x1812A7330")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x06019D43 RID: 105795 RVA: 0x0009F708 File Offset: 0x0009D908
		[Token(Token = "0x17003D92")]
		public int nextBaseLevel
		{
			[Token(Token = "0x6019D43")]
			[Address(RVA = "0x12A73F0", Offset = "0x12A5FF0", VA = "0x1812A73F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x06019D44 RID: 105796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D93")]
		public SandboxV2BaseUpdateData currentUpdateData
		{
			[Token(Token = "0x6019D44")]
			[Address(RVA = "0x12A7390", Offset = "0x12A5F90", VA = "0x1812A7390")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019D45 RID: 105797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D45")]
		[Address(RVA = "0x12A5F80", Offset = "0x12A4B80", VA = "0x1812A5F80")]
		public void LoadData(string topic)
		{
		}

		// Token: 0x06019D46 RID: 105798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D46")]
		[Address(RVA = "0x12A6860", Offset = "0x12A5460", VA = "0x1812A6860")]
		private void _GenUpgradeItemList()
		{
		}

		// Token: 0x06019D47 RID: 105799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D47")]
		[Address(RVA = "0x12A6C60", Offset = "0x12A5860", VA = "0x1812A6C60")]
		private void _GenUpgradePreviewGroupList()
		{
		}

		// Token: 0x06019D48 RID: 105800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D48")]
		[Address(RVA = "0x12A6590", Offset = "0x12A5190", VA = "0x1812A6590")]
		private void _GenUpgradeConditionList()
		{
		}

		// Token: 0x06019D49 RID: 105801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D49")]
		[Address(RVA = "0x12A7190", Offset = "0x12A5D90", VA = "0x1812A7190")]
		public SandboxV2BasementUpgradeViewModel()
		{
		}

		// Token: 0x040206EF RID: 132847
		[Token(Token = "0x40206EF")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2BaseUpdateData> updateData;

		// Token: 0x040206F0 RID: 132848
		[Token(Token = "0x40206F0")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSandboxV2 playerData;

		// Token: 0x040206F1 RID: 132849
		[Token(Token = "0x40206F1")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2BasementUpgradeResourceViewModel> updateItemList;

		// Token: 0x040206F2 RID: 132850
		[Token(Token = "0x40206F2")]
		[FieldOffset(Offset = "0x30")]
		public List<SandboxV2BasementUpgradePreviewGroupViewModel> updatePreviewGroupList;

		// Token: 0x040206F3 RID: 132851
		[Token(Token = "0x40206F3")]
		[FieldOffset(Offset = "0x38")]
		public List<SandboxV2BasementUpgradeConditionViewModel> updateConditionList;

		// Token: 0x040206F4 RID: 132852
		[Token(Token = "0x40206F4")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<int, SandboxV2BasementUpgradePreviewGroupViewModel> updatePreviewDict;

		// Token: 0x040206F5 RID: 132853
		[Token(Token = "0x40206F5")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2BaseUpdateData m_currentUpdateData;

		// Token: 0x040206F6 RID: 132854
		[Token(Token = "0x40206F6")]
		[FieldOffset(Offset = "0x50")]
		private int m_currentBaseLevel;

		// Token: 0x040206F7 RID: 132855
		[Token(Token = "0x40206F7")]
		[FieldOffset(Offset = "0x54")]
		private int m_nextBaseLevel;

		// Token: 0x040206F8 RID: 132856
		[Token(Token = "0x40206F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040206F9 RID: 132857
		[Token(Token = "0x40206F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x040206FA RID: 132858
		[Token(Token = "0x40206FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentLevel;

		// Token: 0x040206FB RID: 132859
		[Token(Token = "0x40206FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nextBaseLevel;

		// Token: 0x040206FC RID: 132860
		[Token(Token = "0x40206FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currentUpdateData;

		// Token: 0x040206FD RID: 132861
		[Token(Token = "0x40206FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040206FE RID: 132862
		[Token(Token = "0x40206FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenUpgradeItemList;

		// Token: 0x040206FF RID: 132863
		[Token(Token = "0x40206FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenUpgradePreviewGroupList;

		// Token: 0x04020700 RID: 132864
		[Token(Token = "0x4020700")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenUpgradeConditionList;

		// Token: 0x04020701 RID: 132865
		[Token(Token = "0x4020701")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
