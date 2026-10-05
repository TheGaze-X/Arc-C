using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004BCF RID: 19407
	[Token(Token = "0x2004BCF")]
	[Obsolete("Legacy Don't Use")]
	public class ActivityViewEntryProviderTrain : ActivityViewEntryProvider
	{
		// Token: 0x0601D2AE RID: 119470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D2AE")]
		[Address(RVA = "0x16B5840", Offset = "0x16B4440", VA = "0x1816B5840", Slot = "4")]
		public override IEnumerable<ActivityViewEntry> EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0601D2AF RID: 119471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2AF")]
		[Address(RVA = "0x16B58A0", Offset = "0x16B44A0", VA = "0x1816B58A0")]
		public ActivityViewEntryProviderTrain()
		{
		}

		// Token: 0x04026477 RID: 156791
		[Token(Token = "0x4026477")]
		[FieldOffset(Offset = "0x18")]
		private ActivityViewEntryProviderTrain.ActivityViewEntryTrain m_entry;

		// Token: 0x02004BD0 RID: 19408
		[Token(Token = "0x2004BD0")]
		private class ActivityViewEntryTrain : ActivityViewEntry
		{
			// Token: 0x0601D2B0 RID: 119472 RVA: 0x000AACD0 File Offset: 0x000A8ED0
			[Token(Token = "0x601D2B0")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			public override ActivityEntryType EntryType()
			{
				return ActivityEntryType.NONE;
			}

			// Token: 0x0601D2B1 RID: 119473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D2B1")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			public override Sprite GetImage()
			{
				return null;
			}

			// Token: 0x0601D2B2 RID: 119474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2B2")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public override void OnClick()
			{
			}

			// Token: 0x0601D2B3 RID: 119475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2B3")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public ActivityViewEntryTrain()
			{
			}

			// Token: 0x04026478 RID: 156792
			[Token(Token = "0x4026478")]
			[FieldOffset(Offset = "0x10")]
			public SpriteHub spriteHub;

			// Token: 0x04026479 RID: 156793
			[Token(Token = "0x4026479")]
			[FieldOffset(Offset = "0x18")]
			public string zoneId;
		}
	}
}
