using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C8 RID: 30920
	[Token(Token = "0x20078C8")]
	public abstract class Act1LockDetailModelBase : IHotfixable
	{
		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x0602B5C0 RID: 177600
		[Token(Token = "0x17006577")]
		public abstract ActivityInterlockData.InterlockStageType stageType { [Token(Token = "0x602B5C0")] get; }

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x0602B5C1 RID: 177601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006578")]
		public string stageId
		{
			[Token(Token = "0x602B5C1")]
			[Address(RVA = "0x271E510", Offset = "0x271D110", VA = "0x18271E510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x0602B5C2 RID: 177602 RVA: 0x000DB840 File Offset: 0x000D9A40
		[Token(Token = "0x17006579")]
		public bool isSelected
		{
			[Token(Token = "0x602B5C2")]
			[Address(RVA = "0x271E4B0", Offset = "0x271D0B0", VA = "0x18271E4B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B5C3 RID: 177603
		[Token(Token = "0x602B5C3")]
		public abstract void LoadStageData(string stageId);

		// Token: 0x0602B5C4 RID: 177604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5C4")]
		[Address(RVA = "0x271E370", Offset = "0x271CF70", VA = "0x18271E370")]
		public void SetSelect(ActivityInterlockData.InterlockStageType type, string stageId)
		{
		}

		// Token: 0x0602B5C5 RID: 177605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5C5")]
		[Address(RVA = "0x271E450", Offset = "0x271D050", VA = "0x18271E450")]
		protected Act1LockDetailModelBase()
		{
		}

		// Token: 0x0403EB3D RID: 256829
		[Token(Token = "0x403EB3D")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isSelected;

		// Token: 0x0403EB3E RID: 256830
		[Token(Token = "0x403EB3E")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403EB3F RID: 256831
		[Token(Token = "0x403EB3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403EB40 RID: 256832
		[Token(Token = "0x403EB40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSelected;

		// Token: 0x0403EB41 RID: 256833
		[Token(Token = "0x403EB41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x0403EB42 RID: 256834
		[Token(Token = "0x403EB42")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
