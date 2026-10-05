using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C5B RID: 7259
	[Token(Token = "0x2001C5B")]
	public class StationConfirmModel
	{
		// Token: 0x0600B490 RID: 46224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B490")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StationConfirmModel()
		{
		}

		// Token: 0x0400B062 RID: 45154
		[Token(Token = "0x400B062")]
		[FieldOffset(Offset = "0x10")]
		public StationConfirmModel.NormalSelect normalSelectInput;

		// Token: 0x0400B063 RID: 45155
		[Token(Token = "0x400B063")]
		[FieldOffset(Offset = "0x18")]
		public StationConfirmModel.AssistSelect assistSelectInput;

		// Token: 0x02001C5C RID: 7260
		[Token(Token = "0x2001C5C")]
		public class NormalSelect
		{
			// Token: 0x0600B491 RID: 46225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B491")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NormalSelect()
			{
			}

			// Token: 0x0400B064 RID: 45156
			[Token(Token = "0x400B064")]
			[FieldOffset(Offset = "0x10")]
			public string slotId;

			// Token: 0x0400B065 RID: 45157
			[Token(Token = "0x400B065")]
			[FieldOffset(Offset = "0x18")]
			public List<int> instIds;
		}

		// Token: 0x02001C5D RID: 7261
		[Token(Token = "0x2001C5D")]
		public class AssistSelect
		{
			// Token: 0x0600B492 RID: 46226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B492")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AssistSelect()
			{
			}

			// Token: 0x0400B066 RID: 45158
			[Token(Token = "0x400B066")]
			[FieldOffset(Offset = "0x10")]
			public int assistType;

			// Token: 0x0400B067 RID: 45159
			[Token(Token = "0x400B067")]
			[FieldOffset(Offset = "0x14")]
			public int instId;
		}
	}
}
