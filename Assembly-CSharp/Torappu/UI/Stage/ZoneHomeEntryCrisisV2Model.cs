using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F4 RID: 26612
	[Token(Token = "0x20067F4")]
	public class ZoneHomeEntryCrisisV2Model : ZoneHomeEntryItemModel
	{
		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x0602623F RID: 156223 RVA: 0x000CA260 File Offset: 0x000C8460
		// (set) Token: 0x06026240 RID: 156224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A2A")]
		public int mainRank
		{
			[Token(Token = "0x602623F")]
			[Address(RVA = "0x2144870", Offset = "0x2143470", VA = "0x182144870")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026240")]
			[Address(RVA = "0x2144990", Offset = "0x2143590", VA = "0x182144990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x06026241 RID: 156225 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026242 RID: 156226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A2B")]
		public string seasonId
		{
			[Token(Token = "0x6026241")]
			[Address(RVA = "0x21448D0", Offset = "0x21434D0", VA = "0x1821448D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026242")]
			[Address(RVA = "0x2144A00", Offset = "0x2143600", VA = "0x182144A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x06026243 RID: 156227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026244 RID: 156228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A2C")]
		public string stageId
		{
			[Token(Token = "0x6026243")]
			[Address(RVA = "0x2144930", Offset = "0x2143530", VA = "0x182144930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026244")]
			[Address(RVA = "0x2144A80", Offset = "0x2143680", VA = "0x182144A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026245 RID: 156229 RVA: 0x000CA278 File Offset: 0x000C8478
		[Token(Token = "0x6026245")]
		[Address(RVA = "0x2143F20", Offset = "0x2142B20", VA = "0x182143F20", Slot = "4")]
		public override ZoneHomeEntryMedalStatus GetMedalStatus()
		{
			return default(ZoneHomeEntryMedalStatus);
		}

		// Token: 0x06026246 RID: 156230 RVA: 0x000CA290 File Offset: 0x000C8490
		[Token(Token = "0x6026246")]
		[Address(RVA = "0x2143EA0", Offset = "0x2142AA0", VA = "0x182143EA0", Slot = "5")]
		public override ZoneHomeEntryLockInfo GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x06026247 RID: 156231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026247")]
		[Address(RVA = "0x2143FB0", Offset = "0x2142BB0", VA = "0x182143FB0")]
		public static ZoneHomeEntryCrisisV2Model LoadData()
		{
			return null;
		}

		// Token: 0x06026248 RID: 156232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026248")]
		[Address(RVA = "0x2144570", Offset = "0x2143170", VA = "0x182144570")]
		private void _LoadPlayerData(string seasonId)
		{
		}

		// Token: 0x06026249 RID: 156233 RVA: 0x000CA2A8 File Offset: 0x000C84A8
		[Token(Token = "0x6026249")]
		[Address(RVA = "0x2144490", Offset = "0x2143090", VA = "0x182144490")]
		private static HomeEntrySortIndex _GetSortIndex(ZoneHomeEntryLockInfo lockInfo, ZoneHomeEntryMedalStatus medalStatus)
		{
			return HomeEntrySortIndex.NONE;
		}

		// Token: 0x0602624A RID: 156234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602624A")]
		[Address(RVA = "0x2144770", Offset = "0x2143370", VA = "0x182144770")]
		public ZoneHomeEntryCrisisV2Model()
		{
		}

		// Token: 0x0602624B RID: 156235 RVA: 0x000CA2C0 File Offset: 0x000C84C0
		[Token(Token = "0x602624B")]
		[Address(RVA = "0x2144450", Offset = "0x2143050", VA = "0x182144450")]
		private ZoneHomeEntryMedalStatus <>xLuaBaseProxy_GetMedalStatus()
		{
			return default(ZoneHomeEntryMedalStatus);
		}

		// Token: 0x0602624C RID: 156236 RVA: 0x000CA2D8 File Offset: 0x000C84D8
		[Token(Token = "0x602624C")]
		[Address(RVA = "0x2144420", Offset = "0x2143020", VA = "0x182144420")]
		private ZoneHomeEntryLockInfo <>xLuaBaseProxy_GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x04035B78 RID: 220024
		[Token(Token = "0x4035B78")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeEntryLockInfo m_lockInfo;

		// Token: 0x04035B79 RID: 220025
		[Token(Token = "0x4035B79")]
		[FieldOffset(Offset = "0x58")]
		private ZoneHomeEntryMedalStatus m_medalStatus;

		// Token: 0x04035B7D RID: 220029
		[Token(Token = "0x4035B7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainRank;

		// Token: 0x04035B7E RID: 220030
		[Token(Token = "0x4035B7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mainRank;

		// Token: 0x04035B7F RID: 220031
		[Token(Token = "0x4035B7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_seasonId;

		// Token: 0x04035B80 RID: 220032
		[Token(Token = "0x4035B80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_seasonId;

		// Token: 0x04035B81 RID: 220033
		[Token(Token = "0x4035B81")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x04035B82 RID: 220034
		[Token(Token = "0x4035B82")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_stageId;

		// Token: 0x04035B83 RID: 220035
		[Token(Token = "0x4035B83")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetMedalStatus;

		// Token: 0x04035B84 RID: 220036
		[Token(Token = "0x4035B84")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLockInfo;

		// Token: 0x04035B85 RID: 220037
		[Token(Token = "0x4035B85")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035B86 RID: 220038
		[Token(Token = "0x4035B86")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadPlayerData;

		// Token: 0x04035B87 RID: 220039
		[Token(Token = "0x4035B87")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetSortIndex;

		// Token: 0x04035B88 RID: 220040
		[Token(Token = "0x4035B88")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
