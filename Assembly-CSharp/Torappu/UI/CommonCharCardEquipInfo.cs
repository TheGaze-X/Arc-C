using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003599 RID: 13721
	[Token(Token = "0x2003599")]
	public class CommonCharCardEquipInfo : ICharEquipInfo, ICharacterInfo, IHotfixable
	{
		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x06015D22 RID: 89378 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015D23 RID: 89379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700341E")]
		public string equipId
		{
			[Token(Token = "0x6015D22")]
			[Address(RVA = "0xE5B580", Offset = "0xE5A180", VA = "0x180E5B580", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015D23")]
			[Address(RVA = "0xE5B7D0", Offset = "0xE5A3D0", VA = "0x180E5B7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x06015D24 RID: 89380 RVA: 0x0008E008 File Offset: 0x0008C208
		[Token(Token = "0x1700341F")]
		public int equipLvl
		{
			[Token(Token = "0x6015D24")]
			[Address(RVA = "0xE5B5E0", Offset = "0xE5A1E0", VA = "0x180E5B5E0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x06015D25 RID: 89381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015D26 RID: 89382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003420")]
		public ListDict<string, PlayerCharEquipInfo> equips
		{
			[Token(Token = "0x6015D25")]
			[Address(RVA = "0xE5B770", Offset = "0xE5A370", VA = "0x180E5B770", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015D26")]
			[Address(RVA = "0xE5B850", Offset = "0xE5A450", VA = "0x180E5B850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D27 RID: 89383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D27")]
		[Address(RVA = "0xE5B4A0", Offset = "0xE5A0A0", VA = "0x180E5B4A0", Slot = "8")]
		public virtual void SetEquipId(string newEquipId)
		{
		}

		// Token: 0x06015D28 RID: 89384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D28")]
		[Address(RVA = "0xE5B520", Offset = "0xE5A120", VA = "0x180E5B520")]
		public CommonCharCardEquipInfo()
		{
		}

		// Token: 0x0401A3FD RID: 107517
		[Token(Token = "0x401A3FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0401A3FE RID: 107518
		[Token(Token = "0x401A3FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_equipId;

		// Token: 0x0401A3FF RID: 107519
		[Token(Token = "0x401A3FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_equipLvl;

		// Token: 0x0401A400 RID: 107520
		[Token(Token = "0x401A400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_equips;

		// Token: 0x0401A401 RID: 107521
		[Token(Token = "0x401A401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_equips;

		// Token: 0x0401A402 RID: 107522
		[Token(Token = "0x401A402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetEquipId;

		// Token: 0x0401A403 RID: 107523
		[Token(Token = "0x401A403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200359A RID: 13722
		[Token(Token = "0x200359A")]
		public struct DefaultEquipInfoPatchBuilder : ICharInfoPatchBuilder<CommonCharCardEquipInfo>, IHotfixable
		{
			// Token: 0x17003421 RID: 13345
			// (get) Token: 0x06015D29 RID: 89385 RVA: 0x0008E020 File Offset: 0x0008C220
			[Token(Token = "0x17003421")]
			public bool isEmpty
			{
				[Token(Token = "0x6015D29")]
				[Address(RVA = "0xE6A9C0", Offset = "0xE695C0", VA = "0x180E6A9C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015D2A RID: 89386 RVA: 0x0008E038 File Offset: 0x0008C238
			[Token(Token = "0x6015D2A")]
			[Address(RVA = "0xE6A290", Offset = "0xE68E90", VA = "0x180E6A290")]
			public CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder SetEquips(ListDict<string, PlayerCharEquipInfo> sourceEquips)
			{
				return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
			}

			// Token: 0x06015D2B RID: 89387 RVA: 0x0008E050 File Offset: 0x0008C250
			[Token(Token = "0x6015D2B")]
			[Address(RVA = "0xE6A480", Offset = "0xE69080", VA = "0x180E6A480")]
			private CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder _CloneEquips(ListDict<string, PlayerCharEquipInfo> sourceEquips)
			{
				return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
			}

			// Token: 0x06015D2C RID: 89388 RVA: 0x0008E068 File Offset: 0x0008C268
			[Token(Token = "0x6015D2C")]
			[Address(RVA = "0xE6A6B0", Offset = "0xE692B0", VA = "0x180E6A6B0")]
			private CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder _GenEquipsFromSource(CharQuery charQuery, int equipLevel)
			{
				return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
			}

			// Token: 0x06015D2D RID: 89389 RVA: 0x0008E080 File Offset: 0x0008C280
			[Token(Token = "0x6015D2D")]
			[Address(RVA = "0xE698B0", Offset = "0xE684B0", VA = "0x180E698B0")]
			public bool GetEquipDataById(string targetEquipId, out PlayerCharEquipInfo charEquip)
			{
				return default(bool);
			}

			// Token: 0x06015D2E RID: 89390 RVA: 0x0008E098 File Offset: 0x0008C298
			[Token(Token = "0x6015D2E")]
			[Address(RVA = "0xE699E0", Offset = "0xE685E0", VA = "0x180E699E0")]
			public bool GetEquipDataByIndex(int targetEquipIndex, out string targetEquipId, out PlayerCharEquipInfo charEquip)
			{
				return default(bool);
			}

			// Token: 0x06015D2F RID: 89391 RVA: 0x0008E0B0 File Offset: 0x0008C2B0
			[Token(Token = "0x6015D2F")]
			[Address(RVA = "0xE69810", Offset = "0xE68410", VA = "0x180E69810")]
			public int GetEquipCount()
			{
				return 0;
			}

			// Token: 0x06015D30 RID: 89392 RVA: 0x0008E0C8 File Offset: 0x0008C2C8
			[Token(Token = "0x6015D30")]
			[Address(RVA = "0xE69FF0", Offset = "0xE68BF0", VA = "0x180E69FF0")]
			public static CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar, [Optional] string overrideTmplId)
			{
				return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
			}

			// Token: 0x06015D31 RID: 89393 RVA: 0x0008E0E0 File Offset: 0x0008C2E0
			[Token(Token = "0x6015D31")]
			[Address(RVA = "0xE69B30", Offset = "0xE68730", VA = "0x180E69B30")]
			public static CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder ParseFromCharData(CharQuery charQuery, int equipLevel, EvolvePhase evolvePhase, int level, [Optional] string overrideDefaultEquipId)
			{
				return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
			}

			// Token: 0x06015D32 RID: 89394 RVA: 0x0008E0F8 File Offset: 0x0008C2F8
			[Token(Token = "0x6015D32")]
			[Address(RVA = "0xE69F10", Offset = "0xE68B10", VA = "0x180E69F10")]
			public static CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder ParseFromEquipInfo(ICharEquipInfo sourceEquipInfo)
			{
				return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
			}

			// Token: 0x06015D33 RID: 89395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015D33")]
			[Address(RVA = "0xE694D0", Offset = "0xE680D0", VA = "0x180E694D0", Slot = "5")]
			public CommonCharCardEquipInfo BuildTo(CommonCharCardEquipInfo characterInfo)
			{
				return null;
			}

			// Token: 0x0401A404 RID: 107524
			[Token(Token = "0x401A404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string equipId;

			// Token: 0x0401A405 RID: 107525
			[Token(Token = "0x401A405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ListDict<string, PlayerCharEquipInfo> s_equips;

			// Token: 0x0401A406 RID: 107526
			[Token(Token = "0x401A406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0401A407 RID: 107527
			[Token(Token = "0x401A407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetEquips;

			// Token: 0x0401A408 RID: 107528
			[Token(Token = "0x401A408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CloneEquips;

			// Token: 0x0401A409 RID: 107529
			[Token(Token = "0x401A409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GenEquipsFromSource;

			// Token: 0x0401A40A RID: 107530
			[Token(Token = "0x401A40A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetEquipDataById;

			// Token: 0x0401A40B RID: 107531
			[Token(Token = "0x401A40B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetEquipDataByIndex;

			// Token: 0x0401A40C RID: 107532
			[Token(Token = "0x401A40C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetEquipCount;

			// Token: 0x0401A40D RID: 107533
			[Token(Token = "0x401A40D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x0401A40E RID: 107534
			[Token(Token = "0x401A40E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_ParseFromCharData;

			// Token: 0x0401A40F RID: 107535
			[Token(Token = "0x401A40F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_ParseFromEquipInfo;

			// Token: 0x0401A410 RID: 107536
			[Token(Token = "0x401A410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
