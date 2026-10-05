using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D0 RID: 22480
	[Token(Token = "0x20057D0")]
	internal class RoguelikeInitRecruitSetContext : RoguelikeInitOptionContext
	{
		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x06020E0E RID: 134670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D1C")]
		public override List<RoguelikeInitOption.Model> list
		{
			[Token(Token = "0x6020E0E")]
			[Address(RVA = "0x1B409D0", Offset = "0x1B3F5D0", VA = "0x181B409D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x06020E0F RID: 134671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D1D")]
		public override string name
		{
			[Token(Token = "0x6020E0F")]
			[Address(RVA = "0x1B40A30", Offset = "0x1B3F630", VA = "0x181B40A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E10 RID: 134672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E10")]
		[Address(RVA = "0x1B3FFF0", Offset = "0x1B3EBF0", VA = "0x181B3FFF0", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x06020E11 RID: 134673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E11")]
		[Address(RVA = "0x1B405C0", Offset = "0x1B3F1C0", VA = "0x181B405C0")]
		private void _AddRecruitSet(string grpId, bool unlockBySvr, RoguelikeTopicDetail detail)
		{
		}

		// Token: 0x06020E12 RID: 134674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E12")]
		[Address(RVA = "0x1B402F0", Offset = "0x1B3EEF0", VA = "0x181B402F0", Slot = "8")]
		public override void OnSelect(int idx)
		{
		}

		// Token: 0x06020E13 RID: 134675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E13")]
		[Address(RVA = "0x1B408D0", Offset = "0x1B3F4D0", VA = "0x181B408D0")]
		public RoguelikeInitRecruitSetContext()
		{
		}

		// Token: 0x0402CAD0 RID: 182992
		[Token(Token = "0x402CAD0")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitOption.Model> m_list;

		// Token: 0x0402CAD1 RID: 182993
		[Token(Token = "0x402CAD1")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_recuitGrps;

		// Token: 0x0402CAD2 RID: 182994
		[Token(Token = "0x402CAD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_list;

		// Token: 0x0402CAD3 RID: 182995
		[Token(Token = "0x402CAD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CAD4 RID: 182996
		[Token(Token = "0x402CAD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CAD5 RID: 182997
		[Token(Token = "0x402CAD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddRecruitSet;

		// Token: 0x0402CAD6 RID: 182998
		[Token(Token = "0x402CAD6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x0402CAD7 RID: 182999
		[Token(Token = "0x402CAD7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
