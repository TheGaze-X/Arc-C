using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics/Rigidbody.h")]
	public class Rigidbody : Component
	{
		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x59CB780", Offset = "0x59CA380", VA = "0x1859CB780")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public Vector3 angularVelocity
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x59CB3D0", Offset = "0x59C9FD0", VA = "0x1859CB3D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x59CB4B0", Offset = "0x59CA0B0", VA = "0x1859CB4B0")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000033 RID: 51
		[Token(Token = "0x1700000A")]
		public extern bool useGravity { [Token(Token = "0x6000033")] [Address(RVA = "0x59CB6E0", Offset = "0x59CA2E0", VA = "0x1859CB6E0")] [MethodImpl(4096)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52
		// (set) Token: 0x06000035 RID: 53
		[Token(Token = "0x1700000B")]
		public extern bool isKinematic { [Token(Token = "0x6000034")] [Address(RVA = "0x59CB420", Offset = "0x59CA020", VA = "0x1859CB420")] [MethodImpl(4096)] get; [Token(Token = "0x6000035")] [Address(RVA = "0x59CB500", Offset = "0x59CA100", VA = "0x1859CB500")] [MethodImpl(4096)] set; }

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Vector3 position
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x59CB5F0", Offset = "0x59CA1F0", VA = "0x1859CB5F0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x59CB690", Offset = "0x59CA290", VA = "0x1859CB690")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000038 RID: 56
		[Token(Token = "0x1700000E")]
		public extern float maxAngularVelocity { [Token(Token = "0x6000038")] [Address(RVA = "0x59CB550", Offset = "0x59CA150", VA = "0x1859CB550")] [MethodImpl(4096)] set; }

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59CB330", Offset = "0x59C9F30", VA = "0x1859CB330")]
		public void MovePosition(Vector3 position)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59CAF50", Offset = "0x59C9B50", VA = "0x1859CAF50")]
		public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59CAF00", Offset = "0x59C9B00", VA = "0x1859CAF00")]
		[ExcludeFromDocs]
		public void AddForce(Vector3 force)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x59CB060", Offset = "0x59C9C60", VA = "0x1859CB060")]
		public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x59CB010", Offset = "0x59C9C10", VA = "0x1859CB010")]
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector3 force)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x59CB280", Offset = "0x59C9E80", VA = "0x1859CB280")]
		public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x59CB230", Offset = "0x59C9E30", VA = "0x1859CB230")]
		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x59CB170", Offset = "0x59C9D70", VA = "0x1859CB170")]
		public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59CB120", Offset = "0x59C9D20", VA = "0x1859CB120")]
		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Rigidbody()
		{
		}

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x59CB730", Offset = "0x59CA330", VA = "0x1859CB730")]
		[MethodImpl(4096)]
		private extern void set_velocity_Injected(ref Vector3 value);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x59CB380", Offset = "0x59C9F80", VA = "0x1859CB380")]
		[MethodImpl(4096)]
		private extern void get_angularVelocity_Injected(out Vector3 ret);

		// Token: 0x06000045 RID: 69
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59CB460", Offset = "0x59CA060", VA = "0x1859CB460")]
		[MethodImpl(4096)]
		private extern void set_angularVelocity_Injected(ref Vector3 value);

		// Token: 0x06000046 RID: 70
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59CB5A0", Offset = "0x59CA1A0", VA = "0x1859CB5A0")]
		[MethodImpl(4096)]
		private extern void set_position_Injected(ref Vector3 value);

		// Token: 0x06000047 RID: 71
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59CB640", Offset = "0x59CA240", VA = "0x1859CB640")]
		[MethodImpl(4096)]
		private extern void set_rotation_Injected(ref Quaternion value);

		// Token: 0x06000048 RID: 72
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x59CB2E0", Offset = "0x59C9EE0", VA = "0x1859CB2E0")]
		[MethodImpl(4096)]
		private extern void MovePosition_Injected(ref Vector3 position);

		// Token: 0x06000049 RID: 73
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59CAEA0", Offset = "0x59C9AA0", VA = "0x1859CAEA0")]
		[MethodImpl(4096)]
		private extern void AddForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);

		// Token: 0x0600004A RID: 74
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x59CAFB0", Offset = "0x59C9BB0", VA = "0x1859CAFB0")]
		[MethodImpl(4096)]
		private extern void AddRelativeForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);

		// Token: 0x0600004B RID: 75
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x59CB1D0", Offset = "0x59C9DD0", VA = "0x1859CB1D0")]
		[MethodImpl(4096)]
		private extern void AddTorque_Injected(ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);

		// Token: 0x0600004C RID: 76
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x59CB0C0", Offset = "0x59C9CC0", VA = "0x1859CB0C0")]
		[MethodImpl(4096)]
		private extern void AddRelativeTorque_Injected(ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
	}
}
