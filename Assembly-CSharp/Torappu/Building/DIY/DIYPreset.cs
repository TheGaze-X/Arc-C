using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200184D RID: 6221
	[Token(Token = "0x200184D")]
	public class DIYPreset : IDIYPreset
	{
		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06009D4E RID: 40270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009D4F RID: 40271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700115C")]
		public string name
		{
			[Token(Token = "0x6009D4E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009D4F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06009D50 RID: 40272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009D51 RID: 40273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700115D")]
		public string roomType
		{
			[Token(Token = "0x6009D50")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009D51")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009D53 RID: 40275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700115E")]
		public string floorModifierId
		{
			[Token(Token = "0x6009D52")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009D53")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700115F")]
		public string wallModifierId
		{
			[Token(Token = "0x6009D54")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009D55")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001160")]
		public string thumbnailUrl
		{
			[Token(Token = "0x6009D56")]
			[Address(RVA = "0x317D1E0", Offset = "0x317BDE0", VA = "0x18317D1E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001161")]
		public IEnumerable<DIYPresetItem> items
		{
			[Token(Token = "0x6009D57")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D58")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DIYPreset()
		{
		}

		// Token: 0x0400940B RID: 37899
		[Token(Token = "0x400940B")]
		[FieldOffset(Offset = "0x10")]
		public List<DIYPresetItem> itemList;
	}
}
