using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Haptics
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	internal struct DualMotorRumble
	{
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00007758 File Offset: 0x00005958
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040D")]
		public float lowFrequencyMotorSpeed
		{
			[Token(Token = "0x6000F10")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000F11")]
			[Address(RVA = "0x8772C0", Offset = "0x875EC0", VA = "0x1808772C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00007770 File Offset: 0x00005970
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040E")]
		public float highFrequencyMotorSpeed
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x1700040F")]
		public bool isRumbling
		{
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x56CFE80", Offset = "0x56CEA80", VA = "0x1856CFE80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x56CFA50", Offset = "0x56CE650", VA = "0x1856CFA50")]
		public void PauseHaptics(InputDevice device)
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x56CFC40", Offset = "0x56CE840", VA = "0x1856CFC40")]
		public void ResumeHaptics(InputDevice device)
		{
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x56CFB80", Offset = "0x56CE780", VA = "0x1856CFB80")]
		public void ResetHaptics(InputDevice device)
		{
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x56CFD00", Offset = "0x56CE900", VA = "0x1856CFD00")]
		public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency)
		{
		}
	}
}
