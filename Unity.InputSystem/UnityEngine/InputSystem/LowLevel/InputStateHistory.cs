using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	public class InputStateHistory : IDisposable, IEnumerable<InputStateHistory.Record>, IEnumerable, IInputStateChangeMonitor
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x170004F1")]
		public int Count
		{
			[Token(Token = "0x600114C")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x170004F2")]
		public uint version
		{
			[Token(Token = "0x600114D")]
			[Address(RVA = "0x4FA5A00", Offset = "0x4FA4600", VA = "0x184FA5A00")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00009060 File Offset: 0x00007260
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F3")]
		public int historyDepth
		{
			[Token(Token = "0x600114E")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600114F")]
			[Address(RVA = "0x56F42B0", Offset = "0x56F2EB0", VA = "0x1856F42B0")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00009078 File Offset: 0x00007278
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F4")]
		public int extraMemoryPerRecord
		{
			[Token(Token = "0x6001150")]
			[Address(RVA = "0x150B0C0", Offset = "0x1509CC0", VA = "0x18150B0C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001151")]
			[Address(RVA = "0x56F41C0", Offset = "0x56F2DC0", VA = "0x1856F41C0")]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00009090 File Offset: 0x00007290
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F5")]
		public InputUpdateType updateMask
		{
			[Token(Token = "0x6001152")]
			[Address(RVA = "0x56F3FB0", Offset = "0x56F2BB0", VA = "0x1856F3FB0")]
			get
			{
				return InputUpdateType.None;
			}
			[Token(Token = "0x6001153")]
			[Address(RVA = "0x56F43A0", Offset = "0x56F2FA0", VA = "0x1856F43A0")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x170004F6")]
		public ReadOnlyArray<InputControl> controls
		{
			[Token(Token = "0x6001154")]
			[Address(RVA = "0x56F3F50", Offset = "0x56F2B50", VA = "0x1856F3F50")]
			get
			{
				return default(ReadOnlyArray<InputControl>);
			}
		}

		// Token: 0x170004F7 RID: 1271
		[Token(Token = "0x170004F7")]
		public InputStateHistory.Record this[int index]
		{
			[Token(Token = "0x6001155")]
			[Address(RVA = "0x56F3DD0", Offset = "0x56F29D0", VA = "0x1856F3DD0")]
			get
			{
				return default(InputStateHistory.Record);
			}
			[Token(Token = "0x6001156")]
			[Address(RVA = "0x56F4050", Offset = "0x56F2C50", VA = "0x1856F4050")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F8")]
		public Action<InputStateHistory.Record> onRecordAdded
		{
			[Token(Token = "0x6001157")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001158")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004F9")]
		public Func<InputControl, double, InputEventPtr, bool> onShouldRecordStateChange
		{
			[Token(Token = "0x6001159")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600115A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x56F3A40", Offset = "0x56F2640", VA = "0x1856F3A40")]
		public InputStateHistory(int maxStateSizeInBytes)
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x56F3B80", Offset = "0x56F2780", VA = "0x1856F3B80")]
		public InputStateHistory(string path)
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x56F3CA0", Offset = "0x56F28A0", VA = "0x1856F3CA0")]
		public InputStateHistory(InputControl control)
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x56F3AF0", Offset = "0x56F26F0", VA = "0x1856F3AF0")]
		public InputStateHistory(IEnumerable<InputControl> controls)
		{
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x56F2980", Offset = "0x56F1580", VA = "0x1856F2980", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x56F2860", Offset = "0x56F1460", VA = "0x1856F2860")]
		public void Clear()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x56F2410", Offset = "0x56F1010", VA = "0x1856F2410")]
		public InputStateHistory.Record AddRecord(InputStateHistory.Record record)
		{
			return default(InputStateHistory.Record);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x56F3530", Offset = "0x56F2130", VA = "0x1856F3530")]
		public void StartRecording()
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x56F36B0", Offset = "0x56F22B0", VA = "0x1856F36B0")]
		public void StopRecording()
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x56F2EC0", Offset = "0x56F1AC0", VA = "0x1856F2EC0")]
		public InputStateHistory.Record RecordStateChange(InputControl control, InputEventPtr eventPtr)
		{
			return default(InputStateHistory.Record);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x56F31E0", Offset = "0x56F1DE0", VA = "0x1856F31E0")]
		public unsafe InputStateHistory.Record RecordStateChange(InputControl control, void* statePtr, double time)
		{
			return default(InputStateHistory.Record);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x56F2A70", Offset = "0x56F1670", VA = "0x1856F2A70", Slot = "5")]
		public IEnumerator<InputStateHistory.Record> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x56F2A70", Offset = "0x56F1670", VA = "0x1856F2A70", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x56F28D0", Offset = "0x56F14D0", VA = "0x1856F28D0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x56F2870", Offset = "0x56F1470", VA = "0x1856F2870")]
		protected void Destroy()
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x56F2590", Offset = "0x56F1190", VA = "0x1856F2590")]
		private void Allocate()
		{
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x56F2EA0", Offset = "0x56F1AA0", VA = "0x1856F2EA0")]
		protected internal int RecordIndexToUserIndex(int index)
		{
			return 0;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x56F3A30", Offset = "0x56F2630", VA = "0x1856F3A30")]
		protected internal int UserIndexToRecordIndex(int index)
		{
			return 0;
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x56F2B80", Offset = "0x56F1780", VA = "0x1856F2B80")]
		protected internal unsafe InputStateHistory.RecordHeader* GetRecord(int index)
		{
			return null;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x56F2AE0", Offset = "0x56F16E0", VA = "0x1856F2AE0")]
		internal unsafe InputStateHistory.RecordHeader* GetRecordUnchecked(int index)
		{
			return null;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x56F24B0", Offset = "0x56F10B0", VA = "0x1856F24B0")]
		protected internal unsafe InputStateHistory.RecordHeader* AllocateRecord(out int index)
		{
			return null;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001170")]
		protected unsafe TValue ReadValue<TValue>(InputStateHistory.RecordHeader* data) where TValue : struct
		{
			return null;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x56F2CF0", Offset = "0x56F18F0", VA = "0x1856F2CF0")]
		protected unsafe object ReadValueAsObject(InputStateHistory.RecordHeader* data)
		{
			return null;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x56F38E0", Offset = "0x56F24E0", VA = "0x1856F38E0", Slot = "7")]
		private void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		private void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
		{
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x170004FA")]
		internal int bytesPerRecord
		{
			[Token(Token = "0x6001174")]
			[Address(RVA = "0x56F3F10", Offset = "0x56F2B10", VA = "0x1856F3F10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		private const int kDefaultHistorySize = 128;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal InputControl[] m_Controls;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int m_ControlCount;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<byte> m_RecordBuffer;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_StateSizeInBytes;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_RecordCount;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_HistoryDepth;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_ExtraMemoryPerRecord;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int m_HeadIndex;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal uint m_CurrentVersion;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputUpdateType? m_UpdateMask;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal readonly bool m_AddNewControls;

		// Token: 0x020001D5 RID: 469
		[Token(Token = "0x20001D5")]
		private struct Enumerator : IEnumerator<InputStateHistory.Record>, IEnumerator, IDisposable
		{
			// Token: 0x06001175 RID: 4469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001175")]
			[Address(RVA = "0x48937B0", Offset = "0x48923B0", VA = "0x1848937B0")]
			public Enumerator(InputStateHistory history)
			{
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x00009168 File Offset: 0x00007368
			[Token(Token = "0x6001176")]
			[Address(RVA = "0x4890CB0", Offset = "0x488F8B0", VA = "0x184890CB0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001177 RID: 4471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001177")]
			[Address(RVA = "0x487A5A0", Offset = "0x48791A0", VA = "0x18487A5A0", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x170004FB RID: 1275
			// (get) Token: 0x06001178 RID: 4472 RVA: 0x00009180 File Offset: 0x00007380
			[Token(Token = "0x170004FB")]
			public InputStateHistory.Record Current
			{
				[Token(Token = "0x6001178")]
				[Address(RVA = "0x56E92A0", Offset = "0x56E7EA0", VA = "0x1856E92A0", Slot = "4")]
				get
				{
					return default(InputStateHistory.Record);
				}
			}

			// Token: 0x170004FC RID: 1276
			// (get) Token: 0x06001179 RID: 4473 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004FC")]
			private object Current
			{
				[Token(Token = "0x6001179")]
				[Address(RVA = "0x56E91F0", Offset = "0x56E7DF0", VA = "0x1856E91F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x04000A77 RID: 2679
			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputStateHistory m_History;

			// Token: 0x04000A78 RID: 2680
			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int m_Index;
		}

		// Token: 0x020001D6 RID: 470
		[Token(Token = "0x20001D6")]
		[StructLayout(2)]
		protected internal struct RecordHeader
		{
			// Token: 0x170004FD RID: 1277
			// (get) Token: 0x0600117B RID: 4475 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004FD")]
			public unsafe byte* statePtrWithControlIndex
			{
				[Token(Token = "0x600117B")]
				[Address(RVA = "0x56F7880", Offset = "0x56F6480", VA = "0x1856F7880")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004FE RID: 1278
			// (get) Token: 0x0600117C RID: 4476 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004FE")]
			public unsafe byte* statePtrWithoutControlIndex
			{
				[Token(Token = "0x600117C")]
				[Address(RVA = "0x4CDE2E0", Offset = "0x4CDCEE0", VA = "0x184CDE2E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000A79 RID: 2681
			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double time;

			// Token: 0x04000A7A RID: 2682
			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint version;

			// Token: 0x04000A7B RID: 2683
			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int controlIndex;

			// Token: 0x04000A7C RID: 2684
			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[FixedBuffer(typeof(byte), 1)]
			private InputStateHistory.RecordHeader.<m_StateWithoutControlIndex>e__FixedBuffer m_StateWithoutControlIndex;

			// Token: 0x04000A7D RID: 2685
			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[FixedBuffer(typeof(byte), 1)]
			private InputStateHistory.RecordHeader.<m_StateWithControlIndex>e__FixedBuffer m_StateWithControlIndex;

			// Token: 0x04000A7E RID: 2686
			[Token(Token = "0x4000A7E")]
			public const int kSizeWithControlIndex = 16;

			// Token: 0x04000A7F RID: 2687
			[Token(Token = "0x4000A7F")]
			public const int kSizeWithoutControlIndex = 12;

			// Token: 0x020001D7 RID: 471
			[Token(Token = "0x20001D7")]
			[CompilerGenerated]
			[UnsafeValueType]
			public struct <m_StateWithoutControlIndex>e__FixedBuffer
			{
				// Token: 0x04000A80 RID: 2688
				[Token(Token = "0x4000A80")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public byte FixedElementField;
			}

			// Token: 0x020001D8 RID: 472
			[Token(Token = "0x20001D8")]
			[UnsafeValueType]
			[CompilerGenerated]
			public struct <m_StateWithControlIndex>e__FixedBuffer
			{
				// Token: 0x04000A81 RID: 2689
				[Token(Token = "0x4000A81")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public byte FixedElementField;
			}
		}

		// Token: 0x020001D9 RID: 473
		[Token(Token = "0x20001D9")]
		public struct Record : IEquatable<InputStateHistory.Record>
		{
			// Token: 0x170004FF RID: 1279
			// (get) Token: 0x0600117D RID: 4477 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004FF")]
			internal unsafe InputStateHistory.RecordHeader* header
			{
				[Token(Token = "0x600117D")]
				[Address(RVA = "0x56F8500", Offset = "0x56F7100", VA = "0x1856F8500")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000500 RID: 1280
			// (get) Token: 0x0600117E RID: 4478 RVA: 0x00009198 File Offset: 0x00007398
			[Token(Token = "0x17000500")]
			internal int recordIndex
			{
				[Token(Token = "0x600117E")]
				[Address(RVA = "0x43C9330", Offset = "0x43C7F30", VA = "0x1843C9330")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000501 RID: 1281
			// (get) Token: 0x0600117F RID: 4479 RVA: 0x000091B0 File Offset: 0x000073B0
			[Token(Token = "0x17000501")]
			internal uint version
			{
				[Token(Token = "0x600117F")]
				[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17000502 RID: 1282
			// (get) Token: 0x06001180 RID: 4480 RVA: 0x000091C8 File Offset: 0x000073C8
			[Token(Token = "0x17000502")]
			public bool valid
			{
				[Token(Token = "0x6001180")]
				[Address(RVA = "0x56F8770", Offset = "0x56F7370", VA = "0x1856F8770")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000503 RID: 1283
			// (get) Token: 0x06001181 RID: 4481 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000503")]
			public InputStateHistory owner
			{
				[Token(Token = "0x6001181")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000504 RID: 1284
			// (get) Token: 0x06001182 RID: 4482 RVA: 0x000091E0 File Offset: 0x000073E0
			[Token(Token = "0x17000504")]
			public int index
			{
				[Token(Token = "0x6001182")]
				[Address(RVA = "0x56F8530", Offset = "0x56F7130", VA = "0x1856F8530")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000505 RID: 1285
			// (get) Token: 0x06001183 RID: 4483 RVA: 0x000091F8 File Offset: 0x000073F8
			[Token(Token = "0x17000505")]
			public double time
			{
				[Token(Token = "0x6001183")]
				[Address(RVA = "0x56F8730", Offset = "0x56F7330", VA = "0x1856F8730")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x17000506 RID: 1286
			// (get) Token: 0x06001184 RID: 4484 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000506")]
			public InputControl control
			{
				[Token(Token = "0x6001184")]
				[Address(RVA = "0x56F83F0", Offset = "0x56F6FF0", VA = "0x1856F83F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000507 RID: 1287
			// (get) Token: 0x06001185 RID: 4485 RVA: 0x00009210 File Offset: 0x00007410
			[Token(Token = "0x17000507")]
			public InputStateHistory.Record next
			{
				[Token(Token = "0x6001185")]
				[Address(RVA = "0x56F8570", Offset = "0x56F7170", VA = "0x1856F8570")]
				get
				{
					return default(InputStateHistory.Record);
				}
			}

			// Token: 0x17000508 RID: 1288
			// (get) Token: 0x06001186 RID: 4486 RVA: 0x00009228 File Offset: 0x00007428
			[Token(Token = "0x17000508")]
			public InputStateHistory.Record previous
			{
				[Token(Token = "0x6001186")]
				[Address(RVA = "0x56F8650", Offset = "0x56F7250", VA = "0x1856F8650")]
				get
				{
					return default(InputStateHistory.Record);
				}
			}

			// Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001187")]
			[Address(RVA = "0x43C8CD0", Offset = "0x43C78D0", VA = "0x1843C8CD0")]
			internal unsafe Record(InputStateHistory owner, int index, InputStateHistory.RecordHeader* header)
			{
			}

			// Token: 0x06001188 RID: 4488 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001188")]
			public TValue ReadValue<TValue>() where TValue : struct
			{
				return null;
			}

			// Token: 0x06001189 RID: 4489 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001189")]
			[Address(RVA = "0x56F80F0", Offset = "0x56F6CF0", VA = "0x1856F80F0")]
			public object ReadValueAsObject()
			{
				return null;
			}

			// Token: 0x0600118A RID: 4490 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600118A")]
			[Address(RVA = "0x56F80D0", Offset = "0x56F6CD0", VA = "0x1856F80D0")]
			public unsafe void* GetUnsafeMemoryPtr()
			{
				return null;
			}

			// Token: 0x0600118B RID: 4491 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600118B")]
			[Address(RVA = "0x56F7FF0", Offset = "0x56F6BF0", VA = "0x1856F7FF0")]
			internal unsafe void* GetUnsafeMemoryPtrUnchecked()
			{
				return null;
			}

			// Token: 0x0600118C RID: 4492 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600118C")]
			[Address(RVA = "0x56F7FD0", Offset = "0x56F6BD0", VA = "0x1856F7FD0")]
			public unsafe void* GetUnsafeExtraMemoryPtr()
			{
				return null;
			}

			// Token: 0x0600118D RID: 4493 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x56F7EF0", Offset = "0x56F6AF0", VA = "0x1856F7EF0")]
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked()
			{
				return null;
			}

			// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600118E")]
			[Address(RVA = "0x56F7970", Offset = "0x56F6570", VA = "0x1856F7970")]
			public void CopyFrom(InputStateHistory.Record record)
			{
			}

			// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600118F")]
			[Address(RVA = "0x56F7890", Offset = "0x56F6490", VA = "0x1856F7890")]
			internal void CheckValid()
			{
			}

			// Token: 0x06001190 RID: 4496 RVA: 0x00009240 File Offset: 0x00007440
			[Token(Token = "0x6001190")]
			[Address(RVA = "0x420DE90", Offset = "0x420CA90", VA = "0x18420DE90", Slot = "4")]
			public bool Equals(InputStateHistory.Record other)
			{
				return default(bool);
			}

			// Token: 0x06001191 RID: 4497 RVA: 0x00009258 File Offset: 0x00007458
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x56F7E40", Offset = "0x56F6A40", VA = "0x1856F7E40", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06001192 RID: 4498 RVA: 0x00009270 File Offset: 0x00007470
			[Token(Token = "0x6001192")]
			[Address(RVA = "0x43C8630", Offset = "0x43C7230", VA = "0x1843C8630", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06001193 RID: 4499 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x56F82D0", Offset = "0x56F6ED0", VA = "0x1856F82D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000A82 RID: 2690
			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputStateHistory m_Owner;

			// Token: 0x04000A83 RID: 2691
			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly int m_IndexPlusOne;

			// Token: 0x04000A84 RID: 2692
			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private uint m_Version;
		}
	}
}
