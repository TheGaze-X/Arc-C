using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public struct InputBindingCompositeContext
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000139")]
		public IEnumerable<InputBindingCompositeContext.PartBinding> controls
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x55F6CC0", Offset = "0x55F58C0", VA = "0x1855F6CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x55F6800", Offset = "0x55F5400", VA = "0x1855F6800")]
		public float EvaluateMagnitude(int partNumber)
		{
			return 0f;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040F")]
		public TValue ReadValue<TValue>(int partNumber) where TValue : struct, IComparable<TValue>
		{
			return null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000410")]
		public TValue ReadValue<TValue>(int partNumber, out InputControl sourceControl) where TValue : struct, IComparable<TValue>
		{
			return null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000411")]
		public TValue ReadValue<TValue, TComparer>(int partNumber, [Optional] TComparer comparer) where TValue : struct where TComparer : IComparer<TValue>
		{
			return null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000412")]
		public TValue ReadValue<TValue, TComparer>(int partNumber, out InputControl sourceControl, [Optional] TComparer comparer) where TValue : struct where TComparer : IComparer<TValue>
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x55F69A0", Offset = "0x55F55A0", VA = "0x1855F69A0")]
		public bool ReadValueAsButton(int partNumber)
		{
			return default(bool);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x55F6B70", Offset = "0x55F5770", VA = "0x1855F6B70")]
		public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x55F6A30", Offset = "0x55F5630", VA = "0x1855F6A30")]
		public object ReadValueAsObject(int partNumber)
		{
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x55F6900", Offset = "0x55F5500", VA = "0x1855F6900")]
		public double GetPressTime(int partNumber)
		{
			return 0.0;
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal InputActionState m_State;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int m_BindingIndex;

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		public struct PartBinding
		{
			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x00003C48 File Offset: 0x00001E48
			// (set) Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700013A")]
			public int part
			{
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700013B")]
			public InputControl control
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600041A")]
				[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		private struct DefaultComparer<TValue> : IComparer<TValue> where TValue : IComparable<TValue>
		{
			// Token: 0x0600041B RID: 1051 RVA: 0x00003C60 File Offset: 0x00001E60
			[Token(Token = "0x600041B")]
			public int Compare(TValue x, TValue y)
			{
				return 0;
			}
		}
	}
}
