using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DFF RID: 28159
	[Token(Token = "0x2006DFF")]
	public class ActVecBreakV2ZoneStageViewModel : IHotfixable
	{
		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x06028160 RID: 164192 RVA: 0x000D0AA0 File Offset: 0x000CECA0
		// (set) Token: 0x06028161 RID: 164193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ECD")]
		public bool isUnlock
		{
			[Token(Token = "0x6028160")]
			[Address(RVA = "0x2371E80", Offset = "0x2370A80", VA = "0x182371E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028161")]
			[Address(RVA = "0x2371FB0", Offset = "0x2370BB0", VA = "0x182371FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x06028162 RID: 164194 RVA: 0x000D0AB8 File Offset: 0x000CECB8
		// (set) Token: 0x06028163 RID: 164195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ECE")]
		public bool isComplete
		{
			[Token(Token = "0x6028162")]
			[Address(RVA = "0x2371E20", Offset = "0x2370A20", VA = "0x182371E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028163")]
			[Address(RVA = "0x2371F40", Offset = "0x2370B40", VA = "0x182371F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x06028164 RID: 164196 RVA: 0x000D0AD0 File Offset: 0x000CECD0
		// (set) Token: 0x06028165 RID: 164197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ECF")]
		public int sortId
		{
			[Token(Token = "0x6028164")]
			[Address(RVA = "0x2371EE0", Offset = "0x2370AE0", VA = "0x182371EE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028165")]
			[Address(RVA = "0x2372020", Offset = "0x2370C20", VA = "0x182372020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028166 RID: 164198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028166")]
		[Address(RVA = "0x2371C30", Offset = "0x2370830", VA = "0x182371C30")]
		public void LoadData(string stageId, int sortId)
		{
		}

		// Token: 0x06028167 RID: 164199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028167")]
		[Address(RVA = "0x2371DC0", Offset = "0x23709C0", VA = "0x182371DC0")]
		public ActVecBreakV2ZoneStageViewModel()
		{
		}

		// Token: 0x04038E05 RID: 232965
		[Token(Token = "0x4038E05")]
		[FieldOffset(Offset = "0x10")]
		private string m_stageId;

		// Token: 0x04038E06 RID: 232966
		[Token(Token = "0x4038E06")]
		[FieldOffset(Offset = "0x18")]
		private PlayerStageState m_stageState;

		// Token: 0x04038E0A RID: 232970
		[Token(Token = "0x4038E0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x04038E0B RID: 232971
		[Token(Token = "0x4038E0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isUnlock;

		// Token: 0x04038E0C RID: 232972
		[Token(Token = "0x4038E0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x04038E0D RID: 232973
		[Token(Token = "0x4038E0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isComplete;

		// Token: 0x04038E0E RID: 232974
		[Token(Token = "0x4038E0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04038E0F RID: 232975
		[Token(Token = "0x4038E0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04038E10 RID: 232976
		[Token(Token = "0x4038E10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038E11 RID: 232977
		[Token(Token = "0x4038E11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
