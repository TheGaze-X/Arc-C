using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class CriAtomOutputDeviceObserver : CriMonoBehaviour
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000EE RID: 238 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000A")]
		public static event CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback OnDeviceConnectionChanged
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x36CF010", Offset = "0x36CDC10", VA = "0x1836CF010")]
			add
			{
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x36CF370", Offset = "0x36CDF70", VA = "0x1836CF370")]
			remove
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x17000018")]
		public static bool IsDeviceConnected
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x36CF290", Offset = "0x36CDE90", VA = "0x1836CF290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x17000019")]
		public static CriAtomOutputDeviceObserver.OutputDeviceType DeviceType
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x36CF220", Offset = "0x36CDE20", VA = "0x1836CF220")]
			get
			{
				return CriAtomOutputDeviceObserver.OutputDeviceType.BuiltinSpeaker;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000B")]
		private static event CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback _onDeviceConnectionChanged
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x36CF160", Offset = "0x36CDD60", VA = "0x1836CF160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x36CF370", Offset = "0x36CDF70", VA = "0x1836CF370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x36CEC60", Offset = "0x36CD860", VA = "0x1836CEC60")]
		private void Awake()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x36CEEF0", Offset = "0x36CDAF0", VA = "0x1836CEEF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x36CEE70", Offset = "0x36CDA70", VA = "0x1836CEE70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x36CF000", Offset = "0x36CDC00", VA = "0x1836CF000")]
		public CriAtomOutputDeviceObserver()
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool dontDestroyOnLoad;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool lastIsConnected;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool isConnected;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CriAtomOutputDeviceObserver.OutputDeviceType lastDeviceType;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CriAtomOutputDeviceObserver.OutputDeviceType deviceType;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CriAtomOutputDeviceObserver instance;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		public enum OutputDeviceType
		{
			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			BuiltinSpeaker,
			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			WiredDevice,
			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			WirelessDevice
		}

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000FA RID: 250
		[Token(Token = "0x2000017")]
		public delegate void DeviceConnectionChangeCallback(bool isConnected, CriAtomOutputDeviceObserver.OutputDeviceType deviceType);

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		private static class UnsafeNativeMethods
		{
			// Token: 0x060000FD RID: 253
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x36DE010", Offset = "0x36DCC10", VA = "0x1836DE010")]
			[PreserveSig]
			internal static extern void criAtomUnity_StartOutputDeviceObserver_WASAPI();

			// Token: 0x060000FE RID: 254
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x36DE080", Offset = "0x36DCC80", VA = "0x1836DE080")]
			[PreserveSig]
			internal static extern void criAtomUnity_StopOutputDeviceObserver_WASAPI();

			// Token: 0x060000FF RID: 255
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x36DDFA0", Offset = "0x36DCBA0", VA = "0x1836DDFA0")]
			[PreserveSig]
			internal static extern bool criAtomUnity_IsOutputDeviceConnected_WASAPI();
		}
	}
}
