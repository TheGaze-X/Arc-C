using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public abstract class AbstractManager : MonoBehaviour
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000F")]
		public static LifecycleHelper coroutineSurrogate
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4E02F50", Offset = "0x4E01B50", VA = "0x184E02F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000010")]
		public static LifecycleHelper lifecycleHelper
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4E02F50", Offset = "0x4E01B50", VA = "0x184E02F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4E02F10", Offset = "0x4E01B10", VA = "0x184E02F10")]
		public static ThreadingCallbackHelper getThreadingCallbackHelper()
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4E02B30", Offset = "0x4E01730", VA = "0x184E02B30")]
		public static void createThreadingCallbackHelper()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4E02D70", Offset = "0x4E01970", VA = "0x184E02D70")]
		public static GameObject getPrime31ManagerGameObject()
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4E03020", Offset = "0x4E01C20", VA = "0x184E03020")]
		public static void initialize(Type type)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4E02A40", Offset = "0x4E01640", VA = "0x184E02A40")]
		private void Awake()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected AbstractManager()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		private static LifecycleHelper _prime31LifecycleHelperRef;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x8")]
		private static ThreadingCallbackHelper _threadingCallbackHelper;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x10")]
		private static GameObject _prime31GameObject;
	}
}
