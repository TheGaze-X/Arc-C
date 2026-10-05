using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[InputControlLayout(stateType = typeof(PoseState))]
	[Preserve]
	public class PoseControl : InputControl<PoseState>
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public ButtonControl isTracked
		{
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000300")]
		public IntegerControl trackingState
		{
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000301")]
		public Vector3Control position
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x560D490", Offset = "0x560C090", VA = "0x18560D490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000302")]
		public QuaternionControl rotation
		{
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000303")]
		public Vector3Control velocity
		{
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		public Vector3Control angularVelocity
		{
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x56AFF50", Offset = "0x56AEB50", VA = "0x1856AFF50")]
		public PoseControl()
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x56AF900", Offset = "0x56AE500", VA = "0x1856AF900", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x56AFAB0", Offset = "0x56AE6B0", VA = "0x1856AFAB0", Slot = "17")]
		public unsafe override PoseState ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(PoseState);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x56AFCC0", Offset = "0x56AE8C0", VA = "0x1856AFCC0", Slot = "18")]
		public unsafe override void WriteValueIntoState(PoseState value, void* statePtr)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x56AF680", Offset = "0x56AE280", VA = "0x1856AF680", Slot = "15")]
		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
