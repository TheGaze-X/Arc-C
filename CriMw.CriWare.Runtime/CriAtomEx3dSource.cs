using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public class CriAtomEx3dSource : CriDisposable
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x36B6A20", Offset = "0x36B5620", VA = "0x1836B6A20")]
		public CriAtomEx3dSource(bool enableVoicePriorityDecay = false, uint randomPositionListMaxLength = 0U)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x36B5830", Offset = "0x36B4430", VA = "0x1836B5830", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x36B5840", Offset = "0x36B4440", VA = "0x1836B5840")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x17000045")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x36B69A0", Offset = "0x36B55A0", VA = "0x1836B69A0")]
		public void Update()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x36B5B90", Offset = "0x36B4790", VA = "0x1836B5B90")]
		public void ResetParameters()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x36B6310", Offset = "0x36B4F10", VA = "0x1836B6310")]
		public void SetPosition(float x, float y, float z)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x36B6880", Offset = "0x36B5480", VA = "0x1836B6880")]
		public void SetVelocity(float x, float y, float z)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x36B6240", Offset = "0x36B4E40", VA = "0x1836B6240")]
		public void SetOrientation(Vector3 front, Vector3 top)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x36B5D70", Offset = "0x36B4970", VA = "0x1836B5D70")]
		[Obsolete("Use CriAtomEx3dSource.SetOrientation(Vector3, Vector3) instead")]
		public void SetConeOrientation(float x, float y, float z)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x36B5E00", Offset = "0x36B4A00", VA = "0x1836B5E00")]
		public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x36B61A0", Offset = "0x36B4DA0", VA = "0x1836B61A0")]
		public void SetMinMaxDistance(float minDistance, float maxDistance)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x36B5FE0", Offset = "0x36B4BE0", VA = "0x1836B5FE0")]
		public void SetInteriorPanField(float sourceRadius, float interiorDistance)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x36B5F50", Offset = "0x36B4B50", VA = "0x1836B5F50")]
		public void SetDopplerFactor(float dopplerFactor)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x36B6910", Offset = "0x36B5510", VA = "0x1836B6910")]
		public void SetVolume(float volume)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x36B6110", Offset = "0x36B4D10", VA = "0x1836B6110")]
		public void SetMaxAngleAisacDelta(float maxDelta)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x36B5CE0", Offset = "0x36B48E0", VA = "0x1836B5CE0")]
		public void SetAttenuationDistanceSetting(bool flag)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x36B59F0", Offset = "0x36B45F0", VA = "0x1836B59F0")]
		public bool GetAttenuationDistanceSetting()
		{
			return default(bool);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x36B63A0", Offset = "0x36B4FA0", VA = "0x1836B63A0")]
		public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x36B65E0", Offset = "0x36B51E0", VA = "0x1836B65E0")]
		public void SetRandomPositionList(Vector3[] positionList)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x36B5C10", Offset = "0x36B4810", VA = "0x1836B5C10")]
		public void Set3dRegion(CriAtomEx3dRegion region3d)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x36B6080", Offset = "0x36B4C80", VA = "0x1836B6080")]
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x36B67F0", Offset = "0x36B53F0", VA = "0x1836B67F0")]
		public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x36B5EC0", Offset = "0x36B4AC0", VA = "0x1836B5EC0")]
		public void SetDistanceAisacControlId(ushort aisacControlId)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x36B5B10", Offset = "0x36B4710", VA = "0x1836B5B10")]
		public bool IsDestroyable()
		{
			return default(bool);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x36B5A70", Offset = "0x36B4670", VA = "0x1836B5A70")]
		public CriAtomEx.NativeVector GetPosition()
		{
			return default(CriAtomEx.NativeVector);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x36B5990", Offset = "0x36B4590", VA = "0x1836B5990", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060002DC RID: 732
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x36B6B50", Offset = "0x36B5750", VA = "0x1836B6B50")]
		[PreserveSig]
		private static extern IntPtr criAtomEx3dSource_Create(ref CriAtomEx3dSource.Config config, IntPtr work, int work_size);

		// Token: 0x060002DD RID: 733
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x36B6C20", Offset = "0x36B5820", VA = "0x1836B6C20")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source);

		// Token: 0x060002DE RID: 734
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x36B7A70", Offset = "0x36B6670", VA = "0x1836B7A70")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source);

		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x36B6E40", Offset = "0x36B5A40", VA = "0x1836B6E40")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source);

		// Token: 0x060002E0 RID: 736
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x36B7550", Offset = "0x36B6150", VA = "0x1836B7550")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position);

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x36B7950", Offset = "0x36B6550", VA = "0x1836B7950")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity);

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x36B74B0", Offset = "0x36B60B0", VA = "0x1836B74B0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top);

		// Token: 0x060002E3 RID: 739
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x36B6FE0", Offset = "0x36B5BE0", VA = "0x1836B6FE0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient);

		// Token: 0x060002E4 RID: 740
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x36B7070", Offset = "0x36B5C70", VA = "0x1836B7070")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume);

		// Token: 0x060002E5 RID: 741
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x36B7410", Offset = "0x36B6010", VA = "0x1836B7410")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance);

		// Token: 0x060002E6 RID: 742
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x36B7250", Offset = "0x36B5E50", VA = "0x1836B7250")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance);

		// Token: 0x060002E7 RID: 743
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x36B71C0", Offset = "0x36B5DC0", VA = "0x1836B71C0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor);

		// Token: 0x060002E8 RID: 744
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x36B79E0", Offset = "0x36B65E0", VA = "0x1836B79E0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume);

		// Token: 0x060002E9 RID: 745
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x36B7380", Offset = "0x36B5F80", VA = "0x1836B7380")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta);

		// Token: 0x060002EA RID: 746
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x36B6F50", Offset = "0x36B5B50", VA = "0x1836B6F50")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag);

		// Token: 0x060002EB RID: 747
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x36B6CA0", Offset = "0x36B58A0", VA = "0x1836B6CA0")]
		[PreserveSig]
		private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source);

		// Token: 0x060002EC RID: 748
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x36B7670", Offset = "0x36B6270", VA = "0x1836B7670")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config);

		// Token: 0x060002ED RID: 749
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x36B75E0", Offset = "0x36B61E0", VA = "0x1836B75E0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config);

		// Token: 0x060002EE RID: 750
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x36B7820", Offset = "0x36B6420", VA = "0x1836B7820")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length);

		// Token: 0x060002EF RID: 751
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x36B7130", Offset = "0x36B5D30", VA = "0x1836B7130")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id);

		// Token: 0x060002F0 RID: 752
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x36B6DC0", Offset = "0x36B59C0", VA = "0x1836B6DC0")]
		[PreserveSig]
		private static extern bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source);

		// Token: 0x060002F1 RID: 753
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x36B6D20", Offset = "0x36B5920", VA = "0x1836B6D20")]
		[PreserveSig]
		private static extern CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source);

		// Token: 0x060002F2 RID: 754
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x36B6EC0", Offset = "0x36B5AC0", VA = "0x1836B6EC0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region);

		// Token: 0x060002F3 RID: 755
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x36B72F0", Offset = "0x36B5EF0", VA = "0x1836B72F0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id);

		// Token: 0x060002F4 RID: 756
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x36B78C0", Offset = "0x36B64C0", VA = "0x1836B78C0")]
		[PreserveSig]
		private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id);

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint currentRandomPositionListMaxLength;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr handle;

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		public struct Config
		{
			// Token: 0x060002F5 RID: 757 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x34CE350", Offset = "0x34CCF50", VA = "0x1834CE350")]
			public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength)
			{
			}

			// Token: 0x040001EF RID: 495
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enableVoicePriorityDecay;

			// Token: 0x040001F0 RID: 496
			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint randomPositionListMaxLength;
		}
	}
}
