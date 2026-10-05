using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C01 RID: 15361
	[Token(Token = "0x2003C01")]
	public class UniEquipArchiveCollectionInfoViewModel : IHotfixable
	{
		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0601805A RID: 98394 RVA: 0x00098F88 File Offset: 0x00097188
		[Token(Token = "0x1700394B")]
		public int equipTotalCount
		{
			[Token(Token = "0x601805A")]
			[Address(RVA = "0x107A380", Offset = "0x1078F80", VA = "0x18107A380")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0601805B RID: 98395 RVA: 0x00098FA0 File Offset: 0x000971A0
		[Token(Token = "0x1700394C")]
		public int equipGetCount
		{
			[Token(Token = "0x601805B")]
			[Address(RVA = "0x107A2C0", Offset = "0x1078EC0", VA = "0x18107A2C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0601805C RID: 98396 RVA: 0x00098FB8 File Offset: 0x000971B8
		[Token(Token = "0x1700394D")]
		public int stage3EquipCount
		{
			[Token(Token = "0x601805C")]
			[Address(RVA = "0x107A440", Offset = "0x1079040", VA = "0x18107A440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0601805D RID: 98397 RVA: 0x00098FD0 File Offset: 0x000971D0
		[Token(Token = "0x1700394E")]
		public int charHasModuleCount
		{
			[Token(Token = "0x601805D")]
			[Address(RVA = "0x107A260", Offset = "0x1078E60", VA = "0x18107A260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0601805E RID: 98398 RVA: 0x00098FE8 File Offset: 0x000971E8
		[Token(Token = "0x1700394F")]
		public int playerHasModuleCharCount
		{
			[Token(Token = "0x601805E")]
			[Address(RVA = "0x107A3E0", Offset = "0x1078FE0", VA = "0x18107A3E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0601805F RID: 98399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003950")]
		public Dictionary<string, UniEquipArchiveCollectionEquipInfoData> equipInfoDict
		{
			[Token(Token = "0x601805F")]
			[Address(RVA = "0x107A320", Offset = "0x1078F20", VA = "0x18107A320")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018060 RID: 98400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018060")]
		[Address(RVA = "0x10797B0", Offset = "0x10783B0", VA = "0x1810797B0")]
		public void LoadData()
		{
		}

		// Token: 0x06018061 RID: 98401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018061")]
		[Address(RVA = "0x1079E30", Offset = "0x1078A30", VA = "0x181079E30")]
		private void _RefreshPlayerGetEquipCountInfo(UniEquipData equipData, PlayerCharacter playerChar, ref UniEquipArchiveCollectionEquipInfoData infoData, ref int equipGetCount, ref int stage3EquipCount, ref PlayerCharEquipInfo equipInfo)
		{
		}

		// Token: 0x06018062 RID: 98402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018062")]
		[Address(RVA = "0x107A1B0", Offset = "0x1078DB0", VA = "0x18107A1B0")]
		public UniEquipArchiveCollectionInfoViewModel()
		{
		}

		// Token: 0x0401D1F3 RID: 119283
		[Token(Token = "0x401D1F3")]
		[FieldOffset(Offset = "0x10")]
		private int m_equipTotalCount;

		// Token: 0x0401D1F4 RID: 119284
		[Token(Token = "0x401D1F4")]
		[FieldOffset(Offset = "0x14")]
		private int m_equipGetCount;

		// Token: 0x0401D1F5 RID: 119285
		[Token(Token = "0x401D1F5")]
		[FieldOffset(Offset = "0x18")]
		private int m_stage3EquipCount;

		// Token: 0x0401D1F6 RID: 119286
		[Token(Token = "0x401D1F6")]
		[FieldOffset(Offset = "0x1C")]
		private int m_charHasModuleCount;

		// Token: 0x0401D1F7 RID: 119287
		[Token(Token = "0x401D1F7")]
		[FieldOffset(Offset = "0x20")]
		private int m_playerHasModuleCharCount;

		// Token: 0x0401D1F8 RID: 119288
		[Token(Token = "0x401D1F8")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, UniEquipArchiveCollectionEquipInfoData> m_equipInfoDict;

		// Token: 0x0401D1F9 RID: 119289
		[Token(Token = "0x401D1F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_equipTotalCount;

		// Token: 0x0401D1FA RID: 119290
		[Token(Token = "0x401D1FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_equipGetCount;

		// Token: 0x0401D1FB RID: 119291
		[Token(Token = "0x401D1FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stage3EquipCount;

		// Token: 0x0401D1FC RID: 119292
		[Token(Token = "0x401D1FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charHasModuleCount;

		// Token: 0x0401D1FD RID: 119293
		[Token(Token = "0x401D1FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_playerHasModuleCharCount;

		// Token: 0x0401D1FE RID: 119294
		[Token(Token = "0x401D1FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_equipInfoDict;

		// Token: 0x0401D1FF RID: 119295
		[Token(Token = "0x401D1FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D200 RID: 119296
		[Token(Token = "0x401D200")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshPlayerGetEquipCountInfo;

		// Token: 0x0401D201 RID: 119297
		[Token(Token = "0x401D201")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
