using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public class BoneControl : InputControl<Bone>
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031F")]
		[InputControl(offset = 0U, displayName = "parentBoneIndex")]
		public IntegerControl parentBoneIndex
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x538FC10", Offset = "0x538E810", VA = "0x18538FC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000320")]
		[InputControl(offset = 4U, displayName = "Position")]
		public Vector3Control position
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x1692740", Offset = "0x1691340", VA = "0x181692740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x1692B70", Offset = "0x1691770", VA = "0x181692B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000321")]
		[InputControl(offset = 16U, displayName = "Rotation")]
		public QuaternionControl rotation
		{
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x4E84380", Offset = "0x4E82F80", VA = "0x184E84380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x538E100", Offset = "0x538CD00", VA = "0x18538E100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x569C330", Offset = "0x569AF30", VA = "0x18569C330", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x569C430", Offset = "0x569B030", VA = "0x18569C430", Slot = "17")]
		public unsafe override Bone ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Bone);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x569C520", Offset = "0x569B120", VA = "0x18569C520", Slot = "18")]
		public unsafe override void WriteValueIntoState(Bone value, void* statePtr)
		{
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x569C630", Offset = "0x569B230", VA = "0x18569C630")]
		public BoneControl()
		{
		}
	}
}
