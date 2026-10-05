using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200527F RID: 21119
	[Token(Token = "0x200527F")]
	public class RoguelikeFocusViewModel : IHotfixable
	{
		// Token: 0x0601F291 RID: 127633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F291")]
		[Address(RVA = "0x18ECC80", Offset = "0x18EB880", VA = "0x1818ECC80")]
		public string GetActiveFocusStageId()
		{
			return null;
		}

		// Token: 0x0601F292 RID: 127634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F292")]
		[Address(RVA = "0x18ECBF0", Offset = "0x18EB7F0", VA = "0x1818ECBF0")]
		public void Clear()
		{
		}

		// Token: 0x0601F293 RID: 127635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F293")]
		[Address(RVA = "0x18ECD00", Offset = "0x18EB900", VA = "0x1818ECD00")]
		public void LoadCapsule(string capsuleId)
		{
		}

		// Token: 0x0601F294 RID: 127636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F294")]
		[Address(RVA = "0x18ED230", Offset = "0x18EBE30", VA = "0x1818ED230")]
		public void LoadFocusNode(RoguelikeDungeonNode node, string zoneId)
		{
		}

		// Token: 0x0601F295 RID: 127637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F295")]
		[Address(RVA = "0x18ED380", Offset = "0x18EBF80", VA = "0x1818ED380")]
		public void LoadFocusStage(RoguelikeDungeonNode node, string focusStageId, string zoneId)
		{
		}

		// Token: 0x0601F296 RID: 127638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F296")]
		[Address(RVA = "0x18ECD80", Offset = "0x18EB980", VA = "0x1818ECD80")]
		public void LoadDetailContent(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x0601F297 RID: 127639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F297")]
		[Address(RVA = "0x18ED5E0", Offset = "0x18EC1E0", VA = "0x1818ED5E0")]
		private void _LoadFocusStageRenderType(string topicId, string focusStageId)
		{
		}

		// Token: 0x0601F298 RID: 127640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F298")]
		[Address(RVA = "0x18ED6F0", Offset = "0x18EC2F0", VA = "0x1818ED6F0")]
		public RoguelikeFocusViewModel()
		{
		}

		// Token: 0x04029D02 RID: 171266
		[Token(Token = "0x4029D02")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeDungeonNode focusNode;

		// Token: 0x04029D03 RID: 171267
		[Token(Token = "0x4029D03")]
		[FieldOffset(Offset = "0x18")]
		public PlayerNodeForesightType foresightType;

		// Token: 0x04029D04 RID: 171268
		[Token(Token = "0x4029D04")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeEventType renderType;

		// Token: 0x04029D05 RID: 171269
		[Token(Token = "0x4029D05")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeFocusViewModel.DetailInfo detailInfo;

		// Token: 0x04029D06 RID: 171270
		[Token(Token = "0x4029D06")]
		[FieldOffset(Offset = "0x28")]
		public string topicId;

		// Token: 0x04029D07 RID: 171271
		[Token(Token = "0x4029D07")]
		[FieldOffset(Offset = "0x30")]
		public string zoneId;

		// Token: 0x04029D08 RID: 171272
		[Token(Token = "0x4029D08")]
		[FieldOffset(Offset = "0x38")]
		public string focusStageId;

		// Token: 0x04029D09 RID: 171273
		[Token(Token = "0x4029D09")]
		[FieldOffset(Offset = "0x40")]
		public string activeCapsuleId;

		// Token: 0x04029D0A RID: 171274
		[Token(Token = "0x4029D0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActiveFocusStageId;

		// Token: 0x04029D0B RID: 171275
		[Token(Token = "0x4029D0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04029D0C RID: 171276
		[Token(Token = "0x4029D0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadCapsule;

		// Token: 0x04029D0D RID: 171277
		[Token(Token = "0x4029D0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadFocusNode;

		// Token: 0x04029D0E RID: 171278
		[Token(Token = "0x4029D0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadFocusStage;

		// Token: 0x04029D0F RID: 171279
		[Token(Token = "0x4029D0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadDetailContent;

		// Token: 0x04029D10 RID: 171280
		[Token(Token = "0x4029D10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadFocusStageRenderType;

		// Token: 0x04029D11 RID: 171281
		[Token(Token = "0x4029D11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005280 RID: 21120
		[Token(Token = "0x2005280")]
		public class DetailInfo : IHotfixable
		{
			// Token: 0x0601F299 RID: 127641 RVA: 0x000B10C0 File Offset: 0x000AF2C0
			[Token(Token = "0x601F299")]
			[Address(RVA = "0x18DD580", Offset = "0x18DC180", VA = "0x1818DD580")]
			public bool CheckAbleToClick()
			{
				return default(bool);
			}

			// Token: 0x0601F29A RID: 127642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F29A")]
			[Address(RVA = "0x18DD630", Offset = "0x18DC230", VA = "0x1818DD630")]
			public void Clear()
			{
			}

			// Token: 0x0601F29B RID: 127643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F29B")]
			[Address(RVA = "0x18DD6F0", Offset = "0x18DC2F0", VA = "0x1818DD6F0")]
			public DetailInfo()
			{
			}

			// Token: 0x04029D12 RID: 171282
			[Token(Token = "0x4029D12")]
			[FieldOffset(Offset = "0x10")]
			public string scene;

			// Token: 0x04029D13 RID: 171283
			[Token(Token = "0x4029D13")]
			[FieldOffset(Offset = "0x18")]
			public List<string> battleShop;

			// Token: 0x04029D14 RID: 171284
			[Token(Token = "0x4029D14")]
			[FieldOffset(Offset = "0x20")]
			public List<string> battleList;

			// Token: 0x04029D15 RID: 171285
			[Token(Token = "0x4029D15")]
			[FieldOffset(Offset = "0x28")]
			public List<string> wishList;

			// Token: 0x04029D16 RID: 171286
			[Token(Token = "0x4029D16")]
			[FieldOffset(Offset = "0x30")]
			public int subTypeId;

			// Token: 0x04029D17 RID: 171287
			[Token(Token = "0x4029D17")]
			[FieldOffset(Offset = "0x38")]
			public string name;

			// Token: 0x04029D18 RID: 171288
			[Token(Token = "0x4029D18")]
			[FieldOffset(Offset = "0x40")]
			public string description;

			// Token: 0x04029D19 RID: 171289
			[Token(Token = "0x4029D19")]
			[FieldOffset(Offset = "0x48")]
			public string iconId;

			// Token: 0x04029D1A RID: 171290
			[Token(Token = "0x4029D1A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckAbleToClick;

			// Token: 0x04029D1B RID: 171291
			[Token(Token = "0x4029D1B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x04029D1C RID: 171292
			[Token(Token = "0x4029D1C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
