using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class CriAtomExTween : CriDisposable
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x1700005C")]
		internal IntPtr nativeHandle
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x36F0C20", Offset = "0x36EF820", VA = "0x1836F0C20")]
		public CriAtomExTween()
		{
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x36F0E00", Offset = "0x36EFA00", VA = "0x1836F0E00")]
		public CriAtomExTween(CriAtomEx.Parameter parameterId)
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x36F0DF0", Offset = "0x36EF9F0", VA = "0x1836F0DF0")]
		public CriAtomExTween(uint aisacId)
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x36F0C30", Offset = "0x36EF830", VA = "0x1836F0C30")]
		public CriAtomExTween(CriAtomExTween.ParameterType parameterType, uint targetId)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x1700005D")]
		public float Value
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x36F12F0", Offset = "0x36EFEF0", VA = "0x1836F12F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x1700005E")]
		public bool IsActive
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x36F1270", Offset = "0x36EFE70", VA = "0x1836F1270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x36F0A80", Offset = "0x36EF680", VA = "0x1836F0A80")]
		public void MoveTo(ushort durationMs, float value)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x36F09E0", Offset = "0x36EF5E0", VA = "0x1836F09E0")]
		public void MoveFrom(ushort durationMs, float value)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x36F0BA0", Offset = "0x36EF7A0", VA = "0x1836F0BA0")]
		public void Stop()
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x36F0B20", Offset = "0x36EF720", VA = "0x1836F0B20")]
		public void Reset()
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x36E2960", Offset = "0x36E1560", VA = "0x1836E2960", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x36F0890", Offset = "0x36EF490", VA = "0x1836F0890", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600059D RID: 1437
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x36F0E10", Offset = "0x36EFA10", VA = "0x1836F0E10")]
		[PreserveSig]
		private static extern IntPtr criAtomExTween_Create(ref CriAtomExTween.Config config, IntPtr work, int work_size);

		// Token: 0x0600059E RID: 1438
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x36F0EB0", Offset = "0x36EFAB0", VA = "0x1836F0EB0")]
		[PreserveSig]
		private static extern void criAtomExTween_Destroy(IntPtr tween);

		// Token: 0x0600059F RID: 1439
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x36F0F30", Offset = "0x36EFB30", VA = "0x1836F0F30")]
		[PreserveSig]
		private static extern float criAtomExTween_GetValue(IntPtr tween);

		// Token: 0x060005A0 RID: 1440
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x36F10D0", Offset = "0x36EFCD0", VA = "0x1836F10D0")]
		[PreserveSig]
		private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value);

		// Token: 0x060005A1 RID: 1441
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x36F1030", Offset = "0x36EFC30", VA = "0x1836F1030")]
		[PreserveSig]
		private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value);

		// Token: 0x060005A2 RID: 1442
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x36F11F0", Offset = "0x36EFDF0", VA = "0x1836F11F0")]
		[PreserveSig]
		private static extern void criAtomExTween_Stop(IntPtr tween);

		// Token: 0x060005A3 RID: 1443
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x36F1170", Offset = "0x36EFD70", VA = "0x1836F1170")]
		[PreserveSig]
		private static extern void criAtomExTween_Reset(IntPtr tween);

		// Token: 0x060005A4 RID: 1444
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x36F0FB0", Offset = "0x36EFBB0", VA = "0x1836F0FB0")]
		[PreserveSig]
		private static extern bool criAtomExTween_IsActive(IntPtr tween);

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		public enum ParameterType
		{
			// Token: 0x040002FB RID: 763
			[Token(Token = "0x40002FB")]
			Basic,
			// Token: 0x040002FC RID: 764
			[Token(Token = "0x40002FC")]
			Aisac
		}

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		private struct Config
		{
			// Token: 0x040002FD RID: 765
			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExTween.Config.Target target;

			// Token: 0x040002FE RID: 766
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public CriAtomExTween.ParameterType parameterType;

			// Token: 0x02000099 RID: 153
			[Token(Token = "0x2000099")]
			[StructLayout(2)]
			public struct Target
			{
				// Token: 0x040002FF RID: 767
				[Token(Token = "0x40002FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public CriAtomEx.Parameter parameterId;

				// Token: 0x04000300 RID: 768
				[Token(Token = "0x4000300")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint aisacIds;
			}
		}
	}
}
