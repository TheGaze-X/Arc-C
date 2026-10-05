using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public static class InputSystem
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public static event Action<string, InputControlLayoutChange> onLayoutChange
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x562CEE0", Offset = "0x562BAE0", VA = "0x18562CEE0")]
			add
			{
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x562DD70", Offset = "0x562C970", VA = "0x18562DD70")]
			remove
			{
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x562B290", Offset = "0x5629E90", VA = "0x18562B290")]
		public static void RegisterLayout(Type type, [Optional] string name, [Optional] InputDeviceMatcher? matches)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		public static void RegisterLayout<T>([Optional] string name, [Optional] InputDeviceMatcher? matches) where T : InputControl
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x562B450", Offset = "0x562A050", VA = "0x18562B450")]
		public static void RegisterLayout(string json, [Optional] string name, [Optional] InputDeviceMatcher? matches)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x562B200", Offset = "0x5629E00", VA = "0x18562B200")]
		public static void RegisterLayoutOverride(string json, [Optional] string name)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x562B180", Offset = "0x5629D80", VA = "0x18562B180")]
		public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher) where TDevice : InputDevice
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x562AFB0", Offset = "0x5629BB0", VA = "0x18562AFB0")]
		public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, [Optional] string baseLayout, [Optional] InputDeviceMatcher? matches)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		public static void RegisterPrecompiledLayout<TDevice>(string metadata) where TDevice : InputDevice, new()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x562BB30", Offset = "0x562A730", VA = "0x18562BB30")]
		public static void RemoveLayout(string name)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x562C120", Offset = "0x562AD20", VA = "0x18562C120")]
		public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription)
		{
			return null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x562A450", Offset = "0x5629050", VA = "0x18562A450")]
		public static IEnumerable<string> ListLayouts()
		{
			return null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x562A380", Offset = "0x5628F80", VA = "0x18562A380")]
		public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout)
		{
			return null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x562A530", Offset = "0x5629130", VA = "0x18562A530")]
		public static InputControlLayout LoadLayout(string name)
		{
			return null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048E")]
		public static InputControlLayout LoadLayout<TControl>() where TControl : InputControl
		{
			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x5629BE0", Offset = "0x56287E0", VA = "0x185629BE0")]
		public static string GetNameOfBaseLayout(string layoutName)
		{
			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x562A050", Offset = "0x5628C50", VA = "0x18562A050")]
		public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName)
		{
			return default(bool);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x562B550", Offset = "0x562A150", VA = "0x18562B550")]
		public static void RegisterProcessor(Type type, [Optional] string name)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		public static void RegisterProcessor<T>([Optional] string name)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x562C370", Offset = "0x562AF70", VA = "0x18562C370")]
		public static Type TryGetProcessor(string name)
		{
			return null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x562A4C0", Offset = "0x56290C0", VA = "0x18562A4C0")]
		public static IEnumerable<string> ListProcessors()
		{
			return null;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x17000162")]
		public static ReadOnlyArray<InputDevice> devices
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x562D060", Offset = "0x562BC60", VA = "0x18562D060")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x17000163")]
		public static ReadOnlyArray<InputDevice> disconnectedDevices
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x562D0E0", Offset = "0x562BCE0", VA = "0x18562D0E0")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public static event Action<InputDevice, InputDeviceChange> onDeviceChange
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x562CB10", Offset = "0x562B710", VA = "0x18562CB10")]
			add
			{
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x562D9A0", Offset = "0x562C5A0", VA = "0x18562D9A0")]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public static event InputDeviceCommandDelegate onDeviceCommand
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x562CC70", Offset = "0x562B870", VA = "0x18562CC70")]
			add
			{
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x562DB00", Offset = "0x562C700", VA = "0x18562DB00")]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x562CDD0", Offset = "0x562B9D0", VA = "0x18562CDD0")]
			add
			{
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x562DC60", Offset = "0x562C860", VA = "0x18562DC60")]
			remove
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000041D0 File Offset: 0x000023D0
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		public static float pollingFrequency
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x562D4C0", Offset = "0x562C0C0", VA = "0x18562D4C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x562DEF0", Offset = "0x562CAF0", VA = "0x18562DEF0")]
			set
			{
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x5629300", Offset = "0x5627F00", VA = "0x185629300")]
		public static InputDevice AddDevice(string layout, [Optional] string name, [Optional] string variants)
		{
			return null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A0")]
		public static TDevice AddDevice<TDevice>([Optional] string name) where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x5629430", Offset = "0x5628030", VA = "0x185629430")]
		public static InputDevice AddDevice(InputDeviceDescription description)
		{
			return null;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x5629240", Offset = "0x5627E40", VA = "0x185629240")]
		public static void AddDevice(InputDevice device)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x562BAC0", Offset = "0x562A6C0", VA = "0x18562BAC0")]
		public static void RemoveDevice(InputDevice device)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x5629860", Offset = "0x5628460", VA = "0x185629860")]
		public static void FlushDisconnectedDevices()
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x5629B70", Offset = "0x5628770", VA = "0x185629B70")]
		public static InputDevice GetDevice(string nameOrLayout)
		{
			return null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A6")]
		public static TDevice GetDevice<TDevice>() where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x5629930", Offset = "0x5628530", VA = "0x185629930")]
		public static InputDevice GetDevice(Type type)
		{
			return null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A8")]
		public static TDevice GetDevice<TDevice>(InternedString usage) where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004A9")]
		public static TDevice GetDevice<TDevice>(string usage) where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x56298C0", Offset = "0x56284C0", VA = "0x1856298C0")]
		public static InputDevice GetDeviceById(int deviceId)
		{
			return null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x5629D20", Offset = "0x5628920", VA = "0x185629D20")]
		public static List<InputDeviceDescription> GetUnsupportedDevices()
		{
			return null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x5629E00", Offset = "0x5628A00", VA = "0x185629E00")]
		public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions)
		{
			return 0;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x56295E0", Offset = "0x56281E0", VA = "0x1856295E0")]
		public static void EnableDevice(InputDevice device)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x5629550", Offset = "0x5628150", VA = "0x185629550")]
		public static void DisableDevice(InputDevice device, bool keepSendingEvents = false)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x562C510", Offset = "0x562B110", VA = "0x18562C510")]
		public static bool TrySyncDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x562BBA0", Offset = "0x562A7A0", VA = "0x18562BBA0")]
		public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x562C450", Offset = "0x562B050", VA = "0x18562C450")]
		[Obsolete("Use 'ResetDevice' instead.", false)]
		public static bool TryResetDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x562A630", Offset = "0x5629230", VA = "0x18562A630")]
		public static void PauseHaptics()
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x562BD70", Offset = "0x562A970", VA = "0x18562BD70")]
		public static void ResumeHaptics()
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x562BC30", Offset = "0x562A830", VA = "0x18562BC30")]
		public static void ResetHaptics()
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x562BFB0", Offset = "0x562ABB0", VA = "0x18562BFB0")]
		public static void SetDeviceUsage(InputDevice device, string usage)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x562C090", Offset = "0x562AC90", VA = "0x18562C090")]
		public static void SetDeviceUsage(InputDevice device, InternedString usage)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x5629190", Offset = "0x5627D90", VA = "0x185629190")]
		public static void AddDeviceUsage(InputDevice device, string usage)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x5629100", Offset = "0x5627D00", VA = "0x185629100")]
		public static void AddDeviceUsage(InputDevice device, InternedString usage)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x562BA10", Offset = "0x562A610", VA = "0x18562BA10")]
		public static void RemoveDeviceUsage(InputDevice device, string usage)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x562B980", Offset = "0x562A580", VA = "0x18562B980")]
		public static void RemoveDeviceUsage(InputDevice device, InternedString usage)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x5629660", Offset = "0x5628260", VA = "0x185629660")]
		public static InputControl FindControl(string path)
		{
			return null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x56297E0", Offset = "0x56283E0", VA = "0x1856297E0")]
		public static InputControlList<InputControl> FindControls(string path)
		{
			return default(InputControlList<InputControl>);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x60004BD")]
		public static InputControlList<TControl> FindControls<TControl>(string path) where TControl : InputControl
		{
			return default(InputControlList<TControl>);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x60004BE")]
		public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls) where TControl : InputControl
		{
			return 0;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x17000165")]
		internal static bool isProcessingEvents
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x562D180", Offset = "0x562BD80", VA = "0x18562D180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000166")]
		public static InputEventListener onEvent
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(InputEventListener);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000167")]
		public static IObservable<InputControl> onAnyButtonPress
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x562D270", Offset = "0x562BE70", VA = "0x18562D270")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x562A970", Offset = "0x5629570", VA = "0x18562A970")]
		public static void QueueEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C4")]
		public static void QueueEvent<TEvent>(ref TEvent inputEvent) where TEvent : struct, IInputEventTypeInfo
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C5")]
		public static void QueueStateEvent<TState>(InputDevice device, TState state, double time = -1.0) where TState : struct, IInputStateTypeInfo
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C6")]
		public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1.0) where TDelta : struct
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x562A7B0", Offset = "0x56293B0", VA = "0x18562A7B0")]
		public static void QueueConfigChangeEvent(InputDevice device, double time = -1.0)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x562AA70", Offset = "0x5629670", VA = "0x18562AA70")]
		public static void QueueTextEvent(InputDevice device, char character, double time = -1.0)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x562C7D0", Offset = "0x562B3D0", VA = "0x18562C7D0")]
		public static void Update()
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x562C650", Offset = "0x562B250", VA = "0x18562C650")]
		internal static void Update(InputUpdateType updateType)
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public static event Action onBeforeUpdate
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x562CA00", Offset = "0x562B600", VA = "0x18562CA00")]
			add
			{
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x562D890", Offset = "0x562C490", VA = "0x18562D890")]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public static event Action onAfterUpdate
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x562C8F0", Offset = "0x562B4F0", VA = "0x18562C8F0")]
			add
			{
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x562D780", Offset = "0x562C380", VA = "0x18562D780")]
			remove
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public static InputSettings settings
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x562D600", Offset = "0x562C200", VA = "0x18562D600")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x562E080", Offset = "0x562CC80", VA = "0x18562E080")]
			set
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public static event Action onSettingsChange
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x562CFF0", Offset = "0x562BBF0", VA = "0x18562CFF0")]
			add
			{
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x562DE80", Offset = "0x562CA80", VA = "0x18562DE80")]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public static event Action<object, InputActionChange> onActionChange
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x562C840", Offset = "0x562B440", VA = "0x18562C840")]
			add
			{
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x562D6D0", Offset = "0x562C2D0", VA = "0x18562D6D0")]
			remove
			{
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x562AE00", Offset = "0x5629A00", VA = "0x18562AE00")]
		public static void RegisterInteraction(Type type, [Optional] string name)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D6")]
		public static void RegisterInteraction<T>([Optional] string name)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x562C290", Offset = "0x562AE90", VA = "0x18562C290")]
		public static Type TryGetInteraction(string name)
		{
			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x562A310", Offset = "0x5628F10", VA = "0x18562A310")]
		public static IEnumerable<string> ListInteractions()
		{
			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x562AC50", Offset = "0x5629850", VA = "0x18562AC50")]
		public static void RegisterBindingComposite(Type type, string name)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DA")]
		public static void RegisterBindingComposite<T>([Optional] string name)
		{
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x562C1B0", Offset = "0x562ADB0", VA = "0x18562C1B0")]
		public static Type TryGetBindingComposite(string name)
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x5629540", Offset = "0x5628140", VA = "0x185629540")]
		public static void DisableAllEnabledActions()
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x562A280", Offset = "0x5628E80", VA = "0x18562A280")]
		public static List<InputAction> ListEnabledActions()
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x562A210", Offset = "0x5628E10", VA = "0x18562A210")]
		public static int ListEnabledActions(List<InputAction> actions)
		{
			return 0;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000169")]
		public static InputRemoting remoting
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x562D520", Offset = "0x562C120", VA = "0x18562D520")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016A")]
		public static Version version
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x562D660", Offset = "0x562C260", VA = "0x18562D660")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000042C0 File Offset: 0x000024C0
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		public static bool runInBackground
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x562D570", Offset = "0x562C170", VA = "0x18562D570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x562DF60", Offset = "0x562CB60", VA = "0x18562DF60")]
			set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x1700016C")]
		public static InputMetrics metrics
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x562D1E0", Offset = "0x562BDE0", VA = "0x18562D1E0")]
			get
			{
				return default(InputMetrics);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x562BF40", Offset = "0x562AB40", VA = "0x18562BF40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RunInitializeInPlayer()
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal static void EnsureInitialized()
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x5629E70", Offset = "0x5628A70", VA = "0x185629E70")]
		private static void InitializeInPlayer([Optional] IInputRuntime runtime, [Optional] InputSettings settings)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x562BEB0", Offset = "0x562AAB0", VA = "0x18562BEB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RunInitialUpdate()
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x562A770", Offset = "0x5629370", VA = "0x18562A770")]
		private static void PerformDefaultPluginInitialization()
		{
		}

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		internal const string kAssemblyVersion = "1.7.0";

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7";

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static InputManager s_Manager;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static InputRemoting s_Remote;

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		private struct StateEventBuffer
		{
			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StateEvent stateEvent;

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			public const int kMaxSize = 512;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[FixedBuffer(typeof(byte), 511)]
			public InputSystem.StateEventBuffer.<data>e__FixedBuffer data;

			// Token: 0x02000067 RID: 103
			[Token(Token = "0x2000067")]
			[CompilerGenerated]
			[UnsafeValueType]
			public struct <data>e__FixedBuffer
			{
				// Token: 0x0400023C RID: 572
				[Token(Token = "0x400023C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public byte FixedElementField;
			}
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		private struct DeltaStateEventBuffer
		{
			// Token: 0x0400023D RID: 573
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DeltaStateEvent stateEvent;

			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			public const int kMaxSize = 512;

			// Token: 0x0400023F RID: 575
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			[FixedBuffer(typeof(byte), 511)]
			public InputSystem.DeltaStateEventBuffer.<data>e__FixedBuffer data;

			// Token: 0x02000069 RID: 105
			[Token(Token = "0x2000069")]
			[UnsafeValueType]
			[CompilerGenerated]
			public struct <data>e__FixedBuffer
			{
				// Token: 0x04000240 RID: 576
				[Token(Token = "0x4000240")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public byte FixedElementField;
			}
		}
	}
}
