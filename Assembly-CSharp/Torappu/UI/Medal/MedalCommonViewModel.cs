using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200499D RID: 18845
	[Token(Token = "0x200499D")]
	public class MedalCommonViewModel : IHotfixable
	{
		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x0601C63A RID: 116282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700432F")]
		public string medalId
		{
			[Token(Token = "0x601C63A")]
			[Address(RVA = "0x15E9880", Offset = "0x15E8480", VA = "0x1815E9880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x0601C63B RID: 116283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004330")]
		public MedalPerData currentData
		{
			[Token(Token = "0x601C63B")]
			[Address(RVA = "0x15E9500", Offset = "0x15E8100", VA = "0x1815E9500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x0601C63C RID: 116284 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C63D RID: 116285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004331")]
		public MedalPerData data
		{
			[Token(Token = "0x601C63C")]
			[Address(RVA = "0x15E9640", Offset = "0x15E8240", VA = "0x1815E9640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601C63D")]
			[Address(RVA = "0x15E9C60", Offset = "0x15E8860", VA = "0x1815E9C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x0601C63E RID: 116286 RVA: 0x000A8090 File Offset: 0x000A6290
		// (set) Token: 0x0601C63F RID: 116287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004332")]
		public MedalGetState getState
		{
			[Token(Token = "0x601C63E")]
			[Address(RVA = "0x15E9760", Offset = "0x15E8360", VA = "0x1815E9760")]
			[CompilerGenerated]
			get
			{
				return MedalGetState.NOTGET;
			}
			[Token(Token = "0x601C63F")]
			[Address(RVA = "0x15E9DC0", Offset = "0x15E89C0", VA = "0x1815E9DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0601C640 RID: 116288 RVA: 0x000A80A8 File Offset: 0x000A62A8
		// (set) Token: 0x0601C641 RID: 116289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004333")]
		public bool hasAdvanced
		{
			[Token(Token = "0x601C640")]
			[Address(RVA = "0x15E9820", Offset = "0x15E8420", VA = "0x1815E9820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601C641")]
			[Address(RVA = "0x15E9EA0", Offset = "0x15E8AA0", VA = "0x1815E9EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0601C642 RID: 116290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C643 RID: 116291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004334")]
		public MedalPerData advancedData
		{
			[Token(Token = "0x601C642")]
			[Address(RVA = "0x15E9320", Offset = "0x15E7F20", VA = "0x1815E9320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601C643")]
			[Address(RVA = "0x15E9A20", Offset = "0x15E8620", VA = "0x1815E9A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x0601C644 RID: 116292 RVA: 0x000A80C0 File Offset: 0x000A62C0
		// (set) Token: 0x0601C645 RID: 116293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004335")]
		public bool advancedGetFlag
		{
			[Token(Token = "0x601C644")]
			[Address(RVA = "0x15E9440", Offset = "0x15E8040", VA = "0x1815E9440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601C645")]
			[Address(RVA = "0x15E9B80", Offset = "0x15E8780", VA = "0x1815E9B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x0601C646 RID: 116294 RVA: 0x000A80D8 File Offset: 0x000A62D8
		// (set) Token: 0x0601C647 RID: 116295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004336")]
		public long getTime
		{
			[Token(Token = "0x601C646")]
			[Address(RVA = "0x15E97C0", Offset = "0x15E83C0", VA = "0x1815E97C0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601C647")]
			[Address(RVA = "0x15E9E30", Offset = "0x15E8A30", VA = "0x1815E9E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x0601C648 RID: 116296 RVA: 0x000A80F0 File Offset: 0x000A62F0
		// (set) Token: 0x0601C649 RID: 116297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004337")]
		public long advancedGetTime
		{
			[Token(Token = "0x601C648")]
			[Address(RVA = "0x15E94A0", Offset = "0x15E80A0", VA = "0x1815E94A0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601C649")]
			[Address(RVA = "0x15E9BF0", Offset = "0x15E87F0", VA = "0x1815E9BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0601C64A RID: 116298 RVA: 0x000A8108 File Offset: 0x000A6308
		// (set) Token: 0x0601C64B RID: 116299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004338")]
		public int finishValue
		{
			[Token(Token = "0x601C64A")]
			[Address(RVA = "0x15E9700", Offset = "0x15E8300", VA = "0x1815E9700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601C64B")]
			[Address(RVA = "0x15E9D50", Offset = "0x15E8950", VA = "0x1815E9D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x0601C64C RID: 116300 RVA: 0x000A8120 File Offset: 0x000A6320
		// (set) Token: 0x0601C64D RID: 116301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004339")]
		public int finishTarget
		{
			[Token(Token = "0x601C64C")]
			[Address(RVA = "0x15E96A0", Offset = "0x15E82A0", VA = "0x1815E96A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601C64D")]
			[Address(RVA = "0x15E9CE0", Offset = "0x15E88E0", VA = "0x1815E9CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x0601C64E RID: 116302 RVA: 0x000A8138 File Offset: 0x000A6338
		// (set) Token: 0x0601C64F RID: 116303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700433A")]
		public int advancedFinishValue
		{
			[Token(Token = "0x601C64E")]
			[Address(RVA = "0x15E93E0", Offset = "0x15E7FE0", VA = "0x1815E93E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601C64F")]
			[Address(RVA = "0x15E9B10", Offset = "0x15E8710", VA = "0x1815E9B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x0601C650 RID: 116304 RVA: 0x000A8150 File Offset: 0x000A6350
		// (set) Token: 0x0601C651 RID: 116305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700433B")]
		public int advancedFinishTarget
		{
			[Token(Token = "0x601C650")]
			[Address(RVA = "0x15E9380", Offset = "0x15E7F80", VA = "0x1815E9380")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601C651")]
			[Address(RVA = "0x15E9AA0", Offset = "0x15E86A0", VA = "0x1815E9AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601C652 RID: 116306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C652")]
		[Address(RVA = "0x15E8EE0", Offset = "0x15E7AE0", VA = "0x1815E8EE0")]
		public void SyncPlayerMedalStatus(MedalPerData medalData, long curTs)
		{
		}

		// Token: 0x0601C653 RID: 116307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C653")]
		[Address(RVA = "0x15E8C30", Offset = "0x15E7830", VA = "0x1815E8C30")]
		public void SyncPlayerAdvancedStatus(MedalPerData advData)
		{
		}

		// Token: 0x0601C654 RID: 116308 RVA: 0x000A8168 File Offset: 0x000A6368
		[Token(Token = "0x601C654")]
		[Address(RVA = "0x15E8700", Offset = "0x15E7300", VA = "0x1815E8700")]
		public MedalCommonViewModel.DisplayInfoCache GetDisplayInfo()
		{
			return default(MedalCommonViewModel.DisplayInfoCache);
		}

		// Token: 0x0601C655 RID: 116309 RVA: 0x000A8180 File Offset: 0x000A6380
		[Token(Token = "0x601C655")]
		[Address(RVA = "0x15E88E0", Offset = "0x15E74E0", VA = "0x1815E88E0")]
		public bool IsAchieved()
		{
			return default(bool);
		}

		// Token: 0x0601C656 RID: 116310 RVA: 0x000A8198 File Offset: 0x000A6398
		[Token(Token = "0x601C656")]
		[Address(RVA = "0x15E8200", Offset = "0x15E6E00", VA = "0x1815E8200")]
		public bool CheckIfMedalMatchShowType(MedalBarListShowType showType)
		{
			return default(bool);
		}

		// Token: 0x0601C657 RID: 116311 RVA: 0x000A81B0 File Offset: 0x000A63B0
		[Token(Token = "0x601C657")]
		[Address(RVA = "0x15E8990", Offset = "0x15E7590", VA = "0x1815E8990")]
		public bool IsExpired()
		{
			return default(bool);
		}

		// Token: 0x0601C658 RID: 116312 RVA: 0x000A81C8 File Offset: 0x000A63C8
		[Token(Token = "0x601C658")]
		[Address(RVA = "0x15E8BC0", Offset = "0x15E77C0", VA = "0x1815E8BC0")]
		public bool IsPermExpired()
		{
			return default(bool);
		}

		// Token: 0x0601C659 RID: 116313 RVA: 0x000A81E0 File Offset: 0x000A63E0
		[Token(Token = "0x601C659")]
		[Address(RVA = "0x15E8B10", Offset = "0x15E7710", VA = "0x1815E8B10")]
		public bool IsMedalGotten()
		{
			return default(bool);
		}

		// Token: 0x0601C65A RID: 116314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C65A")]
		[Address(RVA = "0x15E8810", Offset = "0x15E7410", VA = "0x1815E8810")]
		public string GetProperExpireGetMethodDesc()
		{
			return null;
		}

		// Token: 0x0601C65B RID: 116315 RVA: 0x000A81F8 File Offset: 0x000A63F8
		[Token(Token = "0x601C65B")]
		[Address(RVA = "0x15E87B0", Offset = "0x15E73B0", VA = "0x1815E87B0")]
		public MedalExpireType GetExpireType()
		{
			return MedalExpireType.NONE;
		}

		// Token: 0x0601C65C RID: 116316 RVA: 0x000A8210 File Offset: 0x000A6410
		[Token(Token = "0x601C65C")]
		[Address(RVA = "0x15E8A00", Offset = "0x15E7600", VA = "0x1815E8A00")]
		public bool IsHidden()
		{
			return default(bool);
		}

		// Token: 0x0601C65D RID: 116317 RVA: 0x000A8228 File Offset: 0x000A6428
		[Token(Token = "0x601C65D")]
		[Address(RVA = "0x15E8350", Offset = "0x15E6F50", VA = "0x1815E8350")]
		public bool CheckIfShowPreMedalListDuringNotGet()
		{
			return default(bool);
		}

		// Token: 0x0601C65E RID: 116318 RVA: 0x000A8240 File Offset: 0x000A6440
		[Token(Token = "0x601C65E")]
		[Address(RVA = "0x15E8410", Offset = "0x15E7010", VA = "0x1815E8410")]
		public bool CheckIfShowRewardsDuringNotGet()
		{
			return default(bool);
		}

		// Token: 0x0601C65F RID: 116319 RVA: 0x000A8258 File Offset: 0x000A6458
		[Token(Token = "0x601C65F")]
		[Address(RVA = "0x15E8290", Offset = "0x15E6E90", VA = "0x1815E8290")]
		public bool CheckIfShowAdvMedalDuringNotGet()
		{
			return default(bool);
		}

		// Token: 0x0601C660 RID: 116320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C660")]
		[Address(RVA = "0x15E8540", Offset = "0x15E7140", VA = "0x1815E8540")]
		public static MedalCommonViewModel CreateFromFriendMedal(string medalId, FriendMedalTemplateGroupInfo info)
		{
			return null;
		}

		// Token: 0x0601C661 RID: 116321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C661")]
		[Address(RVA = "0x15E92C0", Offset = "0x15E7EC0", VA = "0x1815E92C0")]
		public MedalCommonViewModel()
		{
		}

		// Token: 0x040252EF RID: 152303
		[Token(Token = "0x40252EF")]
		[FieldOffset(Offset = "0x10")]
		private MedalExpireStatus m_expireStatus;

		// Token: 0x040252FB RID: 152315
		[Token(Token = "0x40252FB")]
		[FieldOffset(Offset = "0x58")]
		public MedalTypeData typeData;

		// Token: 0x040252FC RID: 152316
		[Token(Token = "0x40252FC")]
		[FieldOffset(Offset = "0x60")]
		public bool isSelect;

		// Token: 0x040252FD RID: 152317
		[Token(Token = "0x40252FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_medalId;

		// Token: 0x040252FE RID: 152318
		[Token(Token = "0x40252FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentData;

		// Token: 0x040252FF RID: 152319
		[Token(Token = "0x40252FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04025300 RID: 152320
		[Token(Token = "0x4025300")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x04025301 RID: 152321
		[Token(Token = "0x4025301")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_getState;

		// Token: 0x04025302 RID: 152322
		[Token(Token = "0x4025302")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_getState;

		// Token: 0x04025303 RID: 152323
		[Token(Token = "0x4025303")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasAdvanced;

		// Token: 0x04025304 RID: 152324
		[Token(Token = "0x4025304")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_hasAdvanced;

		// Token: 0x04025305 RID: 152325
		[Token(Token = "0x4025305")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_advancedData;

		// Token: 0x04025306 RID: 152326
		[Token(Token = "0x4025306")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_advancedData;

		// Token: 0x04025307 RID: 152327
		[Token(Token = "0x4025307")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_advancedGetFlag;

		// Token: 0x04025308 RID: 152328
		[Token(Token = "0x4025308")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_advancedGetFlag;

		// Token: 0x04025309 RID: 152329
		[Token(Token = "0x4025309")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_getTime;

		// Token: 0x0402530A RID: 152330
		[Token(Token = "0x402530A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_getTime;

		// Token: 0x0402530B RID: 152331
		[Token(Token = "0x402530B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_advancedGetTime;

		// Token: 0x0402530C RID: 152332
		[Token(Token = "0x402530C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_advancedGetTime;

		// Token: 0x0402530D RID: 152333
		[Token(Token = "0x402530D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_finishValue;

		// Token: 0x0402530E RID: 152334
		[Token(Token = "0x402530E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_finishValue;

		// Token: 0x0402530F RID: 152335
		[Token(Token = "0x402530F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_finishTarget;

		// Token: 0x04025310 RID: 152336
		[Token(Token = "0x4025310")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_finishTarget;

		// Token: 0x04025311 RID: 152337
		[Token(Token = "0x4025311")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_advancedFinishValue;

		// Token: 0x04025312 RID: 152338
		[Token(Token = "0x4025312")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_advancedFinishValue;

		// Token: 0x04025313 RID: 152339
		[Token(Token = "0x4025313")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_advancedFinishTarget;

		// Token: 0x04025314 RID: 152340
		[Token(Token = "0x4025314")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_advancedFinishTarget;

		// Token: 0x04025315 RID: 152341
		[Token(Token = "0x4025315")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SyncPlayerMedalStatus;

		// Token: 0x04025316 RID: 152342
		[Token(Token = "0x4025316")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SyncPlayerAdvancedStatus;

		// Token: 0x04025317 RID: 152343
		[Token(Token = "0x4025317")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetDisplayInfo;

		// Token: 0x04025318 RID: 152344
		[Token(Token = "0x4025318")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_IsAchieved;

		// Token: 0x04025319 RID: 152345
		[Token(Token = "0x4025319")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckIfMedalMatchShowType;

		// Token: 0x0402531A RID: 152346
		[Token(Token = "0x402531A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_IsExpired;

		// Token: 0x0402531B RID: 152347
		[Token(Token = "0x402531B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_IsPermExpired;

		// Token: 0x0402531C RID: 152348
		[Token(Token = "0x402531C")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_IsMedalGotten;

		// Token: 0x0402531D RID: 152349
		[Token(Token = "0x402531D")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetProperExpireGetMethodDesc;

		// Token: 0x0402531E RID: 152350
		[Token(Token = "0x402531E")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetExpireType;

		// Token: 0x0402531F RID: 152351
		[Token(Token = "0x402531F")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_IsHidden;

		// Token: 0x04025320 RID: 152352
		[Token(Token = "0x4025320")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckIfShowPreMedalListDuringNotGet;

		// Token: 0x04025321 RID: 152353
		[Token(Token = "0x4025321")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckIfShowRewardsDuringNotGet;

		// Token: 0x04025322 RID: 152354
		[Token(Token = "0x4025322")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckIfShowAdvMedalDuringNotGet;

		// Token: 0x04025323 RID: 152355
		[Token(Token = "0x4025323")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CreateFromFriendMedal;

		// Token: 0x04025324 RID: 152356
		[Token(Token = "0x4025324")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200499E RID: 18846
		[Token(Token = "0x200499E")]
		public struct DisplayInfoCache : IHotfixable
		{
			// Token: 0x0601C662 RID: 116322 RVA: 0x000A8270 File Offset: 0x000A6470
			[Token(Token = "0x601C662")]
			[Address(RVA = "0x15DD540", Offset = "0x15DC140", VA = "0x1815DD540")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0601C663 RID: 116323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C663")]
			[Address(RVA = "0x15DD5E0", Offset = "0x15DC1E0", VA = "0x1815DD5E0")]
			public DisplayInfoCache(MedalCommonViewModel viewModel)
			{
			}

			// Token: 0x04025325 RID: 152357
			[Token(Token = "0x4025325")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MedalCommonViewModel.DisplayInfoCache EMPTY;

			// Token: 0x04025326 RID: 152358
			[Token(Token = "0x4025326")]
			[FieldOffset(Offset = "0x0")]
			private MedalExpireStatus m_expireStatus;

			// Token: 0x04025327 RID: 152359
			[Token(Token = "0x4025327")]
			[FieldOffset(Offset = "0x8")]
			public string medalId;

			// Token: 0x04025328 RID: 152360
			[Token(Token = "0x4025328")]
			[FieldOffset(Offset = "0x10")]
			public int value;

			// Token: 0x04025329 RID: 152361
			[Token(Token = "0x4025329")]
			[FieldOffset(Offset = "0x14")]
			public int target;

			// Token: 0x0402532A RID: 152362
			[Token(Token = "0x402532A")]
			[FieldOffset(Offset = "0x18")]
			public long getTime;

			// Token: 0x0402532B RID: 152363
			[Token(Token = "0x402532B")]
			[FieldOffset(Offset = "0x20")]
			public MedalGetState getState;

			// Token: 0x0402532C RID: 152364
			[Token(Token = "0x402532C")]
			[FieldOffset(Offset = "0x24")]
			public int advValue;

			// Token: 0x0402532D RID: 152365
			[Token(Token = "0x402532D")]
			[FieldOffset(Offset = "0x28")]
			public int advTarget;

			// Token: 0x0402532E RID: 152366
			[Token(Token = "0x402532E")]
			[FieldOffset(Offset = "0x30")]
			public long advGetTime;

			// Token: 0x0402532F RID: 152367
			[Token(Token = "0x402532F")]
			[FieldOffset(Offset = "0x38")]
			public bool advdGetFlag;

			// Token: 0x04025330 RID: 152368
			[Token(Token = "0x4025330")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x04025331 RID: 152369
			[Token(Token = "0x4025331")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
