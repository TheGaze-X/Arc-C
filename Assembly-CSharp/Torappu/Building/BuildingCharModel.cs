using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.CharWord;

namespace Torappu.Building
{
	// Token: 0x020017F4 RID: 6132
	[Token(Token = "0x20017F4")]
	public struct BuildingCharModel
	{
		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06009AD0 RID: 39632 RVA: 0x0003C228 File Offset: 0x0003A428
		// (set) Token: 0x06009AD1 RID: 39633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010DE")]
		public bool isVisitor
		{
			[Token(Token = "0x6009AD0")]
			[Address(RVA = "0x1692610", Offset = "0x1691210", VA = "0x181692610")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6009AD1")]
			[Address(RVA = "0x1692B00", Offset = "0x1691700", VA = "0x181692B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06009AD2 RID: 39634 RVA: 0x0003C240 File Offset: 0x0003A440
		[Token(Token = "0x170010DF")]
		public bool isEmpty
		{
			[Token(Token = "0x6009AD2")]
			[Address(RVA = "0x3152DE0", Offset = "0x31519E0", VA = "0x183152DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x0003C258 File Offset: 0x0003A458
		[Token(Token = "0x6009AD3")]
		[Address(RVA = "0x3151FD0", Offset = "0x3150BD0", VA = "0x183151FD0")]
		public bool CheckTired()
		{
			return default(bool);
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x0003C270 File Offset: 0x0003A470
		[Token(Token = "0x6009AD4")]
		[Address(RVA = "0x3151EE0", Offset = "0x3150AE0", VA = "0x183151EE0")]
		public bool CheckPowerFull()
		{
			return default(bool);
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06009AD5 RID: 39637 RVA: 0x0003C288 File Offset: 0x0003A488
		[Token(Token = "0x170010E0")]
		public bool isWork
		{
			[Token(Token = "0x6009AD5")]
			[Address(RVA = "0x3152E10", Offset = "0x3151A10", VA = "0x183152E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06009AD6 RID: 39638 RVA: 0x0003C2A0 File Offset: 0x0003A4A0
		[Token(Token = "0x170010E1")]
		public bool isRest
		{
			[Token(Token = "0x6009AD6")]
			[Address(RVA = "0x3152E00", Offset = "0x3151A00", VA = "0x183152E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x0003C2B8 File Offset: 0x0003A4B8
		[Token(Token = "0x170010E2")]
		public int displayAp
		{
			[Token(Token = "0x6009AD7")]
			[Address(RVA = "0x3152C40", Offset = "0x3151840", VA = "0x183152C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06009AD8 RID: 39640 RVA: 0x0003C2D0 File Offset: 0x0003A4D0
		[Token(Token = "0x170010E3")]
		public int displayMaxAp
		{
			[Token(Token = "0x6009AD8")]
			[Address(RVA = "0x3152D00", Offset = "0x3151900", VA = "0x183152D00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		[Token(Token = "0x6009AD9")]
		[Address(RVA = "0x3151A70", Offset = "0x3150670", VA = "0x183151A70")]
		public static float CalcCurApDisplayProgress(long curAp, long maxAp)
		{
			return 0f;
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06009ADA RID: 39642 RVA: 0x0003C300 File Offset: 0x0003A500
		[Token(Token = "0x170010E4")]
		public long stateRemainTime
		{
			[Token(Token = "0x6009ADA")]
			[Address(RVA = "0x3152E20", Offset = "0x3151A20", VA = "0x183152E20")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x0003C318 File Offset: 0x0003A518
		[Token(Token = "0x6009ADB")]
		[Address(RVA = "0x3151B40", Offset = "0x3150740", VA = "0x183151B40")]
		public KeyValuePair<long, int> CalcManpower()
		{
			return default(KeyValuePair<long, int>);
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x0003C330 File Offset: 0x0003A530
		[Token(Token = "0x6009ADC")]
		[Address(RVA = "0x31528C0", Offset = "0x31514C0", VA = "0x1831528C0")]
		public static int RoundCharApToInt(long rawAp)
		{
			return 0;
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x0003C348 File Offset: 0x0003A548
		[Token(Token = "0x6009ADD")]
		[Address(RVA = "0x3152670", Offset = "0x3151270", VA = "0x183152670")]
		public static long DisplayCharApToRoughRawValue(int displayAp)
		{
			return 0L;
		}

		// Token: 0x06009ADE RID: 39646 RVA: 0x0003C360 File Offset: 0x0003A560
		[Token(Token = "0x6009ADE")]
		[Address(RVA = "0x31526C0", Offset = "0x31512C0", VA = "0x1831526C0")]
		public static long GetNextDisplayApChangeStep(long curAp, long maxAp, long apCost)
		{
			return 0L;
		}

		// Token: 0x06009ADF RID: 39647 RVA: 0x0003C378 File Offset: 0x0003A578
		[Token(Token = "0x6009ADF")]
		[Address(RVA = "0x3152AD0", Offset = "0x31516D0", VA = "0x183152AD0")]
		private static long _NextApStepPositive(long curAp, long maxAp)
		{
			return 0L;
		}

		// Token: 0x06009AE0 RID: 39648 RVA: 0x0003C390 File Offset: 0x0003A590
		[Token(Token = "0x6009AE0")]
		[Address(RVA = "0x3152A60", Offset = "0x3151660", VA = "0x183152A60")]
		private static long _NextApStepNegative(long curAp, long maxAp)
		{
			return 0L;
		}

		// Token: 0x06009AE1 RID: 39649 RVA: 0x0003C3A8 File Offset: 0x0003A5A8
		[Token(Token = "0x6009AE1")]
		[Address(RVA = "0x3152600", Offset = "0x3151200", VA = "0x183152600")]
		public static float DisplayApFloat(long rawAp)
		{
			return 0f;
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x0003C3C0 File Offset: 0x0003A5C0
		[Token(Token = "0x6009AE2")]
		[Address(RVA = "0x3151F70", Offset = "0x3150B70", VA = "0x183151F70")]
		public static bool CheckPowerFull(KeyValuePair<long, int> apInfo, BuildingCharModel charModel)
		{
			return default(bool);
		}

		// Token: 0x06009AE3 RID: 39651 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
		[Token(Token = "0x6009AE3")]
		[Address(RVA = "0x3152080", Offset = "0x3150C80", VA = "0x183152080")]
		public static bool CheckTired(KeyValuePair<long, int> apInfo, BuildingCharModel charModel)
		{
			return default(bool);
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x0003C3F0 File Offset: 0x0003A5F0
		[Token(Token = "0x6009AE4")]
		[Address(RVA = "0x3152840", Offset = "0x3151440", VA = "0x183152840")]
		public VoiceQuery GetVoiceQuery()
		{
			return default(VoiceQuery);
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x0003C408 File Offset: 0x0003A608
		[Token(Token = "0x6009AE5")]
		[Address(RVA = "0x31522D0", Offset = "0x3150ED0", VA = "0x1831522D0")]
		public static BuildingCharModel CreateModel(int charInstId, PlayerBuildingChar playerBuildingChar)
		{
			return default(BuildingCharModel);
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x0003C420 File Offset: 0x0003A620
		[Token(Token = "0x6009AE6")]
		[Address(RVA = "0x31521F0", Offset = "0x3150DF0", VA = "0x1831521F0")]
		public static BuildingCharModel CreateModelVisiting(int visitingInstId, PlayerBuildingChar visitingChar)
		{
			return default(BuildingCharModel);
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x0003C438 File Offset: 0x0003A638
		[Token(Token = "0x6009AE7")]
		[Address(RVA = "0x31520E0", Offset = "0x3150CE0", VA = "0x1831520E0")]
		public static BuildingCharModel CreateModelForVisitor(BuildingVisitorModel visitorModel, int index)
		{
			return default(BuildingCharModel);
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x0003C450 File Offset: 0x0003A650
		[Token(Token = "0x6009AE8")]
		[Address(RVA = "0x3152930", Offset = "0x3151530", VA = "0x183152930")]
		private static CharUISkinStruct _CreateSkinForVisit(string charId, string skinId)
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x04009135 RID: 37173
		[Token(Token = "0x4009135")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BuildingCharModel EMPTY;

		// Token: 0x04009136 RID: 37174
		[Token(Token = "0x4009136")]
		[FieldOffset(Offset = "0x0")]
		public int instId;

		// Token: 0x04009137 RID: 37175
		[Token(Token = "0x4009137")]
		[FieldOffset(Offset = "0x8")]
		public string charId;

		// Token: 0x04009138 RID: 37176
		[Token(Token = "0x4009138")]
		[FieldOffset(Offset = "0x10")]
		public CharUISkinStruct skinInfo;

		// Token: 0x04009139 RID: 37177
		[Token(Token = "0x4009139")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0400913A RID: 37178
		[Token(Token = "0x400913A")]
		[FieldOffset(Offset = "0x30")]
		public long lastManpower;

		// Token: 0x0400913B RID: 37179
		[Token(Token = "0x400913B")]
		[FieldOffset(Offset = "0x38")]
		public long maxManpower;

		// Token: 0x0400913C RID: 37180
		[Token(Token = "0x400913C")]
		[FieldOffset(Offset = "0x40")]
		public long powerCost;

		// Token: 0x0400913D RID: 37181
		[Token(Token = "0x400913D")]
		[FieldOffset(Offset = "0x48")]
		public string slotId;

		// Token: 0x0400913E RID: 37182
		[Token(Token = "0x400913E")]
		[FieldOffset(Offset = "0x50")]
		public int stationIndex;

		// Token: 0x0400913F RID: 37183
		[Token(Token = "0x400913F")]
		[FieldOffset(Offset = "0x58")]
		public DateTime lastApAddTime;

		// Token: 0x04009140 RID: 37184
		[Token(Token = "0x4009140")]
		[FieldOffset(Offset = "0x60")]
		public DateTime stateFinishTime;

		// Token: 0x04009141 RID: 37185
		[Token(Token = "0x4009141")]
		[FieldOffset(Offset = "0x68")]
		public bool isTraining;

		// Token: 0x04009142 RID: 37186
		[Token(Token = "0x4009142")]
		[FieldOffset(Offset = "0x69")]
		public bool isDormLock;

		// Token: 0x04009143 RID: 37187
		[Token(Token = "0x4009143")]
		[FieldOffset(Offset = "0x6A")]
		public bool canGainIntimacy;

		// Token: 0x04009144 RID: 37188
		[Token(Token = "0x4009144")]
		[FieldOffset(Offset = "0x6B")]
		public bool assistIntimacy;

		// Token: 0x04009145 RID: 37189
		[Token(Token = "0x4009145")]
		[FieldOffset(Offset = "0x6C")]
		public bool privateIntimacy;

		// Token: 0x04009147 RID: 37191
		[Token(Token = "0x4009147")]
		[FieldOffset(Offset = "0x70")]
		public string extension;
	}
}
