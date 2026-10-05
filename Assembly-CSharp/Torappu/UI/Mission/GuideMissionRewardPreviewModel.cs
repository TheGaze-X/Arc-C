using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004866 RID: 18534
	[Token(Token = "0x2004866")]
	public class GuideMissionRewardPreviewModel : IHotfixable
	{
		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x0601BFE3 RID: 114659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004285")]
		public List<GuideMissionGroupModel> groupList
		{
			[Token(Token = "0x601BFE3")]
			[Address(RVA = "0x154CD60", Offset = "0x154B960", VA = "0x18154CD60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BFE4 RID: 114660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFE4")]
		[Address(RVA = "0x154C560", Offset = "0x154B160", VA = "0x18154C560")]
		public void LoadData()
		{
		}

		// Token: 0x0601BFE5 RID: 114661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BFE5")]
		[Address(RVA = "0x154C410", Offset = "0x154B010", VA = "0x18154C410")]
		public string GetToDoGroupId()
		{
			return null;
		}

		// Token: 0x0601BFE6 RID: 114662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFE6")]
		[Address(RVA = "0x154CCB0", Offset = "0x154B8B0", VA = "0x18154CCB0")]
		public GuideMissionRewardPreviewModel()
		{
		}

		// Token: 0x04024838 RID: 149560
		[Token(Token = "0x4024838")]
		[FieldOffset(Offset = "0x10")]
		private List<GuideMissionGroupModel> m_groupList;

		// Token: 0x04024839 RID: 149561
		[Token(Token = "0x4024839")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupList;

		// Token: 0x0402483A RID: 149562
		[Token(Token = "0x402483A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402483B RID: 149563
		[Token(Token = "0x402483B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetToDoGroupId;

		// Token: 0x0402483C RID: 149564
		[Token(Token = "0x402483C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
