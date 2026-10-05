using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	[Serializable]
	public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr>, IEnumerable
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x17000499")]
		public static FourCC FrameMarkerEvent
		{
			[Token(Token = "0x6001037")]
			[Address(RVA = "0x56DE0F0", Offset = "0x56DCCF0", VA = "0x1856DE0F0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x000087F0 File Offset: 0x000069F0
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049A")]
		public int deviceId
		{
			[Token(Token = "0x6001038")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001039")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x1700049B")]
		public bool enabled
		{
			[Token(Token = "0x600103A")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00008820 File Offset: 0x00006A20
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049C")]
		public bool recordFrameMarkers
		{
			[Token(Token = "0x600103B")]
			[Address(RVA = "0x56DE1F0", Offset = "0x56DCDF0", VA = "0x1856DE1F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600103C")]
			[Address(RVA = "0x56DE250", Offset = "0x56DCE50", VA = "0x1856DE250")]
			set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x1700049D")]
		public long eventCount
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x1700049E")]
		public long totalEventSizeInBytes
		{
			[Token(Token = "0x600103E")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x1700049F")]
		public long allocatedSizeInBytes
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x56DE130", Offset = "0x56DCD30", VA = "0x1856DE130")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x170004A0")]
		public long maxSizeInBytes
		{
			[Token(Token = "0x6001040")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x170004A1")]
		public ReadOnlyArray<InputEventTrace.DeviceInfo> deviceInfos
		{
			[Token(Token = "0x6001041")]
			[Address(RVA = "0x56DE150", Offset = "0x56DCD50", VA = "0x1856DE150")]
			get
			{
				return default(ReadOnlyArray<InputEventTrace.DeviceInfo>);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A2")]
		public Func<InputEventPtr, InputDevice, bool> onFilterEvent
		{
			[Token(Token = "0x6001042")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001043")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000024")]
		public event Action<InputEventPtr> onEvent
		{
			[Token(Token = "0x6001044")]
			[Address(RVA = "0x56DE0A0", Offset = "0x56DCCA0", VA = "0x1856DE0A0")]
			add
			{
			}
			[Token(Token = "0x6001045")]
			[Address(RVA = "0x56DE200", Offset = "0x56DCE00", VA = "0x1856DE200")]
			remove
			{
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x56DDFB0", Offset = "0x56DCBB0", VA = "0x1856DDFB0")]
		public InputEventTrace(InputDevice device, long bufferSizeInBytes = 1048576L, bool growBuffer = false, long maxBufferSizeInBytes = -1L, long growIncrementSizeInBytes = -1L)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x56DDF30", Offset = "0x56DCB30", VA = "0x1856DDF30")]
		public InputEventTrace(long bufferSizeInBytes = 1048576L, bool growBuffer = false, long maxBufferSizeInBytes = -1L, long growIncrementSizeInBytes = -1L)
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x56DDDE0", Offset = "0x56DC9E0", VA = "0x1856DDDE0")]
		public void WriteTo(string filePath)
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x56DD640", Offset = "0x56DC240", VA = "0x1856DD640")]
		public void WriteTo(Stream stream)
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x56DC960", Offset = "0x56DB560", VA = "0x1856DC960")]
		public void ReadFrom(string filePath)
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x56DCA70", Offset = "0x56DB670", VA = "0x1856DCA70")]
		public void ReadFrom(Stream stream)
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x56DC080", Offset = "0x56DAC80", VA = "0x1856DC080")]
		public static InputEventTrace LoadFrom(string filePath)
		{
			return null;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x56DBF10", Offset = "0x56DAB10", VA = "0x1856DBF10")]
		public static InputEventTrace LoadFrom(Stream stream)
		{
			return null;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x56DD320", Offset = "0x56DBF20", VA = "0x1856DD320")]
		public InputEventTrace.ReplayController Replay()
		{
			return null;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x56DD390", Offset = "0x56DBF90", VA = "0x1856DD390")]
		public bool Resize(long newBufferSize, long newMaxBufferSize = -1L)
		{
			return default(bool);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x56DBB10", Offset = "0x56DA710", VA = "0x1856DBB10")]
		public void Clear()
		{
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x56DBCE0", Offset = "0x56DA8E0", VA = "0x1856DBCE0")]
		public void Enable()
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x56DBB50", Offset = "0x56DA750", VA = "0x1856DBB50")]
		public void Disable()
		{
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x56DBEA0", Offset = "0x56DAAA0", VA = "0x1856DBEA0")]
		public bool GetNextEvent(ref InputEventPtr current)
		{
			return default(bool);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x56DBE40", Offset = "0x56DAA40", VA = "0x1856DBE40", Slot = "5")]
		public IEnumerator<InputEventPtr> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x56DBE40", Offset = "0x56DAA40", VA = "0x1856DBE40", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x56DBC70", Offset = "0x56DA870", VA = "0x1856DBC70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A3")]
		private unsafe byte* m_EventBuffer
		{
			[Token(Token = "0x6001057")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001058")]
			[Address(RVA = "0x32F7220", Offset = "0x32F5E20", VA = "0x1832F7220")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		private unsafe byte* m_EventBufferHead
		{
			[Token(Token = "0x6001059")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600105A")]
			[Address(RVA = "0x4DA97A0", Offset = "0x4DA83A0", VA = "0x184DA97A0")]
			set
			{
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A5")]
		private unsafe byte* m_EventBufferTail
		{
			[Token(Token = "0x600105B")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x4DA98E0", Offset = "0x4DA84E0", VA = "0x184DA98E0")]
			set
			{
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x56DBAE0", Offset = "0x56DA6E0", VA = "0x1856DBAE0")]
		private void Allocate()
		{
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600105E")]
		[Address(RVA = "0x56DD2B0", Offset = "0x56DBEB0", VA = "0x1856DD2B0")]
		private void Release()
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600105F")]
		[Address(RVA = "0x56DC310", Offset = "0x56DAF10", VA = "0x1856DC310")]
		private void OnBeforeUpdate()
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x56DC420", Offset = "0x56DB020", VA = "0x1856DC420")]
		private void OnInputEvent(InputEventPtr inputEvent, InputDevice device)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x170004A6")]
		private static FourCC kFileFormat
		{
			[Token(Token = "0x6001061")]
			[Address(RVA = "0x56DE1B0", Offset = "0x56DCDB0", VA = "0x1856DE1B0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		private const int kDefaultBufferSize = 1048576;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private int m_ChangeCounter;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x14")]
		[NonSerialized]
		private bool m_Enabled;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private Func<InputEventPtr, InputDevice, bool> m_OnFilterEvent;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_DeviceId;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private CallbackArray<Action<InputEventPtr>> m_EventListeners;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private long m_EventBufferSize;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private long m_MaxEventBufferSize;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private long m_GrowIncrementSize;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private long m_EventCount;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private long m_EventSizeInBytes;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ulong m_EventBufferStorage;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ulong m_EventBufferHeadStorage;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ulong m_EventBufferTailStorage;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool m_HasWrapped;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_RecordFrameMarkers;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private InputEventTrace.DeviceInfo[] m_DeviceInfos;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x0")]
		private static int kFileVersion;

		// Token: 0x020001B6 RID: 438
		[Token(Token = "0x20001B6")]
		private class Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
		{
			// Token: 0x06001063 RID: 4195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001063")]
			[Address(RVA = "0x56E9250", Offset = "0x56E7E50", VA = "0x1856E9250")]
			public Enumerator(InputEventTrace trace)
			{
			}

			// Token: 0x06001064 RID: 4196 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001064")]
			[Address(RVA = "0x56E9060", Offset = "0x56E7C60", VA = "0x1856E9060", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x06001065 RID: 4197 RVA: 0x000088F8 File Offset: 0x00006AF8
			[Token(Token = "0x6001065")]
			[Address(RVA = "0x56E9090", Offset = "0x56E7C90", VA = "0x1856E9090", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001066")]
			[Address(RVA = "0x56E9170", Offset = "0x56E7D70", VA = "0x1856E9170", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x170004A7 RID: 1191
			// (get) Token: 0x06001067 RID: 4199 RVA: 0x00008910 File Offset: 0x00006B10
			[Token(Token = "0x170004A7")]
			public InputEventPtr Current
			{
				[Token(Token = "0x6001067")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
				get
				{
					return default(InputEventPtr);
				}
			}

			// Token: 0x170004A8 RID: 1192
			// (get) Token: 0x06001068 RID: 4200 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A8")]
			private object Current
			{
				[Token(Token = "0x6001068")]
				[Address(RVA = "0x56E91A0", Offset = "0x56E7DA0", VA = "0x1856E91A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040009E3 RID: 2531
			[Token(Token = "0x40009E3")]
			[FieldOffset(Offset = "0x10")]
			private InputEventTrace m_Trace;

			// Token: 0x040009E4 RID: 2532
			[Token(Token = "0x40009E4")]
			[FieldOffset(Offset = "0x18")]
			private int m_ChangeCounter;

			// Token: 0x040009E5 RID: 2533
			[Token(Token = "0x40009E5")]
			[FieldOffset(Offset = "0x20")]
			internal InputEventPtr m_Current;
		}

		// Token: 0x020001B7 RID: 439
		[Token(Token = "0x20001B7")]
		[Flags]
		private enum FileFlags
		{
			// Token: 0x040009E7 RID: 2535
			[Token(Token = "0x40009E7")]
			FixedUpdate = 1
		}

		// Token: 0x020001B8 RID: 440
		[Token(Token = "0x20001B8")]
		public class ReplayController : IDisposable
		{
			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x06001069 RID: 4201 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A9")]
			public InputEventTrace trace
			{
				[Token(Token = "0x6001069")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004AA RID: 1194
			// (get) Token: 0x0600106A RID: 4202 RVA: 0x00008928 File Offset: 0x00006B28
			// (set) Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004AA")]
			public bool finished
			{
				[Token(Token = "0x600106A")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600106B")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170004AB RID: 1195
			// (get) Token: 0x0600106C RID: 4204 RVA: 0x00008940 File Offset: 0x00006B40
			// (set) Token: 0x0600106D RID: 4205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004AB")]
			public bool paused
			{
				[Token(Token = "0x600106C")]
				[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600106D")]
				[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004AC RID: 1196
			// (get) Token: 0x0600106E RID: 4206 RVA: 0x00008958 File Offset: 0x00006B58
			// (set) Token: 0x0600106F RID: 4207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004AC")]
			public int position
			{
				[Token(Token = "0x600106E")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600106F")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170004AD RID: 1197
			// (get) Token: 0x06001070 RID: 4208 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AD")]
			public IEnumerable<InputDevice> createdDevices
			{
				[Token(Token = "0x6001070")]
				[Address(RVA = "0x56F9E70", Offset = "0x56F8A70", VA = "0x1856F9E70")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001071 RID: 4209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001071")]
			[Address(RVA = "0x56F9DE0", Offset = "0x56F89E0", VA = "0x1856F9DE0")]
			internal ReplayController(InputEventTrace trace)
			{
			}

			// Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001072")]
			[Address(RVA = "0x56F8B10", Offset = "0x56F7710", VA = "0x1856F8B10", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06001073 RID: 4211 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001073")]
			[Address(RVA = "0x56F9BB0", Offset = "0x56F87B0", VA = "0x1856F9BB0")]
			public InputEventTrace.ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice)
			{
				return null;
			}

			// Token: 0x06001074 RID: 4212 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x56F9C90", Offset = "0x56F8890", VA = "0x1856F9C90")]
			public InputEventTrace.ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId)
			{
				return null;
			}

			// Token: 0x06001075 RID: 4213 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x56F9BA0", Offset = "0x56F87A0", VA = "0x1856F9BA0")]
			public InputEventTrace.ReplayController WithAllDevicesMappedToNewInstances()
			{
				return null;
			}

			// Token: 0x06001076 RID: 4214 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001076")]
			[Address(RVA = "0x37369F0", Offset = "0x37355F0", VA = "0x1837369F0")]
			public InputEventTrace.ReplayController OnFinished(Action action)
			{
				return null;
			}

			// Token: 0x06001077 RID: 4215 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001077")]
			[Address(RVA = "0x3736A10", Offset = "0x3735610", VA = "0x183736A10")]
			public InputEventTrace.ReplayController OnEvent(Action<InputEventPtr> action)
			{
				return null;
			}

			// Token: 0x06001078 RID: 4216 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001078")]
			[Address(RVA = "0x56F9880", Offset = "0x56F8480", VA = "0x1856F9880")]
			public InputEventTrace.ReplayController PlayOneEvent()
			{
				return null;
			}

			// Token: 0x06001079 RID: 4217 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001079")]
			[Address(RVA = "0x56F9B50", Offset = "0x56F8750", VA = "0x1856F9B50")]
			public InputEventTrace.ReplayController Rewind()
			{
				return null;
			}

			// Token: 0x0600107A RID: 4218 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600107A")]
			[Address(RVA = "0x56F97D0", Offset = "0x56F83D0", VA = "0x1856F97D0")]
			public InputEventTrace.ReplayController PlayAllFramesOneByOne()
			{
				return null;
			}

			// Token: 0x0600107B RID: 4219 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600107B")]
			[Address(RVA = "0x56F9730", Offset = "0x56F8330", VA = "0x1856F9730")]
			public InputEventTrace.ReplayController PlayAllEvents()
			{
				return null;
			}

			// Token: 0x0600107C RID: 4220 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600107C")]
			[Address(RVA = "0x56F9440", Offset = "0x56F8040", VA = "0x1856F9440")]
			public InputEventTrace.ReplayController PlayAllEventsAccordingToTimestamps()
			{
				return null;
			}

			// Token: 0x0600107D RID: 4221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600107D")]
			[Address(RVA = "0x56F9220", Offset = "0x56F7E20", VA = "0x1856F9220")]
			private void OnBeginFrame()
			{
			}

			// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600107E")]
			[Address(RVA = "0x56F8DD0", Offset = "0x56F79D0", VA = "0x1856F8DD0")]
			private void Finished()
			{
			}

			// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600107F")]
			[Address(RVA = "0x56F9910", Offset = "0x56F8510", VA = "0x1856F9910")]
			private void QueueEvent(InputEventPtr eventPtr)
			{
			}

			// Token: 0x06001080 RID: 4224 RVA: 0x00008970 File Offset: 0x00006B70
			[Token(Token = "0x6001080")]
			[Address(RVA = "0x56F8E90", Offset = "0x56F7A90", VA = "0x1856F8E90")]
			private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr)
			{
				return default(bool);
			}

			// Token: 0x06001081 RID: 4225 RVA: 0x00008988 File Offset: 0x00006B88
			[Token(Token = "0x6001081")]
			[Address(RVA = "0x56F87C0", Offset = "0x56F73C0", VA = "0x1856F87C0")]
			private int ApplyDeviceMapping(int originalDeviceId)
			{
				return 0;
			}

			// Token: 0x040009EB RID: 2539
			[Token(Token = "0x40009EB")]
			[FieldOffset(Offset = "0x18")]
			private InputEventTrace m_EventTrace;

			// Token: 0x040009EC RID: 2540
			[Token(Token = "0x40009EC")]
			[FieldOffset(Offset = "0x20")]
			private InputEventTrace.Enumerator m_Enumerator;

			// Token: 0x040009ED RID: 2541
			[Token(Token = "0x40009ED")]
			[FieldOffset(Offset = "0x28")]
			private InlinedArray<KeyValuePair<int, int>> m_DeviceIDMappings;

			// Token: 0x040009EE RID: 2542
			[Token(Token = "0x40009EE")]
			[FieldOffset(Offset = "0x40")]
			private bool m_CreateNewDevices;

			// Token: 0x040009EF RID: 2543
			[Token(Token = "0x40009EF")]
			[FieldOffset(Offset = "0x48")]
			private InlinedArray<InputDevice> m_CreatedDevices;

			// Token: 0x040009F0 RID: 2544
			[Token(Token = "0x40009F0")]
			[FieldOffset(Offset = "0x60")]
			private Action m_OnFinished;

			// Token: 0x040009F1 RID: 2545
			[Token(Token = "0x40009F1")]
			[FieldOffset(Offset = "0x68")]
			private Action<InputEventPtr> m_OnEvent;

			// Token: 0x040009F2 RID: 2546
			[Token(Token = "0x40009F2")]
			[FieldOffset(Offset = "0x70")]
			private double m_StartTimeAsPerFirstEvent;

			// Token: 0x040009F3 RID: 2547
			[Token(Token = "0x40009F3")]
			[FieldOffset(Offset = "0x78")]
			private double m_StartTimeAsPerRuntime;

			// Token: 0x040009F4 RID: 2548
			[Token(Token = "0x40009F4")]
			[FieldOffset(Offset = "0x80")]
			private int m_AllEventsByTimeIndex;

			// Token: 0x040009F5 RID: 2549
			[Token(Token = "0x40009F5")]
			[FieldOffset(Offset = "0x88")]
			private List<InputEventPtr> m_AllEventsByTime;
		}

		// Token: 0x020001BB RID: 443
		[Token(Token = "0x20001BB")]
		[Serializable]
		public struct DeviceInfo
		{
			// Token: 0x170004AE RID: 1198
			// (get) Token: 0x06001087 RID: 4231 RVA: 0x000089D0 File Offset: 0x00006BD0
			// (set) Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004AE")]
			public int deviceId
			{
				[Token(Token = "0x6001087")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001088")]
				[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
				set
				{
				}
			}

			// Token: 0x170004AF RID: 1199
			// (get) Token: 0x06001089 RID: 4233 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004AF")]
			public string layout
			{
				[Token(Token = "0x6001089")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return null;
				}
				[Token(Token = "0x600108A")]
				[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
				set
				{
				}
			}

			// Token: 0x170004B0 RID: 1200
			// (get) Token: 0x0600108B RID: 4235 RVA: 0x000089E8 File Offset: 0x00006BE8
			// (set) Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004B0")]
			public FourCC stateFormat
			{
				[Token(Token = "0x600108B")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return default(FourCC);
				}
				[Token(Token = "0x600108C")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				set
				{
				}
			}

			// Token: 0x170004B1 RID: 1201
			// (get) Token: 0x0600108D RID: 4237 RVA: 0x00008A00 File Offset: 0x00006C00
			// (set) Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004B1")]
			public int stateSizeInBytes
			{
				[Token(Token = "0x600108D")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600108E")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				set
				{
				}
			}

			// Token: 0x040009F9 RID: 2553
			[Token(Token = "0x40009F9")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			internal int m_DeviceId;

			// Token: 0x040009FA RID: 2554
			[Token(Token = "0x40009FA")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			internal string m_Layout;

			// Token: 0x040009FB RID: 2555
			[Token(Token = "0x40009FB")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal FourCC m_StateFormat;

			// Token: 0x040009FC RID: 2556
			[Token(Token = "0x40009FC")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			internal int m_StateSizeInBytes;

			// Token: 0x040009FD RID: 2557
			[Token(Token = "0x40009FD")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			internal string m_FullLayoutJson;
		}
	}
}
