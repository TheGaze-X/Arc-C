using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200368E RID: 13966
	[Token(Token = "0x200368E")]
	[Serializable]
	public class TransitionAsset
	{
		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0601636A RID: 90986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003564")]
		public string name
		{
			[Token(Token = "0x601636A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0601636B RID: 90987 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601636C RID: 90988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003565")]
		public string FromState
		{
			[Token(Token = "0x601636B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x601636C")]
			[Address(RVA = "0xEB5440", Offset = "0xEB4040", VA = "0x180EB5440")]
			set
			{
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0601636D RID: 90989 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601636E RID: 90990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003566")]
		public string ToState
		{
			[Token(Token = "0x601636D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x601636E")]
			[Address(RVA = "0xEB5480", Offset = "0xEB4080", VA = "0x180EB5480")]
			set
			{
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0601636F RID: 90991 RVA: 0x00090018 File Offset: 0x0008E218
		[Token(Token = "0x17003567")]
		public TransitionType TransType
		{
			[Token(Token = "0x601636F")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return (TransitionType)0;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x06016370 RID: 90992 RVA: 0x00090030 File Offset: 0x0008E230
		// (set) Token: 0x06016371 RID: 90993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003568")]
		public bool IsValid
		{
			[Token(Token = "0x6016370")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016371")]
			[Address(RVA = "0xEB5470", Offset = "0xEB4070", VA = "0x180EB5470")]
			set
			{
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x06016372 RID: 90994 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016373 RID: 90995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003569")]
		public string ErrorMessage
		{
			[Token(Token = "0x6016372")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016373")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x06016374 RID: 90996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016374")]
		[Address(RVA = "0xEB5390", Offset = "0xEB3F90", VA = "0x180EB5390")]
		private TransitionAsset()
		{
		}

		// Token: 0x06016375 RID: 90997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016375")]
		[Address(RVA = "0xEB5030", Offset = "0xEB3C30", VA = "0x180EB5030")]
		public static TransitionAsset NewInstance()
		{
			return null;
		}

		// Token: 0x06016376 RID: 90998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016376")]
		[Address(RVA = "0xEB4D70", Offset = "0xEB3970", VA = "0x180EB4D70")]
		public string GenerateDescription()
		{
			return null;
		}

		// Token: 0x06016377 RID: 90999 RVA: 0x00090048 File Offset: 0x0008E248
		[Token(Token = "0x6016377")]
		[Address(RVA = "0xEB4FC0", Offset = "0xEB3BC0", VA = "0x180EB4FC0")]
		public bool LogicEqual(TransitionAsset transAsset)
		{
			return default(bool);
		}

		// Token: 0x06016378 RID: 91000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016378")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
		public List<BehaviourTransAction> GetStaticActionSlot()
		{
			return null;
		}

		// Token: 0x06016379 RID: 91001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016379")]
		[Address(RVA = "0xEB5130", Offset = "0xEB3D30", VA = "0x180EB5130")]
		private void _RefreshNameByOwnProperties()
		{
		}

		// Token: 0x0601637A RID: 91002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601637A")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static string _GetStateName(string state)
		{
			return null;
		}

		// Token: 0x0401AB1D RID: 109341
		[Token(Token = "0x401AB1D")]
		public const string ANY_STATE = "{ANY}";

		// Token: 0x0401AB1E RID: 109342
		[Token(Token = "0x401AB1E")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private string _name;

		// Token: 0x0401AB1F RID: 109343
		[Token(Token = "0x401AB1F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string _fromState;

		// Token: 0x0401AB20 RID: 109344
		[Token(Token = "0x401AB20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private string _toState;

		// Token: 0x0401AB21 RID: 109345
		[Token(Token = "0x401AB21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TransitionType _transitionType;

		// Token: 0x0401AB22 RID: 109346
		[Token(Token = "0x401AB22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<BehaviourTransAction> _staticActionSlot;

		// Token: 0x0401AB23 RID: 109347
		[Token(Token = "0x401AB23")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ReadOnly]
		private bool _isValid;

		// Token: 0x0401AB24 RID: 109348
		[Token(Token = "0x401AB24")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ReadOnly]
		private string _errorMessage;
	}
}
