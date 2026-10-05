using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[InputControlLayout(displayName = "Oculus Headset", hideInUI = true)]
	public class OculusHMD : XRHMD
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[]
		{
			"devicetrackingstate"
		})]
		[InputControl]
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[]
		{
			"deviceistracked"
		})]
		public ButtonControl userPresence
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAcceleration
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x55DCE50", Offset = "0x55DBA50", VA = "0x1855DCE50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x55DCEB0", Offset = "0x55DBAB0", VA = "0x1855DCEB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularAcceleration
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAcceleration
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x50B83F0", Offset = "0x50B6FF0", VA = "0x1850B83F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x55DCED0", Offset = "0x55DBAD0", VA = "0x1855DCED0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularAcceleration
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x55DCE70", Offset = "0x55DBA70", VA = "0x1855DCE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x55DCEE0", Offset = "0x55DBAE0", VA = "0x1855DCEE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x55DCE40", Offset = "0x55DBA40", VA = "0x1855DCE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x55DCEA0", Offset = "0x55DBAA0", VA = "0x1855DCEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAcceleration
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x55DCE20", Offset = "0x55DBA20", VA = "0x1855DCE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x4FA2340", Offset = "0x4FA0F40", VA = "0x184FA2340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularAcceleration
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x55DCE30", Offset = "0x55DBA30", VA = "0x1855DCE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x55DCE90", Offset = "0x55DBA90", VA = "0x1855DCE90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x55DCB30", Offset = "0x55DB730", VA = "0x1855DCB30", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public OculusHMD()
		{
		}
	}
}
