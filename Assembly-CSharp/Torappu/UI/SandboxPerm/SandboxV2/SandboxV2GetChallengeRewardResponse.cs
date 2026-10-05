using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043FB RID: 17403
	[Token(Token = "0x20043FB")]
	public class SandboxV2GetChallengeRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A9A5 RID: 108965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9A5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2GetChallengeRewardResponse()
		{
		}

		// Token: 0x04021E98 RID: 138904
		[Token(Token = "0x4021E98")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2GetChallengeRewardResponse.RewardItem> items;

		// Token: 0x020043FC RID: 17404
		[Token(Token = "0x20043FC")]
		public struct RewardItem : ISharedItemModel, IGachaResultHolder
		{
			// Token: 0x0601A9A6 RID: 108966 RVA: 0x000A2750 File Offset: 0x000A0950
			[Token(Token = "0x601A9A6")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
			public ItemType GetItemType()
			{
				return ItemType.NONE;
			}

			// Token: 0x0601A9A7 RID: 108967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A9A7")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
			public string GetItemId()
			{
				return null;
			}

			// Token: 0x0601A9A8 RID: 108968 RVA: 0x000A2768 File Offset: 0x000A0968
			[Token(Token = "0x601A9A8")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
			public int GetItemCount()
			{
				return 0;
			}

			// Token: 0x0601A9A9 RID: 108969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A9A9")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
			public void SetItemCount(int count_)
			{
			}

			// Token: 0x0601A9AA RID: 108970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A9AA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			public GachaResult GetGachaResult()
			{
				return null;
			}

			// Token: 0x04021E99 RID: 138905
			[Token(Token = "0x4021E99")]
			[FieldOffset(Offset = "0x0")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x04021E9A RID: 138906
			[Token(Token = "0x4021E9A")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x04021E9B RID: 138907
			[Token(Token = "0x4021E9B")]
			[FieldOffset(Offset = "0x10")]
			public GachaResult charGet;

			// Token: 0x04021E9C RID: 138908
			[Token(Token = "0x4021E9C")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
