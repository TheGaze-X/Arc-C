using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BC9 RID: 19401
	[Token(Token = "0x2004BC9")]
	public class ActivityViewEntryProviderMainStage : ActivityViewEntryProvider
	{
		// Token: 0x0601D28D RID: 119437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D28D")]
		[Address(RVA = "0x16B5140", Offset = "0x16B3D40", VA = "0x1816B5140", Slot = "4")]
		public override IEnumerable<ActivityViewEntry> EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0601D28E RID: 119438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D28E")]
		[Address(RVA = "0x16B51F0", Offset = "0x16B3DF0", VA = "0x1816B51F0")]
		public ActivityViewEntryProviderMainStage()
		{
		}

		// Token: 0x0601D28F RID: 119439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D28F")]
		[Address(RVA = "0x16B4CB0", Offset = "0x16B38B0", VA = "0x1816B4CB0")]
		private IEnumerable<ActivityViewEntry> <>xLuaBaseProxy_EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0402645E RID: 156766
		[Token(Token = "0x402645E")]
		[FieldOffset(Offset = "0x18")]
		private ActivityViewEntryProviderMainStage.ActivityViewEntryMainStage m_entry;

		// Token: 0x0402645F RID: 156767
		[Token(Token = "0x402645F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnumAllActivityViewEntry;

		// Token: 0x04026460 RID: 156768
		[Token(Token = "0x4026460")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BCA RID: 19402
		[Token(Token = "0x2004BCA")]
		private class ActivityViewEntryMainStage : ActivityViewEntry
		{
			// Token: 0x0601D290 RID: 119440 RVA: 0x000AAC40 File Offset: 0x000A8E40
			[Token(Token = "0x601D290")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
			public override ActivityEntryType EntryType()
			{
				return ActivityEntryType.NONE;
			}

			// Token: 0x0601D291 RID: 119441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D291")]
			[Address(RVA = "0x16B4A70", Offset = "0x16B3670", VA = "0x1816B4A70", Slot = "6")]
			public override Sprite GetImage()
			{
				return null;
			}

			// Token: 0x0601D292 RID: 119442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D292")]
			[Address(RVA = "0x16B4B30", Offset = "0x16B3730", VA = "0x1816B4B30", Slot = "7")]
			public override void OnClick()
			{
			}

			// Token: 0x0601D293 RID: 119443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D293")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public ActivityViewEntryMainStage()
			{
			}

			// Token: 0x04026461 RID: 156769
			[Token(Token = "0x4026461")]
			[FieldOffset(Offset = "0x10")]
			public string targetZone;

			// Token: 0x04026462 RID: 156770
			[Token(Token = "0x4026462")]
			[FieldOffset(Offset = "0x18")]
			private UIStateFinder m_stateFinder;

			// Token: 0x04026463 RID: 156771
			[Token(Token = "0x4026463")]
			[FieldOffset(Offset = "0x28")]
			public ActivityViewEntryProviderMainStage closure;
		}
	}
}
