using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B86 RID: 15238
	[Token(Token = "0x2003B86")]
	public class UIClickableEquipItemModel : IHotfixable
	{
		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x06017E1F RID: 97823 RVA: 0x00098868 File Offset: 0x00096A68
		[Token(Token = "0x17003905")]
		public bool isUnlock
		{
			[Token(Token = "0x6017E1F")]
			[Address(RVA = "0x10220F0", Offset = "0x1020CF0", VA = "0x1810220F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x06017E20 RID: 97824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003906")]
		public UniEquipData equipData
		{
			[Token(Token = "0x6017E20")]
			[Address(RVA = "0x1022020", Offset = "0x1020C20", VA = "0x181022020")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x06017E21 RID: 97825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003907")]
		public string equipId
		{
			[Token(Token = "0x6017E21")]
			[Address(RVA = "0x1022080", Offset = "0x1020C80", VA = "0x181022080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x06017E22 RID: 97826 RVA: 0x00098880 File Offset: 0x00096A80
		[Token(Token = "0x17003908")]
		public int sortId
		{
			[Token(Token = "0x6017E22")]
			[Address(RVA = "0x10221B0", Offset = "0x1020DB0", VA = "0x1810221B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x06017E23 RID: 97827 RVA: 0x00098898 File Offset: 0x00096A98
		[Token(Token = "0x17003909")]
		public int level
		{
			[Token(Token = "0x6017E23")]
			[Address(RVA = "0x1022150", Offset = "0x1020D50", VA = "0x181022150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06017E24 RID: 97828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E24")]
		[Address(RVA = "0x1021F20", Offset = "0x1020B20", VA = "0x181021F20")]
		public void LoadData(UniEquipData equipData, int level, bool isUnlock)
		{
		}

		// Token: 0x06017E25 RID: 97829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E25")]
		[Address(RVA = "0x1021FC0", Offset = "0x1020BC0", VA = "0x181021FC0")]
		public UIClickableEquipItemModel()
		{
		}

		// Token: 0x0401CDD5 RID: 118229
		[Token(Token = "0x401CDD5")]
		[FieldOffset(Offset = "0x10")]
		private UniEquipData m_equipData;

		// Token: 0x0401CDD6 RID: 118230
		[Token(Token = "0x401CDD6")]
		[FieldOffset(Offset = "0x18")]
		private int m_level;

		// Token: 0x0401CDD7 RID: 118231
		[Token(Token = "0x401CDD7")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_isUnlock;

		// Token: 0x0401CDD8 RID: 118232
		[Token(Token = "0x401CDD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x0401CDD9 RID: 118233
		[Token(Token = "0x401CDD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_equipData;

		// Token: 0x0401CDDA RID: 118234
		[Token(Token = "0x401CDDA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0401CDDB RID: 118235
		[Token(Token = "0x401CDDB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401CDDC RID: 118236
		[Token(Token = "0x401CDDC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401CDDD RID: 118237
		[Token(Token = "0x401CDDD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401CDDE RID: 118238
		[Token(Token = "0x401CDDE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
