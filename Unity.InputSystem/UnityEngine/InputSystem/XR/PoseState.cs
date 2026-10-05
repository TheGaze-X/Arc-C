using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.XR;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[StructLayout(2)]
	public struct PoseState : IInputStateTypeInfo
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x170002FE")]
		public FourCC format
		{
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x56B00B0", Offset = "0x56AECB0", VA = "0x1856B00B0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x56B0060", Offset = "0x56AEC60", VA = "0x1856B0060")]
		public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity)
		{
		}

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		internal const int kSizeInBytes = 60;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly FourCC s_Format;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Is Tracked", layout = "Button", sizeInBits = 8U)]
		public bool isTracked;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(displayName = "Tracking State", layout = "Integer")]
		public InputTrackingState trackingState;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(displayName = "Position", noisy = true)]
		public Vector3 position;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[InputControl(displayName = "Rotation", noisy = true)]
		public Quaternion rotation;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[InputControl(displayName = "Velocity", noisy = true)]
		public Vector3 velocity;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[InputControl(displayName = "Angular Velocity", noisy = true)]
		public Vector3 angularVelocity;
	}
}
