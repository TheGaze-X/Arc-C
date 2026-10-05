using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200473D RID: 18237
	[Token(Token = "0x200473D")]
	public class RecruitAvailDetailPickUpPart : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA27 RID: 113191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA27")]
		[Address(RVA = "0x14F53F0", Offset = "0x14F3FF0", VA = "0x1814F53F0")]
		public void Render(List<GachaDetailData.GachaAvailChar.GachaPerAvail> perAvailList, RecruitAvailDetailPickUpPart.Options option, string recruit6StarHint)
		{
		}

		// Token: 0x0601BA28 RID: 113192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA28")]
		[Address(RVA = "0x14F5680", Offset = "0x14F4280", VA = "0x1814F5680")]
		public RecruitAvailDetailPickUpPart()
		{
		}

		// Token: 0x04023D78 RID: 146808
		[Token(Token = "0x4023D78")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RecruitUpDetailObj _detailPortraitObj;

		// Token: 0x04023D79 RID: 146809
		[Token(Token = "0x4023D79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitAvailDetailObj _detailTextObj;

		// Token: 0x04023D7A RID: 146810
		[Token(Token = "0x4023D7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023D7B RID: 146811
		[Token(Token = "0x4023D7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D7C RID: 146812
		[Token(Token = "0x4023D7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200473E RID: 18238
		[Token(Token = "0x200473E")]
		public class Options
		{
			// Token: 0x0601BA29 RID: 113193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BA29")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04023D7D RID: 146813
			[Token(Token = "0x4023D7D")]
			[FieldOffset(Offset = "0x10")]
			public RarityRank deltaRarity;

			// Token: 0x04023D7E RID: 146814
			[Token(Token = "0x4023D7E")]
			[FieldOffset(Offset = "0x14")]
			public bool hasSecurityRank;

			// Token: 0x04023D7F RID: 146815
			[Token(Token = "0x4023D7F")]
			[FieldOffset(Offset = "0x18")]
			public RarityRank securityRank;
		}
	}
}
