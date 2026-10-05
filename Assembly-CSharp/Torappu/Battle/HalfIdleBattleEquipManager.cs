using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Runes;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200262D RID: 9773
	[Token(Token = "0x200262D")]
	public class HalfIdleBattleEquipManager : IHotfixable
	{
		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600FFE1 RID: 65505 RVA: 0x000614B8 File Offset: 0x0005F6B8
		[Token(Token = "0x170022F0")]
		public bool autoUpgradeOn
		{
			[Token(Token = "0x600FFE1")]
			[Address(RVA = "0x77DA10", Offset = "0x77C610", VA = "0x18077DA10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FFE2 RID: 65506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFE2")]
		[Address(RVA = "0x77C7D0", Offset = "0x77B3D0", VA = "0x18077C7D0")]
		public void OnInit(string actId)
		{
		}

		// Token: 0x0600FFE3 RID: 65507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFE3")]
		[Address(RVA = "0x77C580", Offset = "0x77B180", VA = "0x18077C580")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600FFE4 RID: 65508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFE4")]
		[Address(RVA = "0x77CDC0", Offset = "0x77B9C0", VA = "0x18077CDC0")]
		public void UpgradeRandomEquip()
		{
		}

		// Token: 0x0600FFE5 RID: 65509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFE5")]
		[Address(RVA = "0x77CA70", Offset = "0x77B670", VA = "0x18077CA70")]
		public void ToggleEquipAutoUpgradeOn()
		{
		}

		// Token: 0x0600FFE6 RID: 65510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFE6")]
		[Address(RVA = "0x77D0B0", Offset = "0x77BCB0", VA = "0x18077D0B0")]
		public void WearEquip(Act1VHalfIdleEquipType type, uint equipUid)
		{
		}

		// Token: 0x0600FFE7 RID: 65511 RVA: 0x000614D0 File Offset: 0x0005F6D0
		[Token(Token = "0x600FFE7")]
		[Address(RVA = "0x77CB10", Offset = "0x77B710", VA = "0x18077CB10")]
		public bool TryAddEquip(Act1VHalfIdleEquipData data)
		{
			return default(bool);
		}

		// Token: 0x0600FFE8 RID: 65512 RVA: 0x000614E8 File Offset: 0x0005F6E8
		[Token(Token = "0x600FFE8")]
		[Address(RVA = "0x77C3D0", Offset = "0x77AFD0", VA = "0x18077C3D0")]
		public int GetSlotNum(Act1VHalfIdleEquipType type)
		{
			return 0;
		}

		// Token: 0x0600FFE9 RID: 65513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFE9")]
		[Address(RVA = "0x77C370", Offset = "0x77AF70", VA = "0x18077C370")]
		public ListDict<Act1VHalfIdleEquipType, HalfIdleBattleEquipManager.HalfIdleEquipSlot> GetEquipSlots()
		{
			return null;
		}

		// Token: 0x0600FFEA RID: 65514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFEA")]
		[Address(RVA = "0x77D190", Offset = "0x77BD90", VA = "0x18077D190")]
		private void _TryAutoUpgradeAllSlots()
		{
		}

		// Token: 0x0600FFEB RID: 65515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFEB")]
		[Address(RVA = "0x77D6F0", Offset = "0x77C2F0", VA = "0x18077D6F0")]
		private void _TryUpgradeWithEquip(HalfIdleBattleEquipManager.HalfIdleEquip equip)
		{
		}

		// Token: 0x0600FFEC RID: 65516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFEC")]
		[Address(RVA = "0x77D9B0", Offset = "0x77C5B0", VA = "0x18077D9B0")]
		public HalfIdleBattleEquipManager()
		{
		}

		// Token: 0x04011C32 RID: 72754
		[Token(Token = "0x4011C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ListDict<Act1VHalfIdleEquipType, HalfIdleBattleEquipManager.HalfIdleEquipSlot> m_equipSlots;

		// Token: 0x04011C33 RID: 72755
		[Token(Token = "0x4011C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint m_instanceIdCounter;

		// Token: 0x04011C34 RID: 72756
		[Token(Token = "0x4011C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_autoUpgradeOn;

		// Token: 0x04011C35 RID: 72757
		[Token(Token = "0x4011C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string actId;

		// Token: 0x04011C36 RID: 72758
		[Token(Token = "0x4011C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_autoUpgradeOn;

		// Token: 0x04011C37 RID: 72759
		[Token(Token = "0x4011C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011C38 RID: 72760
		[Token(Token = "0x4011C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04011C39 RID: 72761
		[Token(Token = "0x4011C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpgradeRandomEquip;

		// Token: 0x04011C3A RID: 72762
		[Token(Token = "0x4011C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ToggleEquipAutoUpgradeOn;

		// Token: 0x04011C3B RID: 72763
		[Token(Token = "0x4011C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_WearEquip;

		// Token: 0x04011C3C RID: 72764
		[Token(Token = "0x4011C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryAddEquip;

		// Token: 0x04011C3D RID: 72765
		[Token(Token = "0x4011C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSlotNum;

		// Token: 0x04011C3E RID: 72766
		[Token(Token = "0x4011C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEquipSlots;

		// Token: 0x04011C3F RID: 72767
		[Token(Token = "0x4011C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryAutoUpgradeAllSlots;

		// Token: 0x04011C40 RID: 72768
		[Token(Token = "0x4011C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryUpgradeWithEquip;

		// Token: 0x04011C41 RID: 72769
		[Token(Token = "0x4011C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200262E RID: 9774
		[Token(Token = "0x200262E")]
		public class HalfIdleEquipSlot : IHotfixable
		{
			// Token: 0x170022F1 RID: 8945
			// (get) Token: 0x0600FFED RID: 65517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170022F1")]
			public List<HalfIdleBattleEquipManager.HalfIdleEquip> equips
			{
				[Token(Token = "0x600FFED")]
				[Address(RVA = "0x77EC20", Offset = "0x77D820", VA = "0x18077EC20")]
				get
				{
					return null;
				}
			}

			// Token: 0x170022F2 RID: 8946
			// (get) Token: 0x0600FFEE RID: 65518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170022F2")]
			public HalfIdleBattleEquipManager.HalfIdleEquip currentEquip
			{
				[Token(Token = "0x600FFEE")]
				[Address(RVA = "0x77EBC0", Offset = "0x77D7C0", VA = "0x18077EBC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FFEF RID: 65519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFEF")]
			[Address(RVA = "0x77DEB0", Offset = "0x77CAB0", VA = "0x18077DEB0")]
			public void OnInit(Act1VHalfIdleEquipType type)
			{
			}

			// Token: 0x0600FFF0 RID: 65520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFF0")]
			[Address(RVA = "0x77DD70", Offset = "0x77C970", VA = "0x18077DD70")]
			public void OnDestroy()
			{
			}

			// Token: 0x0600FFF1 RID: 65521 RVA: 0x00061500 File Offset: 0x0005F700
			[Token(Token = "0x600FFF1")]
			[Address(RVA = "0x77DC30", Offset = "0x77C830", VA = "0x18077DC30")]
			public bool DropEquip(uint instanceId)
			{
				return default(bool);
			}

			// Token: 0x0600FFF2 RID: 65522 RVA: 0x00061518 File Offset: 0x0005F718
			[Token(Token = "0x600FFF2")]
			[Address(RVA = "0x77DA70", Offset = "0x77C670", VA = "0x18077DA70")]
			public bool CreateEquip(Act1VHalfIdleEquipData data, uint instanceId)
			{
				return default(bool);
			}

			// Token: 0x0600FFF3 RID: 65523 RVA: 0x00061530 File Offset: 0x0005F730
			[Token(Token = "0x600FFF3")]
			[Address(RVA = "0x77DFB0", Offset = "0x77CBB0", VA = "0x18077DFB0")]
			public bool UpgradeCurrentEquip(Act1VHalfIdleEquipData data, uint instanceId)
			{
				return default(bool);
			}

			// Token: 0x0600FFF4 RID: 65524 RVA: 0x00061548 File Offset: 0x0005F748
			[Token(Token = "0x600FFF4")]
			[Address(RVA = "0x77E230", Offset = "0x77CE30", VA = "0x18077E230")]
			public bool WearEquip(uint instanceId, [Optional] List<Act1VHalfIdleEquipType> autoUpgradedTypes, bool tryAutoUpgrade = false)
			{
				return default(bool);
			}

			// Token: 0x0600FFF5 RID: 65525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFF5")]
			[Address(RVA = "0x77E5D0", Offset = "0x77D1D0", VA = "0x18077E5D0")]
			private void _TryAutoUpgrade()
			{
			}

			// Token: 0x0600FFF6 RID: 65526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFF6")]
			[Address(RVA = "0x77E520", Offset = "0x77D120", VA = "0x18077E520")]
			private void _DropEquipInternal(HalfIdleBattleEquipManager.HalfIdleEquip equip)
			{
			}

			// Token: 0x0600FFF7 RID: 65527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FFF7")]
			[Address(RVA = "0x77EB60", Offset = "0x77D760", VA = "0x18077EB60")]
			public HalfIdleEquipSlot()
			{
			}

			// Token: 0x04011C42 RID: 72770
			[Token(Token = "0x4011C42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<HalfIdleBattleEquipManager.HalfIdleEquip> m_equipsInBag;

			// Token: 0x04011C43 RID: 72771
			[Token(Token = "0x4011C43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Act1VHalfIdleEquipType m_type;

			// Token: 0x04011C44 RID: 72772
			[Token(Token = "0x4011C44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private HalfIdleBattleEquipManager.HalfIdleEquip m_currentEquip;

			// Token: 0x04011C45 RID: 72773
			[Token(Token = "0x4011C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_equips;

			// Token: 0x04011C46 RID: 72774
			[Token(Token = "0x4011C46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_currentEquip;

			// Token: 0x04011C47 RID: 72775
			[Token(Token = "0x4011C47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04011C48 RID: 72776
			[Token(Token = "0x4011C48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x04011C49 RID: 72777
			[Token(Token = "0x4011C49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DropEquip;

			// Token: 0x04011C4A RID: 72778
			[Token(Token = "0x4011C4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CreateEquip;

			// Token: 0x04011C4B RID: 72779
			[Token(Token = "0x4011C4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_UpgradeCurrentEquip;

			// Token: 0x04011C4C RID: 72780
			[Token(Token = "0x4011C4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_WearEquip;

			// Token: 0x04011C4D RID: 72781
			[Token(Token = "0x4011C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TryAutoUpgrade;

			// Token: 0x04011C4E RID: 72782
			[Token(Token = "0x4011C4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__DropEquipInternal;

			// Token: 0x04011C4F RID: 72783
			[Token(Token = "0x4011C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002632 RID: 9778
		[Token(Token = "0x2002632")]
		public class HalfIdleEquip : IHotfixable
		{
			// Token: 0x170022F3 RID: 8947
			// (get) Token: 0x0600FFFF RID: 65535 RVA: 0x000615A8 File Offset: 0x0005F7A8
			[Token(Token = "0x170022F3")]
			public uint instanceId
			{
				[Token(Token = "0x600FFFF")]
				[Address(RVA = "0x77FFE0", Offset = "0x77EBE0", VA = "0x18077FFE0")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x170022F4 RID: 8948
			// (get) Token: 0x06010000 RID: 65536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170022F4")]
			public Act1VHalfIdleEquipData data
			{
				[Token(Token = "0x6010000")]
				[Address(RVA = "0x77FF80", Offset = "0x77EB80", VA = "0x18077FF80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06010001 RID: 65537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010001")]
			[Address(RVA = "0x77ED50", Offset = "0x77D950", VA = "0x18077ED50")]
			public void OnInit(Act1VHalfIdleEquipData data, uint instanceId)
			{
			}

			// Token: 0x06010002 RID: 65538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010002")]
			[Address(RVA = "0x77F070", Offset = "0x77DC70", VA = "0x18077F070")]
			public void SetEnable(bool enable)
			{
			}

			// Token: 0x06010003 RID: 65539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010003")]
			[Address(RVA = "0x77EC80", Offset = "0x77D880", VA = "0x18077EC80")]
			public void OnDispose()
			{
			}

			// Token: 0x06010004 RID: 65540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010004")]
			[Address(RVA = "0x77F3D0", Offset = "0x77DFD0", VA = "0x18077F3D0")]
			private void _InitRunes(Act1VHalfIdleEquipData equipData)
			{
			}

			// Token: 0x06010005 RID: 65541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010005")]
			[Address(RVA = "0x77F770", Offset = "0x77E370", VA = "0x18077F770")]
			private RuneTable.PackedRuneData _PreProcessRuneData(RuneTable.PackedRuneData packedRuneData)
			{
				return null;
			}

			// Token: 0x06010006 RID: 65542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010006")]
			[Address(RVA = "0x77F5C0", Offset = "0x77E1C0", VA = "0x18077F5C0")]
			private void _PreProcessGlobalBuffs(LevelData levelData, MapData mapData)
			{
			}

			// Token: 0x06010007 RID: 65543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010007")]
			[Address(RVA = "0x77F1A0", Offset = "0x77DDA0", VA = "0x18077F1A0")]
			private void _CreateGlobalBuffs()
			{
			}

			// Token: 0x06010008 RID: 65544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010008")]
			[Address(RVA = "0x77FF20", Offset = "0x77EB20", VA = "0x18077FF20")]
			public HalfIdleEquip()
			{
			}

			// Token: 0x04011C54 RID: 72788
			[Token(Token = "0x4011C54")]
			private const string EQUIP_VARIANCE_PREFIX = "variance@";

			// Token: 0x04011C55 RID: 72789
			[Token(Token = "0x4011C55")]
			private const string EQUIP_RUNE_BB_PREFIX_PATTERN = "^hi\\d+@";

			// Token: 0x04011C56 RID: 72790
			[Token(Token = "0x4011C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleEquipData m_data;

			// Token: 0x04011C57 RID: 72791
			[Token(Token = "0x4011C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private uint m_instanceId;

			// Token: 0x04011C58 RID: 72792
			[Token(Token = "0x4011C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<Rune> m_runes;

			// Token: 0x04011C59 RID: 72793
			[Token(Token = "0x4011C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<LevelData.GlobalBuffData> m_globalBuffData;

			// Token: 0x04011C5A RID: 72794
			[Token(Token = "0x4011C5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<uint> m_globalBuffUids;

			// Token: 0x04011C5B RID: 72795
			[Token(Token = "0x4011C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool m_isEnabled;

			// Token: 0x04011C5C RID: 72796
			[Token(Token = "0x4011C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_instanceId;

			// Token: 0x04011C5D RID: 72797
			[Token(Token = "0x4011C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x04011C5E RID: 72798
			[Token(Token = "0x4011C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04011C5F RID: 72799
			[Token(Token = "0x4011C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetEnable;

			// Token: 0x04011C60 RID: 72800
			[Token(Token = "0x4011C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnDispose;

			// Token: 0x04011C61 RID: 72801
			[Token(Token = "0x4011C61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitRunes;

			// Token: 0x04011C62 RID: 72802
			[Token(Token = "0x4011C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__PreProcessRuneData;

			// Token: 0x04011C63 RID: 72803
			[Token(Token = "0x4011C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__PreProcessGlobalBuffs;

			// Token: 0x04011C64 RID: 72804
			[Token(Token = "0x4011C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__CreateGlobalBuffs;

			// Token: 0x04011C65 RID: 72805
			[Token(Token = "0x4011C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
