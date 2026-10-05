using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.GoogleVr
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[InputControlLayout(displayName = "Daydream Controller", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class DaydreamController : XRController
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		[InputControl]
		public Vector2Control touchpad
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		[InputControl]
		public ButtonControl volumeUp
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		[InputControl]
		public ButtonControl recentered
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		[InputControl]
		public ButtonControl volumeDown
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		[InputControl]
		public ButtonControl recentering
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		[InputControl]
		public ButtonControl app
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		[InputControl]
		public ButtonControl home
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		[InputControl]
		public ButtonControl touchpadClicked
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		[InputControl]
		public ButtonControl touchpadTouched
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x55CCF60", Offset = "0x55CBB60", VA = "0x1855CCF60", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public DaydreamController()
		{
		}
	}
}
