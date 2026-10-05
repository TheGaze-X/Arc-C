using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public struct Eyes
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00005CB8 File Offset: 0x00003EB8
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000318")]
		public Vector3 leftEyePosition
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x361F7D0", Offset = "0x361E3D0", VA = "0x18361F7D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x361F830", Offset = "0x361E430", VA = "0x18361F830")]
			set
			{
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00005CD0 File Offset: 0x00003ED0
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000319")]
		public Quaternion leftEyeRotation
		{
			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x569DE00", Offset = "0x569CA00", VA = "0x18569DE00")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x569DE30", Offset = "0x569CA30", VA = "0x18569DE30")]
			set
			{
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00005CE8 File Offset: 0x00003EE8
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031A")]
		public Vector3 rightEyePosition
		{
			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x569DE10", Offset = "0x569CA10", VA = "0x18569DE10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x569DE40", Offset = "0x569CA40", VA = "0x18569DE40")]
			set
			{
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00005D00 File Offset: 0x00003F00
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031B")]
		public Quaternion rightEyeRotation
		{
			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x4C97D70", Offset = "0x4C96970", VA = "0x184C97D70")]
			set
			{
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00005D18 File Offset: 0x00003F18
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031C")]
		public Vector3 fixationPoint
		{
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x32FB1B0", Offset = "0x32F9DB0", VA = "0x1832FB1B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x5531CB0", Offset = "0x55308B0", VA = "0x185531CB0")]
			set
			{
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00005D30 File Offset: 0x00003F30
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031D")]
		public float leftEyeOpenAmount
		{
			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x4E48960", Offset = "0x4E47560", VA = "0x184E48960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x1DE3EA0", Offset = "0x1DE2AA0", VA = "0x181DE3EA0")]
			set
			{
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00005D48 File Offset: 0x00003F48
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031E")]
		public float rightEyeOpenAmount
		{
			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x17DB8D0", Offset = "0x17DA4D0", VA = "0x1817DB8D0")]
			set
			{
			}
		}

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 m_LeftEyePosition;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion m_LeftEyeRotation;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_RightEyePosition;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion m_RightEyeRotation;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 m_FixationPoint;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x44")]
		public float m_LeftEyeOpenAmount;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x48")]
		public float m_RightEyeOpenAmount;
	}
}
