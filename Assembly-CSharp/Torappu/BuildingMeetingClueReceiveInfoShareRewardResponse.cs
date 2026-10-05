using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x02000686 RID: 1670
	[Token(Token = "0x2000686")]
	public class BuildingMeetingClueReceiveInfoShareRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x060062B4 RID: 25268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B4")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingMeetingClueReceiveInfoShareRewardResponse()
		{
		}

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingMeetingClueReceiveInfoShareRewardResponse.VisitorInfo> list;

		// Token: 0x02000687 RID: 1671
		[Token(Token = "0x2000687")]
		public class VisitorInfo : IPlayerStatus, IHotfixable
		{
			// Token: 0x060062B5 RID: 25269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062B5")]
			[Address(RVA = "0x1DFCE80", Offset = "0x1DFBA80", VA = "0x181DFCE80", Slot = "4")]
			public AvatarInfo GetAvatarInfo()
			{
				return null;
			}

			// Token: 0x060062B6 RID: 25270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062B6")]
			[Address(RVA = "0x1DFCEE0", Offset = "0x1DFBAE0", VA = "0x181DFCEE0", Slot = "5")]
			public string GetSecretarySkinId()
			{
				return null;
			}

			// Token: 0x060062B7 RID: 25271 RVA: 0x00030288 File Offset: 0x0002E488
			[Token(Token = "0x60062B7")]
			[Address(RVA = "0x1DFCF40", Offset = "0x1DFBB40", VA = "0x181DFCF40", Slot = "6")]
			public bool GetSecretarySkinSp()
			{
				return default(bool);
			}

			// Token: 0x060062B8 RID: 25272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062B8")]
			[Address(RVA = "0x1DFCFA0", Offset = "0x1DFBBA0", VA = "0x181DFCFA0")]
			public VisitorInfo()
			{
			}

			// Token: 0x04002E43 RID: 11843
			[Token(Token = "0x4002E43")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04002E44 RID: 11844
			[Token(Token = "0x4002E44")]
			[FieldOffset(Offset = "0x18")]
			public string nickName;

			// Token: 0x04002E45 RID: 11845
			[Token(Token = "0x4002E45")]
			[FieldOffset(Offset = "0x20")]
			public string nickNumber;

			// Token: 0x04002E46 RID: 11846
			[Token(Token = "0x4002E46")]
			[FieldOffset(Offset = "0x28")]
			public int level;

			// Token: 0x04002E47 RID: 11847
			[Token(Token = "0x4002E47")]
			[FieldOffset(Offset = "0x30")]
			public string alias;

			// Token: 0x04002E48 RID: 11848
			[Token(Token = "0x4002E48")]
			[FieldOffset(Offset = "0x38")]
			public long ts;

			// Token: 0x04002E49 RID: 11849
			[Token(Token = "0x4002E49")]
			[FieldOffset(Offset = "0x40")]
			public AvatarInfo avatar;

			// Token: 0x04002E4A RID: 11850
			[Token(Token = "0x4002E4A")]
			[FieldOffset(Offset = "0x48")]
			public string secretary;

			// Token: 0x04002E4B RID: 11851
			[Token(Token = "0x4002E4B")]
			[FieldOffset(Offset = "0x50")]
			public string secretarySkinId;

			// Token: 0x04002E4C RID: 11852
			[Token(Token = "0x4002E4C")]
			[FieldOffset(Offset = "0x58")]
			public bool secretarySkinSp;

			// Token: 0x04002E4D RID: 11853
			[Token(Token = "0x4002E4D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetAvatarInfo;

			// Token: 0x04002E4E RID: 11854
			[Token(Token = "0x4002E4E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinId;

			// Token: 0x04002E4F RID: 11855
			[Token(Token = "0x4002E4F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

			// Token: 0x04002E50 RID: 11856
			[Token(Token = "0x4002E50")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
