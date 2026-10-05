using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B5C RID: 31580
	[Token(Token = "0x2007B5C")]
	[Serializable]
	public class ActivityFirstMapViewModel : IHotfixable
	{
		// Token: 0x17006789 RID: 26505
		// (get) Token: 0x0602C33D RID: 181053 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C33E RID: 181054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006789")]
		public string selectedZoneId
		{
			[Token(Token = "0x602C33D")]
			[Address(RVA = "0x281CE60", Offset = "0x281BA60", VA = "0x18281CE60")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C33E")]
			[Address(RVA = "0x281D020", Offset = "0x281BC20", VA = "0x18281D020")]
			set
			{
			}
		}

		// Token: 0x1700678A RID: 26506
		// (get) Token: 0x0602C33F RID: 181055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700678A")]
		public DefaultZoneData rightData
		{
			[Token(Token = "0x602C33F")]
			[Address(RVA = "0x281CAF0", Offset = "0x281B6F0", VA = "0x18281CAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700678B RID: 26507
		// (get) Token: 0x0602C340 RID: 181056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700678B")]
		public DefaultZoneData leftData
		{
			[Token(Token = "0x602C340")]
			[Address(RVA = "0x281C980", Offset = "0x281B580", VA = "0x18281C980")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700678C RID: 26508
		// (get) Token: 0x0602C341 RID: 181057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700678C")]
		public DefaultZoneData selectedZoneData
		{
			[Token(Token = "0x602C341")]
			[Address(RVA = "0x281CC60", Offset = "0x281B860", VA = "0x18281CC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700678D RID: 26509
		// (get) Token: 0x0602C342 RID: 181058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700678D")]
		public DefaultZoneData showZoneData
		{
			[Token(Token = "0x602C342")]
			[Address(RVA = "0x281CEC0", Offset = "0x281BAC0", VA = "0x18281CEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C343 RID: 181059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C343")]
		[Address(RVA = "0x281C920", Offset = "0x281B520", VA = "0x18281C920")]
		public ActivityFirstMapViewModel()
		{
		}

		// Token: 0x0404014C RID: 262476
		[Token(Token = "0x404014C")]
		[FieldOffset(Offset = "0x10")]
		public List<DefaultZoneData> zoneList;

		// Token: 0x0404014D RID: 262477
		[Token(Token = "0x404014D")]
		[FieldOffset(Offset = "0x18")]
		private string m_selectedZoneId;

		// Token: 0x0404014E RID: 262478
		[Token(Token = "0x404014E")]
		[FieldOffset(Offset = "0x20")]
		public string showZoneId;

		// Token: 0x0404014F RID: 262479
		[Token(Token = "0x404014F")]
		[FieldOffset(Offset = "0x28")]
		private DefaultZoneData m_cacheSelectedZoneData;

		// Token: 0x04040150 RID: 262480
		[Token(Token = "0x4040150")]
		[FieldOffset(Offset = "0x30")]
		private DefaultZoneData m_cacheShowZoneData;

		// Token: 0x04040151 RID: 262481
		[Token(Token = "0x4040151")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedZoneId;

		// Token: 0x04040152 RID: 262482
		[Token(Token = "0x4040152")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedZoneId;

		// Token: 0x04040153 RID: 262483
		[Token(Token = "0x4040153")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rightData;

		// Token: 0x04040154 RID: 262484
		[Token(Token = "0x4040154")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_leftData;

		// Token: 0x04040155 RID: 262485
		[Token(Token = "0x4040155")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedZoneData;

		// Token: 0x04040156 RID: 262486
		[Token(Token = "0x4040156")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_showZoneData;

		// Token: 0x04040157 RID: 262487
		[Token(Token = "0x4040157")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
