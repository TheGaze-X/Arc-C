using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002609 RID: 9737
	[Token(Token = "0x2002609")]
	[SelectionBase]
	public class RallyPoint : Trap
	{
		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600FDAB RID: 64939 RVA: 0x00060060 File Offset: 0x0005E260
		[Token(Token = "0x17002223")]
		public bool inRallyPointMode
		{
			[Token(Token = "0x600FDAB")]
			[Address(RVA = "0x75F6D0", Offset = "0x75E2D0", VA = "0x18075F6D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600FDAC RID: 64940 RVA: 0x00060078 File Offset: 0x0005E278
		[Token(Token = "0x17002224")]
		public bool inDefaultMode
		{
			[Token(Token = "0x600FDAC")]
			[Address(RVA = "0x75F670", Offset = "0x75E270", VA = "0x18075F670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600FDAD RID: 64941 RVA: 0x00060090 File Offset: 0x0005E290
		[Token(Token = "0x17002225")]
		public override EntityCategory category
		{
			[Token(Token = "0x600FDAD")]
			[Address(RVA = "0x75F3D0", Offset = "0x75DFD0", VA = "0x18075F3D0", Slot = "47")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600FDAE RID: 64942 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FDAF RID: 64943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002226")]
		public RallyPointRebornTalent rallyPointRebornTalent
		{
			[Token(Token = "0x600FDAE")]
			[Address(RVA = "0x75F730", Offset = "0x75E330", VA = "0x18075F730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FDAF")]
			[Address(RVA = "0x75F950", Offset = "0x75E550", VA = "0x18075F950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600FDB0 RID: 64944 RVA: 0x000600A8 File Offset: 0x0005E2A8
		[Token(Token = "0x17002227")]
		public FP rebornProgress
		{
			[Token(Token = "0x600FDB0")]
			[Address(RVA = "0x75F790", Offset = "0x75E390", VA = "0x18075F790")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600FDB1 RID: 64945 RVA: 0x000600C0 File Offset: 0x0005E2C0
		[Token(Token = "0x17002228")]
		public override FP hpToShow
		{
			[Token(Token = "0x600FDB1")]
			[Address(RVA = "0x75F430", Offset = "0x75E030", VA = "0x18075F430", Slot = "159")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600FDB2 RID: 64946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDB2")]
		[Address(RVA = "0x75ECA0", Offset = "0x75D8A0", VA = "0x18075ECA0", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FDB3 RID: 64947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDB3")]
		[Address(RVA = "0x75EDC0", Offset = "0x75D9C0", VA = "0x18075EDC0", Slot = "219")]
		public override void SwitchCategory(EntityCategory category)
		{
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600FDB4 RID: 64948 RVA: 0x000600D8 File Offset: 0x0005E2D8
		[Token(Token = "0x17002229")]
		public override bool withdrawable
		{
			[Token(Token = "0x600FDB4")]
			[Address(RVA = "0x75F8D0", Offset = "0x75E4D0", VA = "0x18075F8D0", Slot = "203")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FDB5 RID: 64949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDB5")]
		[Address(RVA = "0x75ED10", Offset = "0x75D910", VA = "0x18075ED10")]
		public void RecoverHpLikeReborn()
		{
		}

		// Token: 0x0600FDB6 RID: 64950 RVA: 0x000600F0 File Offset: 0x0005E2F0
		[Token(Token = "0x600FDB6")]
		[Address(RVA = "0x75F150", Offset = "0x75DD50", VA = "0x18075F150", Slot = "211")]
		public override bool Withdraw(bool switchToDeadState = false, bool force = false, bool manual = true, bool logAutoWithdraw = false)
		{
			return default(bool);
		}

		// Token: 0x0600FDB7 RID: 64951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDB7")]
		[Address(RVA = "0x75EA10", Offset = "0x75D610", VA = "0x18075EA10", Slot = "183")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600FDB8 RID: 64952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDB8")]
		[Address(RVA = "0x75F370", Offset = "0x75DF70", VA = "0x18075F370")]
		public RallyPoint()
		{
		}

		// Token: 0x0600FDB9 RID: 64953 RVA: 0x00060108 File Offset: 0x0005E308
		[Token(Token = "0x600FDB9")]
		[Address(RVA = "0x75F070", Offset = "0x75DC70", VA = "0x18075F070")]
		private EntityCategory <>xLuaBaseProxy_get_category()
		{
			return EntityCategory.NONE;
		}

		// Token: 0x0600FDBA RID: 64954 RVA: 0x00060120 File Offset: 0x0005E320
		[Token(Token = "0x600FDBA")]
		[Address(RVA = "0x75F0E0", Offset = "0x75DCE0", VA = "0x18075F0E0")]
		private FP <>xLuaBaseProxy_get_hpToShow()
		{
			return default(FP);
		}

		// Token: 0x0600FDBB RID: 64955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDBB")]
		[Address(RVA = "0x75EF70", Offset = "0x75DB70", VA = "0x18075EF70")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FDBC RID: 64956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDBC")]
		[Address(RVA = "0x75EFE0", Offset = "0x75DBE0", VA = "0x18075EFE0")]
		private void <>xLuaBaseProxy_SwitchCategory(EntityCategory P0)
		{
		}

		// Token: 0x0600FDBD RID: 64957 RVA: 0x00060138 File Offset: 0x0005E338
		[Token(Token = "0x600FDBD")]
		[Address(RVA = "0x75F140", Offset = "0x75DD40", VA = "0x18075F140")]
		private bool <>xLuaBaseProxy_get_withdrawable()
		{
			return default(bool);
		}

		// Token: 0x0600FDBE RID: 64958 RVA: 0x00060150 File Offset: 0x0005E350
		[Token(Token = "0x600FDBE")]
		[Address(RVA = "0x75F050", Offset = "0x75DC50", VA = "0x18075F050")]
		private bool <>xLuaBaseProxy_Withdraw(bool P0, bool P1, bool P2, bool P3)
		{
			return default(bool);
		}

		// Token: 0x0600FDBF RID: 64959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDBF")]
		[Address(RVA = "0x75A0E0", Offset = "0x758CE0", VA = "0x18075A0E0")]
		private void <>xLuaBaseProxy_OnAwake()
		{
		}

		// Token: 0x040119FC RID: 72188
		[Token(Token = "0x40119FC")]
		[FieldOffset(Offset = "0x578")]
		[SerializeField]
		private List<string> _retainedBuffsWhenDead;

		// Token: 0x040119FD RID: 72189
		[Token(Token = "0x40119FD")]
		[FieldOffset(Offset = "0x580")]
		[SerializeField]
		private bool _showFullHpOnBorn;

		// Token: 0x040119FE RID: 72190
		[Token(Token = "0x40119FE")]
		[FieldOffset(Offset = "0x581")]
		private bool m_isFirstReborn;

		// Token: 0x04011A00 RID: 72192
		[Token(Token = "0x4011A00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inRallyPointMode;

		// Token: 0x04011A01 RID: 72193
		[Token(Token = "0x4011A01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inDefaultMode;

		// Token: 0x04011A02 RID: 72194
		[Token(Token = "0x4011A02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04011A03 RID: 72195
		[Token(Token = "0x4011A03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_rallyPointRebornTalent;

		// Token: 0x04011A04 RID: 72196
		[Token(Token = "0x4011A04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_rallyPointRebornTalent;

		// Token: 0x04011A05 RID: 72197
		[Token(Token = "0x4011A05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rebornProgress;

		// Token: 0x04011A06 RID: 72198
		[Token(Token = "0x4011A06")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hpToShow;

		// Token: 0x04011A07 RID: 72199
		[Token(Token = "0x4011A07")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011A08 RID: 72200
		[Token(Token = "0x4011A08")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SwitchCategory;

		// Token: 0x04011A09 RID: 72201
		[Token(Token = "0x4011A09")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_withdrawable;

		// Token: 0x04011A0A RID: 72202
		[Token(Token = "0x4011A0A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RecoverHpLikeReborn;

		// Token: 0x04011A0B RID: 72203
		[Token(Token = "0x4011A0B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Withdraw;

		// Token: 0x04011A0C RID: 72204
		[Token(Token = "0x4011A0C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x04011A0D RID: 72205
		[Token(Token = "0x4011A0D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
