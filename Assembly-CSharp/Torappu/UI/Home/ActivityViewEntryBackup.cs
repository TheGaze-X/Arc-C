using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004C41 RID: 19521
	[Token(Token = "0x2004C41")]
	public class ActivityViewEntryBackup : ActivityViewEntry
	{
		// Token: 0x0601D4E5 RID: 120037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4E5")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
		public override Sprite GetImage()
		{
			return null;
		}

		// Token: 0x0601D4E6 RID: 120038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4E6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityViewEntryBackup()
		{
		}

		// Token: 0x040268F1 RID: 157937
		[Token(Token = "0x40268F1")]
		[FieldOffset(Offset = "0x10")]
		public Sprite image;
	}
}
