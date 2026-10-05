using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200680E RID: 26638
	[Token(Token = "0x200680E")]
	public class SideStoryViewModel : IHotfixable
	{
		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x060262B0 RID: 156336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060262B1 RID: 156337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A3A")]
		public RetroActData actInfo
		{
			[Token(Token = "0x60262B0")]
			[Address(RVA = "0x2137970", Offset = "0x2136570", VA = "0x182137970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60262B1")]
			[Address(RVA = "0x2137E70", Offset = "0x2136A70", VA = "0x182137E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x060262B2 RID: 156338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060262B3 RID: 156339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A3B")]
		public RetroTrailData trailData
		{
			[Token(Token = "0x60262B2")]
			[Address(RVA = "0x2137E10", Offset = "0x2136A10", VA = "0x182137E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60262B3")]
			[Address(RVA = "0x2137FD0", Offset = "0x2136BD0", VA = "0x182137FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x060262B4 RID: 156340 RVA: 0x000CA398 File Offset: 0x000C8598
		// (set) Token: 0x060262B5 RID: 156341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A3C")]
		public bool isStart
		{
			[Token(Token = "0x60262B4")]
			[Address(RVA = "0x21379D0", Offset = "0x21365D0", VA = "0x1821379D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60262B5")]
			[Address(RVA = "0x2137EF0", Offset = "0x2136AF0", VA = "0x182137EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x060262B6 RID: 156342 RVA: 0x000CA3B0 File Offset: 0x000C85B0
		[Token(Token = "0x17005A3D")]
		public bool isTrailShow
		{
			[Token(Token = "0x60262B6")]
			[Address(RVA = "0x2137B80", Offset = "0x2136780", VA = "0x182137B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x060262B7 RID: 156343 RVA: 0x000CA3C8 File Offset: 0x000C85C8
		[Token(Token = "0x17005A3E")]
		public bool isTrailCountDownFlag
		{
			[Token(Token = "0x60262B7")]
			[Address(RVA = "0x2137A30", Offset = "0x2136630", VA = "0x182137A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x060262B8 RID: 156344 RVA: 0x000CA3E0 File Offset: 0x000C85E0
		[Token(Token = "0x17005A3F")]
		public TimeSpan trailCountDownTime
		{
			[Token(Token = "0x60262B8")]
			[Address(RVA = "0x2137CF0", Offset = "0x21368F0", VA = "0x182137CF0")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x060262B9 RID: 156345 RVA: 0x000CA3F8 File Offset: 0x000C85F8
		// (set) Token: 0x060262BA RID: 156346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A40")]
		public bool isUnlock
		{
			[Token(Token = "0x60262B9")]
			[Address(RVA = "0x2137C90", Offset = "0x2136890", VA = "0x182137C90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60262BA")]
			[Address(RVA = "0x2137F60", Offset = "0x2136B60", VA = "0x182137F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060262BB RID: 156347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262BB")]
		[Address(RVA = "0x2137820", Offset = "0x2136420", VA = "0x182137820")]
		protected SideStoryViewModel()
		{
		}

		// Token: 0x060262BC RID: 156348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262BC")]
		[Address(RVA = "0x2137520", Offset = "0x2136120", VA = "0x182137520")]
		private void InitData(RetroActData actData, RetroTrailData trailData, long curTs)
		{
		}

		// Token: 0x060262BD RID: 156349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60262BD")]
		[Address(RVA = "0x2137280", Offset = "0x2135E80", VA = "0x182137280")]
		public static SideStoryViewModel Create(RetroActData actData, RetroTrailData trailData, long curTs)
		{
			return null;
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x060262BE RID: 156350 RVA: 0x000CA410 File Offset: 0x000C8610
		[Token(Token = "0x17005A41")]
		public virtual bool customZoneClick
		{
			[Token(Token = "0x60262BE")]
			[Address(RVA = "0x21303A0", Offset = "0x212EFA0", VA = "0x1821303A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060262BF RID: 156351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262BF")]
		[Address(RVA = "0x2130320", Offset = "0x212EF20", VA = "0x182130320", Slot = "5")]
		public virtual void OnZoneClick(ZoneGroupViewModel zoneGroupModel, ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060262C0 RID: 156352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C0")]
		[Address(RVA = "0x2137660", Offset = "0x2136260", VA = "0x182137660")]
		public void UpdatePlayerStatus()
		{
		}

		// Token: 0x060262C1 RID: 156353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C1")]
		[Address(RVA = "0x21369B0", Offset = "0x21355B0", VA = "0x1821369B0")]
		public void CheckAvailInfo()
		{
		}

		// Token: 0x04035C48 RID: 220232
		[Token(Token = "0x4035C48")]
		[FieldOffset(Offset = "0x10")]
		private long m_createTs;

		// Token: 0x04035C4B RID: 220235
		[Token(Token = "0x4035C4B")]
		[FieldOffset(Offset = "0x28")]
		public int totalStar;

		// Token: 0x04035C4C RID: 220236
		[Token(Token = "0x4035C4C")]
		[FieldOffset(Offset = "0x2C")]
		public int maxStar;

		// Token: 0x04035C4E RID: 220238
		[Token(Token = "0x4035C4E")]
		[FieldOffset(Offset = "0x31")]
		public bool isTrailClear;

		// Token: 0x04035C4F RID: 220239
		[Token(Token = "0x4035C4F")]
		[FieldOffset(Offset = "0x32")]
		public bool isTrailOnCountDown;

		// Token: 0x04035C50 RID: 220240
		[Token(Token = "0x4035C50")]
		[FieldOffset(Offset = "0x33")]
		public bool haveAvailReward;

		// Token: 0x04035C51 RID: 220241
		[Token(Token = "0x4035C51")]
		[FieldOffset(Offset = "0x34")]
		public bool isNewReward;

		// Token: 0x04035C52 RID: 220242
		[Token(Token = "0x4035C52")]
		[FieldOffset(Offset = "0x35")]
		public bool actOnShow;

		// Token: 0x04035C53 RID: 220243
		[Token(Token = "0x4035C53")]
		[FieldOffset(Offset = "0x38")]
		public string actId;

		// Token: 0x04035C54 RID: 220244
		[Token(Token = "0x4035C54")]
		[FieldOffset(Offset = "0x40")]
		public bool isFocus;

		// Token: 0x04035C56 RID: 220246
		[Token(Token = "0x4035C56")]
		[FieldOffset(Offset = "0x48")]
		public List<ZoneViewModel> zoneList;

		// Token: 0x04035C57 RID: 220247
		[Token(Token = "0x4035C57")]
		[FieldOffset(Offset = "0x50")]
		public List<SideStoryTrailViewModel> trailViewModelList;

		// Token: 0x04035C58 RID: 220248
		[Token(Token = "0x4035C58")]
		[FieldOffset(Offset = "0x58")]
		public bool hasChar;

		// Token: 0x04035C59 RID: 220249
		[Token(Token = "0x4035C59")]
		[FieldOffset(Offset = "0x59")]
		public bool isCharFullPotential;

		// Token: 0x04035C5A RID: 220250
		[Token(Token = "0x4035C5A")]
		[FieldOffset(Offset = "0x60")]
		public PlayerCharacter relatedChar;

		// Token: 0x04035C5B RID: 220251
		[Token(Token = "0x4035C5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actInfo;

		// Token: 0x04035C5C RID: 220252
		[Token(Token = "0x4035C5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actInfo;

		// Token: 0x04035C5D RID: 220253
		[Token(Token = "0x4035C5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_trailData;

		// Token: 0x04035C5E RID: 220254
		[Token(Token = "0x4035C5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_trailData;

		// Token: 0x04035C5F RID: 220255
		[Token(Token = "0x4035C5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isStart;

		// Token: 0x04035C60 RID: 220256
		[Token(Token = "0x4035C60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isStart;

		// Token: 0x04035C61 RID: 220257
		[Token(Token = "0x4035C61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isTrailShow;

		// Token: 0x04035C62 RID: 220258
		[Token(Token = "0x4035C62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isTrailCountDownFlag;

		// Token: 0x04035C63 RID: 220259
		[Token(Token = "0x4035C63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_trailCountDownTime;

		// Token: 0x04035C64 RID: 220260
		[Token(Token = "0x4035C64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x04035C65 RID: 220261
		[Token(Token = "0x4035C65")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_isUnlock;

		// Token: 0x04035C66 RID: 220262
		[Token(Token = "0x4035C66")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04035C67 RID: 220263
		[Token(Token = "0x4035C67")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04035C68 RID: 220264
		[Token(Token = "0x4035C68")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04035C69 RID: 220265
		[Token(Token = "0x4035C69")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_customZoneClick;

		// Token: 0x04035C6A RID: 220266
		[Token(Token = "0x4035C6A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnZoneClick;

		// Token: 0x04035C6B RID: 220267
		[Token(Token = "0x4035C6B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdatePlayerStatus;

		// Token: 0x04035C6C RID: 220268
		[Token(Token = "0x4035C6C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckAvailInfo;
	}
}
