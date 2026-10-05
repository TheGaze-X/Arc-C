using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004C40 RID: 19520
	[Token(Token = "0x2004C40")]
	public class ActivityViewEntry
	{
		// Token: 0x0601D4DF RID: 120031 RVA: 0x000AB228 File Offset: 0x000A9428
		[Token(Token = "0x601D4DF")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
		public virtual ActivityEntryType EntryType()
		{
			return ActivityEntryType.NONE;
		}

		// Token: 0x0601D4E0 RID: 120032 RVA: 0x000AB240 File Offset: 0x000A9440
		[Token(Token = "0x601D4E0")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public virtual int SubOrder()
		{
			return 0;
		}

		// Token: 0x0601D4E1 RID: 120033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4E1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public virtual Sprite GetImage()
		{
			return null;
		}

		// Token: 0x0601D4E2 RID: 120034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4E2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OnClick()
		{
		}

		// Token: 0x0601D4E3 RID: 120035 RVA: 0x000AB258 File Offset: 0x000A9458
		[Token(Token = "0x601D4E3")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
		public virtual bool CheckAvail()
		{
			return default(bool);
		}

		// Token: 0x0601D4E4 RID: 120036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4E4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityViewEntry()
		{
		}
	}
}
