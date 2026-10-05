using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	public class BuildingToDoNotifyItemModel : IHotfixable
	{
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06004D73 RID: 19827 RVA: 0x0002D930 File Offset: 0x0002BB30
		// (set) Token: 0x06004D74 RID: 19828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000201")]
		public BuildingData.BuildingToDoType type
		{
			[Token(Token = "0x6004D73")]
			[Address(RVA = "0x187EBF0", Offset = "0x187D7F0", VA = "0x18187EBF0")]
			get
			{
				return BuildingData.BuildingToDoType.NONE;
			}
			[Token(Token = "0x6004D74")]
			[Address(RVA = "0x187ECC0", Offset = "0x187D8C0", VA = "0x18187ECC0")]
			set
			{
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06004D75 RID: 19829 RVA: 0x0002D948 File Offset: 0x0002BB48
		// (set) Token: 0x06004D76 RID: 19830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000202")]
		public int sortPriority
		{
			[Token(Token = "0x6004D75")]
			[Address(RVA = "0x187EB90", Offset = "0x187D790", VA = "0x18187EB90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004D76")]
			[Address(RVA = "0x187EC50", Offset = "0x187D850", VA = "0x18187EC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06004D77 RID: 19831 RVA: 0x0002D960 File Offset: 0x0002BB60
		[Token(Token = "0x17000203")]
		public bool available
		{
			[Token(Token = "0x6004D77")]
			[Address(RVA = "0x187EB20", Offset = "0x187D720", VA = "0x18187EB20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x0002D978 File Offset: 0x0002BB78
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x187E9A0", Offset = "0x187D5A0", VA = "0x18187E9A0")]
		public int GetCount4Display()
		{
			return 0;
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x187EAC0", Offset = "0x187D6C0", VA = "0x18187EAC0")]
		public BuildingToDoNotifyItemModel()
		{
		}

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x20")]
		public string clickDesc;

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x28")]
		public List<string> slots;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x30")]
		public bool canPlayClickAnim;

		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x31")]
		public bool isHide;

		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x32")]
		public bool needPlayClickAnim;

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x33")]
		public bool forceHideCount;

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x38")]
		private BuildingData.BuildingToDoType m_type;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortPriority;

		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_sortPriority;

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_available;

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCount4Display;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
