using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public class CriAtomEx3dListener : CriDisposable
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x36B4C10", Offset = "0x36B3810", VA = "0x1836B4C10")]
		public CriAtomEx3dListener()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x36B3FC0", Offset = "0x36B2BC0", VA = "0x1836B3FC0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x36B3FD0", Offset = "0x36B2BD0", VA = "0x1836B3FD0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x17000044")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x36B4B50", Offset = "0x36B3750", VA = "0x1836B4B50")]
		public void Update()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x36B4200", Offset = "0x36B2E00", VA = "0x1836B4200")]
		public void ResetParameters()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x36B4930", Offset = "0x36B3530", VA = "0x1836B4930")]
		public void SetPosition(float x, float y, float z)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x36B4A40", Offset = "0x36B3640", VA = "0x1836B4A40")]
		public void SetVelocity(float x, float y, float z)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x36B47F0", Offset = "0x36B33F0", VA = "0x1836B47F0")]
		public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x36B4480", Offset = "0x36B3080", VA = "0x1836B4480")]
		[Obsolete("Use SetDopplerMultiplier instead")]
		public void SetDistanceFactor(float distanceFactor)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x36B4620", Offset = "0x36B3220", VA = "0x1836B4620")]
		public void SetDopplerMultiplier(float dopplerMultiplier)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x36B46E0", Offset = "0x36B32E0", VA = "0x1836B46E0")]
		public void SetFocusPoint(float x, float y, float z)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x36B4550", Offset = "0x36B3150", VA = "0x1836B4550")]
		public void SetDistanceFocusLevel(float distanceFocusLevel)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x36B43B0", Offset = "0x36B2FB0", VA = "0x1836B43B0")]
		public void SetDirectionFocusLevel(float directionFocusLevel)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x36B42C0", Offset = "0x36B2EC0", VA = "0x1836B42C0")]
		public void Set3dRegion(CriAtomEx3dRegion region3d)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x36B4180", Offset = "0x36B2D80", VA = "0x1836B4180")]
		public bool IsDestroyable()
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x36B4120", Offset = "0x36B2D20", VA = "0x1836B4120", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060002B3 RID: 691
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x36B4D20", Offset = "0x36B3920", VA = "0x1836B4D20")]
		[PreserveSig]
		private static extern IntPtr criAtomEx3dListener_Create(ref CriAtomEx3dListener.Config config, IntPtr work, int work_size);

		// Token: 0x060002B4 RID: 692
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x36B4DC0", Offset = "0x36B39C0", VA = "0x1836B4DC0")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener);

		// Token: 0x060002B5 RID: 693
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x36B5460", Offset = "0x36B4060", VA = "0x1836B5460")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener);

		// Token: 0x060002B6 RID: 694
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x36B4EC0", Offset = "0x36B3AC0", VA = "0x1836B4EC0")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener);

		// Token: 0x060002B7 RID: 695
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x36B5340", Offset = "0x36B3F40", VA = "0x1836B5340")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position);

		// Token: 0x060002B8 RID: 696
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x36B53D0", Offset = "0x36B3FD0", VA = "0x1836B53D0")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity);

		// Token: 0x060002B9 RID: 697
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x36B52A0", Offset = "0x36B3EA0", VA = "0x1836B52A0")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);

		// Token: 0x060002BA RID: 698
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x36B5060", Offset = "0x36B3C60", VA = "0x1836B5060")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor);

		// Token: 0x060002BB RID: 699
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x36B5180", Offset = "0x36B3D80", VA = "0x1836B5180")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier);

		// Token: 0x060002BC RID: 700
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x36B5210", Offset = "0x36B3E10", VA = "0x1836B5210")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point);

		// Token: 0x060002BD RID: 701
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x36B50F0", Offset = "0x36B3CF0", VA = "0x1836B50F0")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level);

		// Token: 0x060002BE RID: 702
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x36B4FD0", Offset = "0x36B3BD0", VA = "0x1836B4FD0")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level);

		// Token: 0x060002BF RID: 703
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x36B4E40", Offset = "0x36B3A40", VA = "0x1836B4E40")]
		[PreserveSig]
		private static extern bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener);

		// Token: 0x060002C0 RID: 704
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x36B4F40", Offset = "0x36B3B40", VA = "0x1836B4F40")]
		[PreserveSig]
		private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region);

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		public struct Config
		{
			// Token: 0x040001EC RID: 492
			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int reserved;
		}
	}
}
